using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Auth
{
    /// <summary>
    /// A class representing parsed VKCOM url containing token.
    /// </summary>
    public class OAuthResult
    {
        /// <summary>
        /// Inits OAuthResult from parsed string Uri.
        /// </summary>
        /// <param name="response">Uri to parse.</param>
        public OAuthResult(IReadOnlyDictionary<string, string> response)
        {
            AccessToken = new AccessToken();
            DoIfKey("error", response, s => Error = s);
            DoIfKey("error_description", response, s => ErrorDescription = s);
            DoIfKey("error_reason", response, s => ErrorReason = s);
            DoIfKey("access_token", response, s => AccessToken.Token = s);
            DoIfKey("expires_id", response, s => AccessToken.ExpiresIn = int.Parse(s));
            DoIfKey("user_id", response, s => AccessToken.UserId = int.Parse(s));
        }

        /// <summary>
        /// Error.
        /// </summary>
        public string Error { get; private set; }

        /// <summary>
        /// Error reason
        /// </summary>
        public string ErrorReason { get; private set; }

        /// <summary>
        /// Error description.
        /// </summary>
        public string ErrorDescription { get; private set; }

        /// <summary>
        /// Access token.
        /// </summary>
        public AccessToken AccessToken { get; }

        /// <summary>
        /// Have we managed to get access token?
        /// </summary>
        public bool IsSuccess => 
            !string.IsNullOrEmpty(AccessToken?.Token) && 
            !AccessToken.HasExpired;

        /// <summary>
        /// Performs action if key exists in given dictionary.
        /// </summary>
        private static void DoIfKey(string key,
            IReadOnlyDictionary<string, string> dictionary,
            Action<string> predicateFunc)
        {
            if (dictionary.ContainsKey(key))
                predicateFunc.Invoke(dictionary[key]);
        }
    }
}