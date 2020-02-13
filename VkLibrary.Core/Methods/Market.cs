using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VkApi.Wrapper.Responses.Market;
using VkApi.Wrapper.Types.Base;
using VkApi.Wrapper.Types.Users;

namespace VkApi.Wrapper.Methods
{
    public class Market
    {
        private readonly Vkontakte _vkontakte;

        internal Market(Vkontakte vkontakte) => _vkontakte = vkontakte;

        ///<summary>
        /// Ads a new item to the market.
        ///</summary>
        public Task<MarketAddResponse> Add(int? ownerId = null, String name = null, String description = null, int? categoryId = null, double? price = null, double? oldPrice = null, Boolean? deleted = null, int? mainPhotoId = null, int[] photoIds = null, String url = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (name != null)
                parameters.Add("name", name.ToApiString());
            if (description != null)
                parameters.Add("description", description.ToApiString());
            if (categoryId != null)
                parameters.Add("category_id", categoryId.ToApiString());
            if (price != null)
                parameters.Add("price", price.ToApiString());
            if (oldPrice != null)
                parameters.Add("old_price", oldPrice.ToApiString());
            if (deleted != null)
                parameters.Add("deleted", deleted.ToApiString());
            if (mainPhotoId != null)
                parameters.Add("main_photo_id", mainPhotoId.ToApiString());
            if (photoIds != null)
                parameters.Add("photo_ids", photoIds.ToApiString());
            if (url != null)
                parameters.Add("url", url.ToApiString());
            return _vkontakte.RequestAsync<MarketAddResponse>("market.add", parameters);
        }

        ///<summary>
        /// Creates new collection of items
        ///</summary>
        public Task<MarketAddAlbumResponse> AddAlbum(int? ownerId = null, String title = null, int? photoId = null, Boolean? mainAlbum = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (title != null)
                parameters.Add("title", title.ToApiString());
            if (photoId != null)
                parameters.Add("photo_id", photoId.ToApiString());
            if (mainAlbum != null)
                parameters.Add("main_album", mainAlbum.ToApiString());
            return _vkontakte.RequestAsync<MarketAddAlbumResponse>("market.addAlbum", parameters);
        }

