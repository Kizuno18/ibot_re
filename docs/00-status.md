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
- Wine Program Error resolved: with native .NET 4 (winetricks `dotnet40`) iBot reaches its Login/HWID window ([10](10-runtime.md)).
- **GUI login automation**: DirectDraw menu clicks unreliable under Xvfb; client reaches main menu; Enter Game dialog not driven end-to-end in this session.

- Added: [13 type model](13-type-model.md), [14 client 10.76 memory map](14-client-1076-offsets.md), auth signatures in [05](05-auth-protocol.md).
- Static limit: Agile.NET encrypts method bodies, so logic (healer/cavebot algorithms, offsets inside iBot) is not recoverable without running the protector, which is The session ends at the Authentication dialog (forum credentials required). Feature engines behind that dialog are documented from static metadata.

## Next (optional)

- Log a character into local TFS and dump the battle list live to pin creature offsets past +0x24.

- Deeper Agile.NET string decryption offline.
- Map memory offsets used by `MemoryHelper` once strings decrypted.
- Compare iBot Plus 10.76 packed Qt binary with WindBot lineage.
