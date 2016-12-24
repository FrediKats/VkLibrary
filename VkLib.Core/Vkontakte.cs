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

namespace VkLib
{
    public class Vkontakte
    {
        private readonly string _clientSecret;
        private readonly string _appId;
        private readonly string _apiVersion;

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
        public Vkontakte(string appId, string clientSecret = null, string apiVersion = "5.60")
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
            string urlString = GetUrl(
                string.Concat(MethodBase, method, "?"), 
                parameters
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
            return await GetAsync<T>("execute", new Dictionary<string, string>() 
            {
                { "code", script }
            });
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
        public static DateTime UnixTimeToDateTime(double unixTimeStamp)
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
        /// API files upload helper. Contains upload methods.
        /// </summary>
        public UploadHelper UploadHelper
        {
            get { return new UploadHelper(this); }
        }

        /// <summary>
        /// OAuth helpers API section.
        /// </summary>
        public OAuth OAuth
        {
            get { return new OAuth(this); }
        }

        /// <summary>
        /// Account API section.
        /// </summary>
        public Account Account
        {
            get { return new Account(this); }
        }

        /// <summary>
        /// Ads API section.
        /// </summary>
        public Ads Ads
        {
            get { return new Ads(this); }
        }

        /// <summary>
        /// Apps API section.
        /// </summary>
        public Apps Apps
        {
            get { return new Apps(this); }
        }

        /// <summary>
        /// Audio API section.
        /// </summary>
        public Audio Audio
        {
            get { return new Audio(this); }
        }

        /// <summary>
        /// Auth API section.
        /// </summary>
        public OAuth Auth
        {
            get { return new OAuth(this); }
        }

        /// <summary>
        /// Board API section.
        /// </summary>
        public Board Board
        {
            get { return new Board(this); }
        }

        /// <summary>
        /// Database API section.
        /// </summary>
        public Database Database
        {
            get { return new Database(this); }
        }

        /// <summary>
        /// Docs API section.
        /// </summary>
        public Docs Docs
        {
            get { return new Docs(this); }
        }

        /// <summary>
        /// Fave API section.
        /// </summary>
        public Fave Fave
        {
            get { return new Fave(this); }
        }


        /// <summary>
        /// Friends API section.
        /// </summary>
        public Friends Friends
        {
            get { return new Friends(this); }
        }


        /// <summary>
        /// Gifts API section.
        /// </summary>
        public Gifts Gifts
        {
            get { return new Gifts(this); }
        }


        /// <summary>
        /// Groups API section.
        /// </summary>
        public Groups Groups
        {
            get { return new Groups(this); }
        }


        /// <summary>
        /// Leads API section.
        /// </summary>
        public Leads Leads
        {
            get { return new Leads(this); }
        }


        /// <summary>
        /// Likes API section.
        /// </summary>
        public Likes Likes
        {
            get { return new Likes(this); }
        }


        /// <summary>
        /// Market API section.
        /// </summary>
        public Market Market
        {
            get { return new Market(this); }
        }


        /// <summary>
        /// Messages API section.
        /// </summary>
        public Messages Messages
        {
            get { return new Messages(this); }
        }


        /// <summary>
        /// Newsfeed API section.
        /// </summary>
        public Newsfeed Newsfeed
        {
            get { return new Newsfeed(this); }
        }


        /// <summary>
        /// Notes API section.
        /// </summary>
        public Notes Notes
        {
            get { return new Notes(this); }
        }


        /// <summary>
        /// Notifications API section.
        /// </summary>
        public Notifications Notifications
        {
            get { return new Notifications(this); }
        }


        /// <summary>
        /// Orders API section.
        /// </summary>
        public Orders Orders
        {
            get { return new Orders(this); }
        }


        /// <summary>
        /// Pages API section.
        /// </summary>
        public Pages Pages
        {
            get { return new Pages(this); }
        }


        /// <summary>
        /// Photos API section.
        /// </summary>
        public Photos Photos
        {
            get { return new Photos(this); }
        }


        /// <summary>
        /// Places API section.
        /// </summary>
        public Places Places
        {
            get { return new Places(this); }
        }


        /// <summary>
        /// Polls API section.
        /// </summary>
        public Polls Polls
        {
            get { return new Polls(this); }
        }


        /// <summary>
        /// Search API section.
        /// </summary>
        public Search Search
        {
            get { return new Search(this); }
        }


        /// <summary>
        /// Secure API section.
        /// </summary>
        public Secure Secure
        {
            get { return new Secure(this); }
        }


        /// <summary>
        /// Stats API section.
        /// </summary>
        public Stats Stats
        {
            get { return new Stats(this); }
        }


        /// <summary>
        /// Status API section.
        /// </summary>
        public Status Status
        {
            get { return new Status(this); }
        }


        /// <summary>
        /// Storage API section.
        /// </summary>
        public Storage Storage
        {
            get { return new Storage(this); }
        }


        /// <summary>
        /// Users API section.
        /// </summary>
        public Users Users
        {
            get { return new Users(this); }
        }


        /// <summary>
        /// Utils API section.
        /// </summary>
        public Utils Utils
        {
            get { return new Utils(this); }
        }


        /// <summary>
        /// Video API section.
        /// </summary>
        public Video Video
        {
            get { return new Video(this); }
        }


        /// <summary>
        /// Wall API section.
        /// </summary>
        public Wall Wall
        {
            get { return new Wall(this); }
        }


        /// <summary>
        /// Widgets API section.
        /// </summary>
        public Widgets Widgets
        {
            get { return new Widgets(this); }
        }

    }
}
