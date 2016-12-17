using System;

namespace VkLib.Types
{
    public class AccessToken
    {
        public string Token { get; set; }

        public DateTime ExpiresIn { get; set; }

        public bool HasExpired
        {
            get
            {
                return (ExpiresIn == DateTime.MinValue) ? false : (DateTime.Now > ExpiresIn);
            }
        }

        public long UserId { get; set; }

        public override string ToString()
        {
            return string.Join(" ", Token, ExpiresIn);
        }
    }
}