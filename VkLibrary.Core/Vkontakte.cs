using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using VkLibrary.Core.Auth;
using VkLibrary.Core.LongPolling;
using VkLibrary.Core.Methods;

namespace VkLibrary.Core
{
    /// <summary>
    /// Library main class that should be instantiated to work with VK API.
    /// </summary>
    /// ReSharper disable once ClassNeverInstantiated.Global
    public class Vkontakte : IDisposable
    {
        private readonly JsonParsingType _jsonParsingType;
        private readonly HttpClient _httpClient;
        private readonly Action<object> _logger;
        private readonly string _clientSecret;
        private readonly string _apiVersion;
        private readonly string _appId;

        internal const string DirectAuthUrl = "https://oauth.vk.com/";
        internal const string OAuthUrl = "https://oauth.vk.com/authorize";
        internal const string OAuthRedirectUrl = "https://oauth.vk.com/blank.html";
        internal const string MethodBase = "https://api.vk.com/method/";

        /// <summary>
        /// Initializes the library.
        /// </summary>
        /// <param name="appId">Unique app identifier</param>
        /// <param name="jsonParsingType">How JSON should be parsed</param>
        /// <param name="clientSecret">App access key</param>
        /// <param name="apiVersion">API version</param>
        /// <param name="logger">Custom logger</param>
        public Vkontakte(string appId, JsonParsingType jsonParsingType, 
            string clientSecret = null, string apiVersion = "5.63",
            Action<object> logger = null)
        {
            _appId = appId;
            _logger = logger;
            _apiVersion = apiVersion;
            _clientSecret = clientSecret;
            _jsonParsingType = jsonParsingType;
            _httpClient = new HttpClient();
            Log("Library initialized.");
        }

        /// <summary>
        /// Sends GET request to vk server.
        /// </summary>
        /// <param name="method">Method shortcut</param>
        /// <param name="parameters">Parameters dict</param>
        /// <returns></returns>
        public async Task<TResult> GetAsync<TResult>(string method, Dictionary<string, string> parameters)
        {
            // Add token and api version info to request.
            if (!string.IsNullOrEmpty(AccessToken?.Token))
                parameters.Add("access_token", AccessToken.Token);
            parameters.Add("v", _apiVersion);

            // Build request url with parameters.
            var urlString = BuildUrl(string.Concat(MethodBase, method), parameters);
            Log($"Invoking {method}: {urlString}");

            // Get response and parse it based on parsing type.
            var response = 
                await DeserializeGetInPrefferedWay<ApiResponse<TResult>>
                (urlString).ConfigureAwait(false);
            ProcessErrors(response.Error);
            return response.Response;
        }

        /// <summary>
        /// Checks for any API errors and throws
        /// an exception of type ApiException.
        /// </summary>
        /// <param name="apiError">API error to parse.</param>
        private void ProcessErrors(ApiError apiError)
        {
            if (apiError == null) return;
            Log("Received API error. " +
                $"Code: {apiError.Code}, " +
                $"About: \"{apiError.ErrorMessage}\"");
            throw new ApiException(apiError);
        }

