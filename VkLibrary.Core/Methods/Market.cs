using System.Collections.Generic;
using System.Threading.Tasks;
using VkLibrary.Core.Responses.Market;
using VkLibrary.Core.Types.Market;
using VkLibrary.Core.Types.Wall;

namespace VkLibrary.Core.Methods
{
    /// <summary>
    /// Market API section.
    /// </summary>
    public class Market
    {
        private readonly Vkontakte _vkontakte;

        internal Market(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        /// Returns items list for a community.
        /// Docs: <see href="https://vk.com/dev/market.get">market.get</see>
        /// </summary>
        /// <param name="ownerId">
        /// ID of an item owner community; "Note that community id in the 'owner_id' parameter should be
        /// negative number. For example 'owner_id'=-1 matches the VK API community "
        /// </param>
        /// <param name="count">Number of items to return.</param>
        /// <param name="offset">Offset needed to return a specific subset of results.</param>
        /// <param name="extended">
        /// '1' – method will return additional fields: 'likes, can_comment, car_repost, photos'. These
        /// parameters are not returned by default.
        /// </param>
        public Task<ApiItemsResponse<MarketItem>> Get(int? ownerId = null, int? count = null, int? offset = null,
            bool? extended = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());

            return _vkontakte.RequestAsync<ApiItemsResponse<MarketItem>>("market.get", parameters);
        }

        /// <summary>
        /// Returns information about market items by their ids.
        /// Docs: <see href="https://vk.com/dev/market.getById">market.getById</see>
        /// </summary>
        /// <param name="itemIds">
        /// Comma-separated ids list: {user id}_{item id}.; If an item belongs to a community -{community
        /// id} is used. ; " 'Videos' value example: ; '-4363_136089719,13245770_137352259'"
        /// </param>
        /// <param name="extended">'1' – to return additional fields: 'likes, can_comment, car_repost, photos'. By default: '0'.</param>
        public Task<ApiItemsResponse<MarketItem>> GetById(IEnumerable<string> itemIds = null,
            bool? extended = null)
        {
            var parameters = new Dictionary<string, string>();

            if (itemIds != null)
                parameters.Add("item_ids", itemIds.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());

            return _vkontakte.RequestAsync<ApiItemsResponse<MarketItem>>("market.getById", parameters);
        }

        /// <summary>
        /// Searches market items in a community's catalog
        /// Docs: <see href="https://vk.com/dev/market.search">market.search</see>
        /// </summary>
        /// <param name="ownerId">ID of an items owner community.</param>
        /// <param name="q">Search query, for example "pink slippers".</param>
        /// <param name="priceFrom">Minimum item price value.</param>
        /// <param name="priceTo">Maximum item price value.</param>
        /// <param name="tags">Comma-separated tag IDs list.</param>
        /// <param name="rev">'0' — do not use reverse order, '1' — use reverse order</param>
        /// <param name="offset">Offset needed to return a specific subset of results.</param>
        /// <param name="count">Number of items to return.</param>
        /// <param name="extended">'1' – to return additional fields: 'likes, can_comment, car_repost, photos'. By default: '0'.</param>
        public Task<ApiItemsResponse<MarketItem>> Search(int? ownerId = null, string q = null,
            int? priceFrom = null, int? priceTo = null, IEnumerable<int?> tags = null, int? rev = null,
            int? offset = null, int? count = null, bool? extended = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (q != null)
                parameters.Add("q", q);
            if (priceFrom != null)
                parameters.Add("price_from", priceFrom.ToApiString());
            if (priceTo != null)
                parameters.Add("price_to", priceTo.ToApiString());
            if (tags != null)
                parameters.Add("tags", tags.ToApiString());
            if (rev != null)
                parameters.Add("rev", rev.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());

            return _vkontakte.RequestAsync<ApiItemsResponse<MarketItem>>("market.search", parameters);
        }

