using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace VkApi.Wrapper
{
    /// <summary>
    /// API methods that help with photos / docs / audios uploading.
    /// More info: https://vk.com/dev/upload_files
    /// </summary>
    public class UploadHelper
    {
        private readonly Vkontakte _library;
        
        internal UploadHelper(Vkontakte library) => _library = library;

        /// <summary>
        /// Async POST request.
        /// </summary>
        /// <param name="uri">Request uri</param>
        /// <param name="bytes">Bytes</param>
        /// <param name="type">Type (file/photo/audio/etc.)</param>
        /// <param name="fileName">File's name</param>
        /// <returns>String response</returns>
        public async Task<T> PostAsync<T>(Uri uri, byte[] bytes, string type, string fileName)
        {
            using (var responseStream = await _library.HttpService.PostSingleFileAsync(uri, bytes, type, fileName))
            using (var streamReader = new StreamReader(responseStream, Encoding.UTF8))
            {
                var response = streamReader.ReadToEnd();
                _library.Logger.Log($"Upload response: {response}");
                return JsonConvert.DeserializeObject<T>(response);
            }
        }

        /// <summary>
        /// Async POST request with multiple data entries.
        /// </summary>
        /// <param name="uri">Server uri</param>
        /// <param name="files">Files dict. Key is file name, value is file itself.</param>
        /// <returns>String response</returns>
        public async Task<T> PostMultipleAsync<T>(Uri uri, Dictionary<string, byte[]> files)
        {
            using (var responseStream = await _library.HttpService.PostMultipleFilesAsync(uri, files))
            using (var streamReader = new StreamReader(responseStream, Encoding.UTF8))
            {
                var response = streamReader.ReadToEnd();
                _library.Logger.Log($"Upload response: {response}");
                return JsonConvert.DeserializeObject<T>(response);
            }
        }

        //TODO: Research
        ///// <summary>
        ///// Upload multiple photos to vk servers.
        ///// </summary>
        ///// <param name="url">Server url</param>
        ///// <param name="files">Files name-bytes pairs</param>
        //public Task<PhotoUploadResponse> UploadPhotos(string url, Dictionary<string, byte[]> files) =>
        //    PostMultipleAsync<PhotoUploadResponse>(new Uri(url), files);

        ///// <summary>
        ///// Uploads a photo to conversation.
        ///// </summary>
        ///// <param name="url">Server url</param>
        ///// <param name="fileName">File name</param>
        ///// <param name="bytes">Photo bytes</param>
        //public Task<MessageUploadResponse> UploadMessagesPhoto(string url, string fileName, byte[] bytes) =>
        //    PostAsync<MessageUploadResponse>(new Uri(url), bytes, "photo", fileName);

        ///// <summary>
        ///// Uploads document to vk.
        ///// </summary>
        ///// <param name="url">Server url</param>
        ///// <param name="fileName">File name</param>
        ///// <param name="bytes">Doc bytes</param>
        //public Task<DocUploadResponse> UploadDocument(string url, string fileName, byte[] bytes) =>
        //    PostAsync<DocUploadResponse>(new Uri(url), bytes, "file", fileName);

        ///// <summary>
        ///// Uploads video to vk.
        ///// </summary>
        ///// <param name="url">Server url</param>
        ///// <param name="fileName">File name</param>
        ///// <param name="bytes">Video bytes</param>
        //public Task<UploadResponse> UploadVideo(string url, string fileName, byte[] bytes) =>
        //    PostAsync<UploadResponse>(new Uri(url), bytes, "video_file", fileName);

        ///// <summary>
        ///// Uploads an MP3 audio to vk.
        ///// </summary>
        ///// <param name="url">Upload url</param>
        ///// <param name="fileName">File name</param>
        ///// <param name="bytes">Audio bytes</param>
        //public Task<AudioUploadResponse> UploadAudio(string url, string fileName, byte[] bytes) =>
        //    PostAsync<AudioUploadResponse>(new Uri(url), bytes, "file", fileName);
    }
}