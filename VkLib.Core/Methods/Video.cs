using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkLib.Methods
{
    /// <summary>
    /// Video API section.
    /// </summary>
    public class Video
    {
        private Vkontakte _vkontakte;

        internal Video(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        /// Returns detailed information about videos.
        /// Docs: <see href="https://vk.com/dev/video.get">video.get</see>
        /// </summary>
        /// <param name="owner_id">ID of the user or community that owns the video(s).</param>
        /// <param name="videos">Video IDs, in the following format:; "<owner_id>_<media_id>,<owner_id>_<media_id>"; Use a negative value to designate a community ID.; ; Example:; "-4363_136089719,13245770_137352259"</param>
        /// <param name="album_id">ID of the album containing the video(s).</param>
        /// <param name="count">Number of videos to return.</param>
        /// <param name="offset">Offset needed to return a specific subset of videos.</param>
        /// <param name="extended">'1' — to return an extended response with additional fields</param>
        public async Task<ApiItemsResponse<VkLib.Types.Video.VideoFull>> Get(int? owner_id = null, IEnumerable<string> videos = null, int? album_id = null, int? count = null, int? offset = null, bool? extended = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToApiString());
            if (videos != null)
                parameters.Add("videos", videos.ToApiString());
            if (album_id != null)
                parameters.Add("album_id", album_id.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<VkLib.Types.Video.VideoFull>>("video.get", parameters);
        }

        /// <summary>
        /// Edits information about a video on a user or community page.
        /// Docs: <see href="https://vk.com/dev/video.edit">video.edit</see>
        /// </summary>
        /// <param name="owner_id">ID of the user or community that owns the video.</param>
        /// <param name="video_id">Video ID.</param>
        /// <param name="name">New video title.</param>
        /// <param name="desc">New video description.</param>
        /// <param name="privacy_view">Privacy settings in a [vk.com/dev/privacy_setting|special format].; Privacy setting is available for videos uploaded to own profile by user.</param>
        /// <param name="privacy_comment">Privacy settings for comments in a [vk.com/dev/privacy_setting|special format].</param>
        /// <param name="no_comments">Disable comments for the group video.</param>
        /// <param name="repeat">'1' — to repeat the playback of the video; '0' — to play the video once;</param>
        public async Task<int> Edit(int? owner_id = null, int? video_id = null, string name = null, string desc = null, IEnumerable<string> privacy_view = null, IEnumerable<string> privacy_comment = null, bool? no_comments = null, bool? repeat = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToApiString());
            if (video_id != null)
                parameters.Add("video_id", video_id.ToApiString());
            if (name != null)
                parameters.Add("name", name);
            if (desc != null)
                parameters.Add("desc", desc);
            if (privacy_view != null)
                parameters.Add("privacy_view", privacy_view.ToApiString());
            if (privacy_comment != null)
                parameters.Add("privacy_comment", privacy_comment.ToApiString());
            if (no_comments != null)
                parameters.Add("no_comments", no_comments.ToApiString());
            if (repeat != null)
                parameters.Add("repeat", repeat.ToApiString());

            return await _vkontakte.GetAsync<int>("video.edit", parameters);
        }

        /// <summary>
        /// Adds a video to a user or community page.
        /// Docs: <see href="https://vk.com/dev/video.add">video.add</see>
        /// </summary>
        /// <param name="target_id">identifier of a user or community to add a video to.; Use a negative value to designate a community ID.</param>
        /// <param name="video_id">Video ID.</param>
        /// <param name="owner_id">ID of the user or community that owns the video.; Use a negative value to designate a community ID.</param>
        public async Task<int> Add(int? target_id = null, int? video_id = null, int? owner_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (target_id != null)
                parameters.Add("target_id", target_id.ToApiString());
            if (video_id != null)
                parameters.Add("video_id", video_id.ToApiString());
            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToApiString());

            return await _vkontakte.GetAsync<int>("video.add", parameters);
        }

        /// <summary>
        /// Returns a server address (required for upload) and video data.
        /// Docs: <see href="https://vk.com/dev/video.save">video.save</see>
        /// </summary>
        /// <param name="name">Name of the video.</param>
        /// <param name="description">Description of the video.</param>
        /// <param name="is_private">'1' — to designate the video as private (send it via a private message); the video will not appear on the user's video list and will not be available by ID for other users; '0' — not to designate the video as private</param>
        /// <param name="wallpost">'1' — to post the saved video on a user's wall; '0' — not to post the saved video on a user's wall</param>
        /// <param name="link">URL for embedding the video from an external website.</param>
        /// <param name="group_id">ID of the community in which the video will be saved. By default, the current user's page.</param>
        /// <param name="album_id">ID of the album to which the saved video will be added.</param>
        /// <param name="privacy_view"></param>
        /// <param name="privacy_comment"></param>
        /// <param name="no_comments"></param>
        /// <param name="repeat">'1' — to repeat the playback of the video; '0' — to play the video once;</param>
        public async Task<VkLib.Types.Video.SaveResult> Save(string name = null, string description = null, bool? is_private = null, bool? wallpost = null, string link = null, int? group_id = null, int? album_id = null, IEnumerable<string> privacy_view = null, IEnumerable<string> privacy_comment = null, bool? no_comments = null, bool? repeat = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (name != null)
                parameters.Add("name", name);
            if (description != null)
                parameters.Add("description", description);
            if (is_private != null)
                parameters.Add("is_private", is_private.ToApiString());
            if (wallpost != null)
                parameters.Add("wallpost", wallpost.ToApiString());
            if (link != null)
                parameters.Add("link", link);
            if (group_id != null)
                parameters.Add("group_id", group_id.ToApiString());
            if (album_id != null)
                parameters.Add("album_id", album_id.ToApiString());
            if (privacy_view != null)
                parameters.Add("privacy_view", privacy_view.ToApiString());
            if (privacy_comment != null)
                parameters.Add("privacy_comment", privacy_comment.ToApiString());
            if (no_comments != null)
                parameters.Add("no_comments", no_comments.ToApiString());
            if (repeat != null)
                parameters.Add("repeat", repeat.ToApiString());

            return await _vkontakte.GetAsync<VkLib.Types.Video.SaveResult>("video.save", parameters);
        }

        /// <summary>
        /// Deletes a video from a user or community page.
        /// Docs: <see href="https://vk.com/dev/video.delete">video.delete</see>
        /// </summary>
        /// <param name="video_id">Video ID.</param>
        /// <param name="owner_id">ID of the user or community that owns the video.</param>
        /// <param name="target_id"></param>
        public async Task<int> Delete(int? video_id = null, int? owner_id = null, int? target_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (video_id != null)
                parameters.Add("video_id", video_id.ToApiString());
            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToApiString());
            if (target_id != null)
                parameters.Add("target_id", target_id.ToApiString());

            return await _vkontakte.GetAsync<int>("video.delete", parameters);
        }

        /// <summary>
        /// Restores a previously deleted video.
        /// Docs: <see href="https://vk.com/dev/video.restore">video.restore</see>
        /// </summary>
        /// <param name="video_id">Video ID.</param>
        /// <param name="owner_id">ID of the user or community that owns the video.</param>
        public async Task<int> Restore(int? video_id = null, int? owner_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (video_id != null)
                parameters.Add("video_id", video_id.ToApiString());
            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToApiString());

            return await _vkontakte.GetAsync<int>("video.restore", parameters);
        }

        /// <summary>
        /// Returns a list of videos under the set search criterion.
        /// Docs: <see href="https://vk.com/dev/video.search">video.search</see>
        /// </summary>
        /// <param name="q">Search query string (e.g., 'The Beatles').</param>
        /// <param name="sort">Sort order:; '1' — by duration; '2' — by relevance; '0' — by date added</param>
        /// <param name="hd">If not null, only searches for high-definition videos.</param>
        /// <param name="adult">'1' — to disable the Safe Search filter; '0' — to enable the Safe Search filter</param>
        /// <param name="filters">Filters to apply:; 'youtube' — return YouTube videos only; 'vimeo' — return Vimeo videos only; 'short' — return short videos only; 'long' — return long videos only</param>
        /// <param name="search_own"></param>
        /// <param name="offset">Offset needed to return a specific subset of videos.</param>
        /// <param name="longer"></param>
        /// <param name="shorter"></param>
        /// <param name="count">Number of videos to return.</param>
        /// <param name="extended"></param>
        public async Task<ApiItemsResponse<VkLib.Types.Video.Video>> Search(string q = null, int? sort = null, int? hd = null, bool? adult = null, IEnumerable<string> filters = null, bool? search_own = null, int? offset = null, int? longer = null, int? shorter = null, int? count = null, bool? extended = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

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
            if (search_own != null)
                parameters.Add("search_own", search_own.ToApiString());
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

            return await _vkontakte.GetAsync<ApiItemsResponse<VkLib.Types.Video.Video>>("video.search", parameters);
        }

        /// <summary>
        /// Returns list of videos in which the user is tagged.
        /// Docs: <see href="https://vk.com/dev/video.getUserVideos">video.getUserVideos</see>
        /// </summary>
        /// <param name="user_id">User ID.</param>
        /// <param name="offset">Offset needed to return a specific subset of videos.</param>
        /// <param name="count">Number of videos to return.</param>
        /// <param name="extended"></param>
        public async Task<ApiItemsResponse<VkLib.Types.Video.Video>> GetUserVideos(int? user_id = null, int? offset = null, int? count = null, bool? extended = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (user_id != null)
                parameters.Add("user_id", user_id.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<VkLib.Types.Video.Video>>("video.getUserVideos", parameters);
        }

        /// <summary>
        /// Returns a list of video albums owned by a user or community.
        /// Docs: <see href="https://vk.com/dev/video.getAlbums">video.getAlbums</see>
        /// </summary>
        /// <param name="owner_id">ID of the user or community that owns the video album(s).</param>
        /// <param name="offset">Offset needed to return a specific subset of video albums.</param>
        /// <param name="count">Number of video albums to return.</param>
        /// <param name="extended">'1' — to return additional information about album privacy settings for the current user</param>
        public async Task<ApiItemsResponse<VkLib.Types.Video.VideoAlbumFull>> GetAlbums(int? owner_id = null, int? offset = null, int? count = null, bool? extended = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<VkLib.Types.Video.VideoAlbumFull>>("video.getAlbums", parameters);
        }

        /// <summary>
        /// Returns video album info
        /// Docs: <see href="https://vk.com/dev/video.getAlbumById">video.getAlbumById</see>
        /// </summary>
        /// <param name="owner_id">identifier of a user or community to add a video to. ; Use a negative value to designate a community ID.</param>
        /// <param name="album_id">Album ID.</param>
        public async Task<VkLib.Types.Video.VideoAlbumFull> GetAlbumById(int? owner_id = null, int? album_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToApiString());
            if (album_id != null)
                parameters.Add("album_id", album_id.ToApiString());

            return await _vkontakte.GetAsync<VkLib.Types.Video.VideoAlbumFull>("video.getAlbumById", parameters);
        }

        /// <summary>
        /// Creates an empty album for videos.
        /// Docs: <see href="https://vk.com/dev/video.addAlbum">video.addAlbum</see>
        /// </summary>
        /// <param name="group_id">Community ID (if the album will be created in a community).</param>
        /// <param name="title">Album title.</param>
        /// <param name="privacy">new access permissions for the album.; Possible values: ; *'0' – all users;; *'1' – friends only;; *'2' – friends and friends of friends;; *'3' – "only me".</param>
        public async Task<VkLib.Responses.Video.AddAlbumResponse> AddAlbum(int? group_id = null, string title = null, IEnumerable<string> privacy = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToApiString());
            if (title != null)
                parameters.Add("title", title);
            if (privacy != null)
                parameters.Add("privacy", privacy.ToApiString());

            return await _vkontakte.GetAsync<VkLib.Responses.Video.AddAlbumResponse>("video.addAlbum", parameters);
        }

        /// <summary>
        /// Edits the title of a video album.
        /// Docs: <see href="https://vk.com/dev/video.editAlbum">video.editAlbum</see>
        /// </summary>
        /// <param name="group_id">Community ID (if the album edited is owned by a community).</param>
        /// <param name="album_id">Album ID.</param>
        /// <param name="title">New album title.</param>
        /// <param name="privacy">new access permissions for the album.; Possible values: ; *'0' – all users;; *'1' – friends only;; *'2' – friends and friends of friends;; *'3' – "only me".</param>
        public async Task<int> EditAlbum(int? group_id = null, int? album_id = null, string title = null, IEnumerable<string> privacy = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToApiString());
            if (album_id != null)
                parameters.Add("album_id", album_id.ToApiString());
            if (title != null)
                parameters.Add("title", title);
            if (privacy != null)
                parameters.Add("privacy", privacy.ToApiString());

            return await _vkontakte.GetAsync<int>("video.editAlbum", parameters);
        }

        /// <summary>
        /// Deletes a video album.
        /// Docs: <see href="https://vk.com/dev/video.deleteAlbum">video.deleteAlbum</see>
        /// </summary>
        /// <param name="group_id">Community ID (if the album is owned by a community).</param>
        /// <param name="album_id">Album ID.</param>
        public async Task<int> DeleteAlbum(int? group_id = null, int? album_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToApiString());
            if (album_id != null)
                parameters.Add("album_id", album_id.ToApiString());

            return await _vkontakte.GetAsync<int>("video.deleteAlbum", parameters);
        }

        /// <summary>
        /// Reorders the album in the list of user video albums.
        /// Docs: <see href="https://vk.com/dev/video.reorderAlbums">video.reorderAlbums</see>
        /// </summary>
        /// <param name="owner_id">ID of the user or community that owns the albums..</param>
        /// <param name="album_id">Album ID.</param>
        /// <param name="before">ID of the album before which the album in question shall be placed.</param>
        /// <param name="after">ID of the album after which the album in question shall be placed.</param>
        public async Task<int> ReorderAlbums(int? owner_id = null, int? album_id = null, int? before = null, int? after = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToApiString());
            if (album_id != null)
                parameters.Add("album_id", album_id.ToApiString());
            if (before != null)
                parameters.Add("before", before.ToApiString());
            if (after != null)
                parameters.Add("after", after.ToApiString());

            return await _vkontakte.GetAsync<int>("video.reorderAlbums", parameters);
        }

        /// <summary>
        /// Reorders the video in the video album.
        /// Docs: <see href="https://vk.com/dev/video.reorderVideos">video.reorderVideos</see>
        /// </summary>
        /// <param name="target_id">ID of the user or community that owns the album with videos.</param>
        /// <param name="album_id">ID of the video album.</param>
        /// <param name="owner_id">ID of the user or community that owns the video.</param>
        /// <param name="video_id">ID of the video.</param>
        /// <param name="before_owner_id">ID of the user or community that owns the video before which the video in question shall be placed.</param>
        /// <param name="before_video_id">ID of the video before which the video in question shall be placed.</param>
        /// <param name="after_owner_id">ID of the user or community that owns the video after which the photo in question shall be placed.</param>
        /// <param name="after_video_id">ID of the video after which the photo in question shall be placed.</param>
        public async Task<int> ReorderVideos(int? target_id = null, int? album_id = null, int? owner_id = null, int? video_id = null, int? before_owner_id = null, int? before_video_id = null, int? after_owner_id = null, int? after_video_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (target_id != null)
                parameters.Add("target_id", target_id.ToApiString());
            if (album_id != null)
                parameters.Add("album_id", album_id.ToApiString());
            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToApiString());
            if (video_id != null)
                parameters.Add("video_id", video_id.ToApiString());
            if (before_owner_id != null)
                parameters.Add("before_owner_id", before_owner_id.ToApiString());
            if (before_video_id != null)
                parameters.Add("before_video_id", before_video_id.ToApiString());
            if (after_owner_id != null)
                parameters.Add("after_owner_id", after_owner_id.ToApiString());
            if (after_video_id != null)
                parameters.Add("after_video_id", after_video_id.ToApiString());

            return await _vkontakte.GetAsync<int>("video.reorderVideos", parameters);
        }

        /// <summary>
        /// 
        /// Docs: <see href="https://vk.com/dev/video.addToAlbum">video.addToAlbum</see>
        /// </summary>
        /// <param name="target_id"></param>
        /// <param name="album_id"></param>
        /// <param name="album_ids"></param>
        /// <param name="owner_id"></param>
        /// <param name="video_id"></param>
        public async Task<int> AddToAlbum(int? target_id = null, int? album_id = null, IEnumerable<int?> album_ids = null, int? owner_id = null, int? video_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (target_id != null)
                parameters.Add("target_id", target_id.ToApiString());
            if (album_id != null)
                parameters.Add("album_id", album_id.ToApiString());
            if (album_ids != null)
                parameters.Add("album_ids", album_ids.ToApiString());
            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToApiString());
            if (video_id != null)
                parameters.Add("video_id", video_id.ToApiString());

            return await _vkontakte.GetAsync<int>("video.addToAlbum", parameters);
        }

        /// <summary>
        /// 
        /// Docs: <see href="https://vk.com/dev/video.removeFromAlbum">video.removeFromAlbum</see>
        /// </summary>
        /// <param name="target_id"></param>
        /// <param name="album_id"></param>
        /// <param name="album_ids"></param>
        /// <param name="owner_id"></param>
        /// <param name="video_id"></param>
        public async Task<int> RemoveFromAlbum(int? target_id = null, int? album_id = null, IEnumerable<int?> album_ids = null, int? owner_id = null, int? video_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (target_id != null)
                parameters.Add("target_id", target_id.ToApiString());
            if (album_id != null)
                parameters.Add("album_id", album_id.ToApiString());
            if (album_ids != null)
                parameters.Add("album_ids", album_ids.ToApiString());
            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToApiString());
            if (video_id != null)
                parameters.Add("video_id", video_id.ToApiString());

            return await _vkontakte.GetAsync<int>("video.removeFromAlbum", parameters);
        }

        /// <summary>
        /// 
        /// Docs: <see href="https://vk.com/dev/video.getAlbumsByVideo">video.getAlbumsByVideo</see>
        /// </summary>
        /// <param name="target_id"></param>
        /// <param name="owner_id"></param>
        /// <param name="video_id"></param>
        /// <param name="extended"></param>
        public async Task<IEnumerable<int?>> GetAlbumsByVideo(int? target_id = null, int? owner_id = null, int? video_id = null, bool? extended = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (target_id != null)
                parameters.Add("target_id", target_id.ToApiString());
            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToApiString());
            if (video_id != null)
                parameters.Add("video_id", video_id.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());

            return await _vkontakte.GetAsync<IEnumerable<int?>>("video.getAlbumsByVideo", parameters);
        }

        /// <summary>
        /// Returns a list of comments on a video.
        /// Docs: <see href="https://vk.com/dev/video.getComments">video.getComments</see>
        /// </summary>
        /// <param name="owner_id">ID of the user or community that owns the video.</param>
        /// <param name="video_id">Video ID.</param>
        /// <param name="need_likes">'1' — to return an additional 'likes' field</param>
        /// <param name="start_comment_id"></param>
        /// <param name="offset">Offset needed to return a specific subset of comments.</param>
        /// <param name="count">Number of comments to return.</param>
        /// <param name="sort">Sort order:; 'asc' — oldest comment first; 'desc' — newest comment first</param>
        /// <param name="extended"></param>
        public async Task<VkLib.Responses.Wall.CommentsResponse> GetComments(int? owner_id = null, int? video_id = null, bool? need_likes = null, int? start_comment_id = null, int? offset = null, int? count = null, string sort = null, bool? extended = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToApiString());
            if (video_id != null)
                parameters.Add("video_id", video_id.ToApiString());
            if (need_likes != null)
                parameters.Add("need_likes", need_likes.ToApiString());
            if (start_comment_id != null)
                parameters.Add("start_comment_id", start_comment_id.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (sort != null)
                parameters.Add("sort", sort);
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());

            return await _vkontakte.GetAsync<VkLib.Responses.Wall.CommentsResponse>("video.getComments", parameters);
        }

        /// <summary>
        /// Adds a new comment on a video.
        /// Docs: <see href="https://vk.com/dev/video.createComment">video.createComment</see>
        /// </summary>
        /// <param name="owner_id">ID of the user or community that owns the video.</param>
        /// <param name="video_id">Video ID.</param>
        /// <param name="message">New comment text.</param>
        /// <param name="attachments">List of objects attached to the comment, in the following format:; "<owner_id>_<media_id>,<owner_id>_<media_id>"; '' — Type of media attachment:; 'photo' — photo; 'video' — video; 'audio' — audio; 'doc' — document; '<owner_id>' — ID of the media attachment owner.; '<media_id>' — Media attachment ID. ; ; Example:; "photo100172_166443618,photo66748_265827614"</param>
        /// <param name="from_group">'1' — to post the comment from a community name (only if 'owner_id'<0)</param>
        /// <param name="reply_to_comment"></param>
        /// <param name="sticker_id"></param>
        /// <param name="guid"></param>
        public async Task<int?> CreateComment(int? owner_id = null, int? video_id = null, string message = null, IEnumerable<string> attachments = null, bool? from_group = null, int? reply_to_comment = null, int? sticker_id = null, string guid = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToApiString());
            if (video_id != null)
                parameters.Add("video_id", video_id.ToApiString());
            if (message != null)
                parameters.Add("message", message);
            if (attachments != null)
                parameters.Add("attachments", attachments.ToApiString());
            if (from_group != null)
                parameters.Add("from_group", from_group.ToApiString());
            if (reply_to_comment != null)
                parameters.Add("reply_to_comment", reply_to_comment.ToApiString());
            if (sticker_id != null)
                parameters.Add("sticker_id", sticker_id.ToApiString());
            if (guid != null)
                parameters.Add("guid", guid);

            return await _vkontakte.GetAsync<int?>("video.createComment", parameters);
        }

        /// <summary>
        /// Deletes a comment on a video.
        /// Docs: <see href="https://vk.com/dev/video.deleteComment">video.deleteComment</see>
        /// </summary>
        /// <param name="owner_id">ID of the user or community that owns the video.</param>
        /// <param name="comment_id">ID of the comment to be deleted.</param>
        public async Task<int> DeleteComment(int? owner_id = null, int? comment_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToApiString());
            if (comment_id != null)
                parameters.Add("comment_id", comment_id.ToApiString());

            return await _vkontakte.GetAsync<int>("video.deleteComment", parameters);
        }

        /// <summary>
        /// Restores a previously deleted comment on a video.
        /// Docs: <see href="https://vk.com/dev/video.restoreComment">video.restoreComment</see>
        /// </summary>
        /// <param name="owner_id">ID of the user or community that owns the video.</param>
        /// <param name="comment_id">ID of the deleted comment.</param>
        public async Task<int> RestoreComment(int? owner_id = null, int? comment_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToApiString());
            if (comment_id != null)
                parameters.Add("comment_id", comment_id.ToApiString());

            return await _vkontakte.GetAsync<int>("video.restoreComment", parameters);
        }

        /// <summary>
        /// Edits the text of a comment on a video.
        /// Docs: <see href="https://vk.com/dev/video.editComment">video.editComment</see>
        /// </summary>
        /// <param name="owner_id">ID of the user or community that owns the video.</param>
        /// <param name="comment_id">Comment ID.</param>
        /// <param name="message">New comment text.</param>
        /// <param name="attachments">List of objects attached to the comment, in the following format:; "<owner_id>_<media_id>,<owner_id>_<media_id>"; '' — Type of media attachment:; 'photo' — photo; 'video' — video; 'audio' — audio; 'doc' — document; '<owner_id>' — ID of the media attachment owner.; '<media_id>' — Media attachment ID. ; ; Example:; "photo100172_166443618,photo66748_265827614"</param>
        public async Task<int> EditComment(int? owner_id = null, int? comment_id = null, string message = null, IEnumerable<string> attachments = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToApiString());
            if (comment_id != null)
                parameters.Add("comment_id", comment_id.ToApiString());
            if (message != null)
                parameters.Add("message", message);
            if (attachments != null)
                parameters.Add("attachments", attachments.ToApiString());

            return await _vkontakte.GetAsync<int>("video.editComment", parameters);
        }

        /// <summary>
        /// Returns a list of tags on a video.
        /// Docs: <see href="https://vk.com/dev/video.getTags">video.getTags</see>
        /// </summary>
        /// <param name="owner_id">ID of the user or community that owns the video.</param>
        /// <param name="video_id">Video ID.</param>
        public async Task<IEnumerable<VkLib.Types.Video.VideoTag>> GetTags(int? owner_id = null, int? video_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToApiString());
            if (video_id != null)
                parameters.Add("video_id", video_id.ToApiString());

            return await _vkontakte.GetAsync<IEnumerable<VkLib.Types.Video.VideoTag>>("video.getTags", parameters);
        }

        /// <summary>
        /// Adds a tag on a video.
        /// Docs: <see href="https://vk.com/dev/video.putTag">video.putTag</see>
        /// </summary>
        /// <param name="user_id">ID of the user to be tagged.</param>
        /// <param name="owner_id">ID of the user or community that owns the video.</param>
        /// <param name="video_id">Video ID.</param>
        /// <param name="tagged_name">Tag text.</param>
        public async Task<int?> PutTag(int? user_id = null, int? owner_id = null, int? video_id = null, string tagged_name = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (user_id != null)
                parameters.Add("user_id", user_id.ToApiString());
            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToApiString());
            if (video_id != null)
                parameters.Add("video_id", video_id.ToApiString());
            if (tagged_name != null)
                parameters.Add("tagged_name", tagged_name);

            return await _vkontakte.GetAsync<int?>("video.putTag", parameters);
        }

        /// <summary>
        /// Removes a tag from a video.
        /// Docs: <see href="https://vk.com/dev/video.removeTag">video.removeTag</see>
        /// </summary>
        /// <param name="tag_id">Tag ID.</param>
        /// <param name="owner_id">ID of the user or community that owns the video.</param>
        /// <param name="video_id">Video ID.</param>
        public async Task<int> RemoveTag(int? tag_id = null, int? owner_id = null, int? video_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (tag_id != null)
                parameters.Add("tag_id", tag_id.ToApiString());
            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToApiString());
            if (video_id != null)
                parameters.Add("video_id", video_id.ToApiString());

            return await _vkontakte.GetAsync<int>("video.removeTag", parameters);
        }

        /// <summary>
        /// Returns a list of videos with tags that have not been viewed.
        /// Docs: <see href="https://vk.com/dev/video.getNewTags">video.getNewTags</see>
        /// </summary>
        /// <param name="offset">Offset needed to return a specific subset of videos.</param>
        /// <param name="count">Number of videos to return.</param>
        public async Task<ApiItemsResponse<VkLib.Types.Video.VideoTagInfo>> GetNewTags(int? offset = null, int? count = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<VkLib.Types.Video.VideoTagInfo>>("video.getNewTags", parameters);
        }

        /// <summary>
        /// Reports (submits a complaint about) a video.
        /// Docs: <see href="https://vk.com/dev/video.report">video.report</see>
        /// </summary>
        /// <param name="owner_id">ID of the user or community that owns the video.</param>
        /// <param name="video_id">Video ID.</param>
        /// <param name="reason">Reason for the complaint:; '0' – spam; '1' – child pornography; '2' – extremism; '3' – violence; '4' – drug propaganda; '5' – adult material; '6' – insult; abuse</param>
        /// <param name="comment">Comment describing the complaint.</param>
        /// <param name="search_query">(If the video was found in search results.) Search query string.</param>
        public async Task<int> Report(int? owner_id = null, int? video_id = null, int? reason = null, string comment = null, string search_query = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToApiString());
            if (video_id != null)
                parameters.Add("video_id", video_id.ToApiString());
            if (reason != null)
                parameters.Add("reason", reason.ToApiString());
            if (comment != null)
                parameters.Add("comment", comment);
            if (search_query != null)
                parameters.Add("search_query", search_query);

            return await _vkontakte.GetAsync<int>("video.report", parameters);
        }

        /// <summary>
        /// Reports (submits a complaint about) a comment on a video.;
        /// Docs: <see href="https://vk.com/dev/video.reportComment">video.reportComment</see>
        /// </summary>
        /// <param name="owner_id">ID of the user or community that owns the video.</param>
        /// <param name="comment_id">ID of the comment being reported.</param>
        /// <param name="reason">Reason for the complaint: ; 0 – spam ; 1 – child pornography ; 2 – extremism ; 3 – violence ; 4 – drug propaganda ; 5 – adult material ; 6 – insult; abuse</param>
        public async Task<int> ReportComment(int? owner_id = null, int? comment_id = null, int? reason = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToApiString());
            if (comment_id != null)
                parameters.Add("comment_id", comment_id.ToApiString());
            if (reason != null)
                parameters.Add("reason", reason.ToApiString());

            return await _vkontakte.GetAsync<int>("video.reportComment", parameters);
        }

        /// <summary>
        /// Returns video catalog
        /// Docs: <see href="https://vk.com/dev/video.getCatalog">video.getCatalog</see>
        /// </summary>
        /// <param name="count">number of catalog blocks to return.</param>
        /// <param name="items_count">number of videos in each block.</param>
        /// <param name="from">parameter for requesting the next results page. Value for transmitting here is returned in the 'next' field in a reply.</param>
        /// <param name="filters">list of requested catalog sections</param>
        /// <param name="extended">1 – return additional infor about users and communities in profiles and groups fields.</param>
        public async Task<ApiItemsResponse<VkLib.Types.Video.CatBlock>> GetCatalog(int? count = null, int? items_count = null, string from = null, IEnumerable<string> filters = null, bool? extended = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (items_count != null)
                parameters.Add("items_count", items_count.ToApiString());
            if (from != null)
                parameters.Add("from", from);
            if (filters != null)
                parameters.Add("filters", filters.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<VkLib.Types.Video.CatBlock>>("video.getCatalog", parameters);
        }

        /// <summary>
        /// Returns a separate catalog section
        /// Docs: <see href="https://vk.com/dev/video.getCatalogSection">video.getCatalogSection</see>
        /// </summary>
        /// <param name="section_id">'id' value returned with a block by the '' method.</param>
        /// <param name="from">'next' value returned with a block by the '' method.</param>
        /// <param name="count">number of blocks to return.</param>
        /// <param name="extended">1 – return additional infor about users and communities in profiles and groups fields.</param>
        public async Task<ApiItemsResponse<VkLib.Types.Video.CatElement>> GetCatalogSection(string section_id = null, string from = null, int? count = null, bool? extended = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (section_id != null)
                parameters.Add("section_id", section_id);
            if (from != null)
                parameters.Add("from", from);
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<VkLib.Types.Video.CatElement>>("video.getCatalogSection", parameters);
        }

        /// <summary>
        /// Hides a video catalog section from a user.
        /// Docs: <see href="https://vk.com/dev/video.hideCatalogSection">video.hideCatalogSection</see>
        /// </summary>
        /// <param name="section_id">'id' value returned with a block to hide by the '' method.</param>
        public async Task<int> HideCatalogSection(int? section_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (section_id != null)
                parameters.Add("section_id", section_id.ToApiString());

            return await _vkontakte.GetAsync<int>("video.hideCatalogSection", parameters);
        }

    }
}