        /// <summary>
        /// Returns community's collections list.
        /// Docs: <see href="https://vk.com/dev/market.getAlbums">market.getAlbums</see>
        /// </summary>
        /// <param name="ownerId">ID of an items owner community.</param>
        /// <param name="offset">Offset needed to return a specific subset of results.</param>
        /// <param name="count">Number of items to return.</param>
        public Task<ApiItemsResponse<MarketAlbum>> GetAlbums(int? ownerId = null, int? offset = null,
            int? count = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());

            return _vkontakte.RequestAsync<ApiItemsResponse<MarketAlbum>>("market.getAlbums", parameters);
        }

        /// <summary>
        /// Returns items album's data
        /// Docs: <see href="https://vk.com/dev/market.getAlbumById">market.getAlbumById</see>
        /// </summary>
        /// <param name="ownerId">
        /// identifier of an album owner community; "Note that community id in the 'owner_id' parameter
        /// should be negative number. For example 'owner_id'=-1 matches the VK API community "
        /// </param>
        /// <param name="albumIds">collections identifiers to obtain data from</param>
        public Task<ApiItemsResponse<MarketAlbum>> GetAlbumById(int? ownerId = null,
            IEnumerable<int?> albumIds = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (albumIds != null)
                parameters.Add("album_ids", albumIds.ToApiString());

            return _vkontakte.RequestAsync<ApiItemsResponse<MarketAlbum>>("market.getAlbumById", parameters);
        }

        /// <summary>
        /// Creates a new comment for an item.
        /// Docs: <see href="https://vk.com/dev/market.createComment">market.createComment</see>
        /// </summary>
        /// <param name="ownerId">ID of an item owner community.</param>
        /// <param name="itemId">Item ID.</param>
        /// <param name="message">Comment text (required if 'attachments' parameter is not specified)</param>
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
        /// '1' - comment will be published on behalf of a community, '0' - on behalf of a user (by
        /// default).
        /// </param>
        /// <param name="replyToComment">ID of a comment to reply with current comment to.</param>
        /// <param name="stickerId">Sticker ID.</param>
        /// <param name="guid">Random value to avoid resending one comment.</param>
        public Task<int?> CreateComment(int? ownerId = null, int? itemId = null, string message = null,
            IEnumerable<string> attachments = null, bool? fromGroup = null, int? replyToComment = null,
            int? stickerId = null, string guid = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (itemId != null)
                parameters.Add("item_id", itemId.ToApiString());
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

            return _vkontakte.RequestAsync<int?>("market.createComment", parameters);
        }

