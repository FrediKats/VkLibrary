using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VkApi.Wrapper.Responses.Wall;
using VkApi.Wrapper.Types.Base;
using VkApi.Wrapper.Types.Wall;

namespace VkApi.Wrapper.Methods
{
    public class Wall
    {
        private readonly Vkontakte _vkontakte;

        internal Wall(Vkontakte vkontakte) => _vkontakte = vkontakte;

        ///<summary>
        /// Adds a comment to a post on a user wall or community wall.
        ///</summary>
        public Task<WallCreateCommentResponse> CreateComment(int? ownerId = null, int? postId = null, int? fromGroup = null, String message = null, int? replyToComment = null, String[] attachments = null, int? stickerId = null, String guid = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (postId != null)
                parameters.Add("post_id", postId.ToApiString());
            if (fromGroup != null)
                parameters.Add("from_group", fromGroup.ToApiString());
            if (message != null)
                parameters.Add("message", message.ToApiString());
            if (replyToComment != null)
                parameters.Add("reply_to_comment", replyToComment.ToApiString());
            if (attachments != null)
                parameters.Add("attachments", attachments.ToApiString());
            if (stickerId != null)
                parameters.Add("sticker_id", stickerId.ToApiString());
            if (guid != null)
                parameters.Add("guid", guid.ToApiString());
            return _vkontakte.RequestAsync<WallCreateCommentResponse>("wall.createComment", parameters);
        }

