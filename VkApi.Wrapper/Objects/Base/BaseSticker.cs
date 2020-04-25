using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class BaseSticker
    {
        ///<summary>
        /// Sticker ID
        ///</summary>
        [JsonProperty("sticker_id")]
        public int StickerId { get; set; }

        ///<summary>
        /// Pack ID
        ///</summary>
        [JsonProperty("product_id")]
        public int ProductId { get; set; }
        [JsonProperty("images")]
        public BaseImage[] Images { get; set; }
        [JsonProperty("images_with_background")]
        public BaseImage[] ImagesWithBackground { get; set; }

        ///<summary>
        /// URL of sticker animation script
        ///</summary>
        [JsonProperty("animation_url")]
        public String AnimationUrl { get; set; }

        ///<summary>
        /// Array of sticker animation script objects
        ///</summary>
        [JsonProperty("animations")]
        public BaseStickerAnimation[] Animations { get; set; }

        ///<summary>
        /// Information whether the sticker is allowed
        ///</summary>
        [JsonProperty("is_allowed")]
        public Boolean IsAllowed { get; set; }
    }
}