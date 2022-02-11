using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

namespace Client
{
    public class GoogleAuthorizationMessageHandler : AuthorizationMessageHandler
    {
        public GoogleAuthorizationMessageHandler(IAccessTokenProvider provider,
            NavigationManager navigationManager)
            : base(provider, navigationManager)
        {
            ConfigureHandler(
                authorizedUrls: new[] {"https://sheets.googleapis.com/v4/spreadsheets/"},
                scopes: new[] {"https://www.googleapis.com/auth/drive"});
        }
    }
}
