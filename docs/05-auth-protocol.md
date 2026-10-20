# Auth protocol (static)

## Endpoints
| Endpoint / contract | Role |
|---|---|
| `http://www.tibiaibot.com/service/aut.php` | Legacy check |
| `http://www.tibiaibot.com/Login6`, `/Login6a`, `/LoginX` | SOAP actions (namespace `http://www.tibiaibot.com/`) |
| `urn:ibot.login6/7/X`, `service.Login7Binding` | Second (rpc/encoded, `SoapHttpClientProtocol`) proxy |

## Recovered signatures (generated proxies, not obfuscated)
`iBot.ServiceReference1.Service1SoapClient` (WCF):
- `string Login6(string enterKey)`
- `string Login6a(string enterKey, string hardware, string version, bool changehwdid)`
- `bool LoginX(string value)`

`iBot.Service2.serviceLogin7` (ASMX-style, sync + `*Async` + `*Completed` events):
- `string Login6(string strValue)`, `bool LoginX(string strValue)`, plus `Login7`

## Inferred flow (from types + UI; message bodies are Agile-encrypted)
1. The UI collects e-mail + password. `ibotlib!getHardwareID` produces the HWID shown in the dialog.
2. The client calls `Login6a(enterKey, hardware, version, changehwdid)`. `enterKey` is an opaque string built from the credentials (exact encoding is encrypted). `version` is the bot build. `changehwdid` asks the server to rebind the HWID.
3. It gets back a string token/status. `LoginX(value)` returns a bool for a later session or keep-alive check.
4. `Login6`/`Login7` are older variants kept for compatibility.

The server is dead (tibiaibot.com is offline), so none of this was exercised live.
