using System.Collections.Generic;
using System.Threading.Tasks;
using VkLibrary.Core.Responses.Video;
using VkLibrary.Core.Responses.Wall;
using VkLibrary.Core.Types.Video;

namespace VkLibrary.Core.Methods
{
    /// <summary>
    /// Video API section.
    /// </summary>
    public class Video
    {
        private readonly Vkontakte _vkontakte;
        internal Video(Vkontakte vkontakte) => _vkontakte = vkontakte;

        /// <summary>
        /// Returns detailed information about videos.
        /// Docs: <see href="https://vk.com/dev/video.get">video.get</see>
        /// </summary>
        /// <param name="ownerId">ID of the user or community that owns the video(s).</param>
        /// <param name="videos">
        /// Video IDs, in the following format:; 
        /// "%owner_id%_%media_id%, %owner_id%_%media_id%";
        /// Use a negative value to designate a community ID.; 
        /// Example: "-4363_136089719,13245770_137352259"
        /// </param>
        /// <param name="albumId">ID of the album containing the video(s).</param>
        /// <param name="count">Number of videos to return.</param>
        /// <param name="offset">Offset needed to return a specific subset of videos.</param>
        /// <param name="extended">'1' — to return an extended response with additional fields</param>
        public Task<ApiItemsResponse<VideoFull>> Get(int? ownerId = null, IEnumerable<string> videos = null,
            int? albumId = null, int? count = null, int? offset = null, bool? extended = null)
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

            return _vkontakte.GetAsync<ApiItemsResponse<VideoFull>>("video.get", parameters);
        }

        /// <summary>
        /// Edits information about a video on a user or community page.
        /// Docs: <see href="https://vk.com/dev/video.edit">video.edit</see>
        /// </summary>
        /// <param name="ownerId">ID of the user or community that owns the video.</param>
        /// <param name="videoId">Video ID.</param>
        /// <param name="name">New video title.</param>
        /// <param name="desc">New video description.</param>
        /// <param name="privacyView">
        /// Privacy settings in a special format.; Privacy setting is
        /// available for videos uploaded to own profile by user.
        /// </param>
        /// <param name="privacyComment">Privacy settings for comments in a special format.</param>
        /// <param name="noComments">Disable comments for the group video.</param>
        /// <param name="repeat">'1' — to repeat the playback of the video; '0' — to play the video once;</param>
        public Task<int> Edit(int? ownerId = null, int? videoId = null, string name = null, string desc = null,
            IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null,
            bool? noComments = null, bool? repeat = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (videoId != null)
                parameters.Add("video_id", videoId.ToApiString());
            if (name != null)
                parameters.Add("name", name);
            if (desc != null)
                parameters.Add("desc", desc);
            if (privacyView != null)
                parameters.Add("privacy_view", privacyView.ToApiString());
            if (privacyComment != null)
                parameters.Add("privacy_comment", privacyComment.ToApiString());
            if (noComments != null)
                parameters.Add("no_comments", noComments.ToApiString());
            if (repeat != null)
                parameters.Add("repeat", repeat.ToApiString());

            return _vkontakte.GetAsync<int>("video.edit", parameters);
        }

        /// <summary>
        /// Adds a video to a user or community page.
        /// Docs: <see href="https://vk.com/dev/video.add">video.add</see>
        /// </summary>
        /// <param name="targetId">
        /// identifier of a user or community to add a video to.; Use a negative value to designate a
        /// community ID.
        /// </param>
        /// <param name="videoId">Video ID.</param>
        /// <param name="ownerId">
        /// ID of the user or community that owns the video.; Use a negative value to designate a community
        /// ID.
        /// </param>
        public Task<int> Add(int? targetId = null, int? videoId = null, int? ownerId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (targetId != null)
                parameters.Add("target_id", targetId.ToApiString());
            if (videoId != null)
                parameters.Add("video_id", videoId.ToApiString());
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());

