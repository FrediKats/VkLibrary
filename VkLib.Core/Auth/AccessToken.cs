using Newtonsoft.Json;
using System;

namespace VkLib.Auth
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
        /// Expires in DateTime.
        /// </summary>
        public DateTime ExpiresInDateTime
        {
            get
            {
                return DateTime.Now.Add(TimeSpan.FromSeconds(ExpiresIn));
            }
        }

        /// <summary>
        /// User ID that owns this token.
        /// </summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// Has access token expired?
        /// </summary>
        public bool HasExpired
        {
            get
            {
                return ExpiresInDateTime != DateTime.MinValue && DateTime.Now > ExpiresInDateTime;
            }
        }

        public override string ToString()
        {
            return $"{Token} {ExpiresIn} {UserId}";
        }

    }
}
