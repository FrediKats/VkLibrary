using System.Collections.Generic;
using System.Threading.Tasks;
using VkLibrary.Core.Responses.Docs;
using VkLibrary.Core.Types.Docs;

namespace VkLibrary.Core.Methods
{
    /// <summary>
    /// Docs API section.
    /// </summary>
    public class Docs
    {
        private readonly Vkontakte _vkontakte;
        internal Docs(Vkontakte vkontakte) => _vkontakte = vkontakte;

        /// <summary>
        /// Returns detailed information about user or community documents.
        /// Docs: <see href="https://vk.com/dev/docs.get">docs.get</see>
        /// </summary>
        /// <param name="count">Number of documents to return. By default, all documents.</param>
        /// <param name="offset">Offset needed to return a specific subset of documents.</param>
        /// <param name="ownerId">
        /// ID of the user or community that owns the documents. Use a negative value to designate a
        /// community ID.
        /// </param>
        public Task<ApiItemsResponse<Doc>> Get(int? count = null, int? offset = null, int? ownerId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());

            return _vkontakte.GetAsync<ApiItemsResponse<Doc>>("docs.get", parameters);
        }

        /// <summary>
        /// Returns information about documents by their IDs.
        /// Docs: <see href="https://vk.com/dev/docs.getById">docs.getById</see>
        /// </summary>
        /// <param name="docs">Document IDs. Example: ; "66748_91488,66748_91455";</param>
        public Task<IEnumerable<Doc>> GetById(IEnumerable<string> docs = null)
        {
            var parameters = new Dictionary<string, string>();

            if (docs != null)
                parameters.Add("docs", docs.ToApiString());

            return _vkontakte.GetAsync<IEnumerable<Doc>>("docs.getById", parameters);
        }

        /// <summary>
        /// Returns the server address for document upload.
        /// Docs: <see href="https://vk.com/dev/docs.getUploadServer">docs.getUploadServer</see>
        /// </summary>
        /// <param name="groupId">Community ID (if the document will be uploaded to the community).</param>
        public Task<GetUploadServerResponse> GetUploadServer(int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());

            return _vkontakte.GetAsync<GetUploadServerResponse>("docs.getUploadServer", parameters);
        }

        /// <summary>
        /// Returns the server address for document upload onto a user's or community's wall.
        /// Docs: <see href="https://vk.com/dev/docs.getWallUploadServer">docs.getWallUploadServer</see>
        /// </summary>
        /// <param name="groupId">Community ID (if the document will be uploaded to the community).</param>
        public Task<GetWallUploadServerResponse> GetWallUploadServer(int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());

            return _vkontakte.GetAsync<GetWallUploadServerResponse>("docs.getWallUploadServer", parameters);
        }

        /// <summary>
        /// Saves a document after uploading it to a server.
        /// Docs: <see href="https://vk.com/dev/docs.save">docs.save</see>
        /// </summary>
        /// <param name="file">This parameter is returned when the file is uploaded to the server.</param>
        /// <param name="title">Document title.</param>
        /// <param name="tags">Document tags.</param>
        public Task<IEnumerable<Doc>> Save(string file = null, string title = null, string tags = null)
        {
            var parameters = new Dictionary<string, string>();

            if (file != null)
                parameters.Add("file", file);
            if (title != null)
                parameters.Add("title", title);
            if (tags != null)
                parameters.Add("tags", tags);

            return _vkontakte.GetAsync<IEnumerable<Doc>>("docs.save", parameters);
        }

        /// <summary>
        /// Deletes a user or community document.
        /// Docs: <see href="https://vk.com/dev/docs.delete">docs.delete</see>
        /// </summary>
        /// <param name="ownerId">
        /// ID of the user or community that owns the document. Use a negative value to designate a
        /// community ID.
        /// </param>
        /// <param name="docId">Document ID.</param>
        public Task<int> Delete(int? ownerId = null, int? docId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (docId != null)
                parameters.Add("doc_id", docId.ToApiString());

            return _vkontakte.GetAsync<int>("docs.delete", parameters);
        }

        /// <summary>
        /// Copies a document to a user's or community's document list.
        /// Docs: <see href="https://vk.com/dev/docs.add">docs.add</see>
        /// </summary>
        /// <param name="ownerId">
        /// ID of the user or community that owns the document. Use a negative value to designate a
        /// community ID.
        /// </param>
        /// <param name="docId">Document ID.</param>
        /// <param name="accessKey">Access key. This parameter is required if 'access_key' was returned with the document's data.</param>
        public Task<AddResponse> Add(int? ownerId = null, int? docId = null, string accessKey = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (docId != null)
                parameters.Add("doc_id", docId.ToApiString());
            if (accessKey != null)
                parameters.Add("access_key", accessKey);

            return _vkontakte.GetAsync<AddResponse>("docs.add", parameters);
        }

        /// <summary>
        /// Returns documents types available for current user.
        /// Docs: <see href="https://vk.com/dev/docs.getTypes">docs.getTypes</see>
        /// </summary>
        /// <param name="ownerId">
        /// ID of the user or community that owns the documents. Use a negative value to designate a
        /// community ID.
        /// </param>
        public Task<ApiItemsResponse<DocTypes>> GetTypes(int? ownerId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());

            return _vkontakte.GetAsync<ApiItemsResponse<DocTypes>>("docs.getTypes", parameters);
        }

        /// <summary>
        /// Returns a list of documents matching the search criteria.
        /// Docs: <see href="https://vk.com/dev/docs.search">docs.search</see>
        /// </summary>
        /// <param name="q">Search query string.</param>
        /// <param name="count">Number of results to return.</param>
        /// <param name="offset">Offset needed to return a specific subset of results.</param>
        public Task<ApiItemsResponse<Doc>> Search(string q = null, int? count = null, int? offset = null)
        {
            var parameters = new Dictionary<string, string>();

            if (q != null)
                parameters.Add("q", q);
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());

            return _vkontakte.GetAsync<ApiItemsResponse<Doc>>("docs.search", parameters);
        }

        /// <summary>
        /// Edits a document.
        /// Docs: <see href="https://vk.com/dev/docs.edit">docs.edit</see>
        /// </summary>
        /// <param name="ownerId">User ID or community ID. Use a negative value to designate a community ID.</param>
        /// <param name="docId">Document ID.</param>
        /// <param name="title">Document title.</param>
        /// <param name="tags">Document tags.</param>
        public Task<int> Edit(int? ownerId = null, int? docId = null, string title = null,
            IEnumerable<string> tags = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (docId != null)
                parameters.Add("doc_id", docId.ToApiString());
            if (title != null)
                parameters.Add("title", title);
            if (tags != null)
                parameters.Add("tags", tags.ToApiString());

            return _vkontakte.GetAsync<int>("docs.edit", parameters);
        }
    }
}