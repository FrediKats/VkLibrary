using System;
using System.Collections.Generic;

namespace VkLib.Auth
{
    /// <summary>
    ///     OAuth helpers.
    /// </summary>
    public class OAuth
    {
        private readonly Vkontakte _vkontakte;

        internal OAuth(Vkontakte vkontakte) => _vkontakte = vkontakte;

        /// <summary>
        ///     Returns OAuth url based on provided and const parameters.
        /// </summary>
        /// <param name="scope">Scope to grant access permissions.</param>
        /// <param name="display">How authorization block should be displayed in browser?</param>
        /// <returns></returns>
        public string GetAuthUrl(ScopeSettings? scope, AuthDisplayType display)
        {
            var parameters = new Dictionary<string, string>
            {
                {"redirect_uri", Vkontakte.OAuthRedirectUrl},
                {"display", display.ToString().ToLowerInvariant()},
                {"client_id", _vkontakte.AppId},
                {"response_type", "token"},
                {"v", _vkontakte.ApiVersion}
            };

            // Check and add scope.
            if (scope != null)
                parameters.Add("scope", ((int) scope).ToString());

            // Create result url.
            var resultUrl = Vkontakte.GetUrl(
                Vkontakte.OAuthUrl,
                parameters
            );

            // Log url.
            Vkontakte.Log($"Prepared OAuth url: {resultUrl}");
            return resultUrl;
        }

        /// <summary>
        ///     Extracts token or other data from url after vk redirection.
        /// </summary>
        /// <returns></returns>
        public OAuthResult ParseResponseUrl(Uri uri)
        {
            if (string.IsNullOrEmpty(uri.Fragment))
                return null;

            var fragment = uri.Fragment.Substring(1);
            var parameters = new Dictionary<string, string>();

            foreach (var pair in fragment.Split('&'))
            {
                var equalsPos = pair.IndexOf('=');
                var key = pair.Substring(0, equalsPos);
                var value = pair.Substring(equalsPos + 1, pair.Length - equalsPos - 1);
                parameters.Add(key, value);
            }

            return OAuthResult.Parse(parameters);
        }
    }
}