using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace VkLibrary.Core.Services
{
    /// <summary>
    /// Abstract HTTP service that can be used in VkLibrary.Core.
    /// </summary>
    public interface IHttpService : IDisposable
    {
        /// <summary>
        /// Sends GET request and reads response as a stream.
        /// </summary>
        /// <param name="url">Base url to use.</param>
        /// <param name="parameters">Parameters to append to query url.</param>
        Task<Stream> GetForStreamAsync(Uri url, Dictionary<string, string> parameters);

        /// <summary>
        /// Sends POST request and reads response as a stream.
        /// </summary>
        /// <param name="url">Base url to use.</param>
        /// <param name="parameters">Parameters to append to query url as encoded content.</param>
        Task<Stream> PostForStreamAsync(Uri url, Dictionary<string, string> parameters);

        /// <summary>
        /// Uploads single file to a web server using POST method.
        /// </summary>
        /// <param name="url">Request uri</param>
        /// <param name="bytes">Bytes</param>
        /// <param name="type">Type (file/photo/audio/etc.)</param>
        /// <param name="name">File's name</param>
        Task<Stream> PostSingleFileAsync(Uri url, byte[] bytes, string type, string name);
        
        /// <summary>
        /// Async POST request that uploads multiple file entries as byte arrays.
        /// </summary>
        /// <param name="url">Server uri to upload the document to.</param>
        /// <param name="files">Files dictionary. Key is file name, value is file itself.</param>
        Task<Stream> PostMultipleFilesAsync(Uri url, Dictionary<string, byte[]> files);

        /// <summary>
        /// Creates GET request url.
        /// </summary>
        /// <param name="baseUrl">Base url.</param>
        /// <param name="parameters">Query parameters.</param>
        Uri BuildGetRequestUrl(string baseUrl, Dictionary<string, string> parameters);
    }
}