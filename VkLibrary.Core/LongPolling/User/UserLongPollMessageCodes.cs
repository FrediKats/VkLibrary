namespace VkApi.Wrapper.LongPolling.User
{
    /// <summary>
    /// Each element of the updates array represents its own an array
    /// that contains the event code in the first element and some
    /// set of fields with additional information depending
    /// on the type of event. 
    /// </summary>
    public enum UserLongPollMessageCodes
    {
        /// <summary>
        /// Replace message flags (FLAGS:=$flags). 
        /// </summary>
        ReplaceMessageFlags = 1,

        /// <summary>
        /// Install message flags (FLAGS|=$mask). 
        /// </summary>
        InstallMessageFlags = 2,

        /// <summary>
        /// Reset message flags (FLAGS&amp;=~$mask). 
        /// </summary>
        ResetMessageFlags = 3,

        /// <summary>
        /// Add a new message.
        /// </summary>
        AddMessage = 4,

        /// <summary>
        /// Read all incoming messages with $peer_id up to and including $local_id.
        /// </summary>
        ReadAllIncomingMessages = 6,

        /// <summary>
        /// Read all outgoing messages with $peer_id up to and including $local_id.
        /// </summary>
        ReadAllOutgoingMessages = 7,

        /// <summary>
        /// A friend $user_id is online. $extra is not 0, if flag 64 was passed in mode. 
        /// The low byte (remaining from the division into 256) of an extra number 
        /// contains the platform ID (ref. 7. Platforms). 
        /// </summary>
        FriendOnline = 8,

        /// <summary>
        /// A friend $user_id is offline ($flags is 0, if the user left the website
        /// (for example, by pressing Log Out) and 1, if offline is due to 
        /// timing out (for example, the away status)). 
        /// </summary>
        FriendOffline = 9,

        /// <summary>
        /// Reset dialog flags $peer_id. Corresponds to the operation 
        /// (PEER_FLAGS &amp;= ~$flags). An event is returned only for 
        /// community messages. 
        /// </summary>
        ResetDialogFlags = 10,

        /// <summary>
        /// Replace dialog flags $peer_id. Corresponds to the operation 
        /// (PEER_FLAGS:= $flags). An event is returned only for
        /// community messages. 
        /// </summary>
        ReplaceDialogFlags = 11,

        /// <summary>
        /// Install dialog flags $peer_id. Corresponds to the operation 
        /// (PEER_FLAGS|= $flags). An event is returned only for 
        /// community messages. 
        /// </summary>
        InstallDialogFlags = 12,

        /// <summary>
        /// One of the parameters (content, topic) of the conversation 
        /// $chat_id was changed. $self — 1 or 0 (whether the change 
        /// was caused by the user). 
        /// </summary>
        ConversationChanged = 51,

        /// <summary>
        /// User $user_id began typing in the dialog. The event 
        /// should happen once in ~5 seconds during continuous
        ///  typing. $flags = 1. 
        /// </summary>
        UserTypingInDialog = 61,

        /// <summary>
        /// User $user_id began typing in the conversation $chat_id. 
        /// </summary>
        UserTypingInConversation = 62,

        /// <summary>
        /// User $user_id completed a call with the ID $call_id. 
        /// </summary>
        UserCall = 70,

        /// <summary>
        /// New unread messages counter in the left menu equals $count.
        /// </summary>
        CounterUpdate = 80,

        /// <summary>
        /// Notification settings changed where $peer_id is a chat/user’s ID, 
        /// $sound is either 1 (sound notifications on) or 0 (sound notifications off), 
        /// $disabled_until shows notifications disabled for a certain period 
        /// (-1: forever, 0: enabled, other: timestamp for when it should be switched on). 
        /// </summary>
        NotificationSettingsChanged = 114
    }
}
