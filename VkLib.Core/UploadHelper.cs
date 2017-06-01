using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using VkLib.Types.Audio;
using VkLib.Types.Docs;
using VkLib.Types.Photos;
using VkLib.Types.Video;

namespace VkLib
{
    /// <summary>
    ///     API methods that help with photos / docs / audios uploading.
    ///     More info: https://vk.com/dev/upload_files
    /// </summary>
    public class UploadHelper
    {
        /// <summary>
        ///     Internal lazy initialization.
        /// </summary>
        internal UploadHelper()
        {
        }

        /// <summary>
        ///     Async POST request.
        /// </summary>
        /// <param name="uri">Request uri</param>
        /// <param name="bytes">Bytes</param>
        /// <param name="type">Type (file/photo/audio/etc.)</param>
        /// <param name="fileName">File's name</param>
        /// <returns>String response</returns>
        public static async Task<T> PostAsync<T>(Uri uri, byte[] bytes, string type, string fileName)
        {
            using (var client = new HttpClient())
            using (var content = new MultipartFormDataContent())
            using (var streamContent = new ByteArrayContent(bytes))
            {
                Vkontakte.Log($"Uploading {type} named \"{fileName}\" to VK.COM server: {uri}");
                streamContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                {
                    FileName = fileName,
                    Name = type
                };
                content.Add(streamContent);
                using (var responseMessage = await client.PostAsync(uri, content))
                using (var responseStream = await responseMessage.Content.ReadAsStreamAsync())
                using (var streamReader = new StreamReader(responseStream, Encoding.UTF8))
                {
                    return JsonConvert.DeserializeObject<T>(streamReader.ReadToEnd());
                }
            }
        }

        /// <summary>
        ///     Async POST request with multiple data entries.
        /// </summary>
        /// <param name="uri">Server uri</param>
        /// <param name="files">Files dict. Key is file name, value is file itself.</param>
        /// <returns>String response</returns>
        public static async Task<T> PostMultipleAsync<T>(Uri uri, Dictionary<string, byte[]> files)
        {
            using (var client = new HttpClient())
            using (var content = new MultipartFormDataContent())
            {
                var counter = 1;
                foreach (var entry in files)
                    using (var streamContent = new ByteArrayContent(entry.Value))
                    {
                        streamContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                        {
                            FileName = entry.Key,
                            Name = $"file{counter}"
                        };
                        content.Add(streamContent);
                        counter++;
                    }

                using (var responseMessage = await client.PostAsync(uri, content))
                using (var responseStream = await responseMessage.Content.ReadAsStreamAsync())
                using (var streamReader = new StreamReader(responseStream, Encoding.UTF8))
                {
                    return JsonConvert.DeserializeObject<T>(streamReader.ReadToEnd());
                }
            }
        }

        /// <summary>
        ///     Upload multiple photos to vk servers.
        /// </summary>
        /// <param name="url">Server url</param>
        /// <param name="files">Files name-bytes pairs</param>
        /// <returns></returns>
        public async Task<PhotoUploadResponse> UploadPhotos(string url, Dictionary<string, byte[]> files) => 
            await PostMultipleAsync<PhotoUploadResponse>(new Uri(url), files);

        /// <summary>
        ///     Uploads a photo to conversation.
        /// </summary>
        /// <param name="url">Server url</param>
        /// <param name="fileName">File name</param>
        /// <param name="bytes">Photo bytes</param>
        /// <returns></returns>
        public async Task<MessageUploadResponse> UploadMessagesPhoto(string url, string fileName, byte[] bytes) => 
            await PostAsync<MessageUploadResponse>(new Uri(url), bytes, "photo", fileName);

        /// <summary>
        ///     Uploads document to vk.
        /// </summary>
        /// <param name="url">Server url</param>
        /// <param name="fileName">File name</param>
        /// <param name="bytes">Doc bytes</param>
        /// <returns></returns>
        public async Task<DocUploadResponse> UploadDocument(string url, string fileName, byte[] bytes) => 
            await PostAsync<DocUploadResponse>(new Uri(url), bytes, "file", fileName);

        /// <summary>
        ///     Uploads video to vk.
        /// </summary>
        /// <param name="url">Server url</param>
        /// <param name="fileName">File name</param>
        /// <param name="bytes">Video bytes</param>
        /// <returns></returns>
        public async Task<UploadResponse> UploadVideo(string url, string fileName, byte[] bytes) => 
            await PostAsync<UploadResponse>(new Uri(url), bytes, "video_file", fileName);

        /// <summary>
        ///     Uploads an MP3 audio to vk.
        /// </summary>
        /// <param name="url">Upload url</param>
        /// <param name="fileName">File name</param>
        /// <param name="bytes">Audio bytes</param>
        /// <returns></returns>
        public async Task<AudioUploadResponse> UploadAudio(string url, string fileName, byte[] bytes) => 
            await PostAsync<AudioUploadResponse>(new Uri(url), bytes, "file", fileName);
    }
}