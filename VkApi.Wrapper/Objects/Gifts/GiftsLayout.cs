using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class GiftsLayout
    {
        ///<summary>
        /// Gift ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// URL of the preview image with 512 px in width
        ///</summary>
        [JsonProperty("thumb_512")]
        public String Thumb512 { get; set; }

        ///<summary>
        /// URL of the preview image with 256 px in width
        ///</summary>
        [JsonProperty("thumb_256")]
        public String Thumb256 { get; set; }

        ///<summary>
        /// URL of the preview image with 48 px in width
        ///</summary>
        [JsonProperty("thumb_48")]
        public String Thumb48 { get; set; }

        ///<summary>
        /// URL of the preview image with 96 px in width
        ///</summary>
        [JsonProperty("thumb_96")]
        public String Thumb96 { get; set; }

        ///<summary>
        /// ID of the sticker pack, if the gift is representing one
        ///</summary>
        [JsonProperty("stickers_product_id")]
        public int StickersProductId { get; set; }

        ///<summary>
        /// ID of the build of constructor gift
        ///</summary>
        [JsonProperty("build_id")]
        public String BuildId { get; set; }

        ///<summary>
        /// Keywords used for search
        ///</summary>
        [JsonProperty("keywords")]
        public String Keywords { get; set; }
    }
}