# REA 6.7.0 static analysis (iBot 2.7.2 / iBot Plus 10.76.1)

Tool: `rea@6.7.0` (local, `rea-local`). Every command used is execution-free: PE/CLI metadata parsing only, with no target code loaded and nothing unpacked.
Reduced outputs: `artifacts/rea/`. Full JSON evidence bundles stayed on the analysis box (they contain local paths and are ~12 MB).

## Commands run
| Command | Target | Result |
|---|---|---|
| `inspect-artifact` | iBot.exe, Launcher.exe ×2, ibotlib.dll, AgileDotNetRT.dll, ibotplus.exe, WindBot `code$MyConst.exe` | All are PE roots; REA routes managed → `inspect-managed-artifact`, native → `open_binary` |
| `inspect-managed-members` | iBot.exe | **879 types, 3 674 fields, 7 516 methods, 2 121 member refs, 1 910 call edges, 165 field accesses, only 18 `ldstr` literals** |
| `inspect-managed-native-boundaries` | iBot.exe, Lua.Secure.dll, LuaInterface.dll | iBot: 13 module refs, **99 P/Invoke**, 1 851 native/runtime-impl rows; Lua.Secure: 0; LuaInterface: 0 P/Invoke (4 runtime rows) |
| `compare-managed-members` | Launcher 2.7.2 vs Launcher Plus | 3 unchanged / 3 changed / 5 added / 10 removed |
| `inspect-managed-members` | Plus Launcher.exe | strings `config.txt`, `ibotplus.exe`, `.exe` |
| `inspect-desktop-application` | both folders, WindBot folder | iBot: `dotnet` candidate (5 CLI PEs). Plus: `dotnet` candidate from Launcher only. WindBot: no runtime candidate (native Qt) |
| `inspect-pe-resources` | WindBot / ibotplus.exe | WindBot: 6 icons + 1 group + 1 manifest (Qt assets live in compiled qrc, not PE resources). ibotplus: **rejected**, resource ranges not file-backed (packer) |

## Findings

### 1. Native boundary of iBot.exe (exact P/Invoke inventory)
| DLL | # | Functions |
|---|---|---|
| user32.dll (+ `user32`/`User32.dll`/`USER32.DLL` aliases) | 63 | **SendInput, mouse_event, keybd_event, PostMessage, SendMessage, SetCursorPos**, GetAsyncKeyState/GetKeyState, **SetWindowsHookEx/CallNextHookEx/UnhookWindowsHookEx**, FindWindow/GetClassName/WindowFromPoint, SetForegroundWindow/SwitchToThisWindow, overlay (CreateWindowExW, RegisterClassW, SetLayeredWindowAttributes, SetWindowRgn, BeginPaint/DrawText…), caret APIs |
| kernel32.dll | 11 | **ReadProcessMemory, WriteProcessMemory, VirtualProtectEx**, LoadLibraryA, GetProcAddress, GetModuleHandle, Get(Native)SystemInfo, MulDiv |
| gdi32.dll | 17 | fonts, pens, brushes, regions, TextOut (HUD drawing) |
| imm32.dll | 2 | ImmGetContext, ImmAssociateContext (disables IME while typing into the client) |
| dwmapi.dll | 1 | DwmExtendFrameIntoClientArea (transparent overlay) |
| **ibotlib.dll** | 1 | **getHardwareID** (HWID licence binding) |
| **AgileDotNetRT.dll / AgileDotNetRT64.dll** | 2+2 | `_Initialize`/`_Initialize64`, `_AtExit` |

The managed member names behind these imports are Dotfuscated (e.g. `HCU=` → `SetWindowsHookEx`).
Mapping: `artifacts/rea/ibot_native_boundaries.json`.

The verdict on the "external" claim: iBot reads **and can write** client memory (`WriteProcessMemory` + `VirtualProtectEx`) and installs Windows hooks. There is no `CreateRemoteThread`/`VirtualAllocEx`, so **no DLL injection boundary is declared**. Input is synthesized.

### 2. Agile.NET body stripping, quantified
Of the 1 851 native-implementation rows, **1 752 are `runtime-provided` methods with RVA 0** (impl flags 3 = native|runtime, or 11 = +preservesig). The other 99 are the P/Invoke stubs.
So ~23% of iBot's 7 516 methods have no IL in the file; Agile's runtime supplies their bodies after `<Module>..cctor` calls `<AgileDotNetRT>.Initialize` (first call edge in the graph).
This is why ILSpy shows empty bodies (see [13](13-type-model.md)). Only 18 `ldstr` literals remain, and they are encrypted blobs, so string encryption is total.
Recovering the bodies would require running the Agile.NET runtime or unpacking the protected IL; that was not done in this pass.

### 3. 2.7.2 vs Plus (managed comparison)
iBot Plus's main program is **native** (packed Qt `ibotplus.exe`), so a managed comparison is only possible for the Launchers:
- 2.7.2 Launcher: Dotfuscated (`DotfuscatorAttribute`, renamed members `a/b/c`), 11 methods.
- Plus Launcher: **not obfuscated** (`Launcher.Program.Main`, standard `Properties.Resources/Settings`), 8 methods. Same algorithm: read `config.txt`, rename `ibotplus.exe` → `<random>.exe`.
- Result: 3 matched by exact signature (settings/resources ctors, IL changed), 10 removed (obfuscator artefacts), 5 added (de-obfuscated accessors + `Main`).

### 4. Desktop-application view
- iBot folder: one `.NET` runtime candidate (iBot.exe, Launcher.exe, Lua.Secure.dll, LuaInterface.dll, lua51.dll declare CLI headers). `lua51.dll` is a mixed/CLI build.
- Plus folder: `.NET` candidate is the Launcher only; `ibotplus.exe` + Qt5 DLLs are native.
- WindBot: no managed/Electron/etc. candidate (native Qt + VMProtect).

## Limitations (from REA)
P/Invoke rows prove declarations only, not that the export exists or is called. Tokens are build-local (valid with SHA256 `9ca167aa…` + MVID `958774e8-689d-4669-8f1c-709bcc76f233`).
