using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class GroupsAddress
    {
        ///<summary>
        /// Additional address to the place (6 floor, left door)
        ///</summary>
        [JsonProperty("additional_address")]
        public String AdditionalAddress { get; set; }

        ///<summary>
        /// String address to the place (Nevsky, 28)
        ///</summary>
        [JsonProperty("address")]
        public String Address { get; set; }

        ///<summary>
        /// City id of address
        ///</summary>
        [JsonProperty("city_id")]
        public int CityId { get; set; }

        ///<summary>
        /// Country id of address
        ///</summary>
        [JsonProperty("country_id")]
        public int CountryId { get; set; }

        ///<summary>
        /// Distance from the point
        ///</summary>
        [JsonProperty("distance")]
        public int Distance { get; set; }

        ///<summary>
        /// Address id
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Address latitude
        ///</summary>
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        ///<summary>
        /// Address longitude
        ///</summary>
        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        ///<summary>
        /// Metro id of address
        ///</summary>
        [JsonProperty("metro_station_id")]
        public int MetroStationId { get; set; }

        ///<summary>
        /// Address phone
        ///</summary>
        [JsonProperty("phone")]
        public String Phone { get; set; }

        ///<summary>
        /// Time offset int minutes from utc time
        ///</summary>
        [JsonProperty("time_offset")]
        public int TimeOffset { get; set; }

        ///<summary>
        /// Week timetable for the address
        ///</summary>
        [JsonProperty("timetable")]
        public GroupsAddressTimetable Timetable { get; set; }

        ///<summary>
        /// Title of the place (Zinger, etc)
        ///</summary>
        [JsonProperty("title")]
        public String Title { get; set; }

        ///<summary>
        /// Status of information about timetable
        ///</summary>
        [JsonProperty("work_info_status")]
        public GroupsAddressWorkInfoStatus WorkInfoStatus { get; set; }
    }
}