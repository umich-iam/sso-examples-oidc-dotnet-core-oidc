# DotNet Core OIDC Example

This repository shows how a basic .NET Core web application would use OIDC for authentication. It uses the 
Microsoft.AspNetCore.Authentication.OpenIdConnect and Microsoft.AspNetCore.Authentication.Cookies packages.

OIDC credentials can be obtained from IAM by submitting a Shibboleth Configuration Request Form. More information can be found at:
https://documentation.its.umich.edu/node/767

You will receive the Client Id and Client Secret after your Shibb Configuration Request is complete. 

For local setup of this example project, create environment variables ASPNETCORE_Oidc_Id and ASPNETCORE_Oidc_Secret 
and assign the Client Id and Client Secret values you were provided with, respectively. Also create environment 
variable ASPNETCORE_URLS and set it to the url(s) you need. You can find more information on .NET Core and Host configuration 
here: https://learn.microsoft.com/en-us/aspnet/core/fundamentals/configuration/?source=recommendations&view=aspnetcore-7.0 
