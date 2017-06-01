using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VkLib.Auth
{
    /// <summary>
    ///     Direct auth helpers.
    /// </summary>
    public class DirectAuth
    {
        private readonly Vkontakte _vkontakte;
        internal DirectAuth(Vkontakte vkontakte) => _vkontakte = vkontakte;

        public async Task<AccessToken> Login(string login, string password, ScopeSettings scope)
        {
            Vkontakte.Log("Invoking direct auth login...");

            if (_vkontakte.ClientSecret == null || _vkontakte.AppId == null)
                throw new Exception("App ID and Client Secret MUST be specified.");

            if (login == null || password == null)
                throw new Exception("Login and Password MUST be specified.");

            var parameters = new Dictionary<string, string>
            {
                {"username", login},
                {"password", password},
                {"grant_type", "password"},
                {"scope", ((int) scope).ToString()},
                {"client_secret", _vkontakte.ClientSecret},
                {"client_id", _vkontakte.AppId}
            };

            var token = await _vkontakte.GetAsync<AccessToken>(
                "token",
                parameters,
                Vkontakte.DirectAuthUrl,
                true
            );

            Vkontakte.Log(token.Token == null ? "Failed to get token!" : "Authorization succeed.");

            return token;
        }
    }
}