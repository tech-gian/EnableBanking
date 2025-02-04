using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Security.Cryptography;

namespace EnableBanking.Handlers
{
    public class TokenHandler : DelegatingHandler
    {
        private readonly string _jwtAudience = "api.enablebanking.com";
        private readonly string _jwtIssuer = "api.enablebanking.com";

        private readonly TokenHandlerOptions _options;

        public TokenHandler(TokenHandlerOptions options)
        {
            _options = options;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", GetAccessToken());
            return await base.SendAsync(request, cancellationToken);
        }

        private string GetAccessToken()
        {
            using RSA rsa = RSA.Create();
            rsa.ImportFromPem(File.ReadAllText(_options.KeyPath));

            var signingCredentials = new SigningCredentials(new RsaSecurityKey(rsa), SecurityAlgorithms.RsaSha256)
            {
                CryptoProviderFactory = new CryptoProviderFactory { CacheSignatureProviders = false }
            };

            var now = DateTime.Now;
            var unixTimeSeconds = new DateTimeOffset(now).ToUnixTimeSeconds();

            var jwt = new JwtSecurityToken(
                audience: _jwtAudience,
                issuer: _jwtIssuer,
                claims: new Claim[] {
                    new Claim(JwtRegisteredClaimNames.Iat, unixTimeSeconds.ToString(), ClaimValueTypes.Integer64)
                },
                expires: now.AddMinutes(30),
                signingCredentials: signingCredentials
            );
            jwt.Header.Add("kid", _options.AppKid);
            return new JwtSecurityTokenHandler().WriteToken(jwt);
        }
    }
}
