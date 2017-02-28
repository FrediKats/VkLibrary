using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VkLib.Auth
{
    /// <summary>
    /// Direct auth helpers.
    /// </summary>
    public class DirectAuth
    {
        private readonly Vkontakte _vkontakte;

        internal DirectAuth(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        public async Task<AccessToken> Login(string login, string password, ScopeSettings? scope)
        {
            _vkontakte.log("Invoking direct auth login...");
            
            if (_vkontakte.ClientSecret == null || _vkontakte.AppId == null)
                throw new Exception("App ID and Client Secret MUST be specified.");

            if (login == null || password == null)
                throw new Exception("Login and Password MUST be specified.");

            Dictionary<string, string> parameters = new Dictionary<string, string>
            {
                { "username", login },
                { "password", password },
                { "grant_type", "password" },
                { "scope", ((int)scope).ToString() },
                { "client_secret", _vkontakte.ClientSecret },
                { "client_id", _vkontakte.AppId }
            };

            AccessToken token = await _vkontakte.GetAsync<AccessToken>(
                method: "token",
                parameters: parameters,
                baseUrl: Vkontakte.DirectAuthUrl,
                usePlain: true
            );

            if (token.Token == null)
                _vkontakte.log("Failed to get token!");
            else
                _vkontakte.log("Authorization succeed.");

            return token;
        }
    }
}
