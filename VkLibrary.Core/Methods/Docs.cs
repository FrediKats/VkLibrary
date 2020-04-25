using VkApi.Wrapper.Objects;
using VkApi.Wrapper.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Methods
{
    public class Docs
    {
        private readonly Vkontakte _vkontakte;

        internal Docs(Vkontakte vkontakte) => _vkontakte = vkontakte;

        ///<summary>
        /// Copies a document to a user's or community's document list.
        ///</summary>
        public Task<DocsAddResponse> Add(int? ownerId = null, int? docId = null, String accessKey = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (docId != null)
                parameters.Add("doc_id", docId.ToApiString());
            if (accessKey != null)
                parameters.Add("access_key", accessKey.ToApiString());
            return _vkontakte.RequestAsync<DocsAddResponse>("docs.add", parameters);
        }

        ///<summary>
        /// Deletes a user or community document.
        ///</summary>
        public Task<BaseOkResponse> Delete(int? ownerId = null, int? docId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (docId != null)
                parameters.Add("doc_id", docId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("docs.delete", parameters);
        }

        ///<summary>
        /// Edits a document.
        ///</summary>
        public Task<BaseOkResponse> Edit(int? ownerId = null, int? docId = null, String title = null, String[] tags = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (docId != null)
                parameters.Add("doc_id", docId.ToApiString());
            if (title != null)
                parameters.Add("title", title.ToApiString());
            if (tags != null)
                parameters.Add("tags", tags.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("docs.edit", parameters);
        }

        ///<summary>
        /// Returns detailed information about user or community documents.
        ///</summary>
        public Task<DocsGetResponse> Get(int? count = null, int? offset = null, int? type = null, int? ownerId = null, Boolean? returnTags = null)
        {
            var parameters = new Dictionary<string, string>();
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (type != null)
                parameters.Add("type", type.ToApiString());
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (returnTags != null)
                parameters.Add("return_tags", returnTags.ToApiString());
            return _vkontakte.RequestAsync<DocsGetResponse>("docs.get", parameters);
        }

        ///<summary>
        /// Returns information about documents by their IDs.
        ///</summary>
        public Task<DocsDoc[]> GetById(String[] docs = null, Boolean? returnTags = null)
        {
            var parameters = new Dictionary<string, string>();
            if (docs != null)
                parameters.Add("docs", docs.ToApiString());
            if (returnTags != null)
                parameters.Add("return_tags", returnTags.ToApiString());
            return _vkontakte.RequestAsync<DocsDoc[]>("docs.getById", parameters);
        }

        ///<summary>
        /// Returns the server address for document upload.
        ///</summary>
        public Task<BaseUploadServer> GetMessagesUploadServer(String type = null, int? peerId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (type != null)
                parameters.Add("type", type.ToApiString());
            if (peerId != null)
                parameters.Add("peer_id", peerId.ToApiString());
            return _vkontakte.RequestAsync<BaseUploadServer>("docs.getMessagesUploadServer", parameters);
        }

        ///<summary>
        /// Returns documents types available for current user.
        ///</summary>
        public Task<DocsGetTypesResponse> GetTypes(int? ownerId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            return _vkontakte.RequestAsync<DocsGetTypesResponse>("docs.getTypes", parameters);
        }

        ///<summary>
        /// Returns the server address for document upload.
        ///</summary>
        public Task<BaseUploadServer> GetUploadServer(int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            return _vkontakte.RequestAsync<BaseUploadServer>("docs.getUploadServer", parameters);
        }

        ///<summary>
        /// Returns the server address for document upload onto a user's or community's wall.
        ///</summary>
        public Task<BaseUploadServer> GetWallUploadServer(int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            return _vkontakte.RequestAsync<BaseUploadServer>("docs.getWallUploadServer", parameters);
        }

        ///<summary>
        /// Saves a document after [vk.com/dev/upload_files_2|uploading it to a server].
        ///</summary>
        public Task<DocsSaveResponse> Save(String file = null, String title = null, String tags = null, Boolean? returnTags = null)
        {
            var parameters = new Dictionary<string, string>();
            if (file != null)
                parameters.Add("file", file.ToApiString());
            if (title != null)
                parameters.Add("title", title.ToApiString());
            if (tags != null)
                parameters.Add("tags", tags.ToApiString());
            if (returnTags != null)
                parameters.Add("return_tags", returnTags.ToApiString());
            return _vkontakte.RequestAsync<DocsSaveResponse>("docs.save", parameters);
        }

        ///<summary>
        /// Returns a list of documents matching the search criteria.
        ///</summary>
        public Task<DocsSearchResponse> Search(String q = null, Boolean? searchOwn = null, int? count = null, int? offset = null, Boolean? returnTags = null)
        {
            var parameters = new Dictionary<string, string>();
            if (q != null)
                parameters.Add("q", q.ToApiString());
            if (searchOwn != null)
                parameters.Add("search_own", searchOwn.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (returnTags != null)
                parameters.Add("return_tags", returnTags.ToApiString());
            return _vkontakte.RequestAsync<DocsSearchResponse>("docs.search", parameters);
        }
    }
}