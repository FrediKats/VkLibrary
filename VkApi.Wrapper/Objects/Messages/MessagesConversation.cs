using Newtonsoft.Json;

using System;

namespace VkApi.Wrapper.Objects
{
    public class MessagesConversation
    {
        [JsonProperty("peer")]
        public MessagesConversationPeer Peer { get; set; }

        ///<summary>
        /// ID of the last message in conversation
        ///</summary>
        [JsonProperty("last_message_id")]
        public int LastMessageId { get; set; }

        ///<summary>
        /// Last message user have read
        ///</summary>
        [JsonProperty("in_read")]
        public int InRead { get; set; }

        ///<summary>
        /// Last outcoming message have been read by the opponent
        ///</summary>
        [JsonProperty("out_read")]
        public int OutRead { get; set; }

        ///<summary>
        /// Unread messages number
        ///</summary>
        [JsonProperty("unread_count")]
        public int UnreadCount { get; set; }


        [JsonProperty("important")]
        public Boolean Important { get; set; }
        [JsonProperty("unanswered")]
        public Boolean Unanswered { get; set; }
        [JsonProperty("special_service_type")]
        public String SpecialServiceType { get; set; }
        [JsonProperty("message_request_data")]
        public MessagesMessageRequestData MessageRequestData { get; set; }

        ///<summary>
        /// Ids of messages with mentions
        ///</summary>
        [JsonProperty("mentions")]
        public int[] Mentions { get; set; }
        [JsonProperty("current_keyboard")]
        public MessagesKeyboard CurrentKeyboard { get; set; }

        [JsonProperty("chat_settings")]
        public ConversationChatSettings ChatSettings { get; set; }
    }

    //This is not codegened types
	public class ConversationChatSettings
    {
        [JsonProperty("members_count")]
        public long MembersCount { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("pinned_message")]
        public MessagesPinnedMessage PinnedMessage { get; set; }

        [JsonProperty("photo")]
        public MessagesConversationPhoto Photo { get; set; }

        [JsonProperty("active_ids")]
        public long[] ActiveIds { get; set; }

        [JsonProperty("admin_ids")]
        public long[] AdminIds { get; set; }

        [JsonProperty("owner_id")]
        public long OwnerId { get; set; }

        [JsonProperty("acl")]
        public Acl Acl { get; set; }
    }

    public class MessagesConversationPhoto
    {
        ///<summary>
        /// URL of the preview image with 50 px in width
        ///</summary>
        [JsonProperty("photo_50")]
        public String Photo50 { get; set; }
        ///<summary>
        /// URL of the preview image with 100 px in width
        ///</summary>
        [JsonProperty("photo_100")]
        public String Photo100 { get; set; }

        ///<summary>
        /// URL of the preview image with 200 px in width
        ///</summary>
        [JsonProperty("photo_200")]
        public String Photo200 { get; set; }
    }

    public class Acl
    {
        [JsonProperty("can_invite")]
        public bool CanInvite { get; set; }

        [JsonProperty("can_change_info")]
        public bool CanChangeInfo { get; set; }

        [JsonProperty("can_change_pin")]
        public bool CanChangePin { get; set; }

        [JsonProperty("can_promote_users")]
        public bool CanPromoteUsers { get; set; }

        [JsonProperty("can_see_invite_link")]
        public bool CanSeeInviteLink { get; set; }

        [JsonProperty("can_change_invite_link")]
        public bool CanChangeInviteLink { get; set; }

        [JsonProperty("can_moderate")]
        public bool CanModerate { get; set; }

        [JsonProperty("can_copy_chat")]
        public bool CanCopyChat { get; set; }
    }
}