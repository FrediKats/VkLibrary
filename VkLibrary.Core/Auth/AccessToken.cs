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
        /// Expires in DateTime.
        /// </summary>
        public DateTime ExpiresInDateTime => DateTime.Now.Add(TimeSpan.FromSeconds(ExpiresIn));

        /// <summary>
        /// User ID that owns this token.
        /// </summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// Has access token expired?
        /// </summary>
        public bool HasExpired => ExpiresInDateTime != DateTime.MinValue && DateTime.Now > ExpiresInDateTime;

        /// <summary>
        /// Stringifies token data.
        /// </summary>
        public override string ToString() => $"{Token} {ExpiresIn} {UserId}";

        /// <summary>
        /// Deserializes token from a string.
        /// </summary>
        /// <param name="s">String</param>
        public static AccessToken FromString(string s)
        {
            var split = s.Split(' ');
            return new AccessToken
            {
                Token = split[0],
                ExpiresIn = double.Parse(split[1]),
                UserId = int.Parse(split[2])
            };
        } 
    }
}