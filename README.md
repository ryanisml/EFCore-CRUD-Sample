
# SAMPLE CRUD
Sample of CRUD with MS Sql Server DB, with EF Core.
- V1 (2023-09-21)

## ASP NET.CORE
![App Screenshot](https://blog.rashik.com.np/wp-content/uploads/2020/06/efcore.jpg)

## Installation
To use this .NET CORE make sure you have :
- [DOTNET 7](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
- [Internet Information System 10](https://www.iis.net/downloads)

## Usage/Examples
- Make sure to install iis 10 first.
- Add website and pointing to
```
local/crud-mysql
```
- Run http://localhost/crud-mysql at website.
For better application run at [Microsoft Edge](https://www.microsoft.com/en-us/edge/download)

## REMINDER
**Please remind to configure Azure Active Directory first with your tenant.**
- Because `dotnet ef migrations add InitialCreate` has been initiate before, you can running database migration with script below:
```
dotnet ef database update
```
**After migration and azure active directory has been configure, you can running this program.**

## Features
- Using EF Core,
- Using Database table migration,
- Using Azure Entra ID with web platform instance.

## Support & Used By
This project is used by the following companies:
- My Current Company

## Lisence
.Net Core is a free and open-source, managed computer software framework for Windows, Linux, and macOS operating systems under [Microsoft](https://www.microsoft.com/en-us/licensing/default) & [MIT license](https://opensource.org/licenses/MIT).

## Acknowledgements
- [Azure Entra ID] (https://www.microsoft.com/en-us/security/business/identity-access/microsoft-entra-id)

## Configuration for appsettings.json
- There is only appsettings.Development.json at this repository.
You can copy and paste `appsettings.Development.json` to `appsettings.json` and replace all configuration below:
```
{
  "AzureAd": {
    "Instance": "https://login.microsoftonline.com/",
    "Domain": "{your_tenant}",
    "TenantId": "{your_tenant_id}",
    "ClientId": "{your_client_id}",
    "CallbackPath": "/signin-oidc",
    "SignedOutCallbackPath": "/signout-callback-oidc"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "koneksiSql": "{your_sql_connection_configuration}"
  }
}
```
- replace all `{}` to your Azure AD Configuration setting.
