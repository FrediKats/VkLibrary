using System;

namespace VkLib.AuthTools
{
    /// <summary>
    /// Access token
    /// </summary>
    public class AccessToken
    {
        /// <summary>
        /// Access token
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// Token expiration date
        /// </summary>
        public DateTime ExpiresIn { get; set; }

        /// <summary>
        /// Has token expired
        /// </summary>
        public bool HasExpired
        {
            get
            {
                return (ExpiresIn == DateTime.MinValue) ? false : (DateTime.Now > ExpiresIn);
            }
        }

        /// <summary>
        /// User id associated with this token
        /// </summary>
        public long UserId { get; set; }

        public override string ToString()
        {
            return string.Join(" ", Token, ExpiresIn);
        }
    }
}
