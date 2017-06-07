using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Polls
{
    /// <summary>
    /// API Voters object.
    /// </summary>
    public class Voters
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("users")]
        public VotersUsers Users { get; set; }

        /// <summary>
        /// Answer ID
        /// </summary>
        [JsonProperty("answer_id")]
        public int? AnswerId { get; set; }
    }
}