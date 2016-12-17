using System;
using Newtonsoft.Json;

namespace VkLib.Types.Video 
{
    public class VideoTag
    {
        /// <summary>
        /// Tag ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Tag description
        /// </summary>
        [JsonProperty("tagged_name")]
        public string TaggedName { get; set; }

        /// <summary>
        /// Information whether tha tag is reviewed
        /// </summary>
        [JsonProperty("viewed")]
        public BoolInt Viewed { get; set; }

        /// <summary>
        /// Date when tag has been added in Unixtime
        /// </summary>
        [JsonProperty("date")]
        public int? Date { get; set; }

        /// <summary>
        /// ID of the tag creator
        /// </summary>
        [JsonProperty("placer_id")]
        public int? PlacerId { get; set; }

        /// <summary>
        /// Tagged user ID
        /// </summary>
        [JsonProperty("user_id")]
        public int? UserId { get; set; }

    }
}
