using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class BaseGeoCoordinates
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }
        [JsonProperty("longitude")]
        public double Longitude { get; set; }
    }
}