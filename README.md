# DotNet Core OIDC Example

This repository shows how a basic .NET Core web application would use OIDC for authentication. It uses the 
Microsoft.AspNetCore.Authentication.OpenIdConnect and Microsoft.AspNetCore.Authentication.Cookies packages.

OIDC credentials can be obtained from IAM by submitting a Shibboleth Configuration Request Form. More information can be found at:
https://documentation.its.umich.edu/node/767 . You will receive the Client Id and Client Secret after your Shibb Configuration Request is complete. 

For local setup of this example project:
- Create the .env file that docker-compose.yml is looking for (more information on env files here: https://docs.docker.com/compose/environment-variables/env-file/).
- Set environment variables ASPNETCORE_OIDC_ID and ASPNETCORE_OIDC_SECRET, and assign the Client Id and Client Secret values you were provided with, respectively.
- If necessary, change the environment variables ASPNETCORE_URLS and ASPNETCORE_ENVIRONMENT in docker-compose.yml to values that makes sense for your setup.
- Start the container with the "docker-compose up --build -d".

You can find more information on .NET Core and Host configuration 
here: https://learn.microsoft.com/en-us/aspnet/core/fundamentals/configuration/?source=recommendations&view=aspnetcore-7.0 

You can find more information on Docker here: https://docs.docker.com/get-started/
