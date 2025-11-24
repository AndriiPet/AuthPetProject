// Copyright (c) Duende Software. All rights reserved.
// See LICENSE in the project root for license information.

using IdentityModel;
using System.Security.Claims;
using System.Text.Json;
using Duende.IdentityServer;
using Duende.IdentityServer.Test;

namespace Marvin.IDP;

public static class TestUsers
{
    public static List<TestUser> Users
    {
        get
        {
            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "3fcc057b-e1f6-456f-9f14-85a466b6eb63",
                    Username = "David",
                    Password = "password",
                    Claims =
                    {
                        new Claim(JwtClaimTypes.GivenName, "David"),
                        new Claim(JwtClaimTypes.FamilyName, "Flagg"),
                        new Claim("role", "FreeUser")
                    }
                },
                new TestUser
                {
                    SubjectId = "d21a6949-5b2b-4ef3-a424-a8cbfbaaf1b6",
                    Username = "Emma",
                    Password = "password",
                    Claims =
                    {
                        new Claim(JwtClaimTypes.GivenName, "Emma"),
                        new Claim(JwtClaimTypes.FamilyName, "Flagg"),
                        new Claim("role", "PayingUser")
                    }
                }
            };
        }
    }
}