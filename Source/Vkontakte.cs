using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using VkLib.Methods;
using VkLib.Types;

namespace VkLib
{
    public class Vkontakte
    {
        private readonly string _clientSecret;
        private readonly string _appId;
        private          string _apiVersion;

        public const string DirectAuthUrl    = "https://oauth.vk.com/token";
        public const string OAuthUrl         = "https://oauth.vk.com/authorize?";
        public const string OAuthRedirectUrl = "https://oauth.vk.com/blank.html";
        public const string MethodBase       = "https://api.vk.com/method/";

        /// <summary>
        /// Initializes the library.
        /// </summary>
        /// <param name="appId">Unique app identifier</param>
        /// <param name="clientSecret">App access key</param>
        /// <param name="apiVersion">API version</param>
        public Vkontakte(string appId, string apiVersion = "5.60", string clientSecret = null)
        {
            this._appId = appId;
            this._apiVersion = apiVersion;
            this._clientSecret = clientSecret;
        }

        /// <summary>
        /// Sends GET request to vk server. Sample:
        /// GetAsync
        /// </summary>
        /// <param name="baseUri"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public async Task<T> GetAsync<T>(string method, Dictionary<string, string> parameters)
        {
            // Check network connectivity.
            if (!NetworkInterface.GetIsNetworkAvailable())
                throw new Exception("Network unavailiable.");

            // Sign method using access token and api version number.
            if (AccessToken != null)
                parameters.Add("access_token", AccessToken.Token);
            parameters.Add("v", _apiVersion);

            // Build Uri string.
            string urlString =
                string.Concat(MethodBase, method, "?",
                    string.Join("&", parameters.Select(
                        i => string.Format("{0}={1}",
                        Uri.EscapeDataString(i.Key),
                        Uri.EscapeDataString(i.Value)
                    )))
                );
            log($"Invoking {method}: {urlString}");

            // Invoke GET request.
            using (HttpClient httpClient = new HttpClient())
            using (HttpResponseMessage responseMessage = await httpClient.GetAsync(urlString))
            {
                // Read response as string.
                string response = await responseMessage.Content.ReadAsStringAsync();
                log($"Response: {response}");
               
                // Deserialize object of given type.
                ApiResponse<T> apiResponse = JsonConvert.DeserializeObject<ApiResponse<T>>(response);

                // Check for errors.
                if (apiResponse.Error != null)
                { 
                    log($"ERROR:{apiResponse.Error.ErrorMessage}, CODE: {apiResponse.Error.Code}");
                    throw new FormatException(apiResponse.Error.ErrorMessage);
                }

                return apiResponse.Response;
            }
        }

        /// <summary>
        /// Logs information to Debug output.
        /// </summary>
        /// <param name="obj">Object to show</param>
        public void log(object obj)
        {
#if DEBUG
            Debug.WriteLine(obj);
#endif
        }

        /// <summary>
        /// Converts Unix timestamp to regular DateTime.
        /// </summary>
        /// <param name="unixTimeStamp">unix TimeStamp</param>
        /// <returns>Converted DateTime</returns>
        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(unixTimeStamp).ToLocalTime();
        }

        /// <summary>
        /// User access token.
        /// </summary>
        public AccessToken AccessToken { get; set; } = new AccessToken();

        /// <summary>
        /// Application identifier.
        /// </summary>
        internal string AppId
        {
            get { return _appId; }
        }

        /// <summary>
        /// Application secret code.
        /// </summary>
        internal string ClientSecret
        {
            get { return _clientSecret; }
        }

        /// <summary>
        /// API version used by the Lib.
        /// </summary>
        public string ApiVersion
        {
            get { return _apiVersion; }
        }

        /// <summary>
        /// Messages API section.
        /// </summary>
        public Messages Messages
        {
            get { return new Messages(this); }
        }

        /// <summary>
        /// Account API section.
        /// </summary>
        public Account Account
        {
            get { return new Account(this); }
        }

        /// <summary>
        /// Users API section.
        /// </summary>
        public Users Users
        {
            get { return new Users(this); }
        }

    }
}
