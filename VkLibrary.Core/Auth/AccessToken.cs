using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Auth
{
    /// <summary>
    /// Access token.
    /// </summary>
    public class AccessToken
    {
        /// <summary>
        /// Access token itself.
        /// </summary>
        [JsonProperty("access_token")]
        public string Token { get; set; }

        /// <summary>
        /// Expires in UnixTimeStamp.
        /// </summary>
        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }

        /// <summary>
        /// User ID that owns this token.
        /// </summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// Expires in DateTime.
        /// </summary>
        private DateTime ExpiresInDateTime => DateTime.Now.Add(TimeSpan.FromSeconds(ExpiresIn));

        /// <summary>
        /// Has access token expired?
        /// </summary>
        public bool HasExpired => ExpiresIn != 0 && DateTime.Now > ExpiresInDateTime;

        /// <summary>
        /// Creates token from a string.
        /// </summary>
        /// <param name="token">Token as string.</param>
        /// <param name="userId">User id.</param>
        public static AccessToken FromString(string token, int userId = 0) => new AccessToken
        {
            Token = token,
            ExpiresIn = default(int),
            UserId = userId
        };
    }
}