using Newtonsoft.Json;
using VkLibrary.Core.Types.Account;

namespace VkLibrary.Core.Responses.Account
{
    public class SaveProfileInfoResponse
    {
        /// <summary>
        /// 1 if changes has been processed
        /// </summary>
        [JsonProperty("changed")]
        public int Changed { get; set; }

        /// <summary>
        /// None
        /// </summary>
        [JsonProperty("name_request")]
        public NameRequest NameRequest { get; set; }
    }
}