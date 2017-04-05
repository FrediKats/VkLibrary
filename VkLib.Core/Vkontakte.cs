using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using VkLib.Methods;
using VkLib.Auth;
using System.IO;

namespace VkLib
{
    public class Vkontakte
    {
        private readonly JsonParsingType _jsonParsingType;
        private readonly HttpClient _httpClient;
        private readonly string _clientSecret;
        private readonly string _appId;
        private readonly string _apiVersion;

        public const string DirectAuthUrl    = "https://oauth.vk.com/";
        public const string OAuthUrl         = "https://oauth.vk.com/authorize?";
        public const string OAuthRedirectUrl = "https://oauth.vk.com/blank.html";
        public const string MethodBase       = "https://api.vk.com/method/";

        /// <summary>
        /// Initializes the library.
        /// </summary>
        /// <param name="appId">Unique app identifier</param>
        /// <param name="clientSecret">App access key</param>
        /// <param name="apiVersion">API version</param>
        public Vkontakte(
            string appId, JsonParsingType jsonParsingType,
            string clientSecret = null, string apiVersion = "5.60"
        ) {
            this._appId = appId;
            this._apiVersion = apiVersion;
            this._clientSecret = clientSecret;

            this._jsonParsingType = jsonParsingType;
            this._httpClient = new HttpClient();
        }
        
        /// <summary>
        /// Sends GET request to vk server.
        /// </summary>
        /// <param name="baseUri"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        internal async Task<T> GetAsync<T>(string method, 
            Dictionary<string, string> parameters, 
            string baseUrl = Vkontakte.MethodBase,
            bool usePlain = false
        ) { 
            // Check network connectivity.
            if (!NetworkInterface.GetIsNetworkAvailable())
                throw new HttpRequestException("Network unavailiable.");
            
            // Check access tokens, secret keys, versions.
            if (AccessToken != null && !string.IsNullOrEmpty(AccessToken.Token))
                parameters.Add("access_token", AccessToken.Token);
            parameters.Add("v", _apiVersion);
            
            // Get request Url.
            string urlString = GetUrl(
                string.Concat(baseUrl, method, "?"), 
                parameters
            );
            Log($"Invoking {method}: {urlString}");
            
            // Parse JSON in a preferred way.
            switch (_jsonParsingType)
            {
                case JsonParsingType.UseStream:
                    if (usePlain)
                        return await DeserializeGetFromStream<T>(urlString).ConfigureAwait(false);

                    // Deserialize obj from stream.
                    ApiResponse<T> apiStreamResponse = await DeserializeGetFromStream<ApiResponse<T>>(
                        urlString).ConfigureAwait(false);
                    this.ProcessErrors(apiStreamResponse.Error);
                    return apiStreamResponse.Response;

                case JsonParsingType.UseString:
                    if (usePlain)
                        return await DeserializeGetFromString<T>(urlString).ConfigureAwait(false);

                    // Deserialize obj from string.
                    ApiResponse<T> apiStringResponse = await DeserializeGetFromString<ApiResponse<T>>(
                        urlString).ConfigureAwait(false);
                    this.ProcessErrors(apiStringResponse.Error);
                    return apiStringResponse.Response;

                default:
                    throw new Exception("Unknown error occured.");
            }
        }

        /// <summary>
        /// Check for any API errors.
        /// </summary>
        private void ProcessErrors(ApiError apiError)
        {
            if (apiError != null)
            {
                Log($"Received API error. " +
                    $"Code: {apiError.Code}, " +
                    $"About: \"{apiError.ErrorMessage}\"");
                throw new ApiException(apiError);
            }
        }

        /// <summary>
        /// Deserializes object using Stream and JsonConverter. Optimal.
        /// </summary>
        private async Task<T> DeserializeGetFromStream<T>(string urlString)
        {
            using (Stream stream = await _httpClient.GetStreamAsync(urlString).ConfigureAwait(false))
            using (StreamReader streamReader = new StreamReader(stream))
            using (JsonReader jsonReader = new JsonTextReader(streamReader))
            {
                JsonSerializer serializer = new JsonSerializer();
                T response = serializer.Deserialize<T>(jsonReader);
                Log("Response successfully deserialized.");

                return response;
            }
        }

        /// <summary>
        /// Deserializes object from string and logs some debug info.
        /// </summary>
        private async Task<T> DeserializeGetFromString<T>(string urlString)
        {
            using (var responseMessage = await _httpClient.GetAsync(urlString).ConfigureAwait(false))
            {
                string str = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
                Log($"Response: {str}");

                T response = JsonConvert.DeserializeObject<T>(str);
                Log("Response successfully deserialized.");

                return response;
            }
        }

        /// <summary>
        /// Creates url string from parameters dict and method base.
        /// </summary>
        /// <param name="baseString">Main url part</param>
        /// <param name="parameters">Params dict</param>
        /// <returns></returns>
        internal string GetUrl(string baseString, Dictionary<string, string> parameters)
        {
            return string.Concat(baseString,
                string.Join("&", parameters.Select(
                    i => string.Format("{0}={1}",
                    Uri.EscapeDataString(i.Key),
                    Uri.EscapeDataString(i.Value)
                )))
            );
        }

        /// <summary>
        /// Executes given script written in VKSCRIPT language on VK servers.
        /// See docs for more info: https://vk.com/dev/execute
        /// </summary>
        /// <typeparam name="T">Type to return</typeparam>
        /// <param name="script">Your code</param>
        /// <returns>Object of a given type, determined by a script.</returns>
        public async Task<T> Execute<T>(string script)
        {
            return await GetAsync<T>("execute", new Dictionary<string, string>() {
                { "code", script }
            }).ConfigureAwait(false);
        }