        ///<summary>
        /// Deletes a post from a user wall or community wall.
        ///</summary>
        public Task<BaseOkResponse> Delete(int? ownerId = null, int? postId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (postId != null)
                parameters.Add("post_id", postId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("wall.delete", parameters);
        }

        ///<summary>
        /// Deletes a comment on a post on a user wall or community wall.
        ///</summary>
        public Task<BaseOkResponse> DeleteComment(int? ownerId = null, int? commentId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (commentId != null)
                parameters.Add("comment_id", commentId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("wall.deleteComment", parameters);
        }

        ///<summary>
        /// Edits a post on a user wall or community wall.
        ///</summary>
        public Task<WallEditResponse> Edit(int? ownerId = null, int? postId = null, Boolean? friendsOnly = null, String message = null, String[] attachments = null, String services = null, Boolean? signed = null, int? publishDate = null, double? lat = null, double? _long = null, int? placeId = null, Boolean? markAsAds = null, Boolean? closeComments = null, int? posterBkgId = null, int? posterBkgOwnerId = null, String posterBkgAccessHash = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (postId != null)
                parameters.Add("post_id", postId.ToApiString());
            if (friendsOnly != null)
                parameters.Add("friends_only", friendsOnly.ToApiString());
            if (message != null)
                parameters.Add("message", message.ToApiString());
            if (attachments != null)
                parameters.Add("attachments", attachments.ToApiString());
            if (services != null)
                parameters.Add("services", services.ToApiString());
            if (signed != null)
                parameters.Add("signed", signed.ToApiString());
            if (publishDate != null)
                parameters.Add("publish_date", publishDate.ToApiString());
            if (lat != null)
                parameters.Add("lat", lat.ToApiString());
            if (_long != null)
                parameters.Add("long", _long.ToApiString());
            if (placeId != null)
                parameters.Add("place_id", placeId.ToApiString());
            if (markAsAds != null)
                parameters.Add("mark_as_ads", markAsAds.ToApiString());
            if (closeComments != null)
                parameters.Add("close_comments", closeComments.ToApiString());
            if (posterBkgId != null)
                parameters.Add("poster_bkg_id", posterBkgId.ToApiString());
            if (posterBkgOwnerId != null)
                parameters.Add("poster_bkg_owner_id", posterBkgOwnerId.ToApiString());
            if (posterBkgAccessHash != null)
                parameters.Add("poster_bkg_access_hash", posterBkgAccessHash.ToApiString());
            return _vkontakte.RequestAsync<WallEditResponse>("wall.edit", parameters);
        }

        ///<summary>
        /// Allows to edit hidden post.
        ///</summary>
        public Task<BaseOkResponse> EditAdsStealth(int? ownerId = null, int? postId = null, String message = null, String[] attachments = null, Boolean? signed = null, double? lat = null, double? _long = null, int? placeId = null, String linkButton = null, String linkTitle = null, String linkImage = null, String linkVideo = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (postId != null)
                parameters.Add("post_id", postId.ToApiString());
            if (message != null)
                parameters.Add("message", message.ToApiString());
            if (attachments != null)
                parameters.Add("attachments", attachments.ToApiString());
            if (signed != null)
                parameters.Add("signed", signed.ToApiString());
            if (lat != null)
                parameters.Add("lat", lat.ToApiString());
            if (_long != null)
                parameters.Add("long", _long.ToApiString());
            if (placeId != null)
                parameters.Add("place_id", placeId.ToApiString());
            if (linkButton != null)
                parameters.Add("link_button", linkButton.ToApiString());
            if (linkTitle != null)
                parameters.Add("link_title", linkTitle.ToApiString());
            if (linkImage != null)
                parameters.Add("link_image", linkImage.ToApiString());
            if (linkVideo != null)
                parameters.Add("link_video", linkVideo.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("wall.editAdsStealth", parameters);
        }

        ///<summary>
        /// Edits a comment on a user wall or community wall.
        ///</summary>
        public Task<BaseOkResponse> EditComment(int? ownerId = null, int? commentId = null, String message = null, String[] attachments = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (commentId != null)
                parameters.Add("comment_id", commentId.ToApiString());
            if (message != null)
                parameters.Add("message", message.ToApiString());
            if (attachments != null)
                parameters.Add("attachments", attachments.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("wall.editComment", parameters);
        }

        ///<summary>
        /// Returns a list of posts on a user wall or community wall.
        ///</summary>
        public Task<WallGetResponse> Get(int? ownerId = null, String domain = null, int? offset = null, int? count = null, String filter = null, Boolean? extended = null, BaseUserGroupFields[] fields = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (domain != null)
                parameters.Add("domain", domain.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (filter != null)
                parameters.Add("filter", filter.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            return _vkontakte.RequestAsync<WallGetResponse>("wall.get", parameters);
        }

        ///<summary>
        /// Returns a list of posts from user or community walls by their IDs.
        ///</summary>
        public Task<WallWallpostFull[]> GetById(String[] posts = null, Boolean? extended = null, int? copyHistoryDepth = null, BaseUserGroupFields[] fields = null)
        {
            var parameters = new Dictionary<string, string>();
            if (posts != null)
                parameters.Add("posts", posts.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            if (copyHistoryDepth != null)
                parameters.Add("copy_history_depth", copyHistoryDepth.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            return _vkontakte.RequestAsync<WallWallpostFull[]>("wall.getById", parameters);
        }

        ///<summary>
        /// Returns a list of comments on a post on a user wall or community wall.
        ///</summary>
        public Task<WallGetCommentsResponse> GetComments(int? ownerId = null, int? postId = null, Boolean? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, String sort = null, int? previewLength = null, Boolean? extended = null, BaseUserGroupFields[] fields = null, int? commentId = null, int? threadItemsCount = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (postId != null)
                parameters.Add("post_id", postId.ToApiString());
            if (needLikes != null)
                parameters.Add("need_likes", needLikes.ToApiString());
            if (startCommentId != null)
                parameters.Add("start_comment_id", startCommentId.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (sort != null)
                parameters.Add("sort", sort.ToApiString());
            if (previewLength != null)
                parameters.Add("preview_length", previewLength.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            if (commentId != null)
                parameters.Add("comment_id", commentId.ToApiString());
            if (threadItemsCount != null)
                parameters.Add("thread_items_count", threadItemsCount.ToApiString());
            return _vkontakte.RequestAsync<WallGetCommentsResponse>("wall.getComments", parameters);
        }

        ///<summary>
        /// Returns information about reposts of a post on user wall or community wall.
        ///</summary>
        public Task<WallGetRepostsResponse> GetReposts(int? ownerId = null, int? postId = null, int? offset = null, int? count = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (postId != null)
                parameters.Add("post_id", postId.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            return _vkontakte.RequestAsync<WallGetRepostsResponse>("wall.getReposts", parameters);
        }

        ///<summary>
        /// Pins the post on wall.
        ///</summary>
        public Task<BaseOkResponse> Pin(int? ownerId = null, int? postId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (postId != null)
                parameters.Add("post_id", postId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("wall.pin", parameters);
        }

        ///<summary>
        /// Adds a new post on a user wall or community wall. Can also be used to publish suggested or scheduled posts.
        ///</summary>
        public Task<WallPostResponse> Post(int? ownerId = null, Boolean? friendsOnly = null, Boolean? fromGroup = null, String message = null, String[] attachments = null, String services = null, Boolean? signed = null, int? publishDate = null, double? lat = null, double? _long = null, int? placeId = null, int? postId = null, String guid = null, Boolean? markAsAds = null, Boolean? closeComments = null, Boolean? muteNotifications = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (friendsOnly != null)
                parameters.Add("friends_only", friendsOnly.ToApiString());
            if (fromGroup != null)
                parameters.Add("from_group", fromGroup.ToApiString());
            if (message != null)
                parameters.Add("message", message.ToApiString());
            if (attachments != null)
                parameters.Add("attachments", attachments.ToApiString());
            if (services != null)
                parameters.Add("services", services.ToApiString());
            if (signed != null)
                parameters.Add("signed", signed.ToApiString());
            if (publishDate != null)
                parameters.Add("publish_date", publishDate.ToApiString());
            if (lat != null)
                parameters.Add("lat", lat.ToApiString());
            if (_long != null)
                parameters.Add("long", _long.ToApiString());
            if (placeId != null)
                parameters.Add("place_id", placeId.ToApiString());
            if (postId != null)
                parameters.Add("post_id", postId.ToApiString());
            if (guid != null)
                parameters.Add("guid", guid.ToApiString());
            if (markAsAds != null)
                parameters.Add("mark_as_ads", markAsAds.ToApiString());
            if (closeComments != null)
                parameters.Add("close_comments", closeComments.ToApiString());
            if (muteNotifications != null)
                parameters.Add("mute_notifications", muteNotifications.ToApiString());
            return _vkontakte.RequestAsync<WallPostResponse>("wall.post", parameters);
        }

        ///<summary>
        /// Allows to create hidden post which will not be shown on the community's wall and can be used for creating an ad with type "Community post".
        ///</summary>
        public Task<WallPostAdsStealthResponse> PostAdsStealth(int? ownerId = null, String message = null, String[] attachments = null, Boolean? signed = null, double? lat = null, double? _long = null, int? placeId = null, String guid = null, String linkButton = null, String linkTitle = null, String linkImage = null, String linkVideo = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (message != null)
                parameters.Add("message", message.ToApiString());
            if (attachments != null)
                parameters.Add("attachments", attachments.ToApiString());
            if (signed != null)
                parameters.Add("signed", signed.ToApiString());
            if (lat != null)
                parameters.Add("lat", lat.ToApiString());
            if (_long != null)
                parameters.Add("long", _long.ToApiString());
            if (placeId != null)
                parameters.Add("place_id", placeId.ToApiString());
            if (guid != null)
                parameters.Add("guid", guid.ToApiString());
            if (linkButton != null)
                parameters.Add("link_button", linkButton.ToApiString());
            if (linkTitle != null)
                parameters.Add("link_title", linkTitle.ToApiString());
            if (linkImage != null)
                parameters.Add("link_image", linkImage.ToApiString());
            if (linkVideo != null)
                parameters.Add("link_video", linkVideo.ToApiString());
            return _vkontakte.RequestAsync<WallPostAdsStealthResponse>("wall.postAdsStealth", parameters);
        }

        ///<summary>
        /// Reports (submits a complaint about) a comment on a post on a user wall or community wall.
        ///</summary>
        public Task<BaseOkResponse> ReportComment(int? ownerId = null, int? commentId = null, int? reason = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (commentId != null)
                parameters.Add("comment_id", commentId.ToApiString());
            if (reason != null)
                parameters.Add("reason", reason.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("wall.reportComment", parameters);
        }

        ///<summary>
        /// Reports (submits a complaint about) a post on a user wall or community wall.
        ///</summary>
        public Task<BaseOkResponse> ReportPost(int? ownerId = null, int? postId = null, int? reason = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (postId != null)
                parameters.Add("post_id", postId.ToApiString());
            if (reason != null)
                parameters.Add("reason", reason.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("wall.reportPost", parameters);
        }

        ///<summary>
        /// Reposts (copies) an object to a user wall or community wall.
        ///</summary>
        public Task<WallRepostResponse> Repost(String _object = null, String message = null, int? groupId = null, Boolean? markAsAds = null, Boolean? muteNotifications = null)
        {
            var parameters = new Dictionary<string, string>();
            if (_object != null)
                parameters.Add("object", _object.ToApiString());
            if (message != null)
                parameters.Add("message", message.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (markAsAds != null)
                parameters.Add("mark_as_ads", markAsAds.ToApiString());
            if (muteNotifications != null)
                parameters.Add("mute_notifications", muteNotifications.ToApiString());
            return _vkontakte.RequestAsync<WallRepostResponse>("wall.repost", parameters);
        }

        ///<summary>
        /// Restores a post deleted from a user wall or community wall.
        ///</summary>
        public Task<BaseOkResponse> Restore(int? ownerId = null, int? postId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (postId != null)
                parameters.Add("post_id", postId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("wall.restore", parameters);
        }

        ///<summary>
        /// Restores a comment deleted from a user wall or community wall.
        ///</summary>
        public Task<BaseOkResponse> RestoreComment(int? ownerId = null, int? commentId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (commentId != null)
                parameters.Add("comment_id", commentId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("wall.restoreComment", parameters);
        }

        ///<summary>
        /// Allows to search posts on user or community walls.
        ///</summary>
        public Task<WallSearchResponse> Search(int? ownerId = null, String domain = null, String query = null, Boolean? ownersOnly = null, int? count = null, int? offset = null, Boolean? extended = null, BaseUserGroupFields[] fields = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (domain != null)
                parameters.Add("domain", domain.ToApiString());
            if (query != null)
                parameters.Add("query", query.ToApiString());
            if (ownersOnly != null)
                parameters.Add("owners_only", ownersOnly.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            return _vkontakte.RequestAsync<WallSearchResponse>("wall.search", parameters);
        }

        ///<summary>
        /// Unpins the post on wall.
        ///</summary>
        public Task<BaseOkResponse> Unpin(int? ownerId = null, int? postId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (postId != null)
                parameters.Add("post_id", postId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("wall.unpin", parameters);
        }
    }
}