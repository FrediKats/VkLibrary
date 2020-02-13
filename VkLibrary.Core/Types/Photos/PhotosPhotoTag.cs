using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Photos
{
    public class PhotosPhotoTag
    {
        ///<summary>
        /// Date when tag has been added in Unixtime
        ///</summary>
        [JsonProperty("date")]
        public int Date { get; set; }

        ///<summary>
        /// Tag ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// ID of the tag creator
        ///</summary>
        [JsonProperty("placer_id")]
        public int PlacerId { get; set; }

        ///<summary>
        /// Tag description
        ///</summary>
        [JsonProperty("tagged_name")]
        public String TaggedName { get; set; }

        ///<summary>
        /// Tagged user ID
        ///</summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        ///<summary>
        /// Information whether the tag is reviewed
        ///</summary>
        [JsonProperty("viewed")]
        public int Viewed { get; set; }

        ///<summary>
        /// Coordinate X of the left upper corner
        ///</summary>
        [JsonProperty("x")]
        public double X { get; set; }

        ///<summary>
        /// Coordinate X of the right lower corner
        ///</summary>
        [JsonProperty("x2")]
        public double X2 { get; set; }

        ///<summary>
        /// Coordinate Y of the left upper corner
        ///</summary>
        [JsonProperty("y")]
        public double Y { get; set; }

        ///<summary>
        /// Coordinate Y of the right lower corner
        ///</summary>
        [JsonProperty("y2")]
        public double Y2 { get; set; }
    }
}