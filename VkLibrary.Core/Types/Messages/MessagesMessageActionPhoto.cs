using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Messages
{
    public class MessagesMessageActionPhoto
    {
        ///<summary>
        /// URL of the preview image with 100px in width
        ///</summary>
        [JsonProperty("photo_100")]
        public String Photo100 { get; set; }

        ///<summary>
        /// URL of the preview image with 200px in width
        ///</summary>
        [JsonProperty("photo_200")]
        public String Photo200 { get; set; }

        ///<summary>
        /// URL of the preview image with 50px in width
        ///</summary>
        [JsonProperty("photo_50")]
        public String Photo50 { get; set; }
    }
}