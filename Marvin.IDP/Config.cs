using Duende.IdentityServer;
using Duende.IdentityServer.Models;

namespace Marvin.IDP;

public static class Config
{
    public static IEnumerable<IdentityResource> IdentityResources =>
        new IdentityResource[]
        { 
            new IdentityResources.OpenId(),
            new IdentityResources.Profile(),
            new IdentityResource("roles", 
                "Your roles",
                new [] { "role" }),
            new IdentityResource("country",
                "The country you're living in",
                new [] { "country" }),
        };

    public static IEnumerable<ApiResource> ApiResource =>
    new ApiResource[]
        {
            new ApiResource("imagegalleryapi", 
                "Image Gallery API",
                new [] {"role", "country"})
            {
                Scopes = 
                { 
                    "imagegalleryapi.fullaccess",
                    "imagegalleryapi.read", 
                    "imagegalleryapi.write" 
                },
            },
        };

    public static IEnumerable<ApiScope> ApiScopes =>
        new ApiScope[]
            { 
                new ApiScope("imagegalleryapi.fullaccess"),
                new ApiScope("imagegalleryapi.write"),
                new ApiScope("imagegalleryapi.read")
            };

    public static IEnumerable<Client> Clients =>
        new Client[] 
            {
                new Client()
                {
                    ClientName = "Image Gallary",
                    ClientId = "imageGallryClient",
                    AllowedGrantTypes = GrantTypes.Code,
                    AllowOfflineAccess = true,
                    UpdateAccessTokenClaimsOnRefresh = true,
                    AccessTokenLifetime = 120,
                    //AuthorizationCodeLifetime = 5 min
                    //IdentityTokenLifetime = 5 min
                    RedirectUris =
                    {
                        "https://localhost:7184/signin-oidc"
                    },
                    PostLogoutRedirectUris =
                    {
                        "https://localhost:7184/signout-callback-oidc"
                    },
                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "roles",
                        "imagegalleryapi.write",
                        "imagegalleryapi.read",
                        "country"
                    },
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },
                    RequireConsent = true,
                }
            };
}