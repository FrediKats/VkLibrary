using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Auth
{
    /// <summary>
    /// OAuth helpers.
    /// </summary>
    public class OAuth
    {
        private const string OAuthRedirectUrl = "https://oauth.vk.com/blank.html";
        private const string OAuthUrl = "https://oauth.vk.com/authorize";
        private readonly Vkontakte _library;
        
        internal OAuth(Vkontakte vkontakte) => _library = vkontakte;
         
        /// <summary>
        /// Returns OAuth url based on provided and const parameters.
        /// </summary>
        /// <param name="scope">Scope to grant access permissions.</param>
        /// <param name="display">How authorization block should be displayed in browser?</param>
        /// <returns></returns>
        public Uri GetAuthUrl(ScopeSettings scope, AuthDisplayType display)
        {
            var parameters = new Dictionary<string, string>
            {
                {"redirect_uri", OAuthRedirectUrl},
                {"display", display.ToString().ToLowerInvariant()},
                {"client_id", _library.AppId.ToString()},
                {"response_type", "token"},
                {"v", _library.ApiVersion},
                {"scope", ((int) scope).ToString()},
            };
            var resultUrl = _library.HttpService.BuildGetRequestUrl(OAuthUrl, parameters);
            _library.Logger.Log($"Prepared OAuth url: {resultUrl}");
            return resultUrl;
        }

        /// <summary>
        /// Extracts token or other data from url after vk redirection.
        /// </summary>
        /// <returns>OAuthResult holding token and errors.</returns>
        public OAuthResult ParseResponseUrl(Uri uri)
        {
            _library.Logger.Log("Parsing response url...");
            if (string.IsNullOrEmpty(uri.Fragment)) return null;
            var fragment = uri.Fragment.Substring(1);
            var parameters = new Dictionary<string, string>();
            foreach (var pair in fragment.Split('&'))
            {
                var equalsPos = pair.IndexOf('=');
                var key = pair.Substring(0, equalsPos);
                var value = pair.Substring(equalsPos + 1, pair.Length - equalsPos - 1);
                parameters.Add(key, value);
            }
            _library.Logger.Log("Finished parsing url!");
            return new OAuthResult(parameters);
        }
    }
}