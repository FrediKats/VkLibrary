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
        public string Token { get; set; }

        /// <summary>
        /// Expires in DateTime.
        /// </summary>
        public DateTime ExpiresIn { get; set; }

        /// <summary>
        /// User ID that owns this token.
        /// </summary>
        public long UserId { get; set; }

        /// <summary>
        /// Has access token expired?
        /// </summary>
        public bool HasExpired
        {
            get
            {
                return ExpiresIn != DateTime.MinValue && DateTime.Now > ExpiresIn;
            }
        }

        public override string ToString()
        {
            return $"{Token} {ExpiresIn} {UserId}";
        }

    }
}
