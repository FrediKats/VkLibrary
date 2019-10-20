using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class PrettyCardsPrettyCard
    {
        ///<summary>
        /// Button key
        ///</summary>
        [JsonProperty("button")]
        public String Button { get; set; }

        ///<summary>
        /// Button text in current language
        ///</summary>
        [JsonProperty("button_text")]
        public String ButtonText { get; set; }

        ///<summary>
        /// Card ID (long int returned as string)
        ///</summary>
        [JsonProperty("card_id")]
        public String CardId { get; set; }
        [JsonProperty("images")]
        public BaseImage[] Images { get; set; }

        ///<summary>
        /// Link URL
        ///</summary>
        [JsonProperty("link_url")]
        public String LinkUrl { get; set; }

        ///<summary>
        /// Photo ID (format "<owner_id>_<media_id>")
        ///</summary>
        [JsonProperty("photo")]
        public String Photo { get; set; }

        ///<summary>
        /// Price if set (decimal number returned as string)
        ///</summary>
        [JsonProperty("price")]
        public String Price { get; set; }

        ///<summary>
        /// Old price if set (decimal number returned as string)
        ///</summary>
        [JsonProperty("price_old")]
        public String PriceOld { get; set; }

        ///<summary>
        /// Title
        ///</summary>
        [JsonProperty("title")]
        public String Title { get; set; }
    }
}