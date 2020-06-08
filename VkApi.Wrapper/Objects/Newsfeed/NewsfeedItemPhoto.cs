using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class NewsfeedItemPhoto : NewsfeedItemBase
    {
        [JsonProperty("photos")]
        public NewsfeedItemPhotoPhotos Photos { get; set; }

        ///<summary>
        /// Post ID
        ///</summary>
        [JsonProperty("post_id")]
        public int PostId { get; set; }
    }
}