using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;
using MitDataoverblik.Models;

namespace MitDataoverblik.Services
{
    public class DemoAuthenticationStateProvider
        : AuthenticationStateProvider
    {
        private ClaimsPrincipal bruger = new(new ClaimsIdentity());

        public override Task<AuthenticationState>
            GetAuthenticationStateAsync()
        {
            return Task.FromResult(new AuthenticationState(bruger));
        }

        public void LogInd(Demobruger demobruger)
        {
            var claims = new[]
            {
                new Claim(
                    ClaimTypes.NameIdentifier,
                    demobruger.Id.ToString()),
                new Claim(ClaimTypes.Name, demobruger.Navn),
                new Claim(ClaimTypes.Role, demobruger.Rolle)
            };

            bruger = new ClaimsPrincipal(
                new ClaimsIdentity(claims, "DemoLogin"));

            NotifyAuthenticationStateChanged(
                GetAuthenticationStateAsync());
        }

        public void LogUd()
        {
            bruger = new ClaimsPrincipal(new ClaimsIdentity());

            NotifyAuthenticationStateChanged(
                GetAuthenticationStateAsync());
        }
    }
}