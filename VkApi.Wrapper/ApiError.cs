using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace VkApi.Wrapper
{
    /// <summary>
    /// API error class.
    /// </summary>
    public class ApiError
    {
        /// <summary>
        /// API error code.
        /// </summary>
        [JsonProperty("error_code")]
        public int Code { get; set; }

        /// <summary>
        /// API error title.
        /// </summary>
        [JsonProperty("error_msg")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Contains captcha sid when error code equals 14, 
        /// otherwise null.
        /// </summary>
        [JsonProperty("captcha_sid")]
        public string CaptchaSid { get; set; }

        /// <summary>
        /// Contains captcha image url when error code is
        /// 14, otherwise null.
        /// </summary>
        [JsonProperty("captcha_img")]
        public string CaptchaImg { get; set; }

        /// <summary>
        /// Additional request parameters JSON array.
        /// </summary>
        [JsonProperty("request_params")]
        public JArray RequestParams { get; set; }
    }
}
