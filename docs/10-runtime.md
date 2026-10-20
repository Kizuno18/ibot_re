# Runtime notes

## Environment

- Wine win32 prefix `/workspace/wine/ibot`
- Xvfb `:99` + `scrot`
- VC++ 2010 redist + .NET 4 Client Profile (winetricks/msiexec)
- Wine Mono MSI also attempted

## Client

Patched `Tibia.exe` reaches the classic main menu under Wine once `libGL.so.1` **i386** is installed. OpenGL initially failed with amd64-only libGL.

## Bot

`iBot.exe` initially failed with Wine `Program Error` / `winedbg` after CLR load — consistent with Agile.NET native callbacks (later fixed with native .NET 4).

## OT server

TFS 1.1 listening on `0.0.0.0:7171` / `7172`; account file local only (not committed).