        /// <summary>
        /// Logs information to Debug output.
        /// </summary>
        /// <param name="obj">Object to show</param>
        internal void Log(object obj)
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
        public static DateTime UnixTimeToDateTime(double unixTimeStamp)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(unixTimeStamp).ToLocalTime();
        }

        /// <summary>
        /// Converts DateTime to Unix timestamp.
        /// </summary>
        /// <param name="dateTime">DateTime</param>
        /// <returns>Converted Unix Timestamp</returns>
        public static double DateTomeToUnixTime(DateTime dateTime)
        {
            return (DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
        }

        /// <summary>
        /// User access token.
        /// </summary>
        public AccessToken AccessToken { get; set; }

        /// <summary>
        /// Application identifier.
        /// </summary>
        internal string AppId => _appId;

        /// <summary>
        /// Application secret code.
        /// </summary>
        internal string ClientSecret => _clientSecret;

        /// <summary>
        /// API version used by the Lib.
        /// </summary>
        internal string ApiVersion => _apiVersion;

        #region API sections

        /// <summary>
        /// API part related to direct auth.
        /// </summary>
        public DirectAuth DirectAuth => new DirectAuth(this);

        /// <summary>
        /// API files upload helper. Contains upload methods.
        /// </summary>
        public UploadHelper UploadHelper => new UploadHelper(this); 

        /// <summary>
        /// OAuth helpers API section.
        /// </summary>
        public OAuth OAuth => new OAuth(this);

        /// <summary>
        /// Account API section.
        /// </summary>
        public Account Account => new Account(this); 

        /// <summary>
        /// Ads API section.
        /// </summary>
        public Ads Ads => new Ads(this);

        /// <summary>
        /// Apps API section.
        /// </summary>
        public Apps Apps => new Apps(this);

        /// <summary>
        /// Audio API section.
        /// </summary>
        public Audio Audio => new Audio(this);

        /// <summary>
        /// Board API section.
        /// </summary>
        public Board Board => new Board(this);

        /// <summary>
        /// Database API section.
        /// </summary>
        public Database Database => new Database(this);

        /// <summary>
        /// Docs API section.
        /// </summary>
        public Docs Docs => new Docs(this); 

        /// <summary>
        /// Fave API section.
        /// </summary>
        public Fave Fave => new Fave(this);

        /// <summary>
        /// Friends API section.
        /// </summary>
        public Friends Friends => new Friends(this);

        /// <summary>
        /// Gifts API section.
        /// </summary>
        public Gifts Gifts => new Gifts(this);

        /// <summary>
        /// Groups API section.
        /// </summary>
        public Groups Groups => new Groups(this);

        /// <summary>
        /// Leads API section.
        /// </summary>
        public Leads Leads => new Leads(this);

        /// <summary>
        /// Likes API section.
        /// </summary>
        public Likes Likes => new Likes(this);

        /// <summary>
        /// Market API section.
        /// </summary>
        public Market Market => new Market(this);

        /// <summary>
        /// Messages API section.
        /// </summary>
        public Messages Messages => new Messages(this);

        /// <summary>
        /// Newsfeed API section.
        /// </summary>
        public Newsfeed Newsfeed => new Newsfeed(this);

        /// <summary>
        /// Notes API section.
        /// </summary>
        public Notes Notes => new Notes(this);

        /// <summary>
        /// Notifications API section.
        /// </summary>
        public Notifications Notifications => new Notifications(this);

        /// <summary>
        /// Orders API section.
        /// </summary>
        public Orders Orders => new Orders(this);

        /// <summary>
        /// Pages API section.
        /// </summary>
        public Pages Pages => new Pages(this);

        /// <summary>
        /// Photos API section.
        /// </summary>
        public Photos Photos => new Photos(this);

        /// <summary>
        /// Places API section.
        /// </summary>
        public Places Places => new Places(this);

        /// <summary>
        /// Polls API section.
        /// </summary>
        public Polls Polls => new Polls(this);

        /// <summary>
        /// Search API section.
        /// </summary>
        public Search Search => new Search(this);

        /// <summary>
        /// Secure API section.
        /// </summary>
        public Secure Secure => new Secure(this);

        /// <summary>
        /// Stats API section.
        /// </summary>
        public Stats Stats => new Stats(this);

        /// <summary>
        /// Status API section.
        /// </summary>
        public Status Status => new Status(this);

        /// <summary>
        /// Storage API section.
        /// </summary>
        public Storage Storage => new Storage(this);

        /// <summary>
        /// Users API section.
        /// </summary>
        public Users Users => new Users(this);

        /// <summary>
        /// Utils API section.
        /// </summary>
        public Utils Utils => new Utils(this);

        /// <summary>
        /// Video API section.
        /// </summary>
        public Video Video => new Video(this);

        /// <summary>
        /// Wall API section.
        /// </summary>
        public Wall Wall => new Wall(this);

        /// <summary>
        /// Widgets API section.
        /// </summary>
        public Widgets Widgets => new Widgets(this);

        #endregion
    }

    /// <summary>
    /// Json parsing type.
    /// </summary>
    public enum JsonParsingType
    {
        /// <summary>
        /// To minimize memory usage and the number of objects allocated, 
        /// Json.NET supports serializing and deserializing directly to a stream.
        /// Use this for better performance when parsing Jsons.
        /// </summary>
        UseStream,

        /// <summary>
        /// Loads Json into a string, logs it to the DEBUG output, and then
        /// deserializes. Use this for testing purposes. 
        /// </summary>
        UseString
    }
}
