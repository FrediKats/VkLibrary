using System.Collections.Generic;
using System.Threading.Tasks;
using VkLibrary.Core.Types.Polls;

namespace VkLibrary.Core.Methods
{
    /// <summary>
    /// Polls API section.
    /// </summary>
    public class Polls
    {
        private readonly Vkontakte _vkontakte;
        internal Polls(Vkontakte vkontakte) => _vkontakte = vkontakte;

        /// <summary>
        /// Returns detailed information about a poll by its ID.
        /// Docs: <see href="https://vk.com/dev/polls.getById">polls.getById</see>
        /// </summary>
        /// <param name="ownerId">
        /// ID of the user or community that owns the poll. Use a negative value to designate a community ID.
        /// </param>
        /// <param name="isBoard">'1' – poll is in a board, '0' – poll is on a wall. ; '0' by default.</param>
        /// <param name="pollId">Poll ID.</param>
        public Task<Poll> GetById(int? ownerId = null, bool? isBoard = null, int? pollId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (isBoard != null)
                parameters.Add("is_board", isBoard.ToApiString());
            if (pollId != null)
                parameters.Add("poll_id", pollId.ToApiString());

            return _vkontakte.GetAsync<Poll>("polls.getById", parameters);
        }

        /// <summary>
        /// Adds the current user's vote to the selected answer in the poll.
        /// Docs: <see href="https://vk.com/dev/polls.addVote">polls.addVote</see>
        /// </summary>
        /// <param name="ownerId">
        /// ID of the user or community that owns the poll. Use a negative value to designate a community
        /// ID.
        /// </param>
        /// <param name="pollId">Poll ID.</param>
        /// <param name="answerId">Answer ID.</param>
        /// <param name="isBoard"></param>
        public Task<int> AddVote(int? ownerId = null, int? pollId = null, int? answerId = null,
            bool? isBoard = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (pollId != null)
                parameters.Add("poll_id", pollId.ToApiString());
            if (answerId != null)
                parameters.Add("answer_id", answerId.ToApiString());
            if (isBoard != null)
                parameters.Add("is_board", isBoard.ToApiString());

            return _vkontakte.GetAsync<int>("polls.addVote", parameters);
        }

        /// <summary>
        /// Deletes the current user's vote from the selected answer in the poll.
        /// Docs: <see href="https://vk.com/dev/polls.deleteVote">polls.deleteVote</see>
        /// </summary>
        /// <param name="ownerId">
        /// ID of the user or community that owns the poll. Use a negative value to designate a community
        /// ID.
        /// </param>
        /// <param name="pollId">Poll ID.</param>
        /// <param name="answerId">Answer ID.</param>
        /// <param name="isBoard"></param>
        public Task<int> DeleteVote(int? ownerId = null, int? pollId = null, int? answerId = null,
            bool? isBoard = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (pollId != null)
                parameters.Add("poll_id", pollId.ToApiString());
            if (answerId != null)
                parameters.Add("answer_id", answerId.ToApiString());
            if (isBoard != null)
                parameters.Add("is_board", isBoard.ToApiString());

            return _vkontakte.GetAsync<int>("polls.deleteVote", parameters);
        }

