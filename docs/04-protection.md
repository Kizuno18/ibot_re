# Protection stack

1. **Dotfuscator** — control-flow flattening + identifier renaming (visible in ILSpy as `睷`, `Ax8-`, etc.).
2. **Agile.NET** — encrypted IL / string protection backed by `AgileDotNetRT.dll` (`_Initialize`).
3. **HWID** — `ibotlib.dll!getHardwareID` from volume information.
4. **Online license** — SOAP clients under `iBot.ServiceReference1` / `iBot.Service2`.
5. **Launcher rename** — randomizes on-disk EXE name.

No attempt was made to unpack Agile.NET at runtime beyond ILSpy's partial view.
