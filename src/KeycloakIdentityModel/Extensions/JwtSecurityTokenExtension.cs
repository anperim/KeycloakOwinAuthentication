﻿using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;
using System.IdentityModel.Tokens.Jwt;

namespace KeycloakIdentityModel.Extensions
{
    internal static class JwtSecurityTokenExtension
    {
        public static JObject GetPayloadJObject(this JwtSecurityToken token)
        {
            // TODO: Optimize? Reduce code duplication
            return JObject.Parse(Base64UrlEncoder.Decode(token.RawPayload));
        }
    }
}