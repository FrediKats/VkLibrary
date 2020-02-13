using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VkApi.Wrapper.Responses.Video;
using VkApi.Wrapper.Types.Base;
using VkApi.Wrapper.Types.Video;

namespace VkApi.Wrapper.Methods
{
    public class Video
    {
        private readonly Vkontakte _vkontakte;

        internal Video(Vkontakte vkontakte) => _vkontakte = vkontakte;

        ///<summary>
        /// Adds a video to a user or community page.
        ///</summary>
        public Task<BaseOkResponse> Add(int? targetId = null, int? videoId = null, int? ownerId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (targetId != null)
                parameters.Add("target_id", targetId.ToApiString());
            if (videoId != null)
                parameters.Add("video_id", videoId.ToApiString());
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("video.add", parameters);
        }

        ///<summary>
        /// Creates an empty album for videos.
        ///</summary>
        public Task<VideoAddAlbumResponse> AddAlbum(int? groupId = null, String title = null, String[] privacy = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (title != null)
                parameters.Add("title", title.ToApiString());
            if (privacy != null)
                parameters.Add("privacy", privacy.ToApiString());
            return _vkontakte.RequestAsync<VideoAddAlbumResponse>("video.addAlbum", parameters);
        }

        ///<summary>
        /// Adds a new comment on a video.
        ///</summary>
        public Task<int> CreateComment(int? ownerId = null, int? videoId = null, String message = null, String[] attachments = null, Boolean? fromGroup = null, int? replyToComment = null, int? stickerId = null, String guid = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (videoId != null)
                parameters.Add("video_id", videoId.ToApiString());
            if (message != null)
                parameters.Add("message", message.ToApiString());
            if (attachments != null)
                parameters.Add("attachments", attachments.ToApiString());
            if (fromGroup != null)
                parameters.Add("from_group", fromGroup.ToApiString());
            if (replyToComment != null)
                parameters.Add("reply_to_comment", replyToComment.ToApiString());
            if (stickerId != null)
                parameters.Add("sticker_id", stickerId.ToApiString());
            if (guid != null)
                parameters.Add("guid", guid.ToApiString());
            return _vkontakte.RequestAsync<int>("video.createComment", parameters);
        }

        ///<summary>
        /// Deletes a video from a user or community page.
        ///</summary>
        public Task<BaseOkResponse> Delete(int? videoId = null, int? ownerId = null, int? targetId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (videoId != null)
                parameters.Add("video_id", videoId.ToApiString());
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (targetId != null)
                parameters.Add("target_id", targetId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("video.delete", parameters);
        }

        ///<summary>
        /// Deletes a video album.
        ///</summary>
        public Task<BaseOkResponse> DeleteAlbum(int? groupId = null, int? albumId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (albumId != null)
                parameters.Add("album_id", albumId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("video.deleteAlbum", parameters);
        }

        ///<summary>
        /// Deletes a comment on a video.
        ///</summary>
        public Task<BaseOkResponse> DeleteComment(int? ownerId = null, int? commentId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (commentId != null)
                parameters.Add("comment_id", commentId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("video.deleteComment", parameters);
        }

        ///<summary>
        /// Edits information about a video on a user or community page.
        ///</summary>
        public Task<BaseOkResponse> Edit(int? ownerId = null, int? videoId = null, String name = null, String desc = null, String[] privacyView = null, String[] privacyComment = null, Boolean? noComments = null, Boolean? repeat = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (videoId != null)
                parameters.Add("video_id", videoId.ToApiString());
            if (name != null)
                parameters.Add("name", name.ToApiString());
            if (desc != null)
                parameters.Add("desc", desc.ToApiString());
            if (privacyView != null)
                parameters.Add("privacy_view", privacyView.ToApiString());
            if (privacyComment != null)
                parameters.Add("privacy_comment", privacyComment.ToApiString());
            if (noComments != null)
                parameters.Add("no_comments", noComments.ToApiString());
            if (repeat != null)
                parameters.Add("repeat", repeat.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("video.edit", parameters);
        }

        ///<summary>
        /// Edits the title of a video album.
        ///</summary>
        public Task<BaseOkResponse> EditAlbum(int? groupId = null, int? albumId = null, String title = null, String[] privacy = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (albumId != null)
                parameters.Add("album_id", albumId.ToApiString());
            if (title != null)
                parameters.Add("title", title.ToApiString());
            if (privacy != null)
                parameters.Add("privacy", privacy.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("video.editAlbum", parameters);
        }

        ///<summary>
        /// Edits the text of a comment on a video.
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
            return _vkontakte.RequestAsync<BaseOkResponse>("video.editComment", parameters);
        }

        ///<summary>
        /// Returns detailed information about videos.
        ///</summary>
        public Task<VideoGetResponse> Get(int? ownerId = null, String[] videos = null, int? albumId = null, int? count = null, int? offset = null, Boolean? extended = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (videos != null)
                parameters.Add("videos", videos.ToApiString());
            if (albumId != null)
                parameters.Add("album_id", albumId.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            return _vkontakte.RequestAsync<VideoGetResponse>("video.get", parameters);
        }

        ///<summary>
        /// Returns video album info
        ///</summary>
        public Task<VideoVideoAlbumFull> GetAlbumById(int? ownerId = null, int? albumId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (albumId != null)
                parameters.Add("album_id", albumId.ToApiString());
            return _vkontakte.RequestAsync<VideoVideoAlbumFull>("video.getAlbumById", parameters);
        }

        ///<summary>
        /// Returns a list of video albums owned by a user or community.
        ///</summary>
        public Task<VideoGetAlbumsResponse> GetAlbums(int? ownerId = null, int? offset = null, int? count = null, Boolean? extended = null, Boolean? needSystem = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            if (needSystem != null)
                parameters.Add("need_system", needSystem.ToApiString());
            return _vkontakte.RequestAsync<VideoGetAlbumsResponse>("video.getAlbums", parameters);
        }

        ///<summary>
        /// Returns a list of comments on a video.
        ///</summary>
        public Task<VideoGetCommentsResponse> GetComments(int? ownerId = null, int? videoId = null, Boolean? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, String sort = null, Boolean? extended = null, String[] fields = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (videoId != null)
                parameters.Add("video_id", videoId.ToApiString());
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
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            return _vkontakte.RequestAsync<VideoGetCommentsResponse>("video.getComments", parameters);
        }

        ///<summary>
        /// Reorders the album in the list of user video albums.
        ///</summary>
        public Task<BaseOkResponse> ReorderAlbums(int? ownerId = null, int? albumId = null, int? before = null, int? after = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (albumId != null)
                parameters.Add("album_id", albumId.ToApiString());
            if (before != null)
                parameters.Add("before", before.ToApiString());
            if (after != null)
                parameters.Add("after", after.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("video.reorderAlbums", parameters);
        }

        ///<summary>
        /// Reorders the video in the video album.
        ///</summary>
        public Task<BaseOkResponse> ReorderVideos(int? targetId = null, int? albumId = null, int? ownerId = null, int? videoId = null, int? beforeOwnerId = null, int? beforeVideoId = null, int? afterOwnerId = null, int? afterVideoId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (targetId != null)
                parameters.Add("target_id", targetId.ToApiString());
            if (albumId != null)
                parameters.Add("album_id", albumId.ToApiString());
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (videoId != null)
                parameters.Add("video_id", videoId.ToApiString());
            if (beforeOwnerId != null)
                parameters.Add("before_owner_id", beforeOwnerId.ToApiString());
            if (beforeVideoId != null)
                parameters.Add("before_video_id", beforeVideoId.ToApiString());
            if (afterOwnerId != null)
                parameters.Add("after_owner_id", afterOwnerId.ToApiString());
            if (afterVideoId != null)
                parameters.Add("after_video_id", afterVideoId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("video.reorderVideos", parameters);
        }

        ///<summary>
        /// Reports (submits a complaint about) a video.
        ///</summary>
        public Task<BaseOkResponse> Report(int? ownerId = null, int? videoId = null, int? reason = null, String comment = null, String searchQuery = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (videoId != null)
                parameters.Add("video_id", videoId.ToApiString());
            if (reason != null)
                parameters.Add("reason", reason.ToApiString());
            if (comment != null)
                parameters.Add("comment", comment.ToApiString());
            if (searchQuery != null)
                parameters.Add("search_query", searchQuery.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("video.report", parameters);
        }

        ///<summary>
        /// Reports (submits a complaint about) a comment on a video.
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
            return _vkontakte.RequestAsync<BaseOkResponse>("video.reportComment", parameters);
        }

        ///<summary>
        /// Restores a previously deleted video.
        ///</summary>
        public Task<BaseOkResponse> Restore(int? videoId = null, int? ownerId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (videoId != null)
                parameters.Add("video_id", videoId.ToApiString());
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("video.restore", parameters);
        }

        ///<summary>
        /// Restores a previously deleted comment on a video.
        ///</summary>
        public Task<int> RestoreComment(int? ownerId = null, int? commentId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (commentId != null)
                parameters.Add("comment_id", commentId.ToApiString());
            return _vkontakte.RequestAsync<int>("video.restoreComment", parameters);
        }

        ///<summary>
        /// Returns a server address (required for upload) and video data.
        ///</summary>
        public Task<VideoSaveResult> Save(String name = null, String description = null, Boolean? isPrivate = null, Boolean? wallpost = null, String link = null, int? groupId = null, int? albumId = null, String[] privacyView = null, String[] privacyComment = null, Boolean? noComments = null, Boolean? repeat = null, Boolean? compression = null)
        {
            var parameters = new Dictionary<string, string>();
            if (name != null)
                parameters.Add("name", name.ToApiString());
            if (description != null)
                parameters.Add("description", description.ToApiString());
            if (isPrivate != null)
                parameters.Add("is_private", isPrivate.ToApiString());
            if (wallpost != null)
                parameters.Add("wallpost", wallpost.ToApiString());
            if (link != null)
                parameters.Add("link", link.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (albumId != null)
                parameters.Add("album_id", albumId.ToApiString());
            if (privacyView != null)
                parameters.Add("privacy_view", privacyView.ToApiString());
            if (privacyComment != null)
                parameters.Add("privacy_comment", privacyComment.ToApiString());
            if (noComments != null)
                parameters.Add("no_comments", noComments.ToApiString());
            if (repeat != null)
                parameters.Add("repeat", repeat.ToApiString());
            if (compression != null)
                parameters.Add("compression", compression.ToApiString());
            return _vkontakte.RequestAsync<VideoSaveResult>("video.save", parameters);
        }

        ///<summary>
        /// Returns a list of videos under the set search criterion.
        ///</summary>
        public Task<VideoSearchResponse> Search(String q = null, int? sort = null, int? hd = null, Boolean? adult = null, String[] filters = null, Boolean? searchOwn = null, int? offset = null, int? longer = null, int? shorter = null, int? count = null, Boolean? extended = null)
        {
            var parameters = new Dictionary<string, string>();
            if (q != null)
                parameters.Add("q", q.ToApiString());
            if (sort != null)
                parameters.Add("sort", sort.ToApiString());
            if (hd != null)
                parameters.Add("hd", hd.ToApiString());
            if (adult != null)
                parameters.Add("adult", adult.ToApiString());
            if (filters != null)
                parameters.Add("filters", filters.ToApiString());
            if (searchOwn != null)
                parameters.Add("search_own", searchOwn.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (longer != null)
                parameters.Add("longer", longer.ToApiString());
            if (shorter != null)
                parameters.Add("shorter", shorter.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            return _vkontakte.RequestAsync<VideoSearchResponse>("video.search", parameters);
        }
    }
}