        ///<summary>
        /// Adds an item to one or multiple collections.
        ///</summary>
        public Task<BaseOkResponse> AddToAlbum(int? ownerId = null, int? itemId = null, int[] albumIds = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (itemId != null)
                parameters.Add("item_id", itemId.ToApiString());
            if (albumIds != null)
                parameters.Add("album_ids", albumIds.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("market.addToAlbum", parameters);
        }

        ///<summary>
        /// Creates a new comment for an item.
        ///</summary>
        public Task<int> CreateComment(int? ownerId = null, int? itemId = null, String message = null, String[] attachments = null, Boolean? fromGroup = null, int? replyToComment = null, int? stickerId = null, String guid = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (itemId != null)
                parameters.Add("item_id", itemId.ToApiString());
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
            return _vkontakte.RequestAsync<int>("market.createComment", parameters);
        }

        ///<summary>
        /// Deletes an item.
        ///</summary>
        public Task<BaseOkResponse> Delete(int? ownerId = null, int? itemId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (itemId != null)
                parameters.Add("item_id", itemId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("market.delete", parameters);
        }

        ///<summary>
        /// Deletes a collection of items.
        ///</summary>
        public Task<BaseOkResponse> DeleteAlbum(int? ownerId = null, int? albumId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (albumId != null)
                parameters.Add("album_id", albumId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("market.deleteAlbum", parameters);
        }

        ///<summary>
        /// Deletes an item's comment
        ///</summary>
        public Task<int> DeleteComment(int? ownerId = null, int? commentId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (commentId != null)
                parameters.Add("comment_id", commentId.ToApiString());
            return _vkontakte.RequestAsync<int>("market.deleteComment", parameters);
        }

        ///<summary>
        /// Edits an item.
        ///</summary>
        public Task<BaseOkResponse> Edit(int? ownerId = null, int? itemId = null, String name = null, String description = null, int? categoryId = null, double? price = null, Boolean? deleted = null, int? mainPhotoId = null, int[] photoIds = null, String url = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (itemId != null)
                parameters.Add("item_id", itemId.ToApiString());
            if (name != null)
                parameters.Add("name", name.ToApiString());
            if (description != null)
                parameters.Add("description", description.ToApiString());
            if (categoryId != null)
                parameters.Add("category_id", categoryId.ToApiString());
            if (price != null)
                parameters.Add("price", price.ToApiString());
            if (deleted != null)
                parameters.Add("deleted", deleted.ToApiString());
            if (mainPhotoId != null)
                parameters.Add("main_photo_id", mainPhotoId.ToApiString());
            if (photoIds != null)
                parameters.Add("photo_ids", photoIds.ToApiString());
            if (url != null)
                parameters.Add("url", url.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("market.edit", parameters);
        }

        ///<summary>
        /// Edits a collection of items
        ///</summary>
        public Task<BaseOkResponse> EditAlbum(int? ownerId = null, int? albumId = null, String title = null, int? photoId = null, Boolean? mainAlbum = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (albumId != null)
                parameters.Add("album_id", albumId.ToApiString());
            if (title != null)
                parameters.Add("title", title.ToApiString());
            if (photoId != null)
                parameters.Add("photo_id", photoId.ToApiString());
            if (mainAlbum != null)
                parameters.Add("main_album", mainAlbum.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("market.editAlbum", parameters);
        }

        ///<summary>
        /// Chages item comment's text
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
            return _vkontakte.RequestAsync<BaseOkResponse>("market.editComment", parameters);
        }

        ///<summary>
        /// Returns items list for a community.
        ///</summary>
        public Task<MarketGetResponse> Get(int? ownerId = null, int? albumId = null, int? count = null, int? offset = null, Boolean? extended = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (albumId != null)
                parameters.Add("album_id", albumId.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            return _vkontakte.RequestAsync<MarketGetResponse>("market.get", parameters);
        }

        ///<summary>
        /// Returns items album's data
        ///</summary>
        public Task<MarketGetAlbumByIdResponse> GetAlbumById(int? ownerId = null, int[] albumIds = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (albumIds != null)
                parameters.Add("album_ids", albumIds.ToApiString());
            return _vkontakte.RequestAsync<MarketGetAlbumByIdResponse>("market.getAlbumById", parameters);
        }

        ///<summary>
        /// Returns community's collections list.
        ///</summary>
        public Task<MarketGetAlbumsResponse> GetAlbums(int? ownerId = null, int? offset = null, int? count = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            return _vkontakte.RequestAsync<MarketGetAlbumsResponse>("market.getAlbums", parameters);
        }

        ///<summary>
        /// Returns information about market items by their ids.
        ///</summary>
        public Task<MarketGetByIdResponse> GetById(String[] itemIds = null, Boolean? extended = null)
        {
            var parameters = new Dictionary<string, string>();
            if (itemIds != null)
                parameters.Add("item_ids", itemIds.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            return _vkontakte.RequestAsync<MarketGetByIdResponse>("market.getById", parameters);
        }

        ///<summary>
        /// Returns a list of market categories.
        ///</summary>
        public Task<MarketGetCategoriesResponse> GetCategories(int? count = null, int? offset = null)
        {
            var parameters = new Dictionary<string, string>();
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            return _vkontakte.RequestAsync<MarketGetCategoriesResponse>("market.getCategories", parameters);
        }

        ///<summary>
        /// Returns comments list for an item.
        ///</summary>
        public Task<MarketGetCommentsResponse> GetComments(int? ownerId = null, int? itemId = null, Boolean? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, String sort = null, Boolean? extended = null, UsersFields[] fields = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (itemId != null)
                parameters.Add("item_id", itemId.ToApiString());
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
            return _vkontakte.RequestAsync<MarketGetCommentsResponse>("market.getComments", parameters);
        }

        ///<summary>
        /// Removes an item from one or multiple collections.
        ///</summary>
        public Task<BaseOkResponse> RemoveFromAlbum(int? ownerId = null, int? itemId = null, int[] albumIds = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (itemId != null)
                parameters.Add("item_id", itemId.ToApiString());
            if (albumIds != null)
                parameters.Add("album_ids", albumIds.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("market.removeFromAlbum", parameters);
        }

        ///<summary>
        /// Reorders the collections list.
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
            return _vkontakte.RequestAsync<BaseOkResponse>("market.reorderAlbums", parameters);
        }

        ///<summary>
        /// Changes item place in a collection.
        ///</summary>
        public Task<BaseOkResponse> ReorderItems(int? ownerId = null, int? albumId = null, int? itemId = null, int? before = null, int? after = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (albumId != null)
                parameters.Add("album_id", albumId.ToApiString());
            if (itemId != null)
                parameters.Add("item_id", itemId.ToApiString());
            if (before != null)
                parameters.Add("before", before.ToApiString());
            if (after != null)
                parameters.Add("after", after.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("market.reorderItems", parameters);
        }

        ///<summary>
        /// Sends a complaint to the item.
        ///</summary>
        public Task<BaseOkResponse> Report(int? ownerId = null, int? itemId = null, int? reason = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (itemId != null)
                parameters.Add("item_id", itemId.ToApiString());
            if (reason != null)
                parameters.Add("reason", reason.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("market.report", parameters);
        }

        ///<summary>
        /// Sends a complaint to the item's comment.
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
            return _vkontakte.RequestAsync<BaseOkResponse>("market.reportComment", parameters);
        }

        ///<summary>
        /// Restores recently deleted item
        ///</summary>
        public Task<BaseOkResponse> Restore(int? ownerId = null, int? itemId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (itemId != null)
                parameters.Add("item_id", itemId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("market.restore", parameters);
        }

        ///<summary>
        /// Restores a recently deleted comment
        ///</summary>
        public Task<int> RestoreComment(int? ownerId = null, int? commentId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (commentId != null)
                parameters.Add("comment_id", commentId.ToApiString());
            return _vkontakte.RequestAsync<int>("market.restoreComment", parameters);
        }

        ///<summary>
        /// Searches market items in a community's catalog
        ///</summary>
        public Task<MarketSearchResponse> Search(int? ownerId = null, int? albumId = null, String q = null, int? priceFrom = null, int? priceTo = null, int[] tags = null, int? sort = null, int? rev = null, int? offset = null, int? count = null, Boolean? extended = null, int? status = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (albumId != null)
                parameters.Add("album_id", albumId.ToApiString());
            if (q != null)
                parameters.Add("q", q.ToApiString());
            if (priceFrom != null)
                parameters.Add("price_from", priceFrom.ToApiString());
            if (priceTo != null)
                parameters.Add("price_to", priceTo.ToApiString());
            if (tags != null)
                parameters.Add("tags", tags.ToApiString());
            if (sort != null)
                parameters.Add("sort", sort.ToApiString());
            if (rev != null)
                parameters.Add("rev", rev.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            if (status != null)
                parameters.Add("status", status.ToApiString());
            return _vkontakte.RequestAsync<MarketSearchResponse>("market.search", parameters);
        }
    }
}