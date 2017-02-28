using System;
using System.Collections.Generic;

namespace VkLib.Auth
{
    /// <summary>
    /// A class representing parsed VKCOM url containing token.
    /// </summary>
    public class OAuthResult
    {
        /// <summary>
        /// Access token.
        /// </summary>
        public AccessToken AccessToken { get; set; }

        /// <summary>
        /// Error.
        /// </summary>
        public string Error { get; set; }

        /// <summary>
        /// Error reason
        /// </summary>
        public string ErrorReason { get; set; }

        /// <summary>
        /// Error description.
        /// </summary>
        public string ErrorDescription { get; set; }
    
        /// <summary>
        /// Have we managed to get access token?
        /// </summary>
        public bool IsSuccess
        {
            get
            {
                return AccessToken != null && !string.IsNullOrEmpty(AccessToken.Token) && !AccessToken.HasExpired;
            }
        }

        /// <summary>
        /// Parse from dictionary got from Uri.
        /// </summary>
        /// <param name="p">Dictionary got from Uri</param>
        /// <returns>OAuthResult instance</returns>
        public static OAuthResult Parse(Dictionary<string, string> p)
        {
            OAuthResult result = new OAuthResult();
            result.AccessToken = new AccessToken();

            if (p.ContainsKey("error"))
                result.Error = p["error"];

            if (p.ContainsKey("error_description"))
                result.ErrorDescription = p["error_description"];

            if (p.ContainsKey("error_reason"))
                result.ErrorReason = p["error_reason"];

            #region Token part

            if (p.ContainsKey("access_token"))
                result.AccessToken.Token = p["access_token"];

            if (p.ContainsKey("expires_in"))
                result.AccessToken.ExpiresIn = double.Parse(p["expires_in"]);

            if (p.ContainsKey("user_id"))
                result.AccessToken.UserId = int.Parse(p["user_id"]);

            #endregion

            return result;
        }

    }

}
