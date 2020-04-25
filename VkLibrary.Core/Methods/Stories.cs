using VkApi.Wrapper.Objects;
using VkApi.Wrapper.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Methods
{
    public class Stories
    {
        private readonly Vkontakte _vkontakte;

        internal Stories(Vkontakte vkontakte) => _vkontakte = vkontakte;

        ///<summary>
        /// Allows to hide stories from chosen sources from current user's feed.
        ///</summary>
        public Task<BaseOkResponse> BanOwner(int[] ownersIds = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownersIds != null)
                parameters.Add("owners_ids", ownersIds.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("stories.banOwner", parameters);
        }

        ///<summary>
        /// Allows to delete story.
        ///</summary>
        public Task<BaseOkResponse> Delete(int? ownerId = null, int? storyId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (storyId != null)
                parameters.Add("story_id", storyId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("stories.delete", parameters);
        }

        ///<summary>
        /// Returns stories available for current user.
        ///</summary>
        public Task<StoriesGetV5113Response> Get(int? ownerId = null, Boolean? extended = null, BaseUserGroupFields[] fields = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            return _vkontakte.RequestAsync<StoriesGetV5113Response>("stories.get", parameters);
        }

        ///<summary>
        /// Returns list of sources hidden from current user's feed.
        ///</summary>
        public Task<StoriesGetBannedResponse> GetBanned(Boolean? extended = null, BaseUserGroupFields[] fields = null)
        {
            var parameters = new Dictionary<string, string>();
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            return _vkontakte.RequestAsync<StoriesGetBannedResponse>("stories.getBanned", parameters);
        }

        ///<summary>
        /// Returns story by its ID.
        ///</summary>
        public Task<StoriesGetByIdResponse> GetById(String[] stories = null, Boolean? extended = null, BaseUserGroupFields[] fields = null)
        {
            var parameters = new Dictionary<string, string>();
            if (stories != null)
                parameters.Add("stories", stories.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            return _vkontakte.RequestAsync<StoriesGetByIdResponse>("stories.getById", parameters);
        }

        ///<summary>
        /// Returns URL for uploading a story with photo.
        ///</summary>
        public Task<StoriesGetPhotoUploadServerResponse> GetPhotoUploadServer(Boolean? addToNews = null, int[] userIds = null, String replyToStory = null, String linkText = null, String linkUrl = null, int? groupId = null, String clickableStickers = null)
        {
            var parameters = new Dictionary<string, string>();
            if (addToNews != null)
                parameters.Add("add_to_news", addToNews.ToApiString());
            if (userIds != null)
                parameters.Add("user_ids", userIds.ToApiString());
            if (replyToStory != null)
                parameters.Add("reply_to_story", replyToStory.ToApiString());
            if (linkText != null)
                parameters.Add("link_text", linkText.ToApiString());
            if (linkUrl != null)
                parameters.Add("link_url", linkUrl.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (clickableStickers != null)
                parameters.Add("clickable_stickers", clickableStickers.ToApiString());
            return _vkontakte.RequestAsync<StoriesGetPhotoUploadServerResponse>("stories.getPhotoUploadServer", parameters);
        }

        ///<summary>
        /// Returns replies to the story.
        ///</summary>
        public Task<StoriesGetV5113Response> GetReplies(int? ownerId = null, int? storyId = null, String accessKey = null, Boolean? extended = null, BaseUserGroupFields[] fields = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (storyId != null)
                parameters.Add("story_id", storyId.ToApiString());
            if (accessKey != null)
                parameters.Add("access_key", accessKey.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            return _vkontakte.RequestAsync<StoriesGetV5113Response>("stories.getReplies", parameters);
        }

        ///<summary>
        /// Returns stories available for current user.
        ///</summary>
        public Task<StoriesStoryStats> GetStats(int? ownerId = null, int? storyId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (storyId != null)
                parameters.Add("story_id", storyId.ToApiString());
            return _vkontakte.RequestAsync<StoriesStoryStats>("stories.getStats", parameters);
        }

        ///<summary>
        /// Allows to receive URL for uploading story with video.
        ///</summary>
        public Task<StoriesGetVideoUploadServerResponse> GetVideoUploadServer(Boolean? addToNews = null, int[] userIds = null, String replyToStory = null, String linkText = null, String linkUrl = null, int? groupId = null, String clickableStickers = null)
        {
            var parameters = new Dictionary<string, string>();
            if (addToNews != null)
                parameters.Add("add_to_news", addToNews.ToApiString());
            if (userIds != null)
                parameters.Add("user_ids", userIds.ToApiString());
            if (replyToStory != null)
                parameters.Add("reply_to_story", replyToStory.ToApiString());
            if (linkText != null)
                parameters.Add("link_text", linkText.ToApiString());
            if (linkUrl != null)
                parameters.Add("link_url", linkUrl.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (clickableStickers != null)
                parameters.Add("clickable_stickers", clickableStickers.ToApiString());
            return _vkontakte.RequestAsync<StoriesGetVideoUploadServerResponse>("stories.getVideoUploadServer", parameters);
        }

        ///<summary>
        /// Returns a list of story viewers.
        ///</summary>
        public Task<StoriesGetViewersExtendedV5115Response> GetViewers(int? ownerId = null, int? storyId = null, int? count = null, int? offset = null, Boolean? extended = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (storyId != null)
                parameters.Add("story_id", storyId.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            return _vkontakte.RequestAsync<StoriesGetViewersExtendedV5115Response>("stories.getViewers", parameters);
        }

        ///<summary>
        /// Hides all replies in the last 24 hours from the user to current user's stories.
        ///</summary>
        public Task<BaseOkResponse> HideAllReplies(int? ownerId = null, int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("stories.hideAllReplies", parameters);
        }

        ///<summary>
        /// Hides the reply to the current user's story.
        ///</summary>
        public Task<BaseOkResponse> HideReply(int? ownerId = null, int? storyId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (storyId != null)
                parameters.Add("story_id", storyId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("stories.hideReply", parameters);
        }

        ///<summary>
        /// Allows to show stories from hidden sources in current user's feed.
        ///</summary>
        public Task<BaseOkResponse> UnbanOwner(int[] ownersIds = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownersIds != null)
                parameters.Add("owners_ids", ownersIds.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("stories.unbanOwner", parameters);
        }
    }
}