# Species Web

A platform for researchers & scientists filled with data & statistics on the worlds biodiversity.

## Development

### Prereqs

- [Visual Studio](https://visualstudio.microsoft.com/)
- [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0)
- [Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)
- [Docker](https://www.docker.com/)

### Local development

To run the project. Start the Docker container via the CLI or within Visual Studio. (2019 or higher) It will open up a website at <https://localhost:49159/>.

### Azure AD B2C Authentication Setup

This project uses Azure Active Directory B2C Authentication. Azure AD B2C gives us the security of Azure auth, with the ability for external customers to sign in with their own credentials (email or social accounts). See more info [here](https://docs.microsoft.com/en-us/azure/active-directory-b2c/overview).

To transition this to CBD's azure account, CBD will need to create a B2C tenant and application.

1. Create new B2C tenant. Microsoft tutorial [here](https://docs.microsoft.com/en-us/azure/active-directory-b2c/tutorial-create-tenant)
   - Note: If you see a resource provider error, you may need to register the Microsoft.AzureActiveDirectory resource provider - [instructions](https://docs.microsoft.com/en-us/azure/azure-resource-manager/templates/error-register-resource-provider). 
2. Register your web app. Microsoft tutorial [here](https://docs.microsoft.com/en-us/azure/active-directory-b2c/tutorial-register-applications?tabs=app-reg-ga#register-a-web-application)
3. Create a sign in sign up (recommended) user flow. Call the flow "signupsignin". Microsoft tutorial [here](https://docs.microsoft.com/en-us/azure/active-directory-b2c/tutorial-create-user-flows?pivots=b2c-user-flow)
4. Edit Blazor project appsettings.json to point to the new values. Go to https://portal.azure.com/#blade/Microsoft_AAD_B2CAdmin/TenantManagementMenuBlade/overview to find the correct values. 

>   "AzureAdB2C": {
>     "Instance": "https://**your-domain-name**.b2clogin.com",
>     "Domain": "**your-domain-name**.onmicrosoft.com", <- Look at Domain Name
>     "ClientId": "**Application-(client)-ID**", <- Go to _App Registration_, your app, Application (client) ID    
>     "CallbackPath": "/signin-oidc",
>     "SignedOutCallbackPath": "/signout",
>     "SignUpSignInPolicyId": "**B2C_1_signupsignin**", <- If you called your user flow something, go to _User Flow_ to find. 
>     "ResetPasswordPolicyId": "",
>     "EditProfilePolicyId": ""
>   },

Additional resources: 
**If you prefer a video explanation**, use this [video tutorial](https://youtu.be/73qnhE9pW0E?t=765) walkthrough instead of the above instructions. 

Here is a [blog post](https://medium.com/marcus-tee-anytime/azure-ad-b2c-quickstart-with-visual-studio-blazor-563efdff6fdd) that gives the same instructions, just more context around what the Azure terms mean.  