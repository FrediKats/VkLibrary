using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class WallGraffiti
    {
        ///<summary>
        /// Graffiti ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Graffiti owner's ID
        ///</summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        ///<summary>
        /// URL of the preview image with 200 px in width
        ///</summary>
        [JsonProperty("photo_200")]
        public String Photo200 { get; set; }

        ///<summary>
        /// URL of the preview image with 586 px in width
        ///</summary>
        [JsonProperty("photo_586")]
        public String Photo586 { get; set; }
    }
}