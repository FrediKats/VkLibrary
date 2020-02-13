using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Base
{
    public class BaseGeoCoordinates
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }
        [JsonProperty("longitude")]
        public double Longitude { get; set; }
    }
}