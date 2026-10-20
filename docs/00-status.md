# Status

## Done

- Located and hashed official iBot v2.7.2 + iBot Plus 10.76.1 via Wayback (`tibiaibot.com`).
- Downloaded CipSoft Tibia 10.76 from ots.me; verified `ProductVersion 10.7.6.0`.
- Built local TFS 1.1 (protocol 10.76–10.77), MariaDB account seeded, server online.
- RSA+IP patched client (`Tibia_ot.exe`); TCP probe to `:7171` receives protocol greeting.
- Headless ILSpy (`ilspycmd`) decompilation of `iBot.exe` / `Launcher.exe` / Lua assemblies (obfuscated identifiers retained).
- Documented WinAPI P/Invoke surface, SOAP auth endpoints, HWID export, namespaces.
- Isolated Wine prefix prepared; .NET 4 Client Profile present.

## Open items / environment limits

- Vendor auth host (`tibiaibot.com`) is offline; runtime ends at the Login window. Healer/cavebot/targeting are documented from static metadata.
- Wine Program Error under Mono/.NET Client Profile: fixed later with full .NET 4.
- **GUI login automation**: DirectDraw menu clicks unreliable under Xvfb; client reaches main menu; Enter Game dialog not driven end-to-end in this session.

## Next (optional)

- Deeper Agile.NET string decryption offline.
- Map memory offsets used by `MemoryHelper` once strings decrypted.
- Compare iBot Plus 10.76 packed Qt binary with WindBot lineage.
