using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VkApi.Wrapper.Responses.Notes;
using VkApi.Wrapper.Types.Base;
using VkApi.Wrapper.Types.Notes;

namespace VkApi.Wrapper.Methods
{
    public class Notes
    {
        private readonly Vkontakte _vkontakte;

        internal Notes(Vkontakte vkontakte) => _vkontakte = vkontakte;

        ///<summary>
        /// Creates a new note for the current user.
        ///</summary>
        public Task<int> Add(String title = null, String text = null, String[] privacyView = null, String[] privacyComment = null)
        {
            var parameters = new Dictionary<string, string>();
            if (title != null)
                parameters.Add("title", title.ToApiString());
            if (text != null)
                parameters.Add("text", text.ToApiString());
            if (privacyView != null)
                parameters.Add("privacy_view", privacyView.ToApiString());
            if (privacyComment != null)
                parameters.Add("privacy_comment", privacyComment.ToApiString());
            return _vkontakte.RequestAsync<int>("notes.add", parameters);
        }

        ///<summary>
        /// Adds a new comment on a note.
        ///</summary>
        public Task<int> CreateComment(int? noteId = null, int? ownerId = null, int? replyTo = null, String message = null, String guid = null)
        {
            var parameters = new Dictionary<string, string>();
            if (noteId != null)
                parameters.Add("note_id", noteId.ToApiString());
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (replyTo != null)
                parameters.Add("reply_to", replyTo.ToApiString());
            if (message != null)
                parameters.Add("message", message.ToApiString());
            if (guid != null)
                parameters.Add("guid", guid.ToApiString());
            return _vkontakte.RequestAsync<int>("notes.createComment", parameters);
        }

        ///<summary>
        /// Deletes a note of the current user.
        ///</summary>
        public Task<BaseOkResponse> Delete(int? noteId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (noteId != null)
                parameters.Add("note_id", noteId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("notes.delete", parameters);
        }

        ///<summary>
        /// Deletes a comment on a note.
        ///</summary>
        public Task<BaseOkResponse> DeleteComment(int? commentId = null, int? ownerId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (commentId != null)
                parameters.Add("comment_id", commentId.ToApiString());
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("notes.deleteComment", parameters);
        }

        ///<summary>
        /// Edits a note of the current user.
        ///</summary>
        public Task<BaseOkResponse> Edit(int? noteId = null, String title = null, String text = null, String[] privacyView = null, String[] privacyComment = null)
        {
            var parameters = new Dictionary<string, string>();
            if (noteId != null)
                parameters.Add("note_id", noteId.ToApiString());
            if (title != null)
                parameters.Add("title", title.ToApiString());
            if (text != null)
                parameters.Add("text", text.ToApiString());
            if (privacyView != null)
                parameters.Add("privacy_view", privacyView.ToApiString());
            if (privacyComment != null)
                parameters.Add("privacy_comment", privacyComment.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("notes.edit", parameters);
        }

        ///<summary>
        /// Edits a comment on a note.
        ///</summary>
        public Task<BaseOkResponse> EditComment(int? commentId = null, int? ownerId = null, String message = null)
        {
            var parameters = new Dictionary<string, string>();
            if (commentId != null)
                parameters.Add("comment_id", commentId.ToApiString());
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (message != null)
                parameters.Add("message", message.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("notes.editComment", parameters);
        }

        ///<summary>
        /// Returns a list of notes created by a user.
        ///</summary>
        public Task<NotesGetResponse> Get(int[] noteIds = null, int? userId = null, int? offset = null, int? count = null, int? sort = null)
        {
            var parameters = new Dictionary<string, string>();
            if (noteIds != null)
                parameters.Add("note_ids", noteIds.ToApiString());
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (sort != null)
                parameters.Add("sort", sort.ToApiString());
            return _vkontakte.RequestAsync<NotesGetResponse>("notes.get", parameters);
        }

        ///<summary>
        /// Returns a note by its ID.
        ///</summary>
        public Task<NotesNote> GetById(int? noteId = null, int? ownerId = null, Boolean? needWiki = null)
        {
            var parameters = new Dictionary<string, string>();
            if (noteId != null)
                parameters.Add("note_id", noteId.ToApiString());
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (needWiki != null)
                parameters.Add("need_wiki", needWiki.ToApiString());
            return _vkontakte.RequestAsync<NotesNote>("notes.getById", parameters);
        }

        ///<summary>
        /// Returns a list of comments on a note.
        ///</summary>
        public Task<NotesGetCommentsResponse> GetComments(int? noteId = null, int? ownerId = null, int? sort = null, int? offset = null, int? count = null)
        {
            var parameters = new Dictionary<string, string>();
            if (noteId != null)
                parameters.Add("note_id", noteId.ToApiString());
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (sort != null)
                parameters.Add("sort", sort.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            return _vkontakte.RequestAsync<NotesGetCommentsResponse>("notes.getComments", parameters);
        }

        ///<summary>
        /// Restores a deleted comment on a note.
        ///</summary>
        public Task<BaseOkResponse> RestoreComment(int? commentId = null, int? ownerId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (commentId != null)
                parameters.Add("comment_id", commentId.ToApiString());
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("notes.restoreComment", parameters);
        }
    }
}