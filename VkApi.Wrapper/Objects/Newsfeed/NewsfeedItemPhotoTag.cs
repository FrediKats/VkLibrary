using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class NewsfeedItemPhotoTag
    {
        [JsonProperty("photo_tags")]
        public NewsfeedItemPhotoTagPhotoTags PhotoTags { get; set; }

        ///<summary>
        /// Post ID
        ///</summary>
        [JsonProperty("post_id")]
        public int PostId { get; set; }
    }
}