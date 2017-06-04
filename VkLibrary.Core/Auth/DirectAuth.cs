using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VkLibrary.Core.Auth
{
    /// <summary>
    /// Direct auth helpers.
    /// </summary>
    public class DirectAuth
    {
        private readonly Vkontakte _library;
        internal DirectAuth(Vkontakte vkontakte) => _library = vkontakte;

        /// <summary>
        /// Performs login via VK for official applications and then
        /// stores access token inside current library instance.
        /// </summary>
        /// <param name="login">Login</param>
        /// <param name="password">Password</param>
        /// <param name="scope">Access acope</param>
        /// <returns>AccessToken</returns>
        public async Task<AccessToken> Login(string login, string password, ScopeSettings scope)
        {
            _library.Log("Invoking direct auth login...");
            var clientSecret = _library.GetClientSecret();
            var appId = _library.GetAppId();

            // Both client secret and app id must be specified.
            if (clientSecret == null || appId == null)
                throw new Exception("App ID and Client Secret must be specified.");

            // Login and password must be specified.
            if (login == null) throw new ArgumentNullException(nameof(login));
            if (password == null) throw new ArgumentNullException(nameof(password));
            var parameters = new Dictionary<string, string>
            {
                {"username", login},
                {"password", password},
                {"grant_type", "password"},
                {"scope", ((int) scope).ToString()},
                {"client_secret", clientSecret},
                {"client_id", appId}
            };

            // Build request url.
            var url = Vkontakte.BuildUrl(string.Concat(
                Vkontakte.DirectAuthUrl, "token"), parameters);

            // Deserialize token.
            var token = await _library
                .DeserializeGetInPrefferedWay<AccessToken>(url)
                .ConfigureAwait(false);

            // Manage return types.
            if (token?.Token == null)
            {
                _library.Log("Failed to get token!");
                return null;
            }
            _library.Log("Successfully got and saved token.");
            _library.AccessToken = token;
            return token;
        }
    }
}