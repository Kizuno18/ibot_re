# Auth protocol (static)

Recovered string constants / generated SOAP proxies:

| Endpoint / contract | Role |
| --- | --- |
| `http://www.tibiaibot.com/service/aut.php` | Legacy autocheck |
| `http://www.tibiaibot.com/Login6` | Login6 |
| `http://www.tibiaibot.com/Login6a` | Login6a |
| `http://www.tibiaibot.com/LoginX` | LoginX |
| `urn:ibot.login6` / `login7` / `loginX` | SOAP actions |
| `service.Login7Binding` | WCF-style binding name |

Types under `iBot.ServiceReference1` include `Login6Request/Response`, `Login6a*`, `LoginX*`, and `Service1SoapClient`.

**Runtime:** not exercised (would require vendor credentials). Documented for historical completeness only.
