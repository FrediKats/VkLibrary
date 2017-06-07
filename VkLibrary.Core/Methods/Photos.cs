using System.Collections.Generic;
using System.Threading.Tasks;
using VkLibrary.Core.Responses.Photos;
using VkLibrary.Core.Responses.Wall;
using VkLibrary.Core.Types.Photos;

namespace VkLibrary.Core.Methods
{
    /// <summary>
    /// Photos API section.
    /// </summary>
    public class Photos
    {
        private readonly Vkontakte _vkontakte;
        internal Photos(Vkontakte vkontakte) => _vkontakte = vkontakte;

        /// <summary>
        /// Returns photos given in photo_ids list.
        /// </summary>
        /// <param name="ownerId">Owner's id</param>
        /// <param name="albumId">Aldum id: wall, profile, saved</param>
        /// <param name="photoIds">Photo ids enumerable</param>
        /// <param name="rev">Reverce order or not</param>
        /// <param name="extended">Extended or not</param>
        /// <param name="feedType">photo, photo_tag</param>
        /// <param name="feed">time info</param>
        /// <param name="photoSizes">1 - return photo sizes, 0 - no</param>
        /// <param name="offset">offset info</param>
        /// <param name="count">count info</param>
        public Task<ApiItemsResponse<PhotoFull>> Get(
            int? ownerId = null, string albumId = null, IEnumerable<string> photoIds = null,
            bool? rev = null, bool? extended = null, string feedType = null, int? feed = null,
            bool? photoSizes = null, int? offset = null, int? count = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null) parameters.Add("owner_id", ownerId.ToApiString());
            if (albumId != null) parameters.Add("album_id", albumId.ToApiString());
            if (photoIds != null) parameters.Add("photo_ids", photoIds.ToApiString());
            if (rev != null) parameters.Add("rev", rev.ToApiString());
            if (extended != null) parameters.Add("extended", extended.ToApiString());
            if (feedType != null) parameters.Add("feed_type", feedType.ToApiString());
            if (feed != null) parameters.Add("feed", feed.ToApiString());
            if (photoSizes != null) parameters.Add("photo_sizes", photoSizes.ToApiString());
            if (offset != null) parameters.Add("offset", offset.ToApiString());
            if (count != null) parameters.Add("count", count.ToApiString());

            return _vkontakte.GetAsync<ApiItemsResponse<PhotoFull>>("photos.get", parameters);
        }

        /// <summary>
        /// Returns photos specified in photos enumerable.
        /// </summary>
        /// <param name="photos">Photo ids array</param>
        /// <param name="extended">Should vk return additional fields?</param>
        /// <param name="photoSizes">Return photo sizes or not</param>
        public Task<IEnumerable<PhotoFull>> GetById(
            IEnumerable<string> photos = null, bool? extended = null, bool? photoSizes = null)
        {
            var parameters = new Dictionary<string, string>();

            if (photos != null) parameters.Add("photos", photos.ToApiString());
            if (extended != null) parameters.Add("extended", extended.ToApiString());
            if (photoSizes != null) parameters.Add("photo_sizes", photoSizes.ToApiString());

            return _vkontakte.GetAsync<IEnumerable<PhotoFull>>("photos.getById", parameters);
        }

        /// <summary>
        /// Get chat upload server.
        /// Docs: <see href="https://vk.com/dev/photos.getChatUploadServer">photos.getChatUploadServer</see>
        /// </summary>
        public Task<GetChatUploadServerResponse> GetChatUploadServer(
            int chatId, int? cropX = null, int? cropY = null, int? cropWidth = null)
        {
            var parameters = new Dictionary<string, string>();
            parameters.Add("chat_id", chatId.ToApiString());

            if (cropX != null)
                parameters.Add("crop_x", cropX.ToApiString());
            if (cropY != null)
                parameters.Add("crop_y", cropY.ToApiString());
            if (cropWidth != null)
                parameters.Add("crop_width", cropWidth.ToApiString());

            return _vkontakte.GetAsync<GetChatUploadServerResponse>(
                "photos.getChatUploadServer", parameters);
        }

