# Status

## Done

- Located and hashed official iBot v2.7.2 + iBot Plus 10.76.1 via Wayback (`tibiaibot.com`).
- Downloaded CipSoft Tibia 10.76 from ots.me; verified `ProductVersion 10.7.6.0`.
- Built local TFS 1.1 (protocol 10.76–10.77), MariaDB account seeded, server online.
- RSA+IP patched client (`Tibia_ot.exe`); TCP probe to `:7171` receives protocol greeting.
- Headless ILSpy (`ilspycmd`) decompilation of `iBot.exe` / `Launcher.exe` / Lua assemblies (obfuscated identifiers retained).
- Documented WinAPI P/Invoke surface, SOAP auth endpoints, HWID export, namespaces.
- Isolated Wine prefix prepared; .NET Framework 4 present.
- Wine Program Error resolved: with native .NET 4 (winetricks `dotnet40`) iBot reaches its Login/HWID window ([10](10-runtime.md)).
- Added: [13 type model](13-type-model.md), [14 client 10.76 memory map](14-client-1076-offsets.md) (live-validated), auth signatures in [05](05-auth-protocol.md), [15 REA analysis](15-rea-analysis.md).

## Open items / environment limits

- Vendor auth host (`tibiaibot.com`) is offline; runtime ends at the Login window. Healer/cavebot/targeting are documented from static metadata.
- Agile.NET encrypts method bodies; method logic (healer/cavebot algorithms, internal offsets) is not present as IL in the file and was not recovered.
- Early Xvfb sessions had unreliable DirectDraw menu clicks; later sessions completed Enter Game via corrected coordinates.

## Next (optional)

- Finish skull/party/war-icon and HP%-decrease live checks outside the PZ.
- Deeper Agile.NET string decryption offline.
- Map memory offsets used by `MemoryHelper` once strings are decrypted.
- Compare iBot Plus 10.76 packed Qt binary with WindBot lineage.
