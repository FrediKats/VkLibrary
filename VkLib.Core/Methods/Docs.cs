using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkLib.Methods
{
    /// <summary>
    /// Docs API section.
    /// </summary>
    public class Docs
    {
        private Vkontakte _vkontakte;

        internal Docs(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        /// Returns detailed information about user or community documents.
        /// Docs: <see href="https://vk.com/dev/docs.get">docs.get</see>
        /// </summary>
        /// <param name="count">Number of documents to return. By default, all documents.</param>
        /// <param name="offset">Offset needed to return a specific subset of documents.</param>
        /// <param name="owner_id">ID of the user or community that owns the documents. Use a negative value to designate a community ID.</param>
        public async Task<object> Get(int? count = null, int? offset = null, int? owner_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (count != null)
                parameters.Add("count", count.ToString());
            if (offset != null)
                parameters.Add("offset", offset.ToString());
            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());

            return await _vkontakte.GetAsync<object>("docs.get", parameters);
        }

        /// <summary>
        /// Returns information about documents by their IDs.
        /// Docs: <see href="https://vk.com/dev/docs.getById">docs.getById</see>
        /// </summary>
        /// <param name="docs">Document IDs. Example: ; "66748_91488,66748_91455";</param>
        public async Task<object> GetById(IEnumerable<string> docs = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (docs != null)
                parameters.Add("docs", string.Join(",", docs));

            return await _vkontakte.GetAsync<object>("docs.getById", parameters);
        }

        /// <summary>
        /// Returns the server address for document upload.
        /// Docs: <see href="https://vk.com/dev/docs.getUploadServer">docs.getUploadServer</see>
        /// </summary>
        /// <param name="group_id">Community ID (if the document will be uploaded to the community).</param>
        public async Task<object> GetUploadServer(int? group_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());

            return await _vkontakte.GetAsync<object>("docs.getUploadServer", parameters);
        }

        /// <summary>
        /// Returns the server address for document upload onto a user's or community's wall.
        /// Docs: <see href="https://vk.com/dev/docs.getWallUploadServer">docs.getWallUploadServer</see>
        /// </summary>
        /// <param name="group_id">Community ID (if the document will be uploaded to the community).</param>
        public async Task<object> GetWallUploadServer(int? group_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());

            return await _vkontakte.GetAsync<object>("docs.getWallUploadServer", parameters);
        }

        /// <summary>
        /// Saves a document after [vk.com/dev/upload_files_2|uploading it to a server].
        /// Docs: <see href="https://vk.com/dev/docs.save">docs.save</see>
        /// </summary>
        /// <param name="file">This parameter is returned when the file is [vk.com/dev/upload_files_2|uploaded to the server].</param>
        /// <param name="title">Document title.</param>
        /// <param name="tags">Document tags.</param>
        public async Task<object> Save(string file = null, string title = null, string tags = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (file != null)
                parameters.Add("file", file);
            if (title != null)
                parameters.Add("title", title);
            if (tags != null)
                parameters.Add("tags", tags);

            return await _vkontakte.GetAsync<object>("docs.save", parameters);
        }

        /// <summary>
        /// Deletes a user or community document.
        /// Docs: <see href="https://vk.com/dev/docs.delete">docs.delete</see>
        /// </summary>
        /// <param name="owner_id">ID of the user or community that owns the document. Use a negative value to designate a community ID.</param>
        /// <param name="doc_id">Document ID.</param>
        public async Task<object> Delete(int? owner_id = null, int? doc_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (doc_id != null)
                parameters.Add("doc_id", doc_id.ToString());

            return await _vkontakte.GetAsync<object>("docs.delete", parameters);
        }

        /// <summary>
        /// Copies a document to a user's or community's document list.
        /// Docs: <see href="https://vk.com/dev/docs.add">docs.add</see>
        /// </summary>
        /// <param name="owner_id">ID of the user or community that owns the document. Use a negative value to designate a community ID.</param>
        /// <param name="doc_id">Document ID.</param>
        /// <param name="access_key">Access key. This parameter is required if 'access_key' was returned with the document's data.</param>
        public async Task<object> Add(int? owner_id = null, int? doc_id = null, string access_key = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (doc_id != null)
                parameters.Add("doc_id", doc_id.ToString());
            if (access_key != null)
                parameters.Add("access_key", access_key);

            return await _vkontakte.GetAsync<object>("docs.add", parameters);
        }

        /// <summary>
        /// Returns documents types available for current user.
        /// Docs: <see href="https://vk.com/dev/docs.getTypes">docs.getTypes</see>
        /// </summary>
        /// <param name="owner_id">ID of the user or community that owns the documents. Use a negative value to designate a community ID.</param>
        public async Task<object> GetTypes(int? owner_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());

            return await _vkontakte.GetAsync<object>("docs.getTypes", parameters);
        }

        /// <summary>
        /// Returns a list of documents matching the search criteria.
        /// Docs: <see href="https://vk.com/dev/docs.search">docs.search</see>
        /// </summary>
        /// <param name="q">Search query string.</param>
        /// <param name="count">Number of results to return.</param>
        /// <param name="offset">Offset needed to return a specific subset of results.</param>
        public async Task<object> Search(string q = null, int? count = null, int? offset = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (q != null)
                parameters.Add("q", q);
            if (count != null)
                parameters.Add("count", count.ToString());
            if (offset != null)
                parameters.Add("offset", offset.ToString());

            return await _vkontakte.GetAsync<object>("docs.search", parameters);
        }

        /// <summary>
        /// Edits a document.
        /// Docs: <see href="https://vk.com/dev/docs.edit">docs.edit</see>
        /// </summary>
        /// <param name="owner_id">User ID or community ID. Use a negative value to designate a community ID.</param>
        /// <param name="doc_id">Document ID.</param>
        /// <param name="title">Document title.</param>
        /// <param name="tags">Document tags.</param>
        public async Task<object> Edit(int? owner_id = null, int? doc_id = null, string title = null, IEnumerable<string> tags = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (doc_id != null)
                parameters.Add("doc_id", doc_id.ToString());
            if (title != null)
                parameters.Add("title", title);
            if (tags != null)
                parameters.Add("tags", string.Join(",", tags));

            return await _vkontakte.GetAsync<object>("docs.edit", parameters);
        }

    }
}
