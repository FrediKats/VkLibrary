using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Ads 
{
    public class AdLayout
    {
        /// <summary>
        /// Campaign ID
        /// </summary>
        [JsonProperty("campaign_id")]
        public int? CampaignId { get; set; }

        /// <summary>
        /// Ad format
        /// </summary>
        [JsonProperty("ad_format")]
        public int? AdFormat { get; set; }

        /// <summary>
        /// Information whether the ad is a video
        /// </summary>
        [JsonProperty("video")]
        public int? Video { get; set; }

        /// <summary>
        /// Ad title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// link to preview an ad as it is shown on the website
        /// </summary>
        [JsonProperty("preview_link")]
        public string PreviewLink { get; set; }

        /// <summary>
        /// Cost type
        /// </summary>
        [JsonProperty("cost_type")]
        public int? CostType { get; set; }

        /// <summary>
        /// Domain of advertised object
        /// </summary>
        [JsonProperty("link_domain")]
        public string LinkDomain { get; set; }

        /// <summary>
        /// Ad description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// URL of advertised object
        /// </summary>
        [JsonProperty("link_url")]
        public string LinkUrl { get; set; }

        /// <summary>
        /// Ad ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Image URL
        /// </summary>
        [JsonProperty("image_src")]
        public int? ImageSrc { get; set; }

        /// <summary>
        /// URL of the preview image in double size
        /// </summary>
        [JsonProperty("image_src_2x")]
        public int? ImageSrc2x { get; set; }

    }
}
