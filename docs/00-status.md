# Status & roadmap

Resume point for the iBot (Tibia 10.76) study. What is done, what is out of scope, what could follow.

## Done
- Official iBot **v2.7.2** and iBot Plus **10.76.1** located on Wayback (`tibiaibot.com`) and hashed ([01](01-provenance.md)).
- CipSoft Tibia 10.76 obtained and verified (`ProductVersion 10.7.6.0`); local TFS 1.1 (protocol 10.76–10.77) with seeded MariaDB account.
- RSA + IP patched client; login to the local server reaches the character list and in-game ([09](09-client-patch.md)).
- Headless ILSpy metadata pass of `iBot.exe` / `Launcher.exe` / Lua assemblies (obfuscated identifiers retained) ([07](07-game-model.md), [13](13-type-model.md)).
- WinAPI P/Invoke surface, SOAP auth endpoints and HWID export documented ([05](05-auth-protocol.md), [06](06-winapi-surface.md)).
- Wine runtime: with native .NET 4, iBot reaches its Login/HWID window ([10](10-runtime.md)).
- Client 10.76 memory map live-validated in three rounds; battle-list entry closed from +0x00 to +0xCC ([14](14-client-1076-offsets.md), consolidated in [shared map](shared/client-1076-memory-map.md)).
- REA analysis of the managed/native boundary ([15](15-rea-analysis.md)).
- Product history from Wayback and community forums ([history](history.md)).

## Coverage
| Area | State | Evidence |
|---|---|---|
| Distribution / provenance | complete for archived builds | [01](01-provenance.md) |
| Static PE / .NET metadata | complete | [03](03-static-analysis.md), [13](13-type-model.md) |
| Auth surface | endpoints and contracts only | [05](05-auth-protocol.md) |
| Client memory map (10.76) | live-validated | [14](14-client-1076-offsets.md) |
| Feature engines (healer, cavebot, targeting) | names and types only | [07](07-game-model.md) |

## Out of scope
- Method bodies protected by Agile.NET are not recovered. Unpacking, CLR dumping and protection bypass are outside this repo's scope.
- The vendor auth host is offline; the runtime stops at the Login window, and no licence workaround is attempted.

## Optional follow-ups
- Compare iBot script formats with WindBot's `libs/converter/` iBot→Wind converters (plain Lua, no binaries).
- Add Wayback snapshot links to the forum mentions in [history](history.md) once the archive API responds.

## Conventions
- Addresses are VAs at ImageBase `0x400000` unless stated otherwise.
- Docs are English, UTF-8, LF, final newline. Vendor binaries are referenced by SHA256, never committed.
- Doc numbers are stable identifiers; `01` is provenance here (sibling repos use `01-overview`), kept to avoid breaking links.
