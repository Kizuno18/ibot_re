# Static analysis

See also `artifacts/pe_recon.txt`.

## iBot.exe

| Field | Value |
| --- | --- |
| SHA256 | `9ca167aab8559e519961b57540ac5f45d10e5d02dcdb49b3f77be78bf6c12f00` |
| Kind | PE32 GUI, CLR header present |
| Timestamp | 2015-03-03 22:24:49Z |
| ImageBase | `0x400000` |
| Imports | `mscoree.dll!_CorExeMain` only (pure managed entry) |
| Obfuscation | Dotfuscator attribute on assemblies; CJK surrogate type names in ILSpy output; Agile.NET runtime companion |

## Launcher.exe

Tiny managed stub (~13 KiB). Behavior recovered from decompilation:

1. Prefer `iBot.exe` if present.
2. Else read `config.txt` for alternate filename.
3. On first run, rename `iBot.exe` → `<7 random chars>.exe` and write that name to `config.txt` (anti-signature rename).

## ibotlib.dll

Native helper (MSVC 2010):

- Export: **`getHardwareID`**
- Notable import: `GetVolumeInformationW` (volume serial → HWID)
- Used from managed code via P/Invoke in `WinApi`

## AgileDotNetRT.dll

Native runtime for Agile.NET protection:

- Exports: `_1`, `_AtExit`, `_Initialize`
- Imports include `ReadProcessMemory`, `VirtualProtect`, `OpenProcess`, `CreateThread`, toolhelp/PSAPI enumeration — consistent with runtime decryption / anti-tamper, not necessarily Tibia injection.

## Lua.Secure.dll / LuaInterface.dll / lua51.dll

Managed Lua bridge + Lua 5.1. `library/standard.lua` and `library/SIRMATE.lua` ship as plaintext script libraries.