        /// <summary>
        /// Returns a list of IDs of users who selected specific answers in the poll.
        /// Docs: <see href="https://vk.com/dev/polls.getVoters">polls.getVoters</see>
        /// </summary>
        /// <param name="ownerId">
        /// ID of the user or community that owns the poll. Use a negative value to designate a community
        /// ID.
        /// </param>
        /// <param name="pollId">Poll ID.</param>
        /// <param name="answerIds">Answer IDs.</param>
        /// <param name="isBoard"></param>
        /// <param name="friendsOnly">'1' — to return only current user's friends; '0' — to return all users (default);</param>
        /// <param name="offset">Offset needed to return a specific subset of voters.; '0' — (default)</param>
        /// <param name="count">
        /// Number of user IDs to return (if the 'friends_only' parameter is not set, maximum '1000'; otherwise
        /// '10').; '100' — (default)
        /// </param>
        /// <param name="fields">
        /// Profile fields to return. Sample values: 'nickname', 'screen_name', 'sex', 'bdate (birthdate)',
        /// 'city', 'country', 'timezone', 'photo', 'photo_medium', 'photo_big', 'has_mobile', 'rate', 'contacts', 'education',
        /// 'online', 'counters'.;
        /// </param>
        /// <param name="nameCase">
        /// Case for declension of user name and surname: ; 'nom' — nominative (default) ; 'gen' — genitive
        /// ; 'dat' — dative ; 'acc' — accusative ; 'ins' — instrumental ; 'abl' — prepositional
        /// </param>
        public Task<IEnumerable<Voters>> GetVoters(int? ownerId = null, int? pollId = null,
            IEnumerable<int?> answerIds = null, bool? isBoard = null, bool? friendsOnly = null, int? offset = null,
            int? count = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (pollId != null)
                parameters.Add("poll_id", pollId.ToApiString());
            if (answerIds != null)
                parameters.Add("answer_ids", answerIds.ToApiString());
            if (isBoard != null)
                parameters.Add("is_board", isBoard.ToApiString());
            if (friendsOnly != null)
                parameters.Add("friends_only", friendsOnly.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            if (nameCase != null)
                parameters.Add("name_case", nameCase);

            return _vkontakte.GetAsync<IEnumerable<Voters>>("polls.getVoters", parameters);
        }

        /// <summary>
        /// Creates polls that can be attached to the users' or communities' posts.
        /// Docs: <see href="https://vk.com/dev/polls.create">polls.create</see>
        /// </summary>
        /// <param name="question">question text</param>
        /// <param name="isAnonymous">
        /// '1' – anonymous poll, participants list is hidden;; '0' – public poll, participants list is
        /// available;; Default value is '0'.
        /// </param>
        /// <param name="ownerId">
        /// If a poll will be added to a communty it is required to send a negative group identifier.
        /// Current user by default.
        /// </param>
        /// <param name="addAnswers">
        /// available answers list, for example:; " ["yes","no","maybe"]"; There can be from 1 to 10
        /// answers.
        /// </param>
        public Task<Poll> Create(string question = null, bool? isAnonymous = null, int? ownerId = null,
            string addAnswers = null)
        {
            var parameters = new Dictionary<string, string>();

            if (question != null)
                parameters.Add("question", question);
            if (isAnonymous != null)
                parameters.Add("is_anonymous", isAnonymous.ToApiString());
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (addAnswers != null)
                parameters.Add("add_answers", addAnswers);

            return _vkontakte.GetAsync<Poll>("polls.create", parameters);
        }

        /// <summary>
        /// Edits created polls
        /// Docs: <see href="https://vk.com/dev/polls.edit">polls.edit</see>
        /// </summary>
        /// <param name="ownerId">poll owner id</param>
        /// <param name="pollId">edited poll's id</param>
        /// <param name="question">new question text</param>
        /// <param name="addAnswers">answers list, for example: ; "["yes","no","maybe"]"</param>
        /// <param name="editAnswers">
        /// object containing answers that need to be edited;; key – answer id, value – new answer
        /// text.; Example:; {"382967099":"option1", "382967103":"option2"}"
        /// </param>
        /// <param name="deleteAnswers">list of answer ids to be deleted. For example:; "[382967099, 382967103]"</param>
        public Task<int> Edit(int? ownerId = null, int? pollId = null, string question = null,
            string addAnswers = null, string editAnswers = null, string deleteAnswers = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (pollId != null)
                parameters.Add("poll_id", pollId.ToApiString());
            if (question != null)
                parameters.Add("question", question);
            if (addAnswers != null)
                parameters.Add("add_answers", addAnswers);
            if (editAnswers != null)
                parameters.Add("edit_answers", editAnswers);
            if (deleteAnswers != null)
                parameters.Add("delete_answers", deleteAnswers);

            return _vkontakte.GetAsync<int>("polls.edit", parameters);
        }
    }
}