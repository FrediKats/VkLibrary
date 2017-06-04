using System.Collections.Generic;
using System.Threading.Tasks;
using VkLibrary.Core.Types.Notes;

namespace VkLibrary.Core.Methods
{
    /// <summary>
    /// Notes API section.
    /// </summary>
    public class Notes
    {
        private readonly Vkontakte _vkontakte;

        internal Notes(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        /// Returns a list of notes created by a user.
        /// Docs: <see href="https://vk.com/dev/notes.get">notes.get</see>
        /// </summary>
        /// <param name="noteIds">Note IDs.</param>
        /// <param name="userId">Note owner ID.</param>
        /// <param name="count">Number of notes to return.</param>
        public async Task<ApiItemsResponse<Note>> Get(IEnumerable<int?> noteIds = null, int? userId = null,
            int? count = null)
        {
            var parameters = new Dictionary<string, string>();

            if (noteIds != null)
                parameters.Add("note_ids", noteIds.ToApiString());
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<Note>>("notes.get", parameters);
        }

        /// <summary>
        /// Returns a note by its ID.
        /// Docs: <see href="https://vk.com/dev/notes.getById">notes.getById</see>
        /// </summary>
        /// <param name="noteId">Note ID.</param>
        /// <param name="ownerId">Note owner ID.</param>
        public async Task<Note> GetById(int? noteId = null, int? ownerId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (noteId != null)
                parameters.Add("note_id", noteId.ToApiString());
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());

            return await _vkontakte.GetAsync<Note>("notes.getById", parameters);
        }

        /// <summary>
        /// Creates a new note for the current user.
        /// Docs: <see href="https://vk.com/dev/notes.add">notes.add</see>
        /// </summary>
        /// <param name="title">Note title.</param>
        /// <param name="text">Note text.</param>
        /// <param name="privacyView"></param>
        /// <param name="privacyComment"></param>
        public async Task<int?> Add(string title = null, string text = null, IEnumerable<string> privacyView = null,
            IEnumerable<string> privacyComment = null)
        {
            var parameters = new Dictionary<string, string>();

            if (title != null)
                parameters.Add("title", title);
            if (text != null)
                parameters.Add("text", text);
            if (privacyView != null)
                parameters.Add("privacy_view", privacyView.ToApiString());
            if (privacyComment != null)
                parameters.Add("privacy_comment", privacyComment.ToApiString());

            return await _vkontakte.GetAsync<int?>("notes.add", parameters);
        }

        /// <summary>
        /// Edits a note of the current user.
        /// Docs: <see href="https://vk.com/dev/notes.edit">notes.edit</see>
        /// </summary>
        /// <param name="noteId">Note ID.</param>
        /// <param name="title">Note title.</param>
        /// <param name="text">Note text.</param>
        /// <param name="privacyView"></param>
        /// <param name="privacyComment"></param>
        public async Task<int> Edit(int? noteId = null, string title = null, string text = null,
            IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null)
        {
            var parameters = new Dictionary<string, string>();

            if (noteId != null)
                parameters.Add("note_id", noteId.ToApiString());
            if (title != null)
                parameters.Add("title", title);
            if (text != null)
                parameters.Add("text", text);
            if (privacyView != null)
                parameters.Add("privacy_view", privacyView.ToApiString());
            if (privacyComment != null)
                parameters.Add("privacy_comment", privacyComment.ToApiString());

            return await _vkontakte.GetAsync<int>("notes.edit", parameters);
        }

        /// <summary>
        /// Deletes a note of the current user.
        /// Docs: <see href="https://vk.com/dev/notes.delete">notes.delete</see>
        /// </summary>
        /// <param name="noteId">Note ID.</param>
        public async Task<int> Delete(int? noteId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (noteId != null)
                parameters.Add("note_id", noteId.ToApiString());

            return await _vkontakte.GetAsync<int>("notes.delete", parameters);
        }

        /// <summary>
        /// Returns a list of comments on a note.
        /// Docs: <see href="https://vk.com/dev/notes.getComments">notes.getComments</see>
        /// </summary>
        /// <param name="noteId">Note ID.</param>
        /// <param name="ownerId">Note owner ID.</param>
        /// <param name="count">Number of comments to return.</param>
        public async Task<ApiItemsResponse<NoteComment>> GetComments(int? noteId = null, int? ownerId = null,
            int? count = null)
        {
            var parameters = new Dictionary<string, string>();

            if (noteId != null)
                parameters.Add("note_id", noteId.ToApiString());
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<NoteComment>>("notes.getComments", parameters);
        }

        /// <summary>
        /// Adds a new comment on a note.
        /// Docs: <see href="https://vk.com/dev/notes.createComment">notes.createComment</see>
        /// </summary>
        /// <param name="noteId">Note ID.</param>
        /// <param name="ownerId">Note owner ID.</param>
        /// <param name="replyTo">ID of the user to whom the reply is addressed (if the comment is a reply to another comment).;</param>
        /// <param name="message">Comment text.</param>
        /// <param name="guid"></param>
        public async Task<int?> CreateComment(int? noteId = null, int? ownerId = null, int? replyTo = null,
            string message = null, string guid = null)
        {
            var parameters = new Dictionary<string, string>();

            if (noteId != null)
                parameters.Add("note_id", noteId.ToApiString());
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (replyTo != null)
                parameters.Add("reply_to", replyTo.ToApiString());
            if (message != null)
                parameters.Add("message", message);
            if (guid != null)
                parameters.Add("guid", guid);

            return await _vkontakte.GetAsync<int?>("notes.createComment", parameters);
        }

        /// <summary>
        /// Edits a comment on a note.
        /// Docs: <see href="https://vk.com/dev/notes.editComment">notes.editComment</see>
        /// </summary>
        /// <param name="commentId">Comment ID.</param>
        /// <param name="ownerId">Note owner ID.</param>
        /// <param name="message">New comment text.</param>
        public async Task<int> EditComment(int? commentId = null, int? ownerId = null, string message = null)
        {
            var parameters = new Dictionary<string, string>();

            if (commentId != null)
                parameters.Add("comment_id", commentId.ToApiString());
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (message != null)
                parameters.Add("message", message);

            return await _vkontakte.GetAsync<int>("notes.editComment", parameters);
        }

        /// <summary>
        /// Deletes a comment on a note.
        /// Docs: <see href="https://vk.com/dev/notes.deleteComment">notes.deleteComment</see>
        /// </summary>
        /// <param name="commentId">Comment ID.</param>
        /// <param name="ownerId">Note owner ID.</param>
        public async Task<int> DeleteComment(int? commentId = null, int? ownerId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (commentId != null)
                parameters.Add("comment_id", commentId.ToApiString());
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());

            return await _vkontakte.GetAsync<int>("notes.deleteComment", parameters);
        }

        /// <summary>
        /// Restores a deleted comment on a note.
        /// Docs: <see href="https://vk.com/dev/notes.restoreComment">notes.restoreComment</see>
        /// </summary>
        /// <param name="commentId">Comment ID.</param>
        /// <param name="ownerId">Note owner ID.</param>
        public async Task<int> RestoreComment(int? commentId = null, int? ownerId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (commentId != null)
                parameters.Add("comment_id", commentId.ToApiString());
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());

            return await _vkontakte.GetAsync<int>("notes.restoreComment", parameters);
        }
    }
}