        /// <summary>
        /// Deserializes Get response in a preffered way.
        /// </summary>
        /// <typeparam name="TResult">Type of result object</typeparam>
        /// <param name="urlString">Url string to get response from</param>
        /// <returns>Object of TResult type</returns>
        internal Task<TResult> DeserializeGetInPrefferedWay<TResult>(string urlString)
        {
            switch (_jsonParsingType)
            {
                case JsonParsingType.UseStream:
                    return DeserializeGetFromStream<TResult>(urlString);
                case JsonParsingType.UseString:
                    return DeserializeGetFromString<TResult>(urlString);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// Deserializes object using Stream and JsonConverter. 
        /// Optimal for performance.
        /// </summary>
        /// <typeparam name="TResult">Type of result object</typeparam>
        /// <param name="urlString">Url string to get response from</param>
        /// <returns>Object of TResult type</returns>
        private async Task<TResult> DeserializeGetFromStream<TResult>(string urlString)
        {
            using (var stream = await _httpClient.GetStreamAsync(urlString).ConfigureAwait(false))
            using (var streamReader = new StreamReader(stream))
            using (var jsonReader = new JsonTextReader(streamReader))
            {
                var serializer = new JsonSerializer();
                var response = serializer.Deserialize<TResult>(jsonReader);
                Log("Response successfully deserialized.");
                return response;
            }
        }

        /// <summary>
        /// Deserializes object from string and logs more debug info.
        /// Optimal for debugging.
        /// </summary>
        /// <typeparam name="TResult">Type of result object</typeparam>
        /// <param name="urlString">Url string to get response from</param>
        /// <returns>Object of TResult type</returns>
        private async Task<TResult> DeserializeGetFromString<TResult>(string urlString)
        {
            using (var responseMessage = await _httpClient.GetAsync(urlString).ConfigureAwait(false))
            {
                var str = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
                Log($"Response: {str}");
                var response = JsonConvert.DeserializeObject<TResult>(str);
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
        public static string BuildUrl(string baseString, Dictionary<string, string> parameters) => 
            string.Concat($"{baseString}?", string.Join("&", parameters.Select(i =>
                $"{Uri.EscapeDataString(i.Key)}={Uri.EscapeDataString(i.Value)}")));

        /// <summary>
        /// Executes given script written in VKSCRIPT language on VK servers.
        /// See docs for more info: https://vk.com/dev/execute
        /// </summary>
        /// <typeparam name="TResult">Type to return</typeparam>
        /// <param name="script">Your code</param>
        /// <returns>Object of a given type, determined by a script.</returns>
        public async Task<TResult> Execute<TResult>(string script) => 
            await GetAsync<TResult>("execute", new Dictionary<string, string>
                { {"code", script} });

        /// <summary>
        /// Logs information to Debug output.
        /// </summary>
        /// <param name="obj">Object to show</param>
        internal void Log(object obj) => _logger?.Invoke($"[VKLIBRARY.CORE]: {obj}");

        /// <summary>
        /// Converts Unix timestamp to regular DateTime.
        /// </summary>
        /// <param name="unixTimeStamp">unix TimeStamp</param>
        /// <returns>Converted DateTime</returns>
        public static DateTime UnixTimeToDateTime(double unixTimeStamp) => 
            new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(unixTimeStamp);

        /// <summary>
        /// Converts DateTime to Unix timestamp.
        /// </summary>
        /// <param name="dateTime">DateTime</param>
        /// <returns>Converted Unix Timestamp</returns>
        public static double DateTimeToUnixTime(DateTime dateTime) => 
            dateTime.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;

        /// <summary>
        /// User access token.
        /// </summary>
        public AccessToken AccessToken { get; set; }

        /// <summary>
        /// Inits a LongPollClient using extended settings.
        /// Docs: <see href="https://vk.com/dev/using_longpoll">Using LongPoll</see>
        /// </summary>
        /// <param name="key">Secret session key.</param>
        /// <param name="server">Server address to which you need to send the request</param>
        /// <param name="ts">Number of the last event from which you want to receive data</param>
        /// <param name="mode">Additional answer options.</param>
        /// <param name="version">
        /// Actual version: 1. For version 0 (default), community IDs will arrive in the format 
        /// group_id + 1000000000 for saving backward compatibility. 
        /// We recommend using the updated version.
        /// </param>
        /// <param name="wait">
        /// Waiting period (as most proxy servers terminate the connection after 30 seconds, 
        /// we recommend indicating wait = 25). Maximum: 90. 
        /// </param>
        /// <returns>Running Long Poll Client instance.</returns>
        public LongPollClient StartLongPollClient(string server, string key, int ts, 
            int version = 1, int wait = 25, AnswerFlags mode = AnswerFlags.ReceiveAttachments) => 
            new LongPollClient(this, server, key, ts, version, wait, mode);

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

        #region Helper methods

        /// <summary>
        /// Returns app id that library uses now.
        /// </summary>
        /// <returns></returns>
        public string GetAppId() => _appId;

        /// <summary>
        /// Returns api version that library uses now.
        /// </summary>
        public string GetApiVersion() => _apiVersion;

        /// <summary>
        /// Returns client secret that library uses now. 
        /// </summary>
        public string GetClientSecret() => _clientSecret;

        /// <summary>
        /// Pattern for disposing httpClient.
        /// </summary>
        public void Dispose() => _httpClient?.Dispose();

        #endregion
    }

    /// <summary>
    /// Json parsing type.
    /// </summary>
    public enum JsonParsingType
    {
        /// <summary>
        /// To minimize memory usage and the number of objects allocated,
        /// Json.NET supports serializing and deserializing directly from a stream.
        /// Use this for better performance when parsing JSONs.
        /// </summary>
        UseStream,

        /// <summary>
        /// Loads Json into a string, logs it to the DEBUG output, and then
        /// deserializes. Use this for testing purposes.
        /// </summary>
        UseString
    }
}