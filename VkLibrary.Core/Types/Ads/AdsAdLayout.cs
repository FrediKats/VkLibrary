using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Ads
{
    public class AdsAdLayout
    {
        ///<summary>
        /// Ad format
        ///</summary>
        [JsonProperty("ad_format")]
        public int AdFormat { get; set; }

        ///<summary>
        /// Campaign ID
        ///</summary>
        [JsonProperty("campaign_id")]
        public int CampaignId { get; set; }
        [JsonProperty("cost_type")]
        public AdsAdCostType CostType { get; set; }

        ///<summary>
        /// Ad description
        ///</summary>
        [JsonProperty("description")]
        public String Description { get; set; }

        ///<summary>
        /// Ad ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Image URL
        ///</summary>
        [JsonProperty("image_src")]
        public String ImageSrc { get; set; }

        ///<summary>
        /// URL of the preview image in double size
        ///</summary>
        [JsonProperty("image_src_2x")]
        public String ImageSrc2x { get; set; }

        ///<summary>
        /// Domain of advertised object
        ///</summary>
        [JsonProperty("link_domain")]
        public String LinkDomain { get; set; }

        ///<summary>
        /// URL of advertised object
        ///</summary>
        [JsonProperty("link_url")]
        public String LinkUrl { get; set; }

        ///<summary>
        /// link to preview an ad as it is shown on the website
        ///</summary>
        [JsonProperty("preview_link")]
        public object PreviewLink { get; set; }

        ///<summary>
        /// Ad title
        ///</summary>
        [JsonProperty("title")]
        public String Title { get; set; }

        ///<summary>
        /// Information whether the ad is a video
        ///</summary>
        [JsonProperty("video")]
        public int Video { get; set; }
    }
}