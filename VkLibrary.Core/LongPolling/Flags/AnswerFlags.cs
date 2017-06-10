using System;

namespace VkLibrary.Core.LongPolling.Flags
{
    /// <summary>
    /// Additional answer options codes list. 
    /// </summary>
    [Flags]
    public enum AnswerFlags
    {
        /// <summary>
        /// Receive attachments.
        /// </summary>
        ReceiveAttachments = 2,

        /// <summary>
        /// Receive expanded set of events.
        /// </summary>
        ReceiveExpandedSetOfEvents = 8,

        /// <summary>
        /// Return pts (it's required for the messages.getLongPollHistory 
        /// method operation without a limit of the most recent 256 events).
        /// </summary>
        ReceivePts = 32,

        /// <summary>
        /// For the event with code 8 (a friend is online) extra data is returned 
        /// in the field $extra (learn more in the Event Structure section).
        /// </summary>
        ReceiveExtraData = 64,

        /// <summary>
        /// Return the parameter random_id with a message (random_id can be 
        /// transferred while sending messages using the messages.send method).
        /// </summary>
        ReceiveRandomId = 128
    }
}
