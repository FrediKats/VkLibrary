using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using VkLibrary.Core.Auth;
using VkLibrary.Core.LongPolling;
using VkLibrary.Core.Services;

namespace VkLibrary.Core
{
    /// <summary>
    /// Vkontakte .NET API.
    /// </summary>
    public partial class Vkontakte : IDisposable
    {
        private const string MethodBase = "https://api.vk.com/method/";
        private readonly RequestMethod _requestMethod;
        private readonly ParseJson _parseJson;
        private string _captchaSid;
        private string _captchaKey;
        
        #region Constructors

        /// <summary>
        /// Initializes the library.
        /// </summary>
        /// <param name="appId">Unique VK app identifier. Get it at vk.com/dev -> App Settings</param>
        /// <param name="appSecret">App secret key. Used only with secure section methods and with direct auth.</param>
        /// <param name="apiVersion">API version the library is going to use. Min: 5.63</param>
        /// <param name="requestMethod">GET or POST requests the library should use?</param>
        /// <param name="parseJson">Should the library log received JSONs or focus on performance?</param>
        public Vkontakte(int appId, string appSecret = "", string apiVersion = "5.101",
            RequestMethod requestMethod = RequestMethod.Get, ParseJson parseJson = ParseJson.FromString)
        {
            AppId = appId;
            AppSecret = appSecret;
            ApiVersion = apiVersion;
            Logger = new DefaultLogger();
            HttpService = new DefaultHttpService(Logger);
            _requestMethod = requestMethod;
            _parseJson = parseJson;
        }
        
        /// <summary>
        /// Initializes the library with extended parameters.
        /// </summary>
        /// <param name="appId">Unique VK app identifier. Get it at vk.com/dev -> App Settings</param>
        /// <param name="appSecret">App secret key. Used only with secure section methods and with direct auth.</param>
        /// <param name="apiVersion">API version the library is going to use. Min: 5.63</param>
        /// <param name="requestMethod">GET or POST requests the library should use?</param>
        /// <param name="parseJson">Should the library log received JSONs or focus on performance?</param>
        /// <param name="logger">Logger the library should use. By default is logs info into DEBUG output.</param>
        public Vkontakte(int appId, ILogger logger, string appSecret = "", string apiVersion = "5.101",
            RequestMethod requestMethod = RequestMethod.Get, ParseJson parseJson = ParseJson.FromString)
        {
            AppId = appId;
            Logger = logger;
            AppSecret = appSecret;
            ApiVersion = apiVersion;
            HttpService = new DefaultHttpService(logger);
            _requestMethod = requestMethod;
            _parseJson = parseJson;
        }
        
        /// <summary>
        /// Initializes the library with extended parameters.
        /// </summary>
        /// <param name="appId">Unique VK app identifier. Get it at vk.com/dev -> App Settings</param>
        /// <param name="appSecret">App secret key. Used only with secure section methods and with direct auth.</param>
        /// <param name="apiVersion">API version the library is going to use. Min: 5.63</param>
        /// <param name="requestMethod">GET or POST requests the library should use?</param>
        /// <param name="parseJson">Should the library log received JSONs or focus on performance?</param>
        /// <param name="httpService">
        /// HttpService the library should use. You can inject your own implementation of IHttpService 
        /// into the library if default one does not suite you for some reasons.
        /// </param>
        public Vkontakte(int appId, IHttpService httpService, string appSecret = "", 
            string apiVersion = "5.101", RequestMethod requestMethod = RequestMethod.Get, 
            ParseJson parseJson = ParseJson.FromString)
        {
            AppId = appId;
            AppSecret = appSecret;
            ApiVersion = apiVersion;
            HttpService = httpService;
            Logger = new DefaultLogger();
            _requestMethod = requestMethod;
            _parseJson = parseJson;
        }

        /// <summary>
        /// Initializes the library with extended parameters.
        /// </summary>
        /// <param name="appId">Unique VK app identifier. Get it at vk.com/dev -> App Settings</param>
        /// <param name="appSecret">App secret key. Used only with secure section methods and with direct auth.</param>
        /// <param name="apiVersion">API version the library is going to use. Min: 5.63</param>
        /// <param name="requestMethod">GET or POST requests the library should use?</param>
        /// <param name="parseJson">Should the library log received JSONs or focus on performance?</param>
        /// <param name="logger">Logger the library should use. By default is logs info into DEBUG output.</param>
        /// <param name="httpService">
        /// HttpService the library should use. You can inject your own implementation of IHttpService 
        /// into the library if default one does not suite you for some reasons.
        /// </param>
        public Vkontakte(int appId, ILogger logger, IHttpService httpService, string appSecret = "", 
            string apiVersion = "5.101", RequestMethod requestMethod = RequestMethod.Get, 
            ParseJson parseJson = ParseJson.FromString)
        {
            AppId = appId;
            Logger = logger;
            AppSecret = appSecret;
            ApiVersion = apiVersion;
            HttpService = httpService;
            _requestMethod = requestMethod;
            _parseJson = parseJson;
        }
        
        #endregion

        /// <summary>
        /// Http service which library uses to send requests.
        /// </summary>
        internal IHttpService HttpService { get; }
        
        /// <summary>
        /// Logger that library uses to log information.
        /// </summary>
        internal ILogger Logger { get; }

