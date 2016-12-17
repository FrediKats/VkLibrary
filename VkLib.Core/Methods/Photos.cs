using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkLib.Methods
{
    /// <summary>
    /// Photos API section.
    /// </summary>
    public class Photos
    {
        private Vkontakte _vkontakte;

        internal Photos(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        /// Saves photos after successful uploading.
        /// Docs: <see href="https://vk.com/dev/photos.save">photos.save</see>
        /// </summary>
        /// <param name="album_id">ID of the album to save photos to.</param>
        /// <param name="group_id">ID of the community to save photos to.</param>
        /// <param name="server">Parameter returned when photos are [vk.com/dev/upload_files|uploaded to server].</param>
        /// <param name="photos_list">Parameter returned when photos are [vk.com/dev/upload_files|uploaded to server].</param>
        /// <param name="hash">Parameter returned when photos are [vk.com/dev/upload_files|uploaded to server].</param>
        /// <param name="latitude">Geographical latitude, in degrees (from '-90' to '90').</param>
        /// <param name="longitude">Geographical longitude, in degrees (from '-180' to '180').</param>
        /// <param name="caption">Text describing the photo. 2048 digits max.</param>
        public async Task<object> Save(int? album_id = null, int? group_id = null, int? server = null, string photos_list = null, string hash = null, uint? latitude = null, uint? longitude = null, string caption = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (album_id != null)
                parameters.Add("album_id", album_id.ToString());
            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());
            if (server != null)
                parameters.Add("server", server.ToString());
            if (photos_list != null)
                parameters.Add("photos_list", photos_list);
            if (hash != null)
                parameters.Add("hash", hash);
            if (latitude != null)
                parameters.Add("latitude", latitude.ToString());
            if (longitude != null)
                parameters.Add("longitude", longitude.ToString());
            if (caption != null)
                parameters.Add("caption", caption);

            return await _vkontakte.GetAsync<object>("photos.save", parameters);
        }

        /// <summary>
        /// Allows to copy a photo to the "Saved photos" album
        /// Docs: <see href="https://vk.com/dev/photos.copy">photos.copy</see>
        /// </summary>
        /// <param name="owner_id">photo's owner ID</param>
        /// <param name="photo_id">photo ID</param>
        /// <param name="access_key">for private photos</param>
        public async Task<object> Copy(int? owner_id = null, int? photo_id = null, string access_key = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (photo_id != null)
                parameters.Add("photo_id", photo_id.ToString());
            if (access_key != null)
                parameters.Add("access_key", access_key);

            return await _vkontakte.GetAsync<object>("photos.copy", parameters);
        }

        /// <summary>
        /// Edits the caption of a photo.
        /// Docs: <see href="https://vk.com/dev/photos.edit">photos.edit</see>
        /// </summary>
        /// <param name="owner_id">ID of the user or community that owns the photo.</param>
        /// <param name="photo_id">Photo ID.</param>
        /// <param name="caption">New caption for the photo. If this parameter is not set, it is considered to be equal to an empty string.</param>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <param name="place_str"></param>
        /// <param name="foursquare_id"></param>
        /// <param name="delete_place"></param>
        public async Task<object> Edit(int? owner_id = null, int? photo_id = null, string caption = null, uint? latitude = null, uint? longitude = null, string place_str = null, string foursquare_id = null, bool? delete_place = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (photo_id != null)
                parameters.Add("photo_id", photo_id.ToString());
            if (caption != null)
                parameters.Add("caption", caption);
            if (latitude != null)
                parameters.Add("latitude", latitude.ToString());
            if (longitude != null)
                parameters.Add("longitude", longitude.ToString());
            if (place_str != null)
                parameters.Add("place_str", place_str);
            if (foursquare_id != null)
                parameters.Add("foursquare_id", foursquare_id);
            if (delete_place != null)
                parameters.Add("delete_place", delete_place.ToString());

            return await _vkontakte.GetAsync<object>("photos.edit", parameters);
        }

        /// <summary>
        /// Moves a photo from one album to another.
        /// Docs: <see href="https://vk.com/dev/photos.move">photos.move</see>
        /// </summary>
        /// <param name="owner_id">ID of the user or community that owns the photo.</param>
        /// <param name="target_album_id">ID of the album to which the photo will be moved.</param>
        /// <param name="photo_id">Photo ID.</param>
        public async Task<object> Move(int? owner_id = null, int? target_album_id = null, int? photo_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (target_album_id != null)
                parameters.Add("target_album_id", target_album_id.ToString());
            if (photo_id != null)
                parameters.Add("photo_id", photo_id.ToString());

            return await _vkontakte.GetAsync<object>("photos.move", parameters);
        }

        /// <summary>
        /// Makes a photo into an album cover.
        /// Docs: <see href="https://vk.com/dev/photos.makeCover">photos.makeCover</see>
        /// </summary>
        /// <param name="owner_id">ID of the user or community that owns the photo.</param>
        /// <param name="photo_id">Photo ID.</param>
        /// <param name="album_id">Album ID.</param>
        public async Task<object> MakeCover(int? owner_id = null, int? photo_id = null, int? album_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (photo_id != null)
                parameters.Add("photo_id", photo_id.ToString());
            if (album_id != null)
                parameters.Add("album_id", album_id.ToString());

            return await _vkontakte.GetAsync<object>("photos.makeCover", parameters);
        }

        /// <summary>
        /// Reorders the album in the list of user albums.
        /// Docs: <see href="https://vk.com/dev/photos.reorderAlbums">photos.reorderAlbums</see>
        /// </summary>
        /// <param name="owner_id">ID of the user or community that owns the album.</param>
        /// <param name="album_id">Album ID.</param>
        /// <param name="before">ID of the album before which the album in question shall be placed.</param>
        /// <param name="after">ID of the album after which the album in question shall be placed.</param>
        public async Task<object> ReorderAlbums(int? owner_id = null, int? album_id = null, int? before = null, int? after = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (album_id != null)
                parameters.Add("album_id", album_id.ToString());
            if (before != null)
                parameters.Add("before", before.ToString());
            if (after != null)
                parameters.Add("after", after.ToString());

            return await _vkontakte.GetAsync<object>("photos.reorderAlbums", parameters);
        }

        /// <summary>
        /// Reorders the photo in the list of photos of the user album.
        /// Docs: <see href="https://vk.com/dev/photos.reorderPhotos">photos.reorderPhotos</see>
        /// </summary>
        /// <param name="owner_id">ID of the user or community that owns the photo.</param>
        /// <param name="photo_id">Photo ID.</param>
        /// <param name="before">ID of the photo before which the photo in question shall be placed.</param>
        /// <param name="after">ID of the photo after which the photo in question shall be placed.</param>
        public async Task<object> ReorderPhotos(int? owner_id = null, int? photo_id = null, int? before = null, int? after = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (photo_id != null)
                parameters.Add("photo_id", photo_id.ToString());
            if (before != null)
                parameters.Add("before", before.ToString());
            if (after != null)
                parameters.Add("after", after.ToString());

            return await _vkontakte.GetAsync<object>("photos.reorderPhotos", parameters);
        }

        /// <summary>
        /// Returns a list of photos belonging to a user or community, in reverse chronological order.
        /// Docs: <see href="https://vk.com/dev/photos.getAll">photos.getAll</see>
        /// </summary>
        /// <param name="owner_id">ID of a user or community that owns the photos.; Use a negative value to designate a community ID.</param>
        /// <param name="extended">'1' — to return detailed information about photos</param>
        /// <param name="offset">Offset needed to return a specific subset of photos. By default, '0'.</param>
        /// <param name="count">Number of photos to return.</param>
        /// <param name="photo_sizes">'1' – to return image sizes in [vk.com/dev/photo_sizes|special format].</param>
        /// <param name="no_service_albums">'1' – to return photos only from standard albums; '0' – to return all photos including those in service albums, e.g., 'My wall photos' (default)</param>
        /// <param name="need_hidden">'1' – to show information about photos being hidden from the block above the wall.</param>
        /// <param name="skip_hidden">'1' – not to return photos being hidden from the block above the wall. Works only with owner_id>0, no_service_albums is ignored.</param>
        public async Task<object> GetAll(int? owner_id = null, bool? extended = null, int? offset = null, int? count = null, bool? photo_sizes = null, bool? no_service_albums = null, bool? need_hidden = null, bool? skip_hidden = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (extended != null)
                parameters.Add("extended", extended.ToString());
            if (offset != null)
                parameters.Add("offset", offset.ToString());
            if (count != null)
                parameters.Add("count", count.ToString());
            if (photo_sizes != null)
                parameters.Add("photo_sizes", photo_sizes.ToString());
            if (no_service_albums != null)
                parameters.Add("no_service_albums", no_service_albums.ToString());
            if (need_hidden != null)
                parameters.Add("need_hidden", need_hidden.ToString());
            if (skip_hidden != null)
                parameters.Add("skip_hidden", skip_hidden.ToString());

            return await _vkontakte.GetAsync<object>("photos.getAll", parameters);
        }

        /// <summary>
        /// Returns a list of photos in which a user is tagged.
        /// Docs: <see href="https://vk.com/dev/photos.getUserPhotos">photos.getUserPhotos</see>
        /// </summary>
        /// <param name="user_id">User ID.</param>
        /// <param name="offset">Offset needed to return a specific subset of photos. By default, '0'.</param>
        /// <param name="count">Number of photos to return. Maximum value is 1000.</param>
        /// <param name="extended">'1' — to return an additional 'likes' field; '0' — (default)</param>
        /// <param name="sort">Sort order:; '1' — by date the tag was added in ascending order; '0' — by date the tag was added in descending order</param>
        public async Task<object> GetUserPhotos(int? user_id = null, int? offset = null, int? count = null, bool? extended = null, string sort = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (user_id != null)
                parameters.Add("user_id", user_id.ToString());
            if (offset != null)
                parameters.Add("offset", offset.ToString());
            if (count != null)
                parameters.Add("count", count.ToString());
            if (extended != null)
                parameters.Add("extended", extended.ToString());
            if (sort != null)
                parameters.Add("sort", sort);

            return await _vkontakte.GetAsync<object>("photos.getUserPhotos", parameters);
        }

        /// <summary>
        /// Deletes a photo album belonging to the current user.
        /// Docs: <see href="https://vk.com/dev/photos.deleteAlbum">photos.deleteAlbum</see>
        /// </summary>
        /// <param name="album_id">Album ID.</param>
        /// <param name="group_id">ID of the community that owns the album.</param>
        public async Task<object> DeleteAlbum(int? album_id = null, int? group_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (album_id != null)
                parameters.Add("album_id", album_id.ToString());
            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());

            return await _vkontakte.GetAsync<object>("photos.deleteAlbum", parameters);
        }

        /// <summary>
        /// Deletes a photo.
        /// Docs: <see href="https://vk.com/dev/photos.delete">photos.delete</see>
        /// </summary>
        /// <param name="owner_id">ID of the user or community that owns the photo.</param>
        /// <param name="photo_id">Photo ID.</param>
        public async Task<object> Delete(int? owner_id = null, int? photo_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (photo_id != null)
                parameters.Add("photo_id", photo_id.ToString());

            return await _vkontakte.GetAsync<object>("photos.delete", parameters);
        }

        /// <summary>
        /// Restores a deleted photo.
        /// Docs: <see href="https://vk.com/dev/photos.restore">photos.restore</see>
        /// </summary>
        /// <param name="owner_id">ID of the user or community that owns the photo.</param>
        /// <param name="photo_id">Photo ID.</param>
        public async Task<object> Restore(int? owner_id = null, int? photo_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (photo_id != null)
                parameters.Add("photo_id", photo_id.ToString());

            return await _vkontakte.GetAsync<object>("photos.restore", parameters);
        }

        /// <summary>
        /// Confirms a tag on a photo.
        /// Docs: <see href="https://vk.com/dev/photos.confirmTag">photos.confirmTag</see>
        /// </summary>
        /// <param name="owner_id">ID of the user or community that owns the photo.</param>
        /// <param name="photo_id">Photo ID.</param>
        /// <param name="tag_id">Tag ID.</param>
        public async Task<object> ConfirmTag(int? owner_id = null, string photo_id = null, int? tag_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (photo_id != null)
                parameters.Add("photo_id", photo_id);
            if (tag_id != null)
                parameters.Add("tag_id", tag_id.ToString());

            return await _vkontakte.GetAsync<object>("photos.confirmTag", parameters);
        }

        /// <summary>
        /// Returns a list of comments on a photo.
        /// Docs: <see href="https://vk.com/dev/photos.getComments">photos.getComments</see>
        /// </summary>
        /// <param name="owner_id">ID of the user or community that owns the photo.</param>
        /// <param name="photo_id">Photo ID.</param>
        /// <param name="need_likes">'1' — to return an additional 'likes' field; '0' — (default)</param>
        /// <param name="start_comment_id"></param>
        /// <param name="offset">Offset needed to return a specific subset of comments. By default, '0'.</param>
        /// <param name="count">Number of comments to return.</param>
        /// <param name="sort">Sort order:; 'asc' — old first; 'desc' — new first</param>
        /// <param name="access_key"></param>
        /// <param name="extended"></param>
        /// <param name="fields"></param>
        public async Task<object> GetComments(int? owner_id = null, int? photo_id = null, bool? need_likes = null, int? start_comment_id = null, int? offset = null, int? count = null, string sort = null, string access_key = null, bool? extended = null, IEnumerable<string> fields = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (photo_id != null)
                parameters.Add("photo_id", photo_id.ToString());
            if (need_likes != null)
                parameters.Add("need_likes", need_likes.ToString());
            if (start_comment_id != null)
                parameters.Add("start_comment_id", start_comment_id.ToString());
            if (offset != null)
                parameters.Add("offset", offset.ToString());
            if (count != null)
                parameters.Add("count", count.ToString());
            if (sort != null)
                parameters.Add("sort", sort);
            if (access_key != null)
                parameters.Add("access_key", access_key);
            if (extended != null)
                parameters.Add("extended", extended.ToString());
            if (fields != null)
                parameters.Add("fields", string.Join(",", fields));

            return await _vkontakte.GetAsync<object>("photos.getComments", parameters);
        }

        /// <summary>
        /// Returns a list of comments on a specific photo album or all albums of the user sorted in reverse chronological order.
        /// Docs: <see href="https://vk.com/dev/photos.getAllComments">photos.getAllComments</see>
        /// </summary>
        /// <param name="owner_id">ID of the user or community that owns the album(s).</param>
        /// <param name="album_id">Album ID. If the parameter is not set, comments on all of the user's albums will be returned.</param>
        /// <param name="need_likes">'1' — to return an additional 'likes' field; '0' — (default)</param>
        /// <param name="offset">Offset needed to return a specific subset of comments. By default, '0'.</param>
        /// <param name="count">Number of comments to return. By default, '20'. Maximum value, '100'.</param>
        public async Task<object> GetAllComments(int? owner_id = null, int? album_id = null, bool? need_likes = null, int? offset = null, int? count = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (album_id != null)
                parameters.Add("album_id", album_id.ToString());
            if (need_likes != null)
                parameters.Add("need_likes", need_likes.ToString());
            if (offset != null)
                parameters.Add("offset", offset.ToString());
            if (count != null)
                parameters.Add("count", count.ToString());

            return await _vkontakte.GetAsync<object>("photos.getAllComments", parameters);
        }

        /// <summary>
        /// Adds a new comment on the photo.
        /// Docs: <see href="https://vk.com/dev/photos.createComment">photos.createComment</see>
        /// </summary>
        /// <param name="owner_id">ID of the user or community that owns the photo.</param>
        /// <param name="photo_id">Photo ID.</param>
        /// <param name="message">Comment text.</param>
        /// <param name="attachments">(Required if 'message' is not set.) List of objects attached to the post, in the following format:; "<owner_id>_<media_id>,<owner_id>_<media_id>"; '' — Type of media attachment:; 'photo' — photo; 'video' — video; 'audio' — audio; 'doc' — document; '<owner_id>' — Media attachment owner ID.; '<media_id>' — Media attachment ID.; ; Example:; "photo100172_166443618,photo66748_265827614"</param>
        /// <param name="from_group">'1' — to post a comment from the community</param>
        /// <param name="reply_to_comment"></param>
        /// <param name="sticker_id"></param>
        /// <param name="access_key"></param>
        /// <param name="guid"></param>
        public async Task<object> CreateComment(int? owner_id = null, int? photo_id = null, string message = null, IEnumerable<string> attachments = null, bool? from_group = null, int? reply_to_comment = null, int? sticker_id = null, string access_key = null, string guid = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (photo_id != null)
                parameters.Add("photo_id", photo_id.ToString());
            if (message != null)
                parameters.Add("message", message);
            if (attachments != null)
                parameters.Add("attachments", string.Join(",", attachments));
            if (from_group != null)
                parameters.Add("from_group", from_group.ToString());
            if (reply_to_comment != null)
                parameters.Add("reply_to_comment", reply_to_comment.ToString());
            if (sticker_id != null)
                parameters.Add("sticker_id", sticker_id.ToString());
            if (access_key != null)
                parameters.Add("access_key", access_key);
            if (guid != null)
                parameters.Add("guid", guid);

            return await _vkontakte.GetAsync<object>("photos.createComment", parameters);
        }

        /// <summary>
        /// Deletes a comment on the photo.
        /// Docs: <see href="https://vk.com/dev/photos.deleteComment">photos.deleteComment</see>
        /// </summary>
        /// <param name="owner_id">ID of the user or community that owns the photo.</param>
        /// <param name="comment_id">Comment ID.</param>
        public async Task<object> DeleteComment(int? owner_id = null, int? comment_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (comment_id != null)
                parameters.Add("comment_id", comment_id.ToString());

            return await _vkontakte.GetAsync<object>("photos.deleteComment", parameters);
        }

        /// <summary>
        /// Restores a deleted comment on a photo.
        /// Docs: <see href="https://vk.com/dev/photos.restoreComment">photos.restoreComment</see>
        /// </summary>
        /// <param name="owner_id">ID of the user or community that owns the photo.</param>
        /// <param name="comment_id">ID of the deleted comment.</param>
        public async Task<object> RestoreComment(int? owner_id = null, int? comment_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (comment_id != null)
                parameters.Add("comment_id", comment_id.ToString());

            return await _vkontakte.GetAsync<object>("photos.restoreComment", parameters);
        }

        /// <summary>
        /// Edits a comment on a photo.
        /// Docs: <see href="https://vk.com/dev/photos.editComment">photos.editComment</see>
        /// </summary>
        /// <param name="owner_id">ID of the user or community that owns the photo.</param>
        /// <param name="comment_id">Comment ID.</param>
        /// <param name="message">New text of the comment.</param>
        /// <param name="attachments">(Required if 'message' is not set.) List of objects attached to the post, in the following format:; "<owner_id>_<media_id>,<owner_id>_<media_id>"; '' — Type of media attachment:; 'photo' — photo; 'video' — video; 'audio' — audio; 'doc' — document; '<owner_id>' — Media attachment owner ID.; '<media_id>' — Media attachment ID.; ; Example:; "photo100172_166443618,photo66748_265827614"</param>
        public async Task<object> EditComment(int? owner_id = null, int? comment_id = null, string message = null, IEnumerable<string> attachments = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (comment_id != null)
                parameters.Add("comment_id", comment_id.ToString());
            if (message != null)
                parameters.Add("message", message);
            if (attachments != null)
                parameters.Add("attachments", string.Join(",", attachments));

            return await _vkontakte.GetAsync<object>("photos.editComment", parameters);
        }

        /// <summary>
        /// Returns a list of tags on a photo.
        /// Docs: <see href="https://vk.com/dev/photos.getTags">photos.getTags</see>
        /// </summary>
        /// <param name="owner_id">ID of the user or community that owns the photo.</param>
        /// <param name="photo_id">Photo ID.</param>
        /// <param name="access_key"></param>
        public async Task<object> GetTags(int? owner_id = null, int? photo_id = null, string access_key = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (photo_id != null)
                parameters.Add("photo_id", photo_id.ToString());
            if (access_key != null)
                parameters.Add("access_key", access_key);

            return await _vkontakte.GetAsync<object>("photos.getTags", parameters);
        }

        /// <summary>
        /// Adds a tag on the photo.
        /// Docs: <see href="https://vk.com/dev/photos.putTag">photos.putTag</see>
        /// </summary>
        /// <param name="owner_id">ID of the user or community that owns the photo.</param>
        /// <param name="photo_id">Photo ID.</param>
        /// <param name="user_id">ID of the user to be tagged.</param>
        /// <param name="x">Upper left-corner coordinate of the tagged area (as a percentage of the photo's width).</param>
        /// <param name="y">Upper left-corner coordinate of the tagged area (as a percentage of the photo's height).</param>
        /// <param name="x2">Lower right-corner coordinate of the tagged area (as a percentage of the photo's width).</param>
        /// <param name="y2">Lower right-corner coordinate of the tagged area (as a percentage of the photo's height).</param>
        public async Task<object> PutTag(int? owner_id = null, int? photo_id = null, int? user_id = null, uint? x = null, uint? y = null, uint? x2 = null, uint? y2 = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (photo_id != null)
                parameters.Add("photo_id", photo_id.ToString());
            if (user_id != null)
                parameters.Add("user_id", user_id.ToString());
            if (x != null)
                parameters.Add("x", x.ToString());
            if (y != null)
                parameters.Add("y", y.ToString());
            if (x2 != null)
                parameters.Add("x2", x2.ToString());
            if (y2 != null)
                parameters.Add("y2", y2.ToString());

            return await _vkontakte.GetAsync<object>("photos.putTag", parameters);
        }

        /// <summary>
        /// Removes a tag from a photo.
        /// Docs: <see href="https://vk.com/dev/photos.removeTag">photos.removeTag</see>
        /// </summary>
        /// <param name="owner_id">ID of the user or community that owns the photo.</param>
        /// <param name="photo_id">Photo ID.</param>
        /// <param name="tag_id">Tag ID.</param>
        public async Task<object> RemoveTag(int? owner_id = null, int? photo_id = null, int? tag_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (photo_id != null)
                parameters.Add("photo_id", photo_id.ToString());
            if (tag_id != null)
                parameters.Add("tag_id", tag_id.ToString());

            return await _vkontakte.GetAsync<object>("photos.removeTag", parameters);
        }

        /// <summary>
        /// Returns a list of photos with tags that have not been viewed.
        /// Docs: <see href="https://vk.com/dev/photos.getNewTags">photos.getNewTags</see>
        /// </summary>
        /// <param name="offset">Offset needed to return a specific subset of photos.</param>
        /// <param name="count">Number of photos to return.</param>
        public async Task<object> GetNewTags(int? offset = null, int? count = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (offset != null)
                parameters.Add("offset", offset.ToString());
            if (count != null)
                parameters.Add("count", count.ToString());

            return await _vkontakte.GetAsync<object>("photos.getNewTags", parameters);
        }

    }
}
