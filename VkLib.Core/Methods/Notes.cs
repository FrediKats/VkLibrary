using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkLib.Methods
{
    /// <summary>
    /// Notes API section.
    /// </summary>
    public class Notes
    {
        private Vkontakte _vkontakte;

        internal Notes(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        /// Returns a list of notes created by a user.
        /// Docs: <see href="https://vk.com/dev/notes.get">notes.get</see>
        /// </summary>
        /// <param name="note_ids">Note IDs.</param>
        /// <param name="user_id">Note owner ID.</param>
        /// <param name="count">Number of notes to return.</param>
        public async Task<ApiItemsResponse<VkLib.Types.Notes.Note>> Get(IEnumerable<int?> note_ids = null, int? user_id = null, int? count = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (note_ids != null)
                parameters.Add("note_ids", string.Join(",", note_ids));
            if (user_id != null)
                parameters.Add("user_id", user_id.ToString());
            if (count != null)
                parameters.Add("count", count.ToString());

            return await _vkontakte.GetAsync<ApiItemsResponse<VkLib.Types.Notes.Note>>("notes.get", parameters);
        }

        /// <summary>
        /// Returns a note by its ID.
        /// Docs: <see href="https://vk.com/dev/notes.getById">notes.getById</see>
        /// </summary>
        /// <param name="note_id">Note ID.</param>
        /// <param name="owner_id">Note owner ID.</param>
        public async Task<VkLib.Types.Notes.Note> GetById(int? note_id = null, int? owner_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (note_id != null)
                parameters.Add("note_id", note_id.ToString());
            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());

            return await _vkontakte.GetAsync<VkLib.Types.Notes.Note>("notes.getById", parameters);
        }

        /// <summary>
        /// Creates a new note for the current user.
        /// Docs: <see href="https://vk.com/dev/notes.add">notes.add</see>
        /// </summary>
        /// <param name="title">Note title.</param>
        /// <param name="text">Note text.</param>
        /// <param name="privacy_view"></param>
        /// <param name="privacy_comment"></param>
        public async Task<int?> Add(string title = null, string text = null, IEnumerable<string> privacy_view = null, IEnumerable<string> privacy_comment = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (title != null)
                parameters.Add("title", title);
            if (text != null)
                parameters.Add("text", text);
            if (privacy_view != null)
                parameters.Add("privacy_view", string.Join(",", privacy_view));
            if (privacy_comment != null)
                parameters.Add("privacy_comment", string.Join(",", privacy_comment));

            return await _vkontakte.GetAsync<int?>("notes.add", parameters);
        }

        /// <summary>
        /// Edits a note of the current user.
        /// Docs: <see href="https://vk.com/dev/notes.edit">notes.edit</see>
        /// </summary>
        /// <param name="note_id">Note ID.</param>
        /// <param name="title">Note title.</param>
        /// <param name="text">Note text.</param>
        /// <param name="privacy_view"></param>
        /// <param name="privacy_comment"></param>
        public async Task<int> Edit(int? note_id = null, string title = null, string text = null, IEnumerable<string> privacy_view = null, IEnumerable<string> privacy_comment = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (note_id != null)
                parameters.Add("note_id", note_id.ToString());
            if (title != null)
                parameters.Add("title", title);
            if (text != null)
                parameters.Add("text", text);
            if (privacy_view != null)
                parameters.Add("privacy_view", string.Join(",", privacy_view));
            if (privacy_comment != null)
                parameters.Add("privacy_comment", string.Join(",", privacy_comment));

            return await _vkontakte.GetAsync<int>("notes.edit", parameters);
        }

        /// <summary>
        /// Deletes a note of the current user.
        /// Docs: <see href="https://vk.com/dev/notes.delete">notes.delete</see>
        /// </summary>
        /// <param name="note_id">Note ID.</param>
        public async Task<int> Delete(int? note_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (note_id != null)
                parameters.Add("note_id", note_id.ToString());

            return await _vkontakte.GetAsync<int>("notes.delete", parameters);
        }

        /// <summary>
        /// Returns a list of comments on a note.
        /// Docs: <see href="https://vk.com/dev/notes.getComments">notes.getComments</see>
        /// </summary>
        /// <param name="note_id">Note ID.</param>
        /// <param name="owner_id">Note owner ID.</param>
        /// <param name="count">Number of comments to return.</param>
        public async Task<ApiItemsResponse<VkLib.Types.Notes.NoteComment>> GetComments(int? note_id = null, int? owner_id = null, int? count = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (note_id != null)
                parameters.Add("note_id", note_id.ToString());
            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (count != null)
                parameters.Add("count", count.ToString());

            return await _vkontakte.GetAsync<ApiItemsResponse<VkLib.Types.Notes.NoteComment>>("notes.getComments", parameters);
        }

        /// <summary>
        /// Adds a new comment on a note.
        /// Docs: <see href="https://vk.com/dev/notes.createComment">notes.createComment</see>
        /// </summary>
        /// <param name="note_id">Note ID.</param>
        /// <param name="owner_id">Note owner ID.</param>
        /// <param name="reply_to">ID of the user to whom the reply is addressed (if the comment is a reply to another comment).;</param>
        /// <param name="message">Comment text.</param>
        /// <param name="guid"></param>
        public async Task<int?> CreateComment(int? note_id = null, int? owner_id = null, int? reply_to = null, string message = null, string guid = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (note_id != null)
                parameters.Add("note_id", note_id.ToString());
            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (reply_to != null)
                parameters.Add("reply_to", reply_to.ToString());
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
        /// <param name="comment_id">Comment ID.</param>
        /// <param name="owner_id">Note owner ID.</param>
        /// <param name="message">New comment text.</param>
        public async Task<int> EditComment(int? comment_id = null, int? owner_id = null, string message = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (comment_id != null)
                parameters.Add("comment_id", comment_id.ToString());
            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (message != null)
                parameters.Add("message", message);

            return await _vkontakte.GetAsync<int>("notes.editComment", parameters);
        }

        /// <summary>
        /// Deletes a comment on a note.
        /// Docs: <see href="https://vk.com/dev/notes.deleteComment">notes.deleteComment</see>
        /// </summary>
        /// <param name="comment_id">Comment ID.</param>
        /// <param name="owner_id">Note owner ID.</param>
        public async Task<int> DeleteComment(int? comment_id = null, int? owner_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (comment_id != null)
                parameters.Add("comment_id", comment_id.ToString());
            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());

            return await _vkontakte.GetAsync<int>("notes.deleteComment", parameters);
        }

        /// <summary>
        /// Restores a deleted comment on a note.
        /// Docs: <see href="https://vk.com/dev/notes.restoreComment">notes.restoreComment</see>
        /// </summary>
        /// <param name="comment_id">Comment ID.</param>
        /// <param name="owner_id">Note owner ID.</param>
        public async Task<int> RestoreComment(int? comment_id = null, int? owner_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (comment_id != null)
                parameters.Add("comment_id", comment_id.ToString());
            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());

            return await _vkontakte.GetAsync<int>("notes.restoreComment", parameters);
        }

    }
}
