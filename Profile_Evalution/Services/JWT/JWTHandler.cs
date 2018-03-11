using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Web;

namespace Profile_Evalution.Services.JWT
{
    public class JWTHandler
    {
        private const string communicationKey = "sam";
      
        public string GenerateTokenForUser(string userName,Object userId)
        {
           var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(communicationKey));
           var signingKey = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature, SecurityAlgorithms.Sha256Digest);

            List<Claim> claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name,userName),
                new Claim(ClaimTypes.NameIdentifier,userId.ToString())
            };
            var claimsIdentity = new ClaimsIdentity(claims, "Custom");


           var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = claimsIdentity,
                Issuer = "self",
                Audience = "http://localhost:8080",
                SigningCredentials = signingKey,
                Expires = DateTime.Now.AddMinutes(20)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var securityToken = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(securityToken);

        }


        public JwtSecurityToken parseToken(string authToken)
        {
            var tokenValidationParameters = new TokenValidationParameters()
            {
                ValidAudiences = new String[] {"http://localhost:8080"},
                ValidIssuer = "self",
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(communicationKey))
        };

            var tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken validatedToken;
            try
            {
                tokenHandler.ValidateToken(authToken, tokenValidationParameters,out validatedToken);

            }
            catch(Exception e)
            {
                return null;
            }
            return validatedToken as JwtSecurityToken;
        }


        private JwtAuthenticationIdentity userIdentity(JwtSecurityToken user)
        {
            string name = user.Claims.FirstOrDefault(m => m.Type == "unique_name").Value;
            string userId = user.Claims.FirstOrDefault(m => m.Type == "nameid").Value;

            return new JwtAuthenticationIdentity(name) { UserId = userId, UserName = name };
        }
    }
}