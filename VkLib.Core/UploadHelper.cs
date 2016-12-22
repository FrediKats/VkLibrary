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
        private async Task<string> PostAsync(Uri uri, byte[] bytes, string type, string fileName)
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
                    return streamReader.ReadToEnd();
                }
            }
        }

        /// <summary>
        /// Async POST request with multiple data entries.
        /// </summary>
        /// <param name="uri">Server uri</param>
        /// <param name="files">Files dict. Key is file name, value is file itself.</param>
        /// <returns>String response</returns>
        private async Task<string> PostMultipleAsync(Uri uri, Dictionary<string, byte[]> files)
        {
            if (files.Count > 5) throw new Exception("Too many files to upload.");

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
                    return streamReader.ReadToEnd();
                }
            }
        }

        #region 1. Album photos uploader

        public async Task<string> GetPhotosUploadServer(int group_id = 0)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != 0)
                parameters.Add("group_id", group_id.ToString());

            Responses.Photos.GetChatUploadServerResponse response =
               await _vkontakte.GetAsync<Responses.Photos.GetChatUploadServerResponse>(
                   "photos.getUploadServer", parameters);

            return response.UploadUrl;
        }

        public async Task<VkLib.Types.Photos.PhotoUploadResponse> UploadPhotos(string url, Dictionary<string, byte[]> files)
        {
            VkLib.Types.Photos.PhotoUploadResponse response =
                JsonConvert.DeserializeObject<VkLib.Types.Photos.PhotoUploadResponse>(
                    await PostMultipleAsync(new Uri(url), files)
                    );

            return response;
        }

        public async Task<Types.Photos.Photo> SavePhotos(string photos_list, string server, string album_id, string hash)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("server", server);
            parameters.Add("photos_list", photos_list);
            parameters.Add("aid", album_id);
            parameters.Add("hash", hash);

            IEnumerable<Types.Photos.Photo> response =
                await _vkontakte.GetAsync<IEnumerable<Types.Photos.Photo>>("photos.save", parameters);

            return response.First();
        }

        #endregion

        #region 4. Messages Photo Uploader

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
            VkLib.Types.Photos.MessageUploadResponse response =
                JsonConvert.DeserializeObject<VkLib.Types.Photos.MessageUploadResponse>(
                    await PostAsync(new Uri(url), bytes, "photo", fileName)
                    );

            return response;
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

        #region 10. Docs Uploader

        /// <summary>
        /// Gets documents upload server.
        /// </summary>
        /// <returns>Upload server's uri.</returns>
        public async Task<string> GetDocsUploadServer(int group_id = 0)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            if (group_id != 0) parameters.Add("group_id", group_id.ToString());

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
            VkLib.Types.Docs.DocUploadResponse response =
                JsonConvert.DeserializeObject<VkLib.Types.Docs.DocUploadResponse>(
                    await PostAsync(new Uri(url), bytes, "doc", fileName)
                    );

            return response.File;
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

            IEnumerable<Types.Docs.Doc> response = 
                await _vkontakte.GetAsync<IEnumerable<Types.Docs.Doc>>(
                   "docs.save", parameters);

            return response.First();
        }

        #endregion

        // TODO: Implement left uploading methods

    }
}
