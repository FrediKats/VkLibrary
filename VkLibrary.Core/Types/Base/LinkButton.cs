using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Base
{
    public class LinkButton
    {
        /// <summary>
        /// Button action
        /// </summary>
        [JsonProperty("action")]
        public LinkButtonAction Action { get; set; }

        /// <summary>
        /// Button title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}