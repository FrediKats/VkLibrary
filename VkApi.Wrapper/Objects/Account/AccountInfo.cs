using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class AccountInfo
    {
        [JsonProperty("wishlists_ae_promo_banner_show")]
        public int WishlistsAePromoBannerShow { get; set; }

        ///<summary>
        /// Two factor authentication is enabled
        ///</summary>
        [JsonProperty("2fa_required")]
        public int _2faRequired { get; set; }
        //TODO: fix
        //[JsonProperty("audio_ads")]
        //public AudioAdsConfig AudioAds { get; set; }

        ///<summary>
        /// Country code
        ///</summary>
        [JsonProperty("country")]
        public String Country { get; set; }

        ///<summary>
        /// Information whether HTTPS-only is enabled
        ///</summary>
        [JsonProperty("https_required")]
        public int HttpsRequired { get; set; }

        ///<summary>
        /// Information whether user has been processed intro
        ///</summary>
        [JsonProperty("intro")]
        public int Intro { get; set; }
        [JsonProperty("show_vk_apps_intro")]
        public Boolean ShowVkAppsIntro { get; set; }

        ///<summary>
        /// Ads slot id for MyTarget
        ///</summary>
        [JsonProperty("mini_apps_ads_slot_id")]
        public int MiniAppsAdsSlotId { get; set; }
        [JsonProperty("qr_promotion")]
        public int QrPromotion { get; set; }
        [JsonProperty("link_redirects")]
        public Object LinkRedirects { get; set; }

        ///<summary>
        /// Language ID
        ///</summary>
        [JsonProperty("lang")]
        public int Lang { get; set; }

        ///<summary>
        /// Information whether wall comments should be hidden
        ///</summary>
        [JsonProperty("no_wall_replies")]
        public int NoWallReplies { get; set; }

        ///<summary>
        /// Information whether only owners posts should be shown
        ///</summary>
        [JsonProperty("own_posts_default")]
        public int OwnPostsDefault { get; set; }
        [JsonProperty("subscriptions")]
        public int[] Subscriptions { get; set; }
    }
}