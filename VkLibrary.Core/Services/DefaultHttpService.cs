using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Services
{
    /// <summary>
    /// Default Vklibrary.Core HTTP service.
    /// </summary>
    public class DefaultHttpService : IHttpService
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private readonly ILogger _logger;

        /// <summary>
        /// Initializes a new instane of default HTTP service.
        /// </summary>
        /// <param name="logger">Logger to log info into.</param>
        public DefaultHttpService(ILogger logger) => _logger = logger;

        /// <summary>
        /// Sends GET request and reads response as a stream.
        /// </summary>
        /// <param name="url">Base url to use.</param>
        /// <param name="parameters">Parameters to append to query url.</param>
        public Task<Stream> GetForStreamAsync(Uri url, Dictionary<string, string> parameters)
        {
            var requestUrl = BuildGetRequestUrl(url.AbsoluteUri, parameters);
            _logger.Log($"Sending GET request to url: {requestUrl.AbsoluteUri}");
            return _httpClient.GetStreamAsync(requestUrl);
        }

        /// <summary>
        /// Sends POST request and reads response as a stream.
        /// </summary>
        /// <param name="url">Base url to use.</param>
        /// <param name="parameters">Parameters to append to query url as encoded content.</param>
        public async Task<Stream> PostForStreamAsync(Uri url, Dictionary<string, string> parameters)
        {
            using (var content = new FormUrlEncodedContent(parameters))
            {
                _logger.Log($"Sending POST request to url: {url.AbsoluteUri}");
                content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
                var httpResponseMessage = await _httpClient.PostAsync(url, content).ConfigureAwait(false);
                return await httpResponseMessage.Content.ReadAsStreamAsync().ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Uploads single file to a web server using POST method.
        /// </summary>
        /// <param name="uri">Request uri</param>
        /// <param name="bytes">Bytes</param>
        /// <param name="type">Type (file/photo/audio/etc.)</param>
        /// <param name="name">File's name</param>
        public async Task<Stream> PostSingleFileAsync(Uri uri, byte[] bytes, string type, string name)
        {
            using (var multipartFormDataContent = new MultipartFormDataContent())
            using (var byteArrayContent = new ByteArrayContent(bytes))
            {
                _logger.Log($"Uploading {type} named \"{name}\" to server: {uri}");
                byteArrayContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                { FileName = name, Name = type };
                multipartFormDataContent.Add(byteArrayContent);
                var response = await _httpClient.PostAsync(uri, multipartFormDataContent).ConfigureAwait(false);
                return await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Async POST request that uploads multiple file entries as byte arrays.
        /// </summary>
        /// <param name="uri">Server uri to upload the document to.</param>
        /// <param name="files">Files dictionary. Key is file name, value is file itself.</param>
        public async Task<Stream> PostMultipleFilesAsync(Uri uri, Dictionary<string, byte[]> files)
        {
            using (var content = new MultipartFormDataContent())
            {
                var counter = 1;
                foreach (var entry in files)
                {
                    var streamContent = new ByteArrayContent(entry.Value);
                    _logger.Log($"Uploading file {counter} named \"{entry.Key}\" to server: {uri}");
                    streamContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                    { FileName = entry.Key, Name = $"file{counter}" };
                    content.Add(streamContent);
                    counter++;
                }
                var responseMessage = await _httpClient.PostAsync(uri, content).ConfigureAwait(false);
                return await responseMessage.Content.ReadAsStreamAsync().ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Creates GET request url.
        /// </summary>
        /// <param name="baseUrl">Base url.</param>
        /// <param name="parameters">Query parameters.</param>
        public Uri BuildGetRequestUrl(string baseUrl, Dictionary<string, string> parameters)
        {
            var stringifiedParameters = string.Join("&", parameters.Select(i =>
                $"{Uri.EscapeDataString(i.Key)}={Uri.EscapeDataString(i.Value)}"));
            var requestUrl = string.Concat($"{baseUrl}?", stringifiedParameters);
            return new Uri(requestUrl);
        }

        /// <summary>
        /// Disposes internally stored HTTP client.
        /// </summary>
        public void Dispose() => _httpClient?.Dispose();
    }
}