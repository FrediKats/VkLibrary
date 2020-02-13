using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Stories
{
    public class StoriesStoryVideo
    {
        ///<summary>
        /// Information whether story is private (0 - no, 1 - yes).
        ///</summary>
        [JsonProperty("is_private")]
        public int IsPrivate { get; set; }
    }
}