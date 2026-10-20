# iBot Reverse Engineering

**Architecture, protection, scripting surface, and local analysis notes for iBot (Tibia classic), for preservation/education.**

[Overview](docs/02-overview.md) · [Status](docs/00-status.md) · [Provenance](docs/01-provenance.md)

`ibot_re` documents **iBot** (Jonatas / tibiaibot.com), a .NET external bot that
drives the Tibia client primarily via user-input simulation and selective process
memory reads — historically marketed as safer than injectors. This repo is a
research corpus: hashes, decompilation notes, protocol/auth observations, and
client-patch tooling. Vendor binaries are referenced by SHA256 and archive links
only; they are not checked into the tree.

## Scope

| Item | Value |
| --- | --- |
| Primary build | iBot **v2.7.2** (Wayback of tibiaibot.com, 2015-03-23) |
| Companion | iBot Plus **10.76.1** (Qt, heavily packed) |
| Matched client | CipSoft **Tibia 10.76** (`FileVersion 10.7.6.0`) |
| Local OT | Forgotten Server **1.1** (protocol 10.76–10.77) on `127.0.0.1:7171/7172` |
| Wine prefix | `/workspace/wine/ibot` (win32, isolated) |

## Architecture (static)

```text
Launcher.exe  --renames-->  <random7>.exe  (Dotfuscated stub)
                              |
                              v
                           iBot.exe  (.NET 4, Dotfuscator + Agile.NET runtime)
                              |
              +---------------+----------------+
              |               |                |
         ibotlib.dll     Lua stack         Win32 P/Invoke
       getHardwareID    Lua.Secure.dll      user32/gdi32
       (HWID)           lua51.dll           Read/WriteProcessMemory
                              |             SendInput / mouse_event
                              v
                    SOAP login @ tibiaibot.com
                 Login6 / Login6a / Login7 / LoginX
```

## License / auth

Official builds talk to:

- `http://www.tibiaibot.com/service/aut.php`
- `http://www.tibiaibot.com/Login6`, `Login6a`, `LoginX`
- WCF-style contracts `urn:ibot.login6`, `urn:ibot.login7`, `urn:ibot.loginX`
- Native `ibotlib.dll!getHardwareID` (volume serial / machine binding)

Under Wine the runtime reaches the Login window (e-mail / password / Hardware id).
The vendor auth host is offline, so sessions end there. Feature engines (healer,
cavebot, targeting) are documented from static metadata.

## Documentation map

| Doc | Topic |
| --- | --- |
| [00-status](docs/00-status.md) | Done / open items |
| [01-provenance](docs/01-provenance.md) | Download URLs, SHA256, dates |
| [02-overview](docs/02-overview.md) | Product history & design claims |
| [03-static-analysis](docs/03-static-analysis.md) | PE / .NET / packers |
| [04-protection](docs/04-protection.md) | Dotfuscator, Agile.NET, HWID |
| [05-auth-protocol](docs/05-auth-protocol.md) | SOAP/WCF login surface |
| [06-winapi-surface](docs/06-winapi-surface.md) | P/Invoke catalog |
| [07-game-model](docs/07-game-model.md) | Decompiled namespaces |
| [08-scripting](docs/08-scripting.md) | Lua / library scripts |
| [09-client-patch](docs/09-client-patch.md) | IP/RSA patch for 10.76 |
| [10-runtime](docs/10-runtime.md) | Wine session notes |
| [11-ibotplus](docs/11-ibotplus.md) | Qt packed companion |
| [13-type-model](docs/13-type-model.md) | Declared types/members |
| [14-client-1076-offsets](docs/14-client-1076-offsets.md) | Client memory map |
| [15-rea-analysis](docs/15-rea-analysis.md) | REA 6.7.0 managed/native boundary analysis |

## Tools

- `tools/pe_recon.py` — PE triage
- `tools/patch_client.py` — hostname + RSA modulus patcher (local copies only)
- `tools/verify_offsets_1076.py` — static cross-check of the 10.76 address set
- `tools/read_1076.py` — read-only `/proc/<pid>/mem` reader for a live client
