using VkApi.Wrapper.Objects;
using VkApi.Wrapper.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Methods
{
    public class Photos
    {
        private readonly Vkontakte _vkontakte;

        internal Photos(Vkontakte vkontakte) => _vkontakte = vkontakte;

        ///<summary>
        /// Confirms a tag on a photo.
        ///</summary>
        public Task<BaseOkResponse> ConfirmTag(int? ownerId = null, String photoId = null, int? tagId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (photoId != null)
                parameters.Add("photo_id", photoId.ToApiString());
            if (tagId != null)
                parameters.Add("tag_id", tagId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("photos.confirmTag", parameters);
        }

        ///<summary>
        /// Allows to copy a photo to the "Saved photos" album
        ///</summary>
        public Task<int> Copy(int? ownerId = null, int? photoId = null, String accessKey = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (photoId != null)
                parameters.Add("photo_id", photoId.ToApiString());
            if (accessKey != null)
                parameters.Add("access_key", accessKey.ToApiString());
            return _vkontakte.RequestAsync<int>("photos.copy", parameters);
        }

        ///<summary>
        /// Creates an empty photo album.
        ///</summary>
        public Task<PhotosPhotoAlbumFull> CreateAlbum(String title = null, int? groupId = null, String description = null, String[] privacyView = null, String[] privacyComment = null, Boolean? uploadByAdminsOnly = null, Boolean? commentsDisabled = null)
        {
            var parameters = new Dictionary<string, string>();
            if (title != null)
                parameters.Add("title", title.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (description != null)
                parameters.Add("description", description.ToApiString());
            if (privacyView != null)
                parameters.Add("privacy_view", privacyView.ToApiString());
            if (privacyComment != null)
                parameters.Add("privacy_comment", privacyComment.ToApiString());
            if (uploadByAdminsOnly != null)
                parameters.Add("upload_by_admins_only", uploadByAdminsOnly.ToApiString());
            if (commentsDisabled != null)
                parameters.Add("comments_disabled", commentsDisabled.ToApiString());
            return _vkontakte.RequestAsync<PhotosPhotoAlbumFull>("photos.createAlbum", parameters);
        }

        ///<summary>
        /// Adds a new comment on the photo.
        ///</summary>
        public Task<int> CreateComment(int? ownerId = null, int? photoId = null, String message = null, String[] attachments = null, Boolean? fromGroup = null, int? replyToComment = null, int? stickerId = null, String accessKey = null, String guid = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (photoId != null)
                parameters.Add("photo_id", photoId.ToApiString());
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
            if (accessKey != null)
                parameters.Add("access_key", accessKey.ToApiString());
            if (guid != null)
                parameters.Add("guid", guid.ToApiString());
            return _vkontakte.RequestAsync<int>("photos.createComment", parameters);
        }

        ///<summary>
        /// Deletes a photo.
        ///</summary>
        public Task<BaseOkResponse> Delete(int? ownerId = null, int? photoId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (photoId != null)
                parameters.Add("photo_id", photoId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("photos.delete", parameters);
        }

        ///<summary>
        /// Deletes a photo album belonging to the current user.
        ///</summary>
        public Task<BaseOkResponse> DeleteAlbum(int? albumId = null, int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (albumId != null)
                parameters.Add("album_id", albumId.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("photos.deleteAlbum", parameters);
        }

        ///<summary>
        /// Deletes a comment on the photo.
        ///</summary>
        public Task<int> DeleteComment(int? ownerId = null, int? commentId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (commentId != null)
                parameters.Add("comment_id", commentId.ToApiString());
            return _vkontakte.RequestAsync<int>("photos.deleteComment", parameters);
        }

        ///<summary>
        /// Edits the caption of a photo.
        ///</summary>
        public Task<BaseOkResponse> Edit(int? ownerId = null, int? photoId = null, String caption = null, double? latitude = null, double? longitude = null, String placeStr = null, String foursquareId = null, Boolean? deletePlace = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (photoId != null)
                parameters.Add("photo_id", photoId.ToApiString());
            if (caption != null)
                parameters.Add("caption", caption.ToApiString());
            if (latitude != null)
                parameters.Add("latitude", latitude.ToApiString());
            if (longitude != null)
                parameters.Add("longitude", longitude.ToApiString());
            if (placeStr != null)
                parameters.Add("place_str", placeStr.ToApiString());
            if (foursquareId != null)
                parameters.Add("foursquare_id", foursquareId.ToApiString());
            if (deletePlace != null)
                parameters.Add("delete_place", deletePlace.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("photos.edit", parameters);
        }

        ///<summary>
        /// Edits information about a photo album.
        ///</summary>
        public Task<BaseOkResponse> EditAlbum(int? albumId = null, String title = null, String description = null, int? ownerId = null, String[] privacyView = null, String[] privacyComment = null, Boolean? uploadByAdminsOnly = null, Boolean? commentsDisabled = null)
        {
            var parameters = new Dictionary<string, string>();
            if (albumId != null)
                parameters.Add("album_id", albumId.ToApiString());
            if (title != null)
                parameters.Add("title", title.ToApiString());
            if (description != null)
                parameters.Add("description", description.ToApiString());
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (privacyView != null)
                parameters.Add("privacy_view", privacyView.ToApiString());
            if (privacyComment != null)
                parameters.Add("privacy_comment", privacyComment.ToApiString());
            if (uploadByAdminsOnly != null)
                parameters.Add("upload_by_admins_only", uploadByAdminsOnly.ToApiString());
            if (commentsDisabled != null)
                parameters.Add("comments_disabled", commentsDisabled.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("photos.editAlbum", parameters);
        }

        ///<summary>
        /// Edits a comment on a photo.
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
            return _vkontakte.RequestAsync<BaseOkResponse>("photos.editComment", parameters);
        }

        ///<summary>
        /// Returns a list of a user's or community's photos.
        ///</summary>
        public Task<PhotosGetResponse> Get(int? ownerId = null, String albumId = null, String[] photoIds = null, Boolean? rev = null, Boolean? extended = null, String feedType = null, int? feed = null, Boolean? photoSizes = null, int? offset = null, int? count = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (albumId != null)
                parameters.Add("album_id", albumId.ToApiString());
            if (photoIds != null)
                parameters.Add("photo_ids", photoIds.ToApiString());
            if (rev != null)
                parameters.Add("rev", rev.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            if (feedType != null)
                parameters.Add("feed_type", feedType.ToApiString());
            if (feed != null)
                parameters.Add("feed", feed.ToApiString());
            if (photoSizes != null)
                parameters.Add("photo_sizes", photoSizes.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            return _vkontakte.RequestAsync<PhotosGetResponse>("photos.get", parameters);
        }

        ///<summary>
        /// Returns a list of a user's or community's photo albums.
        ///</summary>
        public Task<PhotosGetAlbumsResponse> GetAlbums(int? ownerId = null, int[] albumIds = null, int? offset = null, int? count = null, Boolean? needSystem = null, Boolean? needCovers = null, Boolean? photoSizes = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (albumIds != null)
                parameters.Add("album_ids", albumIds.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (needSystem != null)
                parameters.Add("need_system", needSystem.ToApiString());
            if (needCovers != null)
                parameters.Add("need_covers", needCovers.ToApiString());
            if (photoSizes != null)
                parameters.Add("photo_sizes", photoSizes.ToApiString());
            return _vkontakte.RequestAsync<PhotosGetAlbumsResponse>("photos.getAlbums", parameters);
        }

        ///<summary>
        /// Returns the number of photo albums belonging to a user or community.
        ///</summary>
        public Task<int> GetAlbumsCount(int? userId = null, int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            return _vkontakte.RequestAsync<int>("photos.getAlbumsCount", parameters);
        }

        ///<summary>
        /// Returns a list of photos belonging to a user or community, in reverse chronological order.
        ///</summary>
        public Task<PhotosGetAllResponse> GetAll(int? ownerId = null, Boolean? extended = null, int? offset = null, int? count = null, Boolean? photoSizes = null, Boolean? noServiceAlbums = null, Boolean? needHidden = null, Boolean? skipHidden = null)
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
            return _vkontakte.RequestAsync<PhotosGetAllResponse>("photos.getAll", parameters);
        }

        ///<summary>
        /// Returns a list of comments on a specific photo album or all albums of the user sorted in reverse chronological order.
        ///</summary>
        public Task<PhotosGetAllCommentsResponse> GetAllComments(int? ownerId = null, int? albumId = null, Boolean? needLikes = null, int? offset = null, int? count = null)
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
            return _vkontakte.RequestAsync<PhotosGetAllCommentsResponse>("photos.getAllComments", parameters);
        }

        ///<summary>
        /// Returns information about photos by their IDs.
        ///</summary>
        public Task<PhotosPhoto[]> GetById(String[] photos = null, Boolean? extended = null, Boolean? photoSizes = null)
        {
            var parameters = new Dictionary<string, string>();
            if (photos != null)
                parameters.Add("photos", photos.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            if (photoSizes != null)
                parameters.Add("photo_sizes", photoSizes.ToApiString());
            return _vkontakte.RequestAsync<PhotosPhoto[]>("photos.getById", parameters);
        }

        ///<summary>
        /// Returns an upload link for chat cover pictures.
        ///</summary>
        public Task<BaseUploadServer> GetChatUploadServer(int? chatId = null, int? cropX = null, int? cropY = null, int? cropWidth = null)
        {
            var parameters = new Dictionary<string, string>();
            if (chatId != null)
                parameters.Add("chat_id", chatId.ToApiString());
            if (cropX != null)
                parameters.Add("crop_x", cropX.ToApiString());
            if (cropY != null)
                parameters.Add("crop_y", cropY.ToApiString());
            if (cropWidth != null)
                parameters.Add("crop_width", cropWidth.ToApiString());
            return _vkontakte.RequestAsync<BaseUploadServer>("photos.getChatUploadServer", parameters);
        }

        ///<summary>
        /// Returns a list of comments on a photo.
        ///</summary>
        public Task<PhotosGetCommentsResponse> GetComments(int? ownerId = null, int? photoId = null, Boolean? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, String sort = null, String accessKey = null, Boolean? extended = null, UsersFields[] fields = null)
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
                parameters.Add("sort", sort.ToApiString());
            if (accessKey != null)
                parameters.Add("access_key", accessKey.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            return _vkontakte.RequestAsync<PhotosGetCommentsResponse>("photos.getComments", parameters);
        }

        ///<summary>
        /// Returns the server address for market album photo upload.
        ///</summary>
        public Task<BaseUploadServer> GetMarketAlbumUploadServer(int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            return _vkontakte.RequestAsync<BaseUploadServer>("photos.getMarketAlbumUploadServer", parameters);
        }

        ///<summary>
        /// Returns the server address for market photo upload.
        ///</summary>
        public Task<BaseUploadServer> GetMarketUploadServer(int? groupId = null, Boolean? mainPhoto = null, int? cropX = null, int? cropY = null, int? cropWidth = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (mainPhoto != null)
                parameters.Add("main_photo", mainPhoto.ToApiString());
            if (cropX != null)
                parameters.Add("crop_x", cropX.ToApiString());
            if (cropY != null)
                parameters.Add("crop_y", cropY.ToApiString());
            if (cropWidth != null)
                parameters.Add("crop_width", cropWidth.ToApiString());
            return _vkontakte.RequestAsync<BaseUploadServer>("photos.getMarketUploadServer", parameters);
        }

        ///<summary>
        /// Returns the server address for photo upload in a private message for a user.
        ///</summary>
        public Task<PhotosPhotoUpload> GetMessagesUploadServer(int? peerId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (peerId != null)
                parameters.Add("peer_id", peerId.ToApiString());
            return _vkontakte.RequestAsync<PhotosPhotoUpload>("photos.getMessagesUploadServer", parameters);
        }

        ///<summary>
        /// Returns a list of photos with tags that have not been viewed.
        ///</summary>
        public Task<PhotosGetNewTagsResponse> GetNewTags(int? offset = null, int? count = null)
        {
            var parameters = new Dictionary<string, string>();
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            return _vkontakte.RequestAsync<PhotosGetNewTagsResponse>("photos.getNewTags", parameters);
        }

        ///<summary>
        /// Returns the server address for owner cover upload.
        ///</summary>
        public Task<BaseUploadServer> GetOwnerCoverPhotoUploadServer(int? groupId = null, int? cropX = null, int? cropY = null, int? cropX2 = null, int? cropY2 = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (cropX != null)
                parameters.Add("crop_x", cropX.ToApiString());
            if (cropY != null)
                parameters.Add("crop_y", cropY.ToApiString());
            if (cropX2 != null)
                parameters.Add("crop_x2", cropX2.ToApiString());
            if (cropY2 != null)
                parameters.Add("crop_y2", cropY2.ToApiString());
            return _vkontakte.RequestAsync<BaseUploadServer>("photos.getOwnerCoverPhotoUploadServer", parameters);
        }

        ///<summary>
        /// Returns an upload server address for a profile or community photo.
        ///</summary>
        public Task<BaseUploadServer> GetOwnerPhotoUploadServer(int? ownerId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            return _vkontakte.RequestAsync<BaseUploadServer>("photos.getOwnerPhotoUploadServer", parameters);
        }

        ///<summary>
        /// Returns a list of tags on a photo.
        ///</summary>
        public Task<PhotosPhotoTag[]> GetTags(int? ownerId = null, int? photoId = null, String accessKey = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (photoId != null)
                parameters.Add("photo_id", photoId.ToApiString());
            if (accessKey != null)
                parameters.Add("access_key", accessKey.ToApiString());
            return _vkontakte.RequestAsync<PhotosPhotoTag[]>("photos.getTags", parameters);
        }

        ///<summary>
        /// Returns the server address for photo upload.
        ///</summary>
        public Task<PhotosPhotoUpload> GetUploadServer(int? groupId = null, int? albumId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (albumId != null)
                parameters.Add("album_id", albumId.ToApiString());
            return _vkontakte.RequestAsync<PhotosPhotoUpload>("photos.getUploadServer", parameters);
        }

        ///<summary>
        /// Returns a list of photos in which a user is tagged.
        ///</summary>
        public Task<PhotosGetUserPhotosResponse> GetUserPhotos(int? userId = null, int? offset = null, int? count = null, Boolean? extended = null, String sort = null)
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
                parameters.Add("sort", sort.ToApiString());
            return _vkontakte.RequestAsync<PhotosGetUserPhotosResponse>("photos.getUserPhotos", parameters);
        }

        ///<summary>
        /// Returns the server address for photo upload onto a user's wall.
        ///</summary>
        public Task<PhotosPhotoUpload> GetWallUploadServer(int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            return _vkontakte.RequestAsync<PhotosPhotoUpload>("photos.getWallUploadServer", parameters);
        }

        ///<summary>
        /// Makes a photo into an album cover.
        ///</summary>
        public Task<BaseOkResponse> MakeCover(int? ownerId = null, int? photoId = null, int? albumId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (photoId != null)
                parameters.Add("photo_id", photoId.ToApiString());
            if (albumId != null)
                parameters.Add("album_id", albumId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("photos.makeCover", parameters);
        }

        ///<summary>
        /// Moves a photo from one album to another.
        ///</summary>
        public Task<BaseOkResponse> Move(int? ownerId = null, int? targetAlbumId = null, int? photoId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (targetAlbumId != null)
                parameters.Add("target_album_id", targetAlbumId.ToApiString());
            if (photoId != null)
                parameters.Add("photo_id", photoId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("photos.move", parameters);
        }

        ///<summary>
        /// Adds a tag on the photo.
        ///</summary>
        public Task<int> PutTag(int? ownerId = null, int? photoId = null, int? userId = null, double? x = null, double? y = null, double? x2 = null, double? y2 = null)
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
            return _vkontakte.RequestAsync<int>("photos.putTag", parameters);
        }

        ///<summary>
        /// Removes a tag from a photo.
        ///</summary>
        public Task<BaseOkResponse> RemoveTag(int? ownerId = null, int? photoId = null, int? tagId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (photoId != null)
                parameters.Add("photo_id", photoId.ToApiString());
            if (tagId != null)
                parameters.Add("tag_id", tagId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("photos.removeTag", parameters);
        }

        ///<summary>
        /// Reorders the album in the list of user albums.
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
            return _vkontakte.RequestAsync<BaseOkResponse>("photos.reorderAlbums", parameters);
        }

        ///<summary>
        /// Reorders the photo in the list of photos of the user album.
        ///</summary>
        public Task<BaseOkResponse> ReorderPhotos(int? ownerId = null, int? photoId = null, int? before = null, int? after = null)
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
            return _vkontakte.RequestAsync<BaseOkResponse>("photos.reorderPhotos", parameters);
        }

        ///<summary>
        /// Reports (submits a complaint about) a photo.
        ///</summary>
        public Task<BaseOkResponse> Report(int? ownerId = null, int? photoId = null, int? reason = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (photoId != null)
                parameters.Add("photo_id", photoId.ToApiString());
            if (reason != null)
                parameters.Add("reason", reason.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("photos.report", parameters);
        }

        ///<summary>
        /// Reports (submits a complaint about) a comment on a photo.
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
            return _vkontakte.RequestAsync<BaseOkResponse>("photos.reportComment", parameters);
        }

        ///<summary>
        /// Restores a deleted photo.
        ///</summary>
        public Task<BaseOkResponse> Restore(int? ownerId = null, int? photoId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (photoId != null)
                parameters.Add("photo_id", photoId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("photos.restore", parameters);
        }

        ///<summary>
        /// Restores a deleted comment on a photo.
        ///</summary>
        public Task<int> RestoreComment(int? ownerId = null, int? commentId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (commentId != null)
                parameters.Add("comment_id", commentId.ToApiString());
            return _vkontakte.RequestAsync<int>("photos.restoreComment", parameters);
        }

        ///<summary>
        /// Saves photos after successful uploading.
        ///</summary>
        public Task<PhotosPhoto[]> Save(int? albumId = null, int? groupId = null, int? server = null, String photosList = null, String hash = null, double? latitude = null, double? longitude = null, String caption = null)
        {
            var parameters = new Dictionary<string, string>();
            if (albumId != null)
                parameters.Add("album_id", albumId.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (server != null)
                parameters.Add("server", server.ToApiString());
            if (photosList != null)
                parameters.Add("photos_list", photosList.ToApiString());
            if (hash != null)
                parameters.Add("hash", hash.ToApiString());
            if (latitude != null)
                parameters.Add("latitude", latitude.ToApiString());
            if (longitude != null)
                parameters.Add("longitude", longitude.ToApiString());
            if (caption != null)
                parameters.Add("caption", caption.ToApiString());
            return _vkontakte.RequestAsync<PhotosPhoto[]>("photos.save", parameters);
        }

        ///<summary>
        /// Saves market album photos after successful uploading.
        ///</summary>
        public Task<PhotosPhoto[]> SaveMarketAlbumPhoto(int? groupId = null, String photo = null, int? server = null, String hash = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (photo != null)
                parameters.Add("photo", photo.ToApiString());
            if (server != null)
                parameters.Add("server", server.ToApiString());
            if (hash != null)
                parameters.Add("hash", hash.ToApiString());
            return _vkontakte.RequestAsync<PhotosPhoto[]>("photos.saveMarketAlbumPhoto", parameters);
        }

        ///<summary>
        /// Saves market photos after successful uploading.
        ///</summary>
        public Task<PhotosPhoto[]> SaveMarketPhoto(int? groupId = null, String photo = null, int? server = null, String hash = null, String cropData = null, String cropHash = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (photo != null)
                parameters.Add("photo", photo.ToApiString());
            if (server != null)
                parameters.Add("server", server.ToApiString());
            if (hash != null)
                parameters.Add("hash", hash.ToApiString());
            if (cropData != null)
                parameters.Add("crop_data", cropData.ToApiString());
            if (cropHash != null)
                parameters.Add("crop_hash", cropHash.ToApiString());
            return _vkontakte.RequestAsync<PhotosPhoto[]>("photos.saveMarketPhoto", parameters);
        }

        ///<summary>
        /// Saves a photo after being successfully uploaded. URL obtained with [vk.com/dev/photos.getMessagesUploadServer|photos.getMessagesUploadServer] method.
        ///</summary>
        public Task<PhotosPhoto[]> SaveMessagesPhoto(String photo = null, int? server = null, String hash = null)
        {
            var parameters = new Dictionary<string, string>();
            if (photo != null)
                parameters.Add("photo", photo.ToApiString());
            if (server != null)
                parameters.Add("server", server.ToApiString());
            if (hash != null)
                parameters.Add("hash", hash.ToApiString());
            return _vkontakte.RequestAsync<PhotosPhoto[]>("photos.saveMessagesPhoto", parameters);
        }

        ///<summary>
        /// Saves cover photo after successful uploading.
        ///</summary>
        public Task<BaseImage[]> SaveOwnerCoverPhoto(String hash = null, String photo = null)
        {
            var parameters = new Dictionary<string, string>();
            if (hash != null)
                parameters.Add("hash", hash.ToApiString());
            if (photo != null)
                parameters.Add("photo", photo.ToApiString());
            return _vkontakte.RequestAsync<BaseImage[]>("photos.saveOwnerCoverPhoto", parameters);
        }

        ///<summary>
        /// Saves a profile or community photo. Upload URL can be got with the [vk.com/dev/photos.getOwnerPhotoUploadServer|photos.getOwnerPhotoUploadServer] method.
        ///</summary>
        public Task<PhotosSaveOwnerPhotoResponse> SaveOwnerPhoto(String server = null, String hash = null, String photo = null)
        {
            var parameters = new Dictionary<string, string>();
            if (server != null)
                parameters.Add("server", server.ToApiString());
            if (hash != null)
                parameters.Add("hash", hash.ToApiString());
            if (photo != null)
                parameters.Add("photo", photo.ToApiString());
            return _vkontakte.RequestAsync<PhotosSaveOwnerPhotoResponse>("photos.saveOwnerPhoto", parameters);
        }

        ///<summary>
        /// Saves a photo to a user's or community's wall after being uploaded.
        ///</summary>
        public Task<PhotosPhoto[]> SaveWallPhoto(int? userId = null, int? groupId = null, String photo = null, int? server = null, String hash = null, double? latitude = null, double? longitude = null, String caption = null)
        {
            var parameters = new Dictionary<string, string>();
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (photo != null)
                parameters.Add("photo", photo.ToApiString());
            if (server != null)
                parameters.Add("server", server.ToApiString());
            if (hash != null)
                parameters.Add("hash", hash.ToApiString());
            if (latitude != null)
                parameters.Add("latitude", latitude.ToApiString());
            if (longitude != null)
                parameters.Add("longitude", longitude.ToApiString());
            if (caption != null)
                parameters.Add("caption", caption.ToApiString());
            return _vkontakte.RequestAsync<PhotosPhoto[]>("photos.saveWallPhoto", parameters);
        }

        ///<summary>
        /// Returns a list of photos.
        ///</summary>
        public Task<PhotosSearchResponse> Search(String q = null, double? lat = null, double? @long = null, int? startTime = null, int? endTime = null, int? sort = null, int? offset = null, int? count = null, int? radius = null)
        {
            var parameters = new Dictionary<string, string>();
            if (q != null)
                parameters.Add("q", q.ToApiString());
            if (lat != null)
                parameters.Add("lat", lat.ToApiString());
            if (@long != null)
                parameters.Add("long", @long.ToApiString());
            if (startTime != null)
                parameters.Add("start_time", startTime.ToApiString());
            if (endTime != null)
                parameters.Add("end_time", endTime.ToApiString());
            if (sort != null)
                parameters.Add("sort", sort.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (radius != null)
                parameters.Add("radius", radius.ToApiString());
            return _vkontakte.RequestAsync<PhotosSearchResponse>("photos.search", parameters);
        }
    }
}