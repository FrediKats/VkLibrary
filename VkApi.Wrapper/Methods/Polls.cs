using VkApi.Wrapper.Objects;
using VkApi.Wrapper.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Methods
{
    public class Polls
    {
        private readonly Vkontakte _vkontakte;

        internal Polls(Vkontakte vkontakte) => _vkontakte = vkontakte;

        ///<summary>
        /// Adds the current user's vote to the selected answer in the poll.
        ///</summary>
        public Task<int> AddVote(int? ownerId = null, int? pollId = null, int[] answerIds = null, Boolean? isBoard = null)
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
            return _vkontakte.RequestAsync<int>("polls.addVote", parameters);
        }

        ///<summary>
        /// Creates polls that can be attached to the users' or communities' posts.
        ///</summary>
        public Task<PollsPoll> Create(String question = null, Boolean? isAnonymous = null, Boolean? isMultiple = null, int? endDate = null, int? ownerId = null, String addAnswers = null, int? photoId = null, String backgroundId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (question != null)
                parameters.Add("question", question.ToApiString());
            if (isAnonymous != null)
                parameters.Add("is_anonymous", isAnonymous.ToApiString());
            if (isMultiple != null)
                parameters.Add("is_multiple", isMultiple.ToApiString());
            if (endDate != null)
                parameters.Add("end_date", endDate.ToApiString());
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (addAnswers != null)
                parameters.Add("add_answers", addAnswers.ToApiString());
            if (photoId != null)
                parameters.Add("photo_id", photoId.ToApiString());
            if (backgroundId != null)
                parameters.Add("background_id", backgroundId.ToApiString());
            return _vkontakte.RequestAsync<PollsPoll>("polls.create", parameters);
        }

        ///<summary>
        /// Deletes the current user's vote from the selected answer in the poll.
        ///</summary>
        public Task<int> DeleteVote(int? ownerId = null, int? pollId = null, int? answerId = null, Boolean? isBoard = null)
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
            return _vkontakte.RequestAsync<int>("polls.deleteVote", parameters);
        }

        ///<summary>
        /// Edits created polls
        ///</summary>
        public Task<BaseOkResponse> Edit(int? ownerId = null, int? pollId = null, String question = null, String addAnswers = null, String editAnswers = null, String deleteAnswers = null, int? endDate = null, int? photoId = null, String backgroundId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (pollId != null)
                parameters.Add("poll_id", pollId.ToApiString());
            if (question != null)
                parameters.Add("question", question.ToApiString());
            if (addAnswers != null)
                parameters.Add("add_answers", addAnswers.ToApiString());
            if (editAnswers != null)
                parameters.Add("edit_answers", editAnswers.ToApiString());
            if (deleteAnswers != null)
                parameters.Add("delete_answers", deleteAnswers.ToApiString());
            if (endDate != null)
                parameters.Add("end_date", endDate.ToApiString());
            if (photoId != null)
                parameters.Add("photo_id", photoId.ToApiString());
            if (backgroundId != null)
                parameters.Add("background_id", backgroundId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("polls.edit", parameters);
        }

        ///<summary>
        /// Returns detailed information about a poll by its ID.
        ///</summary>
        public Task<PollsPoll> GetById(int? ownerId = null, Boolean? isBoard = null, int? pollId = null, Boolean? extended = null, int? friendsCount = null, String[] fields = null, String nameCase = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (isBoard != null)
                parameters.Add("is_board", isBoard.ToApiString());
            if (pollId != null)
                parameters.Add("poll_id", pollId.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            if (friendsCount != null)
                parameters.Add("friends_count", friendsCount.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            if (nameCase != null)
                parameters.Add("name_case", nameCase.ToApiString());
            return _vkontakte.RequestAsync<PollsPoll>("polls.getById", parameters);
        }

        ///<summary>
        /// Returns a list of IDs of users who selected specific answers in the poll.
        ///</summary>
        public Task<PollsVoters[]> GetVoters(int? ownerId = null, int? pollId = null, int[] answerIds = null, Boolean? isBoard = null, Boolean? friendsOnly = null, int? offset = null, int? count = null, UsersFields[] fields = null, String nameCase = null)
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
                parameters.Add("name_case", nameCase.ToApiString());
            return _vkontakte.RequestAsync<PollsVoters[]>("polls.getVoters", parameters);
        }
    }
}