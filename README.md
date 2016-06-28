# AcmeChallenge

HTTP handler for ACME challenge support (Let's Encrypt) on shared ASP.NET hosts.

### NuGet
```
PM> Install-Package AcmeChallenge
```

## How To
Add a AcmeChallenge reference to your web application. Request a `http-01` challenge from Let's Encrypt.

Before responding to the `http-01` challenge, add token and payload (the key authorization) to your `web.config`. Once your application is configured, Let's Encrypt can validate your challenge response, and issue your certificate.

```xml
<configSections>
    <section name="logikfabrik.acmeChallenge" type="Logikfabrik.AcmeChallenge.Configuration.Section, Logikfabrik.AcmeChallenge" />
<configSections>
<logikfabrik.acmeChallenge>
    <tokens>
        <add token="" payload="" />
    </tokens>
</logikfabrik.acmeChallenge>
<system.webServer>
    <handlers>
        <remove name="AcmeChallengeHttpHandler" />
        <add name="AcmeChallengeHttpHandler" verb="GET" path=".well-known/acme-challenge/*" type="Logikfabrik.AcmeChallenge.AcmeChallengeHttpHandler, Logikfabrik.AcmeChallenge" />
    </handlers>
</system.webServer>
```

## Contributions
AcmeChallenge is Open Source (MIT), and you’re welcome to contribute!

If you have a bug report, feature request, or suggestion, please open a new issue. To submit a patch, please send a pull request.