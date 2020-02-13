using Newtonsoft.Json;

namespace VkApi.Wrapper.Responses.Docs
{
    public class DocsAddResponse
    {
        ///<summary>
        /// Doc ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}