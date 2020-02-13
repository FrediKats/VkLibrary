using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Base
{
    public class BaseSticker
    {
        [JsonProperty("images")]
        public BaseImage[] Images { get; set; }
        [JsonProperty("images_with_background")]
        public BaseImage[] ImagesWithBackground { get; set; }

        ///<summary>
        /// Collection ID
        ///</summary>
        [JsonProperty("product_id")]
        public int ProductId { get; set; }

        ///<summary>
        /// Sticker ID
        ///</summary>
        [JsonProperty("sticker_id")]
        public int StickerId { get; set; }
    }
}