        /// <summary>
        /// Get messages upload server.
        /// Docs: <see href="https://vk.com/dev/photos.getMessagesUploadServer">photos.getMessagesUploadServer</see>
        /// </summary>
        public Task<GetChatUploadServerResponse> GetMessagesUploadServer()
        {
            var parameters = new Dictionary<string, string>();
            return _vkontakte.GetAsync<GetChatUploadServerResponse>(
                "photos.getMessagesUploadServer", parameters);
        }

        /// <summary>
        /// Gets owner photo upload server.
        /// Docs: <see href="https://vk.com/dev/photos.getOwnerPhotoUploadServer">photos.getOwnerPhotoUploadServer</see>
        /// </summary>
        /// <param name="ownerId">Owner id. Add "-" for groups.</param>
        public Task<GetChatUploadServerResponse> GetOwnerPhotoUploadServer(int ownerId = 0)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != 0)
                parameters.Add("owner_id", ownerId.ToApiString());

            return _vkontakte.GetAsync<GetChatUploadServerResponse>(
                "photos.getOwnerPhotoUploadServer", parameters);
        }

        /// <summary>
        /// Get wall upload server.
        /// Docs: <see href="https://vk.com/dev/photos.getWallUploadServer">photos.getWallUploadServer</see>
        /// </summary>
        /// <param name="groupId">Group id.</param>
        public Task<GetChatUploadServerResponse> GetWallUploadServer(uint groupId)
        {
            var parameters = new Dictionary<string, string>();

            parameters.Add("group_id", groupId.ToApiString());

            return _vkontakte.GetAsync<GetChatUploadServerResponse>(
                "photos.getWallUploadServer", parameters);
        }

        /// <summary>
        /// Get photos upload server.
        /// Docs: <see href="https://vk.com/dev/photos.getUploadServer">photos.getUploadServer</see>
        /// </summary>
        /// <param name="groupId">Group id.</param>
        public Task<GetChatUploadServerResponse> GetUploadServer(uint groupId = 0)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != 0)
                parameters.Add("group_id", groupId.ToApiString());

            return _vkontakte.GetAsync<GetChatUploadServerResponse>(
                "photos.getUploadServer", parameters);
        }

        /// <summary>
        /// Saves photos after successful uploading.
        /// Docs: <see href="https://vk.com/dev/photos.save">photos.save</see>
        /// </summary>
        /// <param name="albumId">ID of the album to save photos to.</param>
        /// <param name="groupId">ID of the community to save photos to.</param>
        /// <param name="server">Parameter returned when photos are uploaded to server.</param>
        /// <param name="photosList">Parameter returned when photos are uploaded to server.</param>
        /// <param name="hash">Parameter returned when photos are uploaded to server.</param>
        /// <param name="latitude">Geographical latitude, in degrees (from '-90' to '90').</param>
        /// <param name="longitude">Geographical longitude, in degrees (from '-180' to '180').</param>
        /// <param name="caption">Text describing the photo. 2048 digits max.</param>
        public Task<IEnumerable<Photo>> Save(
            int? albumId = null, int? groupId = null, int? server = null, string photosList = null,
            string hash = null, uint? latitude = null, uint? longitude = null, string caption = null)
        {
            var parameters = new Dictionary<string, string>();

            if (albumId != null)
                parameters.Add("album_id", albumId.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (server != null)
                parameters.Add("server", server.ToApiString());
            if (photosList != null)
                parameters.Add("photos_list", photosList);
            if (hash != null)
                parameters.Add("hash", hash);
            if (latitude != null)
                parameters.Add("latitude", latitude.ToApiString());
            if (longitude != null)
                parameters.Add("longitude", longitude.ToApiString());
            if (caption != null)
                parameters.Add("caption", caption);

            return _vkontakte.GetAsync<IEnumerable<Photo>>("photos.save", parameters);
        }

        /// <summary>
        /// Allows to copy a photo to the "Saved photos" album
        /// Docs: <see href="https://vk.com/dev/photos.copy">photos.copy</see>
        /// </summary>
        /// <param name="ownerId">photo's owner ID</param>
        /// <param name="photoId">photo ID</param>
        /// <param name="accessKey">for private photos</param>
        public Task<int?> Copy(int? ownerId = null, int? photoId = null, string accessKey = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (photoId != null)
                parameters.Add("photo_id", photoId.ToApiString());
            if (accessKey != null)
                parameters.Add("access_key", accessKey);

            return _vkontakte.GetAsync<int?>("photos.copy", parameters);
        }

        /// <summary>
        /// Edits the caption of a photo.
        /// Docs: <see href="https://vk.com/dev/photos.edit">photos.edit</see>
        /// </summary>
        /// <param name="ownerId">ID of the user or community that owns the photo.</param>
        /// <param name="photoId">Photo ID.</param>
        /// <param name="caption">
        /// New caption for the photo. If this parameter is not set, it is considered to be equal to an empty
        /// string.
        /// </param>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <param name="placeStr"></param>
        /// <param name="foursquareId"></param>
        /// <param name="deletePlace"></param>
        public Task<int> Edit(int? ownerId = null, int? photoId = null, string caption = null,
            uint? latitude = null, uint? longitude = null, string placeStr = null, string foursquareId = null,
            bool? deletePlace = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (photoId != null)
                parameters.Add("photo_id", photoId.ToApiString());
            if (caption != null)
                parameters.Add("caption", caption);
            if (latitude != null)
                parameters.Add("latitude", latitude.ToApiString());
            if (longitude != null)
                parameters.Add("longitude", longitude.ToApiString());
            if (placeStr != null)
                parameters.Add("place_str", placeStr);
            if (foursquareId != null)
                parameters.Add("foursquare_id", foursquareId);
            if (deletePlace != null)
                parameters.Add("delete_place", deletePlace.ToApiString());

            return _vkontakte.GetAsync<int>("photos.edit", parameters);
        }

        /// <summary>
        /// Moves a photo from one album to another.
        /// Docs: <see href="https://vk.com/dev/photos.move">photos.move</see>
        /// </summary>
        /// <param name="ownerId">ID of the user or community that owns the photo.</param>
        /// <param name="targetAlbumId">ID of the album to which the photo will be moved.</param>
        /// <param name="photoId">Photo ID.</param>
        public Task<int> Move(int? ownerId = null, int? targetAlbumId = null, int? photoId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (targetAlbumId != null)
                parameters.Add("target_album_id", targetAlbumId.ToApiString());
            if (photoId != null)
                parameters.Add("photo_id", photoId.ToApiString());

            return _vkontakte.GetAsync<int>("photos.move", parameters);
        }

        /// <summary>
        /// Makes a photo into an album cover.
        /// Docs: <see href="https://vk.com/dev/photos.makeCover">photos.makeCover</see>
        /// </summary>
        /// <param name="ownerId">ID of the user or community that owns the photo.</param>
        /// <param name="photoId">Photo ID.</param>
        /// <param name="albumId">Album ID.</param>
        public Task<int> MakeCover(int? ownerId = null, int? photoId = null, int? albumId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (photoId != null)
                parameters.Add("photo_id", photoId.ToApiString());
            if (albumId != null)
                parameters.Add("album_id", albumId.ToApiString());

            return _vkontakte.GetAsync<int>("photos.makeCover", parameters);
        }

        /// <summary>
        /// Reorders the album in the list of user albums.
        /// Docs: <see href="https://vk.com/dev/photos.reorderAlbums">photos.reorderAlbums</see>
        /// </summary>
        /// <param name="ownerId">ID of the user or community that owns the album.</param>
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

            return _vkontakte.GetAsync<int>("photos.reorderAlbums", parameters);
        }

        /// <summary>
        /// Reorders the photo in the list of photos of the user album.
        /// Docs: <see href="https://vk.com/dev/photos.reorderPhotos">photos.reorderPhotos</see>
        /// </summary>
        /// <param name="ownerId">ID of the user or community that owns the photo.</param>
        /// <param name="photoId">Photo ID.</param>
        /// <param name="before">ID of the photo before which the photo in question shall be placed.</param>
        /// <param name="after">ID of the photo after which the photo in question shall be placed.</param>
        public Task<int> ReorderPhotos(int? ownerId = null, int? photoId = null, int? before = null,
            int? after = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (photoId != null)
                parameters.Add("photo_id", photoId.ToApiString());
            if (before != null)
                parameters.Add("before", before.ToApiString());
            if (after != null)
                parameters.Add("after", after.ToApiString());

            return _vkontakte.GetAsync<int>("photos.reorderPhotos", parameters);
        }

        /// <summary>
        /// Returns a list of photos belonging to a user or community, in reverse chronological order.
        /// Docs: <see href="https://vk.com/dev/photos.getAll">photos.getAll</see>
        /// </summary>
        /// <param name="ownerId">
        /// ID of a user or community that owns the photos.; Use a negative value to designate a community
        /// ID.
        /// </param>
        /// <param name="extended">'1' — to return detailed information about photos</param>
        /// <param name="offset">Offset needed to return a specific subset of photos. By default, '0'.</param>
        /// <param name="count">Number of photos to return.</param>
        /// <param name="photoSizes">'1' – to return image sizes in special format.</param>
        /// <param name="noServiceAlbums">
        /// '1' – to return photos only from standard albums; '0' – to return all photos including
        /// those in service albums, e.g., 'My wall photos' (default)
        /// </param>
        /// <param name="needHidden">'1' – to show information about photos being hidden from the block above the wall.</param>
        /// <param name="skipHidden">
        /// '1' – not to return photos being hidden from the block above the wall. Works only with
        /// owner_id>0, no_service_albums is ignored.
        /// </param>
        public Task<ApiItemsResponse<PhotoXtrRealOffset>> GetAll(int? ownerId = null, bool? extended = null,
            int? offset = null, int? count = null, bool? photoSizes = null, bool? noServiceAlbums = null,
            bool? needHidden = null, bool? skipHidden = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (photoSizes != null)
                parameters.Add("photo_sizes", photoSizes.ToApiString());
            if (noServiceAlbums != null)
                parameters.Add("no_service_albums", noServiceAlbums.ToApiString());
            if (needHidden != null)
                parameters.Add("need_hidden", needHidden.ToApiString());
            if (skipHidden != null)
                parameters.Add("skip_hidden", skipHidden.ToApiString());

            return _vkontakte.GetAsync<ApiItemsResponse<PhotoXtrRealOffset>>("photos.getAll", parameters);
        }

        /// <summary>
        /// Returns a list of photos in which a user is tagged.
        /// Docs: <see href="https://vk.com/dev/photos.getUserPhotos">photos.getUserPhotos</see>
        /// </summary>
        /// <param name="userId">User ID.</param>
        /// <param name="offset">Offset needed to return a specific subset of photos. By default, '0'.</param>
        /// <param name="count">Number of photos to return. Maximum value is 1000.</param>
        /// <param name="extended">'1' — to return an additional 'likes' field; '0' — (default)</param>
        /// <param name="sort">
        /// Sort order:; '1' — by date the tag was added in ascending order; '0' — by date the tag was added in
        /// descending order
        /// </param>
        public Task<ApiItemsResponse<Photo>> GetUserPhotos(int? userId = null, int? offset = null,
            int? count = null, bool? extended = null, string sort = null)
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
            if (sort != null)
                parameters.Add("sort", sort);

            return _vkontakte.GetAsync<ApiItemsResponse<Photo>>("photos.getUserPhotos", parameters);
        }

        /// <summary>
        /// Deletes a photo album belonging to the current user.
        /// Docs: <see href="https://vk.com/dev/photos.deleteAlbum">photos.deleteAlbum</see>
        /// </summary>
        /// <param name="albumId">Album ID.</param>
        /// <param name="groupId">ID of the community that owns the album.</param>
        public Task<int> DeleteAlbum(int? albumId = null, int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (albumId != null)
                parameters.Add("album_id", albumId.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());

            return _vkontakte.GetAsync<int>("photos.deleteAlbum", parameters);
        }

        /// <summary>
        /// Deletes a photo.
        /// Docs: <see href="https://vk.com/dev/photos.delete">photos.delete</see>
        /// </summary>
        /// <param name="ownerId">ID of the user or community that owns the photo.</param>
        /// <param name="photoId">Photo ID.</param>
        public Task<int> Delete(int? ownerId = null, int? photoId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (photoId != null)
                parameters.Add("photo_id", photoId.ToApiString());

            return _vkontakte.GetAsync<int>("photos.delete", parameters);
        }

        /// <summary>
        /// Restores a deleted photo.
        /// Docs: <see href="https://vk.com/dev/photos.restore">photos.restore</see>
        /// </summary>
        /// <param name="ownerId">ID of the user or community that owns the photo.</param>
        /// <param name="photoId">Photo ID.</param>
        public Task<int> Restore(int? ownerId = null, int? photoId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (photoId != null)
                parameters.Add("photo_id", photoId.ToApiString());

            return _vkontakte.GetAsync<int>("photos.restore", parameters);
        }

        /// <summary>
        /// Confirms a tag on a photo.
        /// Docs: <see href="https://vk.com/dev/photos.confirmTag">photos.confirmTag</see>
        /// </summary>
        /// <param name="ownerId">ID of the user or community that owns the photo.</param>
        /// <param name="photoId">Photo ID.</param>
        /// <param name="tagId">Tag ID.</param>
        public Task<int> ConfirmTag(int? ownerId = null, string photoId = null, int? tagId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (photoId != null)
                parameters.Add("photo_id", photoId);
            if (tagId != null)
                parameters.Add("tag_id", tagId.ToApiString());

            return _vkontakte.GetAsync<int>("photos.confirmTag", parameters);
        }

        /// <summary>
        /// Returns a list of comments on a photo.
        /// Docs: <see href="https://vk.com/dev/photos.getComments">photos.getComments</see>
        /// </summary>
        /// <param name="ownerId">ID of the user or community that owns the photo.</param>
        /// <param name="photoId">Photo ID.</param>
        /// <param name="needLikes">'1' — to return an additional 'likes' field; '0' — (default)</param>
        /// <param name="startCommentId"></param>
        /// <param name="offset">Offset needed to return a specific subset of comments. By default, '0'.</param>
        /// <param name="count">Number of comments to return.</param>
        /// <param name="sort">Sort order:; 'asc' — old first; 'desc' — new first</param>
        /// <param name="accessKey"></param>
        /// <param name="extended"></param>
        /// <param name="fields"></param>
        public Task<CommentsResponse> GetComments(int? ownerId = null, int? photoId = null,
            bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null,
            string sort = null, string accessKey = null, bool? extended = null, IEnumerable<string> fields = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (photoId != null)
                parameters.Add("photo_id", photoId.ToApiString());
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
            if (accessKey != null)
                parameters.Add("access_key", accessKey);
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());

            return _vkontakte.GetAsync<CommentsResponse>("photos.getComments", parameters);
        }

        /// <summary>
        /// Returns a list of comments on a specific photo album or all albums of the user sorted in reverse chronological
        /// order.
        /// Docs: <see href="https://vk.com/dev/photos.getAllComments">photos.getAllComments</see>
        /// </summary>
        /// <param name="ownerId">ID of the user or community that owns the album(s).</param>
        /// <param name="albumId">Album ID. If the parameter is not set, comments on all of the user's albums will be returned.</param>
        /// <param name="needLikes">'1' — to return an additional 'likes' field; '0' — (default)</param>
        /// <param name="offset">Offset needed to return a specific subset of comments. By default, '0'.</param>
        /// <param name="count">Number of comments to return. By default, '20'. Maximum value, '100'.</param>
        public Task<ApiItemsResponse<CommentXtrPid>> GetAllComments(int? ownerId = null, int? albumId = null,
            bool? needLikes = null, int? offset = null, int? count = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (albumId != null)
                parameters.Add("album_id", albumId.ToApiString());
            if (needLikes != null)
                parameters.Add("need_likes", needLikes.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());

            return _vkontakte.GetAsync<ApiItemsResponse<CommentXtrPid>>("photos.getAllComments", parameters);
        }

        /// <summary>
        /// Adds a new comment on the photo.
        /// Docs: <see href="https://vk.com/dev/photos.createComment">photos.createComment</see>
        /// </summary>
        /// <param name="ownerId">ID of the user or community that owns the photo.</param>
        /// <param name="photoId">Photo ID.</param>
        /// <param name="message">Comment text.</param>
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
        /// <param name="fromGroup">'1' — to post a comment from the community</param>
        /// <param name="replyToComment"></param>
        /// <param name="stickerId"></param>
        /// <param name="accessKey"></param>
        /// <param name="guid"></param>
        public Task<int?> CreateComment(int? ownerId = null, int? photoId = null, string message = null,
            IEnumerable<string> attachments = null, bool? fromGroup = null, int? replyToComment = null,
            int? stickerId = null, string accessKey = null, string guid = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (photoId != null)
                parameters.Add("photo_id", photoId.ToApiString());
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
            if (accessKey != null)
                parameters.Add("access_key", accessKey);
            if (guid != null)
                parameters.Add("guid", guid);

            return _vkontakte.GetAsync<int?>("photos.createComment", parameters);
        }

        /// <summary>
        /// Deletes a comment on the photo.
        /// Docs: <see href="https://vk.com/dev/photos.deleteComment">photos.deleteComment</see>
        /// </summary>
        /// <param name="ownerId">ID of the user or community that owns the photo.</param>
        /// <param name="commentId">Comment ID.</param>
        public Task<int> DeleteComment(int? ownerId = null, int? commentId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (commentId != null)
                parameters.Add("comment_id", commentId.ToApiString());

            return _vkontakte.GetAsync<int>("photos.deleteComment", parameters);
        }

        /// <summary>
        /// Restores a deleted comment on a photo.
        /// Docs: <see href="https://vk.com/dev/photos.restoreComment">photos.restoreComment</see>
        /// </summary>
        /// <param name="ownerId">ID of the user or community that owns the photo.</param>
        /// <param name="commentId">ID of the deleted comment.</param>
        public Task<int> RestoreComment(int? ownerId = null, int? commentId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (commentId != null)
                parameters.Add("comment_id", commentId.ToApiString());

            return _vkontakte.GetAsync<int>("photos.restoreComment", parameters);
        }

        /// <summary>
        /// Edits a comment on a photo.
        /// Docs: <see href="https://vk.com/dev/photos.editComment">photos.editComment</see>
        /// </summary>
        /// <param name="ownerId">ID of the user or community that owns the photo.</param>
        /// <param name="commentId">Comment ID.</param>
        /// <param name="message">New text of the comment.</param>
        /// <param name="attachments">
        /// (Required if 'message' is not set.) List of objects attached to the post, in the following format:; 
        /// "%owner_id%_%media_id%, %owner_id%_%media_id%"; 
        /// '' — Type of media attachment:; 
        /// 'photo' — photo; 'video' — video; 'audio' — audio; 'doc' — document; 
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

            return _vkontakte.GetAsync<int>("photos.editComment", parameters);
        }

        /// <summary>
        /// Returns a list of tags on a photo.
        /// Docs: <see href="https://vk.com/dev/photos.getTags">photos.getTags</see>
        /// </summary>
        /// <param name="ownerId">ID of the user or community that owns the photo.</param>
        /// <param name="photoId">Photo ID.</param>
        /// <param name="accessKey"></param>
        public Task<IEnumerable<PhotoTag>> GetTags(int? ownerId = null, int? photoId = null,
            string accessKey = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (photoId != null)
                parameters.Add("photo_id", photoId.ToApiString());
            if (accessKey != null)
                parameters.Add("access_key", accessKey);

            return _vkontakte.GetAsync<IEnumerable<PhotoTag>>("photos.getTags", parameters);
        }

        /// <summary>
        /// Adds a tag on the photo.
        /// Docs: <see href="https://vk.com/dev/photos.putTag">photos.putTag</see>
        /// </summary>
        /// <param name="ownerId">ID of the user or community that owns the photo.</param>
        /// <param name="photoId">Photo ID.</param>
        /// <param name="userId">ID of the user to be tagged.</param>
        /// <param name="x">Upper left-corner coordinate of the tagged area (as a percentage of the photo's width).</param>
        /// <param name="y">Upper left-corner coordinate of the tagged area (as a percentage of the photo's height).</param>
        /// <param name="x2">Lower right-corner coordinate of the tagged area (as a percentage of the photo's width).</param>
        /// <param name="y2">Lower right-corner coordinate of the tagged area (as a percentage of the photo's height).</param>
        public Task<int?> PutTag(int? ownerId = null, int? photoId = null, int? userId = null, uint? x = null,
            uint? y = null, uint? x2 = null, uint? y2 = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (photoId != null)
                parameters.Add("photo_id", photoId.ToApiString());
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (x != null)
                parameters.Add("x", x.ToApiString());
            if (y != null)
                parameters.Add("y", y.ToApiString());
            if (x2 != null)
                parameters.Add("x2", x2.ToApiString());
            if (y2 != null)
                parameters.Add("y2", y2.ToApiString());

            return _vkontakte.GetAsync<int?>("photos.putTag", parameters);
        }

        /// <summary>
        /// Removes a tag from a photo.
        /// Docs: <see href="https://vk.com/dev/photos.removeTag">photos.removeTag</see>
        /// </summary>
        /// <param name="ownerId">ID of the user or community that owns the photo.</param>
        /// <param name="photoId">Photo ID.</param>
        /// <param name="tagId">Tag ID.</param>
        public Task<int> RemoveTag(int? ownerId = null, int? photoId = null, int? tagId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (photoId != null)
                parameters.Add("photo_id", photoId.ToApiString());
            if (tagId != null)
                parameters.Add("tag_id", tagId.ToApiString());

            return _vkontakte.GetAsync<int>("photos.removeTag", parameters);
        }

        /// <summary>
        /// Returns a list of photos with tags that have not been viewed.
        /// Docs: <see href="https://vk.com/dev/photos.getNewTags">photos.getNewTags</see>
        /// </summary>
        /// <param name="offset">Offset needed to return a specific subset of photos.</param>
        /// <param name="count">Number of photos to return.</param>
        public Task<ApiItemsResponse<PhotoXtrTagInfo>> GetNewTags(int? offset = null, int? count = null)
        {
            var parameters = new Dictionary<string, string>();

            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());

            return _vkontakte.GetAsync<ApiItemsResponse<PhotoXtrTagInfo>>("photos.getNewTags", parameters);
        }
    }
}