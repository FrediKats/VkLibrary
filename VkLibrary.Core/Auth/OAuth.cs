using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Auth
{
    /// <summary>
    /// OAuth helpers.
    /// </summary>
    public class OAuth
    {
        private readonly VkLibrary _library;
        internal OAuth(VkLibrary vkontakte) => _library = vkontakte;
         
        /// <summary>
        /// Returns OAuth url based on provided and const parameters.
        /// </summary>
        /// <param name="scope">Scope to grant access permissions.</param>
        /// <param name="display">How authorization block should be displayed in browser?</param>
        /// <returns></returns>
        public string GetAuthUrl(ScopeSettings scope, AuthDisplayType display)
        {
            // Initialize parameters.
            var parameters = new Dictionary<string, string>
            {
                {"redirect_uri", VkLibrary.OAuthRedirectUrl},
                {"display", display.ToString().ToLowerInvariant()},
                {"client_id", _library.GetAppId()},
                {"response_type", "token"},
                {"v", _library.GetApiVersion()},
                {"scope", ((int) scope).ToString()}
            };

            // Create result url.
            var resultUrl = VkLibrary.BuildUrl(VkLibrary.OAuthUrl, parameters);
            _library.Log($"Prepared OAuth url: {resultUrl}");
            return resultUrl;
        }

        /// <summary>
        /// Extracts token or other data from url after vk redirection.
        /// </summary>
        /// <returns>OAuthResult holding token and errors.</returns>
        public OAuthResult ParseResponseUrl(Uri uri)
        {
            _library.Log("Parsing response url...");
            if (string.IsNullOrEmpty(uri.Fragment))
                return null;

            // Parse parameters.
            var fragment = uri.Fragment.Substring(1);
            var parameters = new Dictionary<string, string>();
            foreach (var pair in fragment.Split('&'))
            {
                var equalsPos = pair.IndexOf('=');
                var key = pair.Substring(0, equalsPos);
                var value = pair.Substring(equalsPos + 1, pair.Length - equalsPos - 1);
                parameters.Add(key, value);
            }

            // Return auth result.
            _library.Log("Finished parsing url!");
            return new OAuthResult(parameters);
        }
    }
}