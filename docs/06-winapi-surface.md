# Win32 surface (`iBot.Util.WinApi`)

P/Invoke targets recovered from decompilation (names preserved; many callers obfuscated):

**Input / focus:** `SendInput`, `mouse_event`, `keybd_event`, `SetCursorPos`, `GetCursorPos`, `GetAsyncKeyState`, `GetKeyState`, `SetForegroundWindow`, `SetFocus`, `SwitchToThisWindow`, `FlashWindow`, …

**Window / GDI overlay:** `CreateWindowExW`, `RegisterClassW`, `SetLayeredWindowAttributes`, `DwmExtendFrameIntoClientArea`, `CreateFont*`, `TextOut`, `DrawText`, region helpers — consistent with an on-top HUD/overlay.

**Process memory:** `ReadProcessMemory`, `WriteProcessMemory`, `VirtualProtectEx` — selective external memory access (not full DLL injection of the bot engine).

**Hooks:** `CallNextHookEx`, `UnhookWindowsHookEx` (+ `KeyboardHook.cs`).

**HWID:** `getHardwareID` → `ibotlib.dll`.

Full listing: `artifacts/WinApi.cs`.
