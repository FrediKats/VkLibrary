using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class MessagesChat
    {
        ///<summary>
        /// Chat creator ID
        ///</summary>
        [JsonProperty("admin_id")]
        public int AdminId { get; set; }

        ///<summary>
        /// Chat ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Shows that user has been kicked from the chat
        ///</summary>
        [JsonProperty("kicked")]
        public int Kicked { get; set; }

        ///<summary>
        /// Shows that user has been left the chat
        ///</summary>
        [JsonProperty("left")]
        public int Left { get; set; }

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

        ///<summary>
        /// URL of the preview image with 50 px in width
        ///</summary>
        [JsonProperty("photo_50")]
        public String Photo50 { get; set; }
        [JsonProperty("push_settings")]
        public MessagesChatPushSettings PushSettings { get; set; }

        ///<summary>
        /// Chat title
        ///</summary>
        [JsonProperty("title")]
        public String Title { get; set; }

        ///<summary>
        /// Chat type
        ///</summary>
        [JsonProperty("type")]
        public String Type { get; set; }
        [JsonProperty("users")]
        public int[] Users { get; set; }

        ///<summary>
        /// If provided photo is default
        ///</summary>
        [JsonProperty("is_default_photo")]
        public Boolean IsDefaultPhoto { get; set; }
    }
}