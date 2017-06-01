using Newtonsoft.Json;

namespace VkLib.Responses.Groups
{
    public class IsMemberExtendedResponse
    {
        /// <summary>
        ///     Information whether user has sent request to the group
        /// </summary>
        [JsonProperty("request")]
        public int Request { get; set; }

        /// <summary>
        ///     Information whether user is a member of the group
        /// </summary>
        [JsonProperty("member")]
        public int Member { get; set; }

        /// <summary>
        ///     Information whether user has been invited to the group
        /// </summary>
        [JsonProperty("invitation")]
        public int Invitation { get; set; }
    }
}