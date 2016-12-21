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
    /// </summary>
    public class UploadHelper
    {
        private Vkontakte _vkontakte;

        internal UploadHelper(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        #region Docs Uploader

        /// <summary>
        /// Gets documents upload server.
        /// </summary>
        /// <returns>Upload server's uri.</returns>
        public async Task<string> GetDocsUploadServer(int group_id = 0)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != 0)
                parameters.Add("group_id", group_id.ToString());

            Responses.Docs.GetUploadServerResponse response = 
                await _vkontakte.GetAsync<Responses.Docs.GetUploadServerResponse>(
                    "docs.getUploadServer", parameters);

            return response.UploadUrl;
        }

        /// <summary>
        /// Uploads document to a given server (get it's uri using GetDocsUploadServer)
        /// </summary>
        /// <param name="url">Server's url</param>
        /// <param name="fileName">File name</param>
        /// <param name="photoStream">Photo MultipartFormDataContent</param>
        /// <returns></returns>
        public async Task<string> UploadDocument(string url, string fileName, byte[] bytes)
        {
            using (HttpClient client = new HttpClient())
            using (MultipartFormDataContent content = new MultipartFormDataContent())
            using (ByteArrayContent streamContent = new ByteArrayContent(bytes))
            {
                streamContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                {
                    FileName = fileName,
                    Name = "file"
                };
                content.Add(streamContent);

                using (HttpResponseMessage responseMessage = await client.PostAsync(new Uri(url), content))
                using (Stream responseStream = await responseMessage.Content.ReadAsStreamAsync())
                using (StreamReader streamReader = new StreamReader(responseStream, Encoding.UTF8))
                {
                    VkLib.Types.Docs.DocUploadResponse response =
                        JsonConvert.DeserializeObject<VkLib.Types.Docs.DocUploadResponse>(
                            streamReader.ReadToEnd()
                            );
                    return response.File;
                }
            }
        }

        /// <summary>
        /// Saves uploaded photo. Uses id.
        /// </summary>
        /// <param name="photo"></param>
        /// <param name="server"></param>
        /// <param name="hash"></param>
        /// <returns></returns>
        public async Task<Types.Docs.Doc> SaveDocument(string file, string title, string tags)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("file", file);
            parameters.Add("title", title);
            parameters.Add("tags", tags);

            IEnumerable<Types.Docs.Doc> response = await _vkontakte.GetAsync<IEnumerable<Types.Docs.Doc>>(
                   "docs.save", parameters);

            return response.First();
        }

        #endregion

        #region Messages Photo Uploader

        /// <summary>
        /// Gets messages upload vk server.
        /// </summary>
        /// <returns>Upload server's uri.</returns>
        public async Task<string> GetMessagesUploadServer()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            
            Responses.Photos.GetChatUploadServerResponse response =
               await _vkontakte.GetAsync<Responses.Photos.GetChatUploadServerResponse>(
                   "docs.getUploadServer", parameters);

            return response.UploadUrl;
        }

        /// <summary>
        /// Uploads photo to a given server (get it's uri using GetMessagesUploadServer)
        /// </summary>
        /// <param name="url">Server's url</param>
        /// <param name="fileName">File name</param>
        /// <param name="photoStream">Photo MultipartFormDataContent</param>
        /// <returns></returns>
        public async Task<VkLib.Types.Photos.MessageUploadResponse> UploadMessagesPhotos(string url, string fileName, byte[] bytes)
        {
            using (HttpClient client = new HttpClient())
            using (MultipartFormDataContent content = new MultipartFormDataContent())
            using (ByteArrayContent streamContent = new ByteArrayContent(bytes))
            {
                streamContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                {
                    FileName = fileName,
                    Name = "photo"
                };
                content.Add(streamContent);

                using (HttpResponseMessage responseMessage = await client.PostAsync(new Uri(url), content))
                using (Stream responseStream = await responseMessage.Content.ReadAsStreamAsync())
                using (StreamReader streamReader = new StreamReader(responseStream, Encoding.UTF8))
                {
                    VkLib.Types.Photos.MessageUploadResponse response =
                        JsonConvert.DeserializeObject<VkLib.Types.Photos.MessageUploadResponse>(
                            streamReader.ReadToEnd()
                            );
                    return response;
                }
            }
        }

        /// <summary>
        /// Saves uploaded photo. Uses id.
        /// </summary>
        /// <param name="photo"></param>
        /// <param name="server"></param>
        /// <param name="hash"></param>
        /// <returns></returns>
        public async Task<Types.Photos.Photo> SaveMessagesPhotos(string photo, string server, string hash)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("photo", photo);
            parameters.Add("server", server);
            parameters.Add("hash", hash);

            IEnumerable<Types.Photos.Photo> response = 
                await _vkontakte.GetAsync<IEnumerable<Types.Photos.Photo>>("photos.saveMessagesPhoto", parameters);

            return response.First();
        }

        #endregion
    }
}
