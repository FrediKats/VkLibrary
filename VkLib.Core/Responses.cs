using System.Collections.Generic;
using Newtonsoft.Json;

namespace VkLib
{
    /// <summary>
    ///     Main API response object that helds all information.
    /// </summary>
    /// <typeparam name="T">Generic</typeparam>
    [JsonObject]
    public class ApiResponse<T>
    {
        /// <summary>
        ///     Response of a given type.
        /// </summary>
        [JsonProperty("response")]
        public T Response { get; set; }

        /// <summary>
        ///     Error got from API. Is NULL when everything is OK.
        /// </summary>
        [JsonProperty("error")]
        public ApiError Error { get; set; }
    }

    /// <summary>
    ///     API error class.
    /// </summary>
    [JsonObject]
    public class ApiError
    {
        /// <summary>
        ///     API error code.
        /// </summary>
        [JsonProperty("error_code")]
        public int Code { get; set; }

        /// <summary>
        ///     API error title.
        /// </summary>
        [JsonProperty("error_msg")]
        public string ErrorMessage { get; set; }
    }

    /// <summary>
    ///     Extended collection response.
    /// </summary>
    /// <typeparam name="T">Generic</typeparam>
    [JsonObject]
    public class ApiItemsResponse<T>
    {
        /// <summary>
        ///     Total items count.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        ///     Collection of items.
        /// </summary>
        [JsonProperty("items")]
        public List<T> Items { get; set; }

        /// <summary>
        ///     Next-from indicator. Used in some methods.
        /// </summary>
        [JsonProperty("next_from")]
        public string NextFrom { get; set; }
    }
}