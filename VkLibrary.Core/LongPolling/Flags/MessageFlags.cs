using System;

namespace VkLibrary.Core.LongPolling.Flags
{
    /// <summary>
    /// Each message has a flag, which is a value received 
    /// by summing up any of the following parameters. 
    /// </summary>
    [Flags]
    public enum MessageFlags
    {
        /// <summary>
        /// Message is unread.
        /// </summary>
        Unread = 1,

        /// <summary>
        /// Message is outgoing.
        /// </summary>
        Outbox = 2,

        /// <summary>
        /// Message was answered.
        /// </summary>
        Replied = 4,

        /// <summary>
        /// Message is marked as important.
        /// </summary>
        Important = 8,

        /// <summary>
        /// Message sent via chat.
        /// </summary>
        Chat = 16,

        /// <summary>
        /// Message sent by a friend.
        /// </summary>
        Friends = 32,

        /// <summary>
        /// Message marked as "Spam".
        /// </summary>
        Spam = 64,

        /// <summary>
        /// Message was deleted.
        /// </summary>
        Deleted = 128,

        /// <summary>
        /// Message was user-checked for spam.
        /// </summary>
        Fixed = 256,

        /// <summary>
        /// Message has media content.
        /// </summary>
        Media = 512
    }
}