        /// <summary>
        /// Returns comments list for an item.
        /// Docs: <see href="https://vk.com/dev/market.getComments">market.getComments</see>
        /// </summary>
        /// <param name="ownerId">ID of an item owner community</param>
        /// <param name="itemId">Item ID.</param>
        /// <param name="needLikes">'1' — to return likes info.</param>
        /// <param name="startCommentId">ID of a comment to start a list from (details below).</param>
        /// <param name="count">Number of results to return.</param>
        /// <param name="sort">Sort order ('asc' — from old to new, 'desc' — from new to old)</param>
        /// <param name="extended">
        /// '1' — comments will be returned as numbered objects, in addition lists of 'profiles' and
        /// 'groups' objects will be returned.
        /// </param>
        /// <param name="fields">List of additional profile fields to return. See the details</param>
        public Task<ApiItemsResponse<WallComment>> GetComments(int? ownerId = null, int? itemId = null,
            bool? needLikes = null, int? startCommentId = null, int? count = null, string sort = null,
            bool? extended = null, IEnumerable<string> fields = null)
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
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (sort != null)
                parameters.Add("sort", sort);
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());

            return _vkontakte.RequestAsync<ApiItemsResponse<WallComment>>("market.getComments", parameters);
        }

        /// <summary>
        /// Deletes an item's comment
        /// Docs: <see href="https://vk.com/dev/market.deleteComment">market.deleteComment</see>
        /// </summary>
        /// <param name="ownerId">
        /// identifier of an item owner community; "Note that community id in the 'owner_id' parameter
        /// should be negative number. For example 'owner_id'=-1 matches the VK API community "
        /// </param>
        /// <param name="commentId">comment id</param>
        public Task<int> DeleteComment(int? ownerId = null, int? commentId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (commentId != null)
                parameters.Add("comment_id", commentId.ToApiString());

            return _vkontakte.RequestAsync<int>("market.deleteComment", parameters);
        }

        /// <summary>
        /// Restores a recently deleted comment
        /// Docs: <see href="https://vk.com/dev/market.restoreComment">market.restoreComment</see>
        /// </summary>
        /// <param name="ownerId">
        /// identifier of an item owner community; "Note that community id in the 'owner_id' parameter
        /// should be negative number. For example 'owner_id'=-1 matches the VK API community "
        /// </param>
        /// <param name="commentId">deleted comment id</param>
        public Task<int> RestoreComment(int? ownerId = null, int? commentId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (commentId != null)
                parameters.Add("comment_id", commentId.ToApiString());

            return _vkontakte.RequestAsync<int>("market.restoreComment", parameters);
        }

        /// <summary>
        /// Chages item comment's text
        /// Docs: <see href="https://vk.com/dev/market.editComment">market.editComment</see>
        /// </summary>
        /// <param name="ownerId">ID of an item owner community.</param>
        /// <param name="commentId">Comment ID.</param>
        /// <param name="message">New comment text (required if 'attachments' are not specified); ; 2048 symbols maximum.</param>
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

            return _vkontakte.RequestAsync<int>("market.editComment", parameters);
        }

        /// <summary>
        /// Sends a complaint to the item's comment.
        /// Docs: <see href="https://vk.com/dev/market.reportComment">market.reportComment</see>
        /// </summary>
        /// <param name="ownerId">ID of an item owner community.</param>
        /// <param name="commentId">Comment ID.</param>
        /// <param name="reason">
        /// Complaint reason. Possible values:; *'0' — spam;; *'1' — child porn;; *'2' — extremism;; *'3' —
        /// violence;; *'4' — drugs propaganda;; *'5' — adult materials;; *'6' — insult.
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

            return _vkontakte.RequestAsync<int>("market.reportComment", parameters);
        }

        /// <summary>
        /// Returns a list of market categories.
        /// Docs: <see href="https://vk.com/dev/market.getCategories">market.getCategories</see>
        /// </summary>
        /// <param name="count">Number of results to return.</param>
        /// <param name="offset">Offset needed to return a specific subset of results.</param>
        public Task<ApiItemsResponse<MarketCategory>> GetCategories(int? count = null, int? offset = null)
        {
            var parameters = new Dictionary<string, string>();

            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());

            return _vkontakte.RequestAsync<ApiItemsResponse<MarketCategory>>("market.getCategories", parameters);
        }

        /// <summary>
        /// Sends a complaint to the item.
        /// Docs: <see href="https://vk.com/dev/market.report">market.report</see>
        /// </summary>
        /// <param name="ownerId">ID of an item owner community.</param>
        /// <param name="itemId">Item ID.</param>
        /// <param name="reason">
        /// Complaint reason. Possible values:; *'0' — spam;; *'1' — child porn;; *'2' — extremism;; *'3' —
        /// violence;; *'4' — drugs propaganda;; *'5' — adult materials;; *'6' — insult.
        /// </param>
        public Task<int> Report(int? ownerId = null, int? itemId = null, int? reason = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (itemId != null)
                parameters.Add("item_id", itemId.ToApiString());
            if (reason != null)
                parameters.Add("reason", reason.ToApiString());

            return _vkontakte.RequestAsync<int>("market.report", parameters);
        }

        /// <summary>
        /// Ads a new item to the market.
        /// Docs: <see href="https://vk.com/dev/market.add">market.add</see>
        /// </summary>
        /// <param name="ownerId">ID of an item owner community.</param>
        /// <param name="name">Item name.</param>
        /// <param name="description">Item description.</param>
        /// <param name="categoryId">Item category ID.</param>
        /// <param name="price">Item price.</param>
        /// <param name="deleted">Item status ('1' — deleted, '0' — not deleted).</param>
        /// <param name="mainPhotoId">Cover photo ID.</param>
        /// <param name="photoIds">IDs of additional photos.</param>
        public Task<AddResponse> Add(int? ownerId = null, string name = null, string description = null,
            int? categoryId = null, uint? price = null, bool? deleted = null, int? mainPhotoId = null,
            IEnumerable<int?> photoIds = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (name != null)
                parameters.Add("name", name);
            if (description != null)
                parameters.Add("description", description);
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

            return _vkontakte.RequestAsync<AddResponse>("market.add", parameters);
        }

        /// <summary>
        /// Edits an item.
        /// Docs: <see href="https://vk.com/dev/market.edit">market.edit</see>
        /// </summary>
        /// <param name="ownerId">ID of an item owner community.</param>
        /// <param name="itemId">Item ID.</param>
        /// <param name="name">Item name.</param>
        /// <param name="description">Item description.</param>
        /// <param name="categoryId">Item category ID.</param>
        /// <param name="price">Item price.</param>
        /// <param name="deleted">Item status ('1' — deleted, '0' — not deleted).</param>
        /// <param name="mainPhotoId">Cover photo ID.</param>
        /// <param name="photoIds">IDs of additional photos.</param>
        public Task<int> Edit(int? ownerId = null, int? itemId = null, string name = null,
            string description = null, int? categoryId = null, uint? price = null, bool? deleted = null,
            int? mainPhotoId = null, IEnumerable<int?> photoIds = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (itemId != null)
                parameters.Add("item_id", itemId.ToApiString());
            if (name != null)
                parameters.Add("name", name);
            if (description != null)
                parameters.Add("description", description);
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

            return _vkontakte.RequestAsync<int>("market.edit", parameters);
        }

        /// <summary>
        /// Deletes an item.
        /// Docs: <see href="https://vk.com/dev/market.delete">market.delete</see>
        /// </summary>
        /// <param name="ownerId">ID of an item owner community.</param>
        /// <param name="itemId">Item ID.</param>
        public Task<int> Delete(int? ownerId = null, int? itemId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (itemId != null)
                parameters.Add("item_id", itemId.ToApiString());

            return _vkontakte.RequestAsync<int>("market.delete", parameters);
        }

        /// <summary>
        /// Restores recently deleted item
        /// Docs: <see href="https://vk.com/dev/market.restore">market.restore</see>
        /// </summary>
        /// <param name="ownerId">ID of an item owner community.</param>
        /// <param name="itemId">Deleted item ID.</param>
        public Task<int> Restore(int? ownerId = null, int? itemId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (itemId != null)
                parameters.Add("item_id", itemId.ToApiString());

            return _vkontakte.RequestAsync<int>("market.restore", parameters);
        }

        /// <summary>
        /// Changes item place in a collection.
        /// Docs: <see href="https://vk.com/dev/market.reorderItems">market.reorderItems</see>
        /// </summary>
        /// <param name="ownerId">ID of an item owner community.</param>
        /// <param name="albumId">ID of a collection to reorder items in. Set 0 to reorder full items list.</param>
        /// <param name="itemId">Item ID.</param>
        /// <param name="before">ID of an item to place current item before it.</param>
        /// <param name="after">ID of an item to place current item after it.</param>
        public Task<int> ReorderItems(int? ownerId = null, int? albumId = null, int? itemId = null,
            int? before = null, int? after = null)
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

            return _vkontakte.RequestAsync<int>("market.reorderItems", parameters);
        }

        /// <summary>
        /// Reorders the collections list.
        /// Docs: <see href="https://vk.com/dev/market.reorderAlbums">market.reorderAlbums</see>
        /// </summary>
        /// <param name="ownerId">ID of an item owner community.</param>
        /// <param name="albumId">Collection ID.</param>
        /// <param name="before">ID of a collection to place current collection before it.</param>
        /// <param name="after">ID of a collection to place current collection after it.</param>
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

            return _vkontakte.RequestAsync<int>("market.reorderAlbums", parameters);
        }

        /// <summary>
        /// Creates new collection of items
        /// Docs: <see href="https://vk.com/dev/market.addAlbum">market.addAlbum</see>
        /// </summary>
        /// <param name="ownerId">ID of an item owner community.</param>
        /// <param name="title">Collection title.</param>
        /// <param name="photoId">Cover photo ID.</param>
        /// <param name="mainAlbum">Set as main ('1' – set, '0' – no).</param>
        public Task<AddAlbumResponse> AddAlbum(int? ownerId = null, string title = null, int? photoId = null,
            bool? mainAlbum = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (title != null)
                parameters.Add("title", title);
            if (photoId != null)
                parameters.Add("photo_id", photoId.ToApiString());
            if (mainAlbum != null)
                parameters.Add("main_album", mainAlbum.ToApiString());

            return _vkontakte.RequestAsync<AddAlbumResponse>("market.addAlbum", parameters);
        }

        /// <summary>
        /// Edits a collection of items
        /// Docs: <see href="https://vk.com/dev/market.editAlbum">market.editAlbum</see>
        /// </summary>
        /// <param name="ownerId">ID of an collection owner community.</param>
        /// <param name="albumId">Collection ID.</param>
        /// <param name="title">Collection title.</param>
        /// <param name="photoId">Cover photo id</param>
        /// <param name="mainAlbum">Set as main ('1' – set, '0' – no).</param>
        public Task<int> EditAlbum(int? ownerId = null, int? albumId = null, string title = null,
            int? photoId = null, bool? mainAlbum = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (albumId != null)
                parameters.Add("album_id", albumId.ToApiString());
            if (title != null)
                parameters.Add("title", title);
            if (photoId != null)
                parameters.Add("photo_id", photoId.ToApiString());
            if (mainAlbum != null)
                parameters.Add("main_album", mainAlbum.ToApiString());

            return _vkontakte.RequestAsync<int>("market.editAlbum", parameters);
        }

        /// <summary>
        /// Deletes a collection of items.
        /// Docs: <see href="https://vk.com/dev/market.deleteAlbum">market.deleteAlbum</see>
        /// </summary>
        /// <param name="ownerId">ID of an collection owner community.</param>
        /// <param name="albumId">Collection ID.</param>
        public Task<int> DeleteAlbum(int? ownerId = null, int? albumId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (albumId != null)
                parameters.Add("album_id", albumId.ToApiString());

            return _vkontakte.RequestAsync<int>("market.deleteAlbum", parameters);
        }

        /// <summary>
        /// Removes an item from one or multiple collections.
        /// Docs: <see href="https://vk.com/dev/market.removeFromAlbum">market.removeFromAlbum</see>
        /// </summary>
        /// <param name="ownerId">ID of an item owner community.</param>
        /// <param name="itemId">Item ID.</param>
        /// <param name="albumIds">Collections IDs to remove item from.</param>
        public Task<int> RemoveFromAlbum(int? ownerId = null, int? itemId = null,
            IEnumerable<int?> albumIds = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (itemId != null)
                parameters.Add("item_id", itemId.ToApiString());
            if (albumIds != null)
                parameters.Add("album_ids", albumIds.ToApiString());

            return _vkontakte.RequestAsync<int>("market.removeFromAlbum", parameters);
        }

        /// <summary>
        /// Adds an item to one or multiple collections.
        /// Docs: <see href="https://vk.com/dev/market.addToAlbum">market.addToAlbum</see>
        /// </summary>
        /// <param name="ownerId">ID of an item owner community.</param>
        /// <param name="itemId">Item ID.</param>
        /// <param name="albumIds">Collections IDs to add item to.</param>
        public Task<int> AddToAlbum(int? ownerId = null, int? itemId = null, IEnumerable<int?> albumIds = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (itemId != null)
                parameters.Add("item_id", itemId.ToApiString());
            if (albumIds != null)
                parameters.Add("album_ids", albumIds.ToApiString());

            return _vkontakte.RequestAsync<int>("market.addToAlbum", parameters);
        }
    }
}