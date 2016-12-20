using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Photos 
{
    public class PhotoAlbum
    {
        /// <summary>
        /// Photo album ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Album owner's ID
        /// </summary>
        [JsonProperty("owner_id")]
        public int? OwnerId_ { get; set; }

        /// <summary>
        /// Photos number
        /// </summary>
        [JsonProperty("size")]
        public int? Size { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("thumb")]
        public VkLib.Types.Photos.Photo Thumb { get; set; }

        /// <summary>
        /// Date when the album has been created in Unixtime
        /// </summary>
        [JsonProperty("created")]
        public int? Created { get; set; }

        /// <summary>
        /// Photo album description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Photo album title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Date when the album has been updated last time in Unixtime
        /// </summary>
        [JsonProperty("updated")]
        public int? Updated { get; set; }

    }
}
