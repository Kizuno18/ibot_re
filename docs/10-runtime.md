# Runtime notes (Wine)

## Environment
- Isolated prefix `/workspace/wine/ibot` (win32), Xvfb `:99`, `scrot`.
- VC++ 2010 x86 redist; **.NET Framework 4 (winetricks `dotnet40`)**; Wine Mono was tried first.
- 32-bit `libGL.so.1` (i386 Mesa) required for the 10.76 client.

## "Program Error" — root cause
The earlier crash happened while the prefix only had Wine Mono plus a half-installed
.NET 4 Client Profile. Under Mono the Agile.NET native runtime (`AgileDotNetRT.dll!_Initialize`)
could not hook the CLR, and Wine popped `winedbg` up as "Program Error". Once winetricks
`dotnet40` had finished (native `clr.dll` v4.0.30319), the load chain worked:

```
mscoree.dll -> mscoreei.dll -> clr.dll -> clrjit.dll
           -> C:\iBot\AgileDotNetRT.dll   (Agile.NET runtime, native)
           -> C:\iBot\ibotlib.dll         (getHardwareID)
```
(`WINEDEBUG=+loaddll,+seh`). The only first-chance exception seen was `RPC_S_SERVER_UNAVAILABLE (0x6ba)`,
which is harmless COM noise.

## Result
`iBot.exe` reaches its **Login** window (322×145):

| Control | Notes |
|---|---|
| E-mail | Forum/licence account |
| Password | — |
| Hardware id | Shown as `XXXX-XXXX` (8 chars, from `ibotlib!getHardwareID`, volume-serial based) |
| Auto-login | checkbox |
| Login / Exit | — |

The vendor auth host is offline, so the session ends at this dialog. Feature engines
(healer, cavebot, targeting) are documented from static metadata.

## Client
The patched 10.76 client reaches its main menu under Wine and, with corrected click
coordinates, logs into local TFS 1.1 (MOTD → character list → in game).