        /// <summary>
        /// Sends GET or POST request and deserializes response from STREAM or from LOGGABLE STRING 
        /// based on settings passed during initialization. Also supplies request with AccessToken, 
        /// Captcha, ApiVersion if these properties are not null. Throws ApiException if error 
        /// has been received from Vkontakte API servers. 
        /// </summary>
        /// <param name="method"></param>
        /// <param name="parameters"></param>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        /// <exception cref="ApiException"></exception>
        public async Task<TResult> RequestAsync<TResult>(string method, Dictionary<string, string> parameters)
        {
            if (!string.IsNullOrEmpty(AccessToken?.Token))
                parameters.Add("access_token", AccessToken.Token);
            parameters.Add("v", ApiVersion);
            
            if (_captchaSid != null && _captchaKey != null)
            {
                parameters.Add("captcha_sid", _captchaSid);
                parameters.Add("captcha_key", _captchaKey);
                _captchaSid = null;
                _captchaKey = null;
            }
            
            var url = new Uri(string.Concat(MethodBase, method));
            var response = await Deserialize<ApiResponse<TResult>>(url, parameters);
            if (response.Error == null) return response.Response;
            
            var error = response.Error;
            Logger.Log($"Received API error. Code: {error.Code}. About: \"{error.ErrorMessage}\"");
            throw new ApiException(error);
        }

        /// <summary>
        /// Sends POST or GET requests and deserializes objects from stream. If 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="parameters"></param>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        internal async Task<TResult> Deserialize<TResult>(Uri url, Dictionary<string, string> parameters)
        {
            using (var stream = await RequestForStream(url, parameters).ConfigureAwait(false))
            using (var streamReader = new StreamReader(stream))
            using (var jsonReader = new JsonTextReader(streamReader))
            {
                var serializer = new JsonSerializer();
                Logger.Log("Response has been successfully received, deserializing...");
                switch (_parseJson)
                {
                    case ParseJson.FromStream:
                        return serializer.Deserialize<TResult>(jsonReader);
                    case ParseJson.FromString:
                        var loggableString = streamReader.ReadToEnd();
                        Logger.Log($"Received: {loggableString}");
                        return JsonConvert.DeserializeObject<TResult>(loggableString);
                    default: throw new ArgumentOutOfRangeException();
                }
            }
        }

        /// <summary>
        /// Send POST or GET requests based on initialization preferences.
        /// </summary>
        private Task<Stream> RequestForStream(Uri url, Dictionary<string, string> parameters)
        {
            switch (_requestMethod)
            {
                case RequestMethod.Get: return HttpService.GetForStreamAsync(url, parameters);
                case RequestMethod.Post: return HttpService.PostForStreamAsync(url, parameters);
                default: throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// Executes given script written in VKSCRIPT language on VK servers.
        /// See docs for more info: https://vk.com/dev/execute
        /// </summary>
        /// <typeparam name="TResult">Type to return</typeparam>
        /// <param name="script">Your code</param>
        /// <returns>Object of a given type, determined by a script.</returns>
        public Task<TResult> Execute<TResult>(string script) => RequestAsync<TResult>("execute", 
            new Dictionary<string, string> { {"code", script} });

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
        public async Task<LongPollClient> StartLongPollClient(string server, string key, int ts, 
            int version = 1, int wait = 25, AnswerFlags mode = AnswerFlags.ReceiveAttachments)
        {
            var client = new LongPollClient(this);
            await client.StartListener(server, key, ts, version, wait, mode);
            return client;
        }

        /// <summary>
        /// If any action is performed too frequently, an API request may return "Captcha needed" error. 
        /// After that a user needs to enter a code from the image and resend a request with a Captcha 
        /// code input in the request parameters. Use SetCaptchaForNextRequest method to set the captcha 
        /// codes for ONLY ONE next request.
        /// </summary>
        /// <param name="captchaSid">Received ID by ApiException</param>
        /// <param name="captchaKey">Text input, answer for captcha</param>
        public void SetCaptchaForNextRequest(string captchaSid, string captchaKey)
        {
            _captchaSid = captchaSid; _captchaKey = captchaKey;
        }
        
        /// <summary>
        /// Application identifier for current library instance.
        /// </summary>
        public int AppId { get; }
        
        /// <summary>
        /// Application secret key used for secure API sections for current library instance.
        /// </summary>
        public string AppSecret { get; }
        
        /// <summary>
        /// API version that current library instance uses.
        /// </summary>
        public string ApiVersion { get; }

        /// <summary>
        /// User access token.
        /// </summary>
        public AccessToken AccessToken { get; set; }

        /// <summary>
        /// Disposes internaly stored HttpService.
        /// </summary>
        public void Dispose() => HttpService?.Dispose();
    }

    /// <summary>
    /// Determines how the library should parse JSONs received from API servers.
    /// </summary>
    public enum ParseJson
    {
        /// <summary>
        /// To minimize memory usage and the number of strings allocated in memory,
        /// Json.NET supports serializing and deserializing directly from a stream.
        /// Use this in production for better performance.
        /// </summary>
        FromStream,
        /// <summary>
        /// Loads JSON into a string, logs it using Logger, and then deserializes. 
        /// Use this for testing purposes only.
        /// </summary>
        FromString
    }

    /// <summary>
    /// Determines which request method should be used when sending queries to Vkontakte API.
    /// GET option is generally a good choice for testing and debugging as GET queries are
    /// easy to read and understand. But when sending LARGE objects to VK API servers 
    /// consider using POST option.
    /// </summary>
    public enum RequestMethod
    {
        /// <summary>
        /// Use GET method when querying VK servers.
        /// </summary>
        Get,
        /// <summary>
        /// Use POST method when querying VK servers.
        /// </summary>
        Post
    }
}