            return _vkontakte.GetAsync<int>("video.add", parameters);
        }

        /// <summary>
        /// Returns a server address (required for upload) and video data.
        /// Docs: <see href="https://vk.com/dev/video.save">video.save</see>
        /// </summary>
        /// <param name="name">Name of the video.</param>
        /// <param name="description">Description of the video.</param>
        /// <param name="isPrivate">
        /// '1' — to designate the video as private (send it via a private message); the video will not
        /// appear on the user's video list and will not be available by ID for other users; '0' — not to designate the video
        /// as private
        /// </param>
        /// <param name="wallpost">
        /// '1' — to post the saved video on a user's wall; '0' — not to post the saved video on a user's
        /// wall
        /// </param>
        /// <param name="link">URL for embedding the video from an external website.</param>
        /// <param name="groupId">ID of the community in which the video will be saved. By default, the current user's page.</param>
        /// <param name="albumId">ID of the album to which the saved video will be added.</param>
        /// <param name="privacyView"></param>
        /// <param name="privacyComment"></param>
        /// <param name="noComments"></param>
        /// <param name="repeat">'1' — to repeat the playback of the video; '0' — to play the video once;</param>
        public Task<SaveResult> Save(string name = null, string description = null, bool? isPrivate = null,
            bool? wallpost = null, string link = null, int? groupId = null, int? albumId = null,
            IEnumerable<string> privacyView = null, IEnumerable<string> privacyComment = null,
            bool? noComments = null, bool? repeat = null)
        {
            var parameters = new Dictionary<string, string>();

            if (name != null)
                parameters.Add("name", name);
            if (description != null)
                parameters.Add("description", description);
            if (isPrivate != null)
                parameters.Add("is_private", isPrivate.ToApiString());
            if (wallpost != null)
                parameters.Add("wallpost", wallpost.ToApiString());
            if (link != null)
                parameters.Add("link", link);
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

            return _vkontakte.GetAsync<SaveResult>("video.save", parameters);
        }

        /// <summary>
        /// Deletes a video from a user or community page.
        /// Docs: <see href="https://vk.com/dev/video.delete">video.delete</see>
        /// </summary>
        /// <param name="videoId">Video ID.</param>
        /// <param name="ownerId">ID of the user or community that owns the video.</param>
        /// <param name="targetId"></param>
        public Task<int> Delete(int? videoId = null, int? ownerId = null, int? targetId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (videoId != null)
                parameters.Add("video_id", videoId.ToApiString());
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (targetId != null)
                parameters.Add("target_id", targetId.ToApiString());

            return _vkontakte.GetAsync<int>("video.delete", parameters);
        }

        /// <summary>
        /// Restores a previously deleted video.
        /// Docs: <see href="https://vk.com/dev/video.restore">video.restore</see>
        /// </summary>
        /// <param name="videoId">Video ID.</param>
        /// <param name="ownerId">ID of the user or community that owns the video.</param>
        public Task<int> Restore(int? videoId = null, int? ownerId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (videoId != null)
                parameters.Add("video_id", videoId.ToApiString());
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());

            return _vkontakte.GetAsync<int>("video.restore", parameters);
        }

        /// <summary>
        /// Returns a list of videos under the set search criterion.
        /// Docs: <see href="https://vk.com/dev/video.search">video.search</see>
        /// </summary>
        /// <param name="q">Search query string (e.g., 'The Beatles').</param>
        /// <param name="sort">Sort order:; '1' — by duration; '2' — by relevance; '0' — by date added</param>
        /// <param name="hd">If not null, only searches for high-definition videos.</param>
        /// <param name="adult">'1' — to disable the Safe Search filter; '0' — to enable the Safe Search filter</param>
        /// <param name="filters">
        /// Filters to apply:; 'youtube' — return YouTube videos only; 'vimeo' — return Vimeo videos only;
        /// 'short' — return short videos only; 'long' — return long videos only
        /// </param>
        /// <param name="searchOwn"></param>
        /// <param name="offset">Offset needed to return a specific subset of videos.</param>
        /// <param name="longer"></param>
        /// <param name="shorter"></param>
        /// <param name="count">Number of videos to return.</param>
        /// <param name="extended"></param>
        public Task<ApiItemsResponse<Types.Video.Video>> Search(string q = null, int? sort = null, int? hd = null,
            bool? adult = null, IEnumerable<string> filters = null, bool? searchOwn = null, int? offset = null,
            int? longer = null, int? shorter = null, int? count = null, bool? extended = null)
        {
            var parameters = new Dictionary<string, string>();

            if (q != null)
                parameters.Add("q", q);
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

            return _vkontakte.GetAsync<ApiItemsResponse<Types.Video.Video>>("video.search", parameters);
        }

        /// <summary>
        /// Returns list of videos in which the user is tagged.
        /// Docs: <see href="https://vk.com/dev/video.getUserVideos">video.getUserVideos</see>
        /// </summary>
        /// <param name="userId">User ID.</param>
        /// <param name="offset">Offset needed to return a specific subset of videos.</param>
        /// <param name="count">Number of videos to return.</param>
        /// <param name="extended"></param>
        public Task<ApiItemsResponse<Types.Video.Video>> GetUserVideos(int? userId = null, int? offset = null,
            int? count = null, bool? extended = null)
        {
            var parameters = new Dictionary<string, string>();

            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());

            return _vkontakte.GetAsync<ApiItemsResponse<Types.Video.Video>>("video.getUserVideos", parameters);
        }

        /// <summary>
        /// Returns a list of video albums owned by a user or community.
        /// Docs: <see href="https://vk.com/dev/video.getAlbums">video.getAlbums</see>
        /// </summary>
        /// <param name="ownerId">ID of the user or community that owns the video album(s).</param>
        /// <param name="offset">Offset needed to return a specific subset of video albums.</param>
        /// <param name="count">Number of video albums to return.</param>
        /// <param name="extended">'1' — to return additional information about album privacy settings for the current user</param>
        public Task<ApiItemsResponse<VideoAlbumFull>> GetAlbums(int? ownerId = null, int? offset = null,
            int? count = null, bool? extended = null)
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

            return _vkontakte.GetAsync<ApiItemsResponse<VideoAlbumFull>>("video.getAlbums", parameters);
        }

        /// <summary>
        /// Returns video album info
        /// Docs: <see href="https://vk.com/dev/video.getAlbumById">video.getAlbumById</see>
        /// </summary>
        /// <param name="ownerId">
        /// identifier of a user or community to add a video to. ; Use a negative value to designate a
        /// community ID.
        /// </param>
        /// <param name="albumId">Album ID.</param>
        public Task<VideoAlbumFull> GetAlbumById(int? ownerId = null, int? albumId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (albumId != null)
                parameters.Add("album_id", albumId.ToApiString());

            return _vkontakte.GetAsync<VideoAlbumFull>("video.getAlbumById", parameters);
        }

        /// <summary>
        /// Creates an empty album for videos.
        /// Docs: <see href="https://vk.com/dev/video.addAlbum">video.addAlbum</see>
        /// </summary>
        /// <param name="groupId">Community ID (if the album will be created in a community).</param>
        /// <param name="title">Album title.</param>
        /// <param name="privacy">
        /// new access permissions for the album.; Possible values: ; *'0' – all users;; *'1' – friends
        /// only;; *'2' – friends and friends of friends;; *'3' – "only me".
        /// </param>
        public Task<AddAlbumResponse> AddAlbum(int? groupId = null, string title = null,
            IEnumerable<string> privacy = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (title != null)
                parameters.Add("title", title);
            if (privacy != null)
                parameters.Add("privacy", privacy.ToApiString());

            return _vkontakte.GetAsync<AddAlbumResponse>("video.addAlbum", parameters);
        }

        /// <summary>
        /// Edits the title of a video album.
        /// Docs: <see href="https://vk.com/dev/video.editAlbum">video.editAlbum</see>
        /// </summary>
        /// <param name="groupId">Community ID (if the album edited is owned by a community).</param>
        /// <param name="albumId">Album ID.</param>
        /// <param name="title">New album title.</param>
        /// <param name="privacy">
        /// new access permissions for the album.; Possible values: ; *'0' – all users;; *'1' – friends
        /// only;; *'2' – friends and friends of friends;; *'3' – "only me".
        /// </param>
        public Task<int> EditAlbum(int? groupId = null, int? albumId = null, string title = null,
            IEnumerable<string> privacy = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (albumId != null)
                parameters.Add("album_id", albumId.ToApiString());
            if (title != null)
                parameters.Add("title", title);
            if (privacy != null)
                parameters.Add("privacy", privacy.ToApiString());

            return _vkontakte.GetAsync<int>("video.editAlbum", parameters);
        }

        /// <summary>
        /// Deletes a video album.
        /// Docs: <see href="https://vk.com/dev/video.deleteAlbum">video.deleteAlbum</see>
        /// </summary>
        /// <param name="groupId">Community ID (if the album is owned by a community).</param>
        /// <param name="albumId">Album ID.</param>
        public Task<int> DeleteAlbum(int? groupId = null, int? albumId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (albumId != null)
                parameters.Add("album_id", albumId.ToApiString());

            return _vkontakte.GetAsync<int>("video.deleteAlbum", parameters);
        }

        /// <summary>
        /// Reorders the album in the list of user video albums.
        /// Docs: <see href="https://vk.com/dev/video.reorderAlbums">video.reorderAlbums</see>
        /// </summary>
        /// <param name="ownerId">ID of the user or community that owns the albums..</param>
        /// <param name="albumId">Album ID.</param>
        /// <param name="before">ID of the album before which the album in question shall be placed.</param>
        /// <param name="after">ID of the album after which the album in question shall be placed.</param>
        public Task<int> ReorderAlbums(int? ownerId = null, int? albumId = null, int? before = null,
            int? after = null)
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

            return _vkontakte.GetAsync<int>("video.reorderAlbums", parameters);
        }

        /// <summary>
        /// Reorders the video in the video album.
        /// Docs: <see href="https://vk.com/dev/video.reorderVideos">video.reorderVideos</see>
        /// </summary>
        /// <param name="targetId">ID of the user or community that owns the album with videos.</param>
        /// <param name="albumId">ID of the video album.</param>
        /// <param name="ownerId">ID of the user or community that owns the video.</param>
        /// <param name="videoId">ID of the video.</param>
        /// <param name="beforeOwnerId">
        /// ID of the user or community that owns the video before which the video in question shall
        /// be placed.
        /// </param>
        /// <param name="beforeVideoId">ID of the video before which the video in question shall be placed.</param>
        /// <param name="afterOwnerId">
        /// ID of the user or community that owns the video after which the photo in question shall be
        /// placed.
        /// </param>
        /// <param name="afterVideoId">ID of the video after which the photo in question shall be placed.</param>
        public Task<int> ReorderVideos(int? targetId = null, int? albumId = null, int? ownerId = null,
            int? videoId = null, int? beforeOwnerId = null, int? beforeVideoId = null, int? afterOwnerId = null,
            int? afterVideoId = null)
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

            return _vkontakte.GetAsync<int>("video.reorderVideos", parameters);
        }

        /// <summary>
        /// Docs: <see href="https://vk.com/dev/video.addToAlbum">video.addToAlbum</see>
        /// </summary>
        /// <param name="targetId"></param>
        /// <param name="albumId"></param>
        /// <param name="albumIds"></param>
        /// <param name="ownerId"></param>
        /// <param name="videoId"></param>
        public Task<int> AddToAlbum(int? targetId = null, int? albumId = null,
            IEnumerable<int?> albumIds = null, int? ownerId = null, int? videoId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (targetId != null)
                parameters.Add("target_id", targetId.ToApiString());
            if (albumId != null)
                parameters.Add("album_id", albumId.ToApiString());
            if (albumIds != null)
                parameters.Add("album_ids", albumIds.ToApiString());
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (videoId != null)
                parameters.Add("video_id", videoId.ToApiString());

            return _vkontakte.GetAsync<int>("video.addToAlbum", parameters);
        }

        /// <summary>
        /// Docs: <see href="https://vk.com/dev/video.removeFromAlbum">video.removeFromAlbum</see>
        /// </summary>
        /// <param name="targetId"></param>
        /// <param name="albumId"></param>
        /// <param name="albumIds"></param>
        /// <param name="ownerId"></param>
        /// <param name="videoId"></param>
        public Task<int> RemoveFromAlbum(int? targetId = null, int? albumId = null,
            IEnumerable<int?> albumIds = null, int? ownerId = null, int? videoId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (targetId != null)
                parameters.Add("target_id", targetId.ToApiString());
            if (albumId != null)
                parameters.Add("album_id", albumId.ToApiString());
            if (albumIds != null)
                parameters.Add("album_ids", albumIds.ToApiString());
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (videoId != null)
                parameters.Add("video_id", videoId.ToApiString());

            return _vkontakte.GetAsync<int>("video.removeFromAlbum", parameters);
        }

        /// <summary>
        /// Docs: <see href="https://vk.com/dev/video.getAlbumsByVideo">video.getAlbumsByVideo</see>
        /// </summary>
        /// <param name="targetId"></param>
        /// <param name="ownerId"></param>
        /// <param name="videoId"></param>
        /// <param name="extended"></param>
        public Task<IEnumerable<int?>> GetAlbumsByVideo(int? targetId = null, int? ownerId = null,
            int? videoId = null, bool? extended = null)
        {
            var parameters = new Dictionary<string, string>();

            if (targetId != null)
                parameters.Add("target_id", targetId.ToApiString());
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (videoId != null)
                parameters.Add("video_id", videoId.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());

            return _vkontakte.GetAsync<IEnumerable<int?>>("video.getAlbumsByVideo", parameters);
        }

        /// <summary>
        /// Returns a list of comments on a video.
        /// Docs: <see href="https://vk.com/dev/video.getComments">video.getComments</see>
        /// </summary>
        /// <param name="ownerId">ID of the user or community that owns the video.</param>
        /// <param name="videoId">Video ID.</param>
        /// <param name="needLikes">'1' — to return an additional 'likes' field</param>
        /// <param name="startCommentId"></param>
        /// <param name="offset">Offset needed to return a specific subset of comments.</param>
        /// <param name="count">Number of comments to return.</param>
        /// <param name="sort">Sort order:; 'asc' — oldest comment first; 'desc' — newest comment first</param>
        /// <param name="extended"></param>
        public Task<CommentsResponse> GetComments(int? ownerId = null, int? videoId = null,
            bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null,
            string sort = null, bool? extended = null)
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
                parameters.Add("sort", sort);
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());

            return _vkontakte.GetAsync<CommentsResponse>("video.getComments", parameters);
        }

        /// <summary>
        /// Adds a new comment on a video.
        /// Docs: <see href="https://vk.com/dev/video.createComment">video.createComment</see>
        /// </summary>
        /// <param name="ownerId">ID of the user or community that owns the video.</param>
        /// <param name="videoId">Video ID.</param>
        /// <param name="message">New comment text.</param>
        /// <param name="attachments">
        /// (Required if 'message' is not set.) List of objects attached to the post, in the following format:; 
        /// "%owner_id%_%media_id%, %owner_id%_%media_id%"; 
        /// '' — Type of media attachment:; 
        /// 'photo' — photo; 
        /// 'video' — video; 
        /// 'audio' — audio; 
        /// 'doc' — document; 
        /// '%owner_id%' — Media attachment owner ID.; 
        /// '%media_id%' — Media attachment ID.;
        /// Example:; "photo100172_166443618,photo66748_265827614"
        /// </param>
        /// <param name="fromGroup">
        /// '1' — to post the comment from a community name (only if 'owner_id' is larger than 0)</param>
        /// <param name="replyToComment"></param>
        /// <param name="stickerId"></param>
        /// <param name="guid"></param>
        public Task<int?> CreateComment(int? ownerId = null, int? videoId = null, string message = null,
            IEnumerable<string> attachments = null, bool? fromGroup = null, int? replyToComment = null,
            int? stickerId = null, string guid = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (videoId != null)
                parameters.Add("video_id", videoId.ToApiString());
            if (message != null)
                parameters.Add("message", message);
            if (attachments != null)
                parameters.Add("attachments", attachments.ToApiString());
            if (fromGroup != null)
                parameters.Add("from_group", fromGroup.ToApiString());
            if (replyToComment != null)
                parameters.Add("reply_to_comment", replyToComment.ToApiString());
            if (stickerId != null)
                parameters.Add("sticker_id", stickerId.ToApiString());
            if (guid != null)
                parameters.Add("guid", guid);

            return _vkontakte.GetAsync<int?>("video.createComment", parameters);
        }

        /// <summary>
        /// Deletes a comment on a video.
        /// Docs: <see href="https://vk.com/dev/video.deleteComment">video.deleteComment</see>
        /// </summary>
        /// <param name="ownerId">ID of the user or community that owns the video.</param>
        /// <param name="commentId">ID of the comment to be deleted.</param>
        public Task<int> DeleteComment(int? ownerId = null, int? commentId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (commentId != null)
                parameters.Add("comment_id", commentId.ToApiString());

            return _vkontakte.GetAsync<int>("video.deleteComment", parameters);
        }

        /// <summary>
        /// Restores a previously deleted comment on a video.
        /// Docs: <see href="https://vk.com/dev/video.restoreComment">video.restoreComment</see>
        /// </summary>
        /// <param name="ownerId">ID of the user or community that owns the video.</param>
        /// <param name="commentId">ID of the deleted comment.</param>
        public Task<int> RestoreComment(int? ownerId = null, int? commentId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (commentId != null)
                parameters.Add("comment_id", commentId.ToApiString());

            return _vkontakte.GetAsync<int>("video.restoreComment", parameters);
        }

        /// <summary>
        /// Edits the text of a comment on a video.
        /// Docs: <see href="https://vk.com/dev/video.editComment">video.editComment</see>
        /// </summary>
        /// <param name="ownerId">ID of the user or community that owns the video.</param>
        /// <param name="commentId">Comment ID.</param>
        /// <param name="message">New comment text.</param>
        /// <param name="attachments">
        /// (Required if 'message' is not set.) List of objects attached to the post, in the following format:; 
        /// "%owner_id%_%media_id%, %owner_id%_%media_id%"; 
        /// '' — Type of media attachment:; 
        /// 'photo' — photo; 
        /// 'video' — video; 
        /// 'audio' — audio; 
        /// 'doc' — document; 
        /// '%owner_id%' — Media attachment owner ID.; 
        /// '%media_id%' — Media attachment ID.;
        /// Example:; "photo100172_166443618,photo66748_265827614"
        /// </param>
        public Task<int> EditComment(int? ownerId = null, int? commentId = null, string message = null,
            IEnumerable<string> attachments = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (commentId != null)
                parameters.Add("comment_id", commentId.ToApiString());
            if (message != null)
                parameters.Add("message", message);
            if (attachments != null)
                parameters.Add("attachments", attachments.ToApiString());

            return _vkontakte.GetAsync<int>("video.editComment", parameters);
        }

        /// <summary>
        /// Returns a list of tags on a video.
        /// Docs: <see href="https://vk.com/dev/video.getTags">video.getTags</see>
        /// </summary>
        /// <param name="ownerId">ID of the user or community that owns the video.</param>
        /// <param name="videoId">Video ID.</param>
        public Task<IEnumerable<VideoTag>> GetTags(int? ownerId = null, int? videoId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (videoId != null)
                parameters.Add("video_id", videoId.ToApiString());

            return _vkontakte.GetAsync<IEnumerable<VideoTag>>("video.getTags", parameters);
        }

        /// <summary>
        /// Adds a tag on a video.
        /// Docs: <see href="https://vk.com/dev/video.putTag">video.putTag</see>
        /// </summary>
        /// <param name="userId">ID of the user to be tagged.</param>
        /// <param name="ownerId">ID of the user or community that owns the video.</param>
        /// <param name="videoId">Video ID.</param>
        /// <param name="taggedName">Tag text.</param>
        public Task<int?> PutTag(int? userId = null, int? ownerId = null, int? videoId = null,
            string taggedName = null)
        {
            var parameters = new Dictionary<string, string>();

            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (videoId != null)
                parameters.Add("video_id", videoId.ToApiString());
            if (taggedName != null)
                parameters.Add("tagged_name", taggedName);

            return _vkontakte.GetAsync<int?>("video.putTag", parameters);
        }

        /// <summary>
        /// Removes a tag from a video.
        /// Docs: <see href="https://vk.com/dev/video.removeTag">video.removeTag</see>
        /// </summary>
        /// <param name="tagId">Tag ID.</param>
        /// <param name="ownerId">ID of the user or community that owns the video.</param>
        /// <param name="videoId">Video ID.</param>
        public Task<int> RemoveTag(int? tagId = null, int? ownerId = null, int? videoId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (tagId != null)
                parameters.Add("tag_id", tagId.ToApiString());
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (videoId != null)
                parameters.Add("video_id", videoId.ToApiString());

            return _vkontakte.GetAsync<int>("video.removeTag", parameters);
        }

        /// <summary>
        /// Returns a list of videos with tags that have not been viewed.
        /// Docs: <see href="https://vk.com/dev/video.getNewTags">video.getNewTags</see>
        /// </summary>
        /// <param name="offset">Offset needed to return a specific subset of videos.</param>
        /// <param name="count">Number of videos to return.</param>
        public Task<ApiItemsResponse<VideoTagInfo>> GetNewTags(int? offset = null, int? count = null)
        {
            var parameters = new Dictionary<string, string>();

            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());

            return _vkontakte.GetAsync<ApiItemsResponse<VideoTagInfo>>("video.getNewTags", parameters);
        }

        /// <summary>
        /// Reports (submits a complaint about) a video.
        /// Docs: <see href="https://vk.com/dev/video.report">video.report</see>
        /// </summary>
        /// <param name="ownerId">ID of the user or community that owns the video.</param>
        /// <param name="videoId">Video ID.</param>
        /// <param name="reason">
        /// Reason for the complaint:; '0' – spam; '1' – child pornography; '2' – extremism; '3' – violence;
        /// '4' – drug propaganda; '5' – adult material; '6' – insult; abuse
        /// </param>
        /// <param name="comment">Comment describing the complaint.</param>
        /// <param name="searchQuery">(If the video was found in search results.) Search query string.</param>
        public Task<int> Report(int? ownerId = null, int? videoId = null, int? reason = null,
            string comment = null, string searchQuery = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (videoId != null)
                parameters.Add("video_id", videoId.ToApiString());
            if (reason != null)
                parameters.Add("reason", reason.ToApiString());
            if (comment != null)
                parameters.Add("comment", comment);
            if (searchQuery != null)
                parameters.Add("search_query", searchQuery);

            return _vkontakte.GetAsync<int>("video.report", parameters);
        }

        /// <summary>
        /// Reports (submits a complaint about) a comment on a video.;
        /// Docs: <see href="https://vk.com/dev/video.reportComment">video.reportComment</see>
        /// </summary>
        /// <param name="ownerId">ID of the user or community that owns the video.</param>
        /// <param name="commentId">ID of the comment being reported.</param>
        /// <param name="reason">
        /// Reason for the complaint: ; 0 – spam ; 1 – child pornography ; 2 – extremism ; 3 – violence ; 4 –
        /// drug propaganda ; 5 – adult material ; 6 – insult; abuse
        /// </param>
        public Task<int> ReportComment(int? ownerId = null, int? commentId = null, int? reason = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (commentId != null)
                parameters.Add("comment_id", commentId.ToApiString());
            if (reason != null)
                parameters.Add("reason", reason.ToApiString());

            return _vkontakte.GetAsync<int>("video.reportComment", parameters);
        }

        /// <summary>
        /// Returns video catalog
        /// Docs: <see href="https://vk.com/dev/video.getCatalog">video.getCatalog</see>
        /// </summary>
        /// <param name="count">number of catalog blocks to return.</param>
        /// <param name="itemsCount">number of videos in each block.</param>
        /// <param name="from">
        /// parameter for requesting the next results page. Value for transmitting here is returned in the
        /// 'next' field in a reply.
        /// </param>
        /// <param name="filters">list of requested catalog sections</param>
        /// <param name="extended">1 – return additional infor about users and communities in profiles and groups fields.</param>
        public Task<ApiItemsResponse<CatBlock>> GetCatalog(int? count = null, int? itemsCount = null,
            string from = null, IEnumerable<string> filters = null, bool? extended = null)
        {
            var parameters = new Dictionary<string, string>();

            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (itemsCount != null)
                parameters.Add("items_count", itemsCount.ToApiString());
            if (from != null)
                parameters.Add("from", from);
            if (filters != null)
                parameters.Add("filters", filters.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());

            return _vkontakte.GetAsync<ApiItemsResponse<CatBlock>>("video.getCatalog", parameters);
        }

        /// <summary>
        /// Returns a separate catalog section
        /// Docs: <see href="https://vk.com/dev/video.getCatalogSection">video.getCatalogSection</see>
        /// </summary>
        /// <param name="sectionId">'id' value returned with a block by the '' method.</param>
        /// <param name="from">'next' value returned with a block by the '' method.</param>
        /// <param name="count">number of blocks to return.</param>
        /// <param name="extended">1 – return additional infor about users and communities in profiles and groups fields.</param>
        public Task<ApiItemsResponse<CatElement>> GetCatalogSection(string sectionId = null, string from = null,
            int? count = null, bool? extended = null)
        {
            var parameters = new Dictionary<string, string>();

            if (sectionId != null)
                parameters.Add("section_id", sectionId);
            if (from != null)
                parameters.Add("from", from);
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());

            return _vkontakte.GetAsync<ApiItemsResponse<CatElement>>("video.getCatalogSection", parameters);
        }

        /// <summary>
        /// Hides a video catalog section from a user.
        /// Docs: <see href="https://vk.com/dev/video.hideCatalogSection">video.hideCatalogSection</see>
        /// </summary>
        /// <param name="sectionId">'id' value returned with a block to hide by the '' method.</param>
        public Task<int> HideCatalogSection(int? sectionId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (sectionId != null)
                parameters.Add("section_id", sectionId.ToApiString());

            return _vkontakte.GetAsync<int>("video.hideCatalogSection", parameters);
        }
    }
}