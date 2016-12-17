using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkLib.Methods
{
    /// <summary>
    /// Polls API section.
    /// </summary>
    public class Polls
    {
        private Vkontakte _vkontakte;

        internal Polls(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        /// Returns detailed information about a poll by its ID.
        /// Docs: <see href="https://vk.com/dev/polls.getById">polls.getById</see>
        /// </summary>
        /// <param name="owner_id">ID of the user or community that owns the poll. Use a negative value to designate a community ID.</param>
        /// <param name="is_board">'1' – poll is in a board, '0' – poll is on a wall. ; '0' by default.</param>
        /// <param name="poll_id">Poll ID.</param>
        public async Task<object> GetById(int? owner_id = null, bool? is_board = null, int? poll_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (is_board != null)
                parameters.Add("is_board", is_board.ToString());
            if (poll_id != null)
                parameters.Add("poll_id", poll_id.ToString());

            return await _vkontakte.GetAsync<object>("polls.getById", parameters);
        }

        /// <summary>
        /// Adds the current user's vote to the selected answer in the poll.
        /// Docs: <see href="https://vk.com/dev/polls.addVote">polls.addVote</see>
        /// </summary>
        /// <param name="owner_id">ID of the user or community that owns the poll. Use a negative value to designate a community ID.</param>
        /// <param name="poll_id">Poll ID.</param>
        /// <param name="answer_id">Answer ID.</param>
        /// <param name="is_board"></param>
        public async Task<object> AddVote(int? owner_id = null, int? poll_id = null, int? answer_id = null, bool? is_board = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (poll_id != null)
                parameters.Add("poll_id", poll_id.ToString());
            if (answer_id != null)
                parameters.Add("answer_id", answer_id.ToString());
            if (is_board != null)
                parameters.Add("is_board", is_board.ToString());

            return await _vkontakte.GetAsync<object>("polls.addVote", parameters);
        }

        /// <summary>
        /// Deletes the current user's vote from the selected answer in the poll.
        /// Docs: <see href="https://vk.com/dev/polls.deleteVote">polls.deleteVote</see>
        /// </summary>
        /// <param name="owner_id">ID of the user or community that owns the poll. Use a negative value to designate a community ID.</param>
        /// <param name="poll_id">Poll ID.</param>
        /// <param name="answer_id">Answer ID.</param>
        /// <param name="is_board"></param>
        public async Task<object> DeleteVote(int? owner_id = null, int? poll_id = null, int? answer_id = null, bool? is_board = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (poll_id != null)
                parameters.Add("poll_id", poll_id.ToString());
            if (answer_id != null)
                parameters.Add("answer_id", answer_id.ToString());
            if (is_board != null)
                parameters.Add("is_board", is_board.ToString());

            return await _vkontakte.GetAsync<object>("polls.deleteVote", parameters);
        }

        /// <summary>
        /// Returns a list of IDs of users who selected specific answers in the poll.
        /// Docs: <see href="https://vk.com/dev/polls.getVoters">polls.getVoters</see>
        /// </summary>
        /// <param name="owner_id">ID of the user or community that owns the poll. Use a negative value to designate a community ID.</param>
        /// <param name="poll_id">Poll ID.</param>
        /// <param name="answer_ids">Answer IDs.</param>
        /// <param name="is_board"></param>
        /// <param name="friends_only">'1' — to return only current user's friends; '0' — to return all users (default);</param>
        /// <param name="offset">Offset needed to return a specific subset of voters.; '0' — (default)</param>
        /// <param name="count">Number of user IDs to return (if the 'friends_only' parameter is not set, maximum '1000'; otherwise '10').; '100' — (default)</param>
        /// <param name="fields">Profile fields to return. Sample values: 'nickname', 'screen_name', 'sex', 'bdate (birthdate)', 'city', 'country', 'timezone', 'photo', 'photo_medium', 'photo_big', 'has_mobile', 'rate', 'contacts', 'education', 'online', 'counters'.;</param>
        /// <param name="name_case">Case for declension of user name and surname: ; 'nom' — nominative (default) ; 'gen' — genitive ; 'dat' — dative ; 'acc' — accusative ; 'ins' — instrumental ; 'abl' — prepositional</param>
        public async Task<object> GetVoters(int? owner_id = null, int? poll_id = null, IEnumerable<int?> answer_ids = null, bool? is_board = null, bool? friends_only = null, int? offset = null, int? count = null, IEnumerable<string> fields = null, string name_case = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (poll_id != null)
                parameters.Add("poll_id", poll_id.ToString());
            if (answer_ids != null)
                parameters.Add("answer_ids", string.Join(",", answer_ids));
            if (is_board != null)
                parameters.Add("is_board", is_board.ToString());
            if (friends_only != null)
                parameters.Add("friends_only", friends_only.ToString());
            if (offset != null)
                parameters.Add("offset", offset.ToString());
            if (count != null)
                parameters.Add("count", count.ToString());
            if (fields != null)
                parameters.Add("fields", string.Join(",", fields));
            if (name_case != null)
                parameters.Add("name_case", name_case);

            return await _vkontakte.GetAsync<object>("polls.getVoters", parameters);
        }

        /// <summary>
        /// Creates polls that can be attached to the users' or communities' posts.
        /// Docs: <see href="https://vk.com/dev/polls.create">polls.create</see>
        /// </summary>
        /// <param name="question">question text</param>
        /// <param name="is_anonymous">'1' – anonymous poll, participants list is hidden;; '0' – public poll, participants list is available;; Default value is '0'.</param>
        /// <param name="owner_id">If a poll will be added to a communty it is required to send a negative group identifier. Current user by default.</param>
        /// <param name="add_answers">available answers list, for example:; " ["yes","no","maybe"]"; There can be from 1 to 10 answers.</param>
        public async Task<object> Create(string question = null, bool? is_anonymous = null, int? owner_id = null, string add_answers = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (question != null)
                parameters.Add("question", question);
            if (is_anonymous != null)
                parameters.Add("is_anonymous", is_anonymous.ToString());
            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (add_answers != null)
                parameters.Add("add_answers", add_answers);

            return await _vkontakte.GetAsync<object>("polls.create", parameters);
        }

        /// <summary>
        /// Edits created polls
        /// Docs: <see href="https://vk.com/dev/polls.edit">polls.edit</see>
        /// </summary>
        /// <param name="owner_id">poll owner id</param>
        /// <param name="poll_id">edited poll's id</param>
        /// <param name="question">new question text</param>
        /// <param name="add_answers">answers list, for example: ; "["yes","no","maybe"]"</param>
        /// <param name="edit_answers">object containing answers that need to be edited;; key – answer id, value – new answer text.; Example:; {"382967099":"option1", "382967103":"option2"}"</param>
        /// <param name="delete_answers">list of answer ids to be deleted. For example:; "[382967099, 382967103]"</param>
        public async Task<object> Edit(int? owner_id = null, int? poll_id = null, string question = null, string add_answers = null, string edit_answers = null, string delete_answers = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (poll_id != null)
                parameters.Add("poll_id", poll_id.ToString());
            if (question != null)
                parameters.Add("question", question);
            if (add_answers != null)
                parameters.Add("add_answers", add_answers);
            if (edit_answers != null)
                parameters.Add("edit_answers", edit_answers);
            if (delete_answers != null)
                parameters.Add("delete_answers", delete_answers);

            return await _vkontakte.GetAsync<object>("polls.edit", parameters);
        }

    }
}
