using Newtonsoft.Json;

namespace VkLib.Types.Polls
{
    public class Voters
    {
        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("users")]
        public VotersUsers Users { get; set; }

        /// <summary>
        ///     Answer ID
        /// </summary>
        [JsonProperty("answer_id")]
        public int? AnswerId { get; set; }
    }
}