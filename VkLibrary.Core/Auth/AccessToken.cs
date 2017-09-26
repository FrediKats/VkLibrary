using System;
using Newtonsoft.Json;

namespace VkLibrary.Core.Auth
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
        public double ExpiresIn { get; set; }

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
        public bool HasExpired => ExpiresIn != default(double) && DateTime.Now > ExpiresInDateTime;

        /// <summary>
        /// Creates token from a string.
        /// </summary>
        /// <param name="token">Token as string.</param>
        /// <param name="userId">User id.</param>
        public static AccessToken FromString(string token, int userId) => new AccessToken
        {
            Token = token,
            ExpiresIn = default(double),
            UserId = userId
        };
    }
}