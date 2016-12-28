using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace VkLib
{
    /// <summary>
    /// API methods that help with photos / docs / audios uploading.
    /// More info: https://vk.com/dev/upload_files
    /// </summary>
    public class UploadHelper
    {
        private Vkontakte _vkontakte;

        internal UploadHelper(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

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
            using (HttpClient client = new HttpClient())
            using (MultipartFormDataContent content = new MultipartFormDataContent())
            using (ByteArrayContent streamContent = new ByteArrayContent(bytes))
            {
                streamContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                {
                    FileName = fileName,
                    Name = type
                };
                content.Add(streamContent);
                using (HttpResponseMessage responseMessage = await client.PostAsync(uri, content))
                using (Stream responseStream = await responseMessage.Content.ReadAsStreamAsync())
                using (StreamReader streamReader = new StreamReader(responseStream, Encoding.UTF8))
                {
                    return JsonConvert.DeserializeObject<T>(streamReader.ReadToEnd());
                }
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
            using (HttpClient client = new HttpClient())
            using (MultipartFormDataContent content = new MultipartFormDataContent())
            {
                int counter = 1;
                foreach (KeyValuePair<string, byte[]> entry in files)
                {
                    using (ByteArrayContent streamContent = new ByteArrayContent(entry.Value))
                    {
                        streamContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                        {
                            FileName = entry.Key,
                            Name = $"file{counter}"
                        };
                        content.Add(streamContent);
                        counter++;
                    }
                }
                
                using (HttpResponseMessage responseMessage = await client.PostAsync(uri, content))
                using (Stream responseStream = await responseMessage.Content.ReadAsStreamAsync())
                using (StreamReader streamReader = new StreamReader(responseStream, Encoding.UTF8))
                {
                    return JsonConvert.DeserializeObject<T>(streamReader.ReadToEnd());
                }
            }
        }

        /// <summary>
        /// Upload multiple photos to vk servers.
        /// </summary>
        /// <param name="url">Server url</param>
        /// <param name="files">Files name-bytes pairs</param>
        /// <returns></returns>
        public async Task<Types.Photos.PhotoUploadResponse> UploadPhotos(string url, Dictionary<string, byte[]> files)
        {
            return await PostMultipleAsync<Types.Photos.PhotoUploadResponse>(new Uri(url), files);    
        }

        /// <summary>
        /// Uploads a photo to conversation.
        /// </summary>
        /// <param name="url">Server url</param>
        /// <param name="fileName">File name</param>
        /// <param name="bytes">Photo bytes</param>
        /// <returns></returns>
        public async Task<Types.Photos.MessageUploadResponse> UploadMessagesPhoto(string url, string fileName, byte[] bytes)
        {
            return await PostAsync<Types.Photos.MessageUploadResponse>(new Uri(url), bytes, "photo", fileName);
        }

        /// <summary>
        /// Uploads document to vk.
        /// </summary>
        /// <param name="url">Server url</param>
        /// <param name="fileName">File name</param>
        /// <param name="bytes">Doc bytes</param>
        /// <returns></returns>
        public async Task<Types.Docs.DocUploadResponse> UploadDocument(string url, string fileName, byte[] bytes)
        {
            return await PostAsync<Types.Docs.DocUploadResponse>(new Uri(url), bytes, "file", fileName);
        }

        /// <summary>
        /// Uploads video to vk.
        /// </summary>
        /// <param name="url">Server url</param>
        /// <param name="fileName">File name</param>
        /// <param name="bytes">Video bytes</param>
        /// <returns></returns>
        public async Task<Types.Video.UploadResponse> UploadVideo(string url, string fileName, byte[] bytes)
        {
            return await PostAsync<Types.Video.UploadResponse>(new Uri(url), bytes, "video_file", fileName);
        }

        /// <summary>
        /// Uploads an MP3 audio to vk.
        /// </summary>
        /// <param name="url">Upload url</param>
        /// <param name="fileName">File name</param>
        /// <param name="bytes">Audio bytes</param>
        /// <returns></returns>
        public async Task<Types.Audio.AudioUploadResponse> UploadAudio(string url, string fileName, byte[] bytes)
        {
            return await PostAsync<Types.Audio.AudioUploadResponse>(new Uri(url), bytes, "file", fileName);
        }


    }
}
