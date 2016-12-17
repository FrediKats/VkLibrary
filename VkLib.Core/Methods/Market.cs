using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkLib.Methods
{
    /// <summary>
    /// Market API section.
    /// </summary>
    public class Market
    {
        private Vkontakte _vkontakte;

        internal Market(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        /// Returns items list for a community.
        /// Docs: <see href="https://vk.com/dev/market.get">market.get</see>
        /// </summary>
        /// <param name="owner_id">ID of an item owner community; "Note that community id in the 'owner_id' parameter should be negative number. For example 'owner_id'=-1 matches the [vk.com/apiclub|VK API] community "</param>
        /// <param name="count">Number of items to return.</param>
        /// <param name="offset">Offset needed to return a specific subset of results.</param>
        /// <param name="extended">'1' – method will return additional fields: 'likes, can_comment, car_repost, photos'. These parameters are not returned by default.</param>
        public async Task<object> Get(int? owner_id = null, int? count = null, int? offset = null, bool? extended = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (count != null)
                parameters.Add("count", count.ToString());
            if (offset != null)
                parameters.Add("offset", offset.ToString());
            if (extended != null)
                parameters.Add("extended", extended.ToString());

            return await _vkontakte.GetAsync<object>("market.get", parameters);
        }

        /// <summary>
        /// Returns information about market items by their ids.
        /// Docs: <see href="https://vk.com/dev/market.getById">market.getById</see>
        /// </summary>
        /// <param name="item_ids">Comma-separated ids list: {user id}_{item id}.; If an item belongs to a community -{community id} is used. ; " 'Videos' value example: ; '-4363_136089719,13245770_137352259'"</param>
        /// <param name="extended">'1' – to return additional fields: 'likes, can_comment, car_repost, photos'. By default: '0'.</param>
        public async Task<object> GetById(IEnumerable<string> item_ids = null, bool? extended = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (item_ids != null)
                parameters.Add("item_ids", string.Join(",", item_ids));
            if (extended != null)
                parameters.Add("extended", extended.ToString());

            return await _vkontakte.GetAsync<object>("market.getById", parameters);
        }

        /// <summary>
        /// Searches market items in a community's catalog
        /// Docs: <see href="https://vk.com/dev/market.search">market.search</see>
        /// </summary>
        /// <param name="owner_id">ID of an items owner community.</param>
        /// <param name="q">Search query, for example "pink slippers".</param>
        /// <param name="price_from">Minimum item price value.</param>
        /// <param name="price_to">Maximum item price value.</param>
        /// <param name="tags">Comma-separated tag IDs list.</param>
        /// <param name="rev">'0' — do not use reverse order, '1' — use reverse order</param>
        /// <param name="offset">Offset needed to return a specific subset of results.</param>
        /// <param name="count">Number of items to return.</param>
        /// <param name="extended">'1' – to return additional fields: 'likes, can_comment, car_repost, photos'. By default: '0'.</param>
        public async Task<object> Search(int? owner_id = null, string q = null, int? price_from = null, int? price_to = null, IEnumerable<int?> tags = null, int? rev = null, int? offset = null, int? count = null, bool? extended = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (q != null)
                parameters.Add("q", q);
            if (price_from != null)
                parameters.Add("price_from", price_from.ToString());
            if (price_to != null)
                parameters.Add("price_to", price_to.ToString());
            if (tags != null)
                parameters.Add("tags", string.Join(",", tags));
            if (rev != null)
                parameters.Add("rev", rev.ToString());
            if (offset != null)
                parameters.Add("offset", offset.ToString());
            if (count != null)
                parameters.Add("count", count.ToString());
            if (extended != null)
                parameters.Add("extended", extended.ToString());

            return await _vkontakte.GetAsync<object>("market.search", parameters);
        }

        /// <summary>
        /// Returns community's collections list.
        /// Docs: <see href="https://vk.com/dev/market.getAlbums">market.getAlbums</see>
        /// </summary>
        /// <param name="owner_id">ID of an items owner community.</param>
        /// <param name="offset">Offset needed to return a specific subset of results.</param>
        /// <param name="count">Number of items to return.</param>
        public async Task<object> GetAlbums(int? owner_id = null, int? offset = null, int? count = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (offset != null)
                parameters.Add("offset", offset.ToString());
            if (count != null)
                parameters.Add("count", count.ToString());

            return await _vkontakte.GetAsync<object>("market.getAlbums", parameters);
        }

        /// <summary>
        /// Returns items album's data
        /// Docs: <see href="https://vk.com/dev/market.getAlbumById">market.getAlbumById</see>
        /// </summary>
        /// <param name="owner_id">identifier of an album owner community; "Note that community id in the 'owner_id' parameter should be negative number. For example 'owner_id'=-1 matches the [vk.com/apiclub|VK API] community "</param>
        /// <param name="album_ids">collections identifiers to obtain data from</param>
        public async Task<object> GetAlbumById(int? owner_id = null, IEnumerable<int?> album_ids = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (album_ids != null)
                parameters.Add("album_ids", string.Join(",", album_ids));

            return await _vkontakte.GetAsync<object>("market.getAlbumById", parameters);
        }

        /// <summary>
        /// Creates a new comment for an item.
        /// Docs: <see href="https://vk.com/dev/market.createComment">market.createComment</see>
        /// </summary>
        /// <param name="owner_id">ID of an item owner community.</param>
        /// <param name="item_id">Item ID.</param>
        /// <param name="message">Comment text (required if 'attachments' parameter is not specified)</param>
        /// <param name="attachments">Comma-separated list of objects attached to a comment. The field is submitted the following way: ; "'<owner_id>_<media_id>,<owner_id>_<media_id>'"; ; '' - media attachment type:; "'photo' - photo; 'video' - video; 'audio' - audio; 'doc' - document"; ; '<owner_id>' - media owner id; '<media_id>' - media attachment id; ; For example:; "photo100172_166443618,photo66748_265827614";</param>
        /// <param name="from_group">'1' - comment will be published on behalf of a community, '0' - on behalf of a user (by default).</param>
        /// <param name="reply_to_comment">ID of a comment to reply with current comment to.</param>
        /// <param name="sticker_id">Sticker ID.</param>
        /// <param name="guid">Random value to avoid resending one comment.</param>
        public async Task<object> CreateComment(int? owner_id = null, int? item_id = null, string message = null, IEnumerable<string> attachments = null, bool? from_group = null, int? reply_to_comment = null, int? sticker_id = null, string guid = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (item_id != null)
                parameters.Add("item_id", item_id.ToString());
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
            if (guid != null)
                parameters.Add("guid", guid);

            return await _vkontakte.GetAsync<object>("market.createComment", parameters);
        }

        /// <summary>
        /// Returns comments list for an item.
        /// Docs: <see href="https://vk.com/dev/market.getComments">market.getComments</see>
        /// </summary>
        /// <param name="owner_id">ID of an item owner community</param>
        /// <param name="item_id">Item ID.</param>
        /// <param name="need_likes">'1' — to return likes info.</param>
        /// <param name="start_comment_id">ID of a comment to start a list from (details below).</param>
        /// <param name="count">Number of results to return.</param>
        /// <param name="sort">Sort order ('asc' — from old to new, 'desc' — from new to old)</param>
        /// <param name="extended">'1' — comments will be returned as numbered objects, in addition lists of 'profiles' and 'groups' objects will be returned.</param>
        /// <param name="fields">List of additional profile fields to return. See the [vk.com/dev/fields|details]</param>
        public async Task<object> GetComments(int? owner_id = null, int? item_id = null, bool? need_likes = null, int? start_comment_id = null, int? count = null, string sort = null, bool? extended = null, IEnumerable<string> fields = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (item_id != null)
                parameters.Add("item_id", item_id.ToString());
            if (need_likes != null)
                parameters.Add("need_likes", need_likes.ToString());
            if (start_comment_id != null)
                parameters.Add("start_comment_id", start_comment_id.ToString());
            if (count != null)
                parameters.Add("count", count.ToString());
            if (sort != null)
                parameters.Add("sort", sort);
            if (extended != null)
                parameters.Add("extended", extended.ToString());
            if (fields != null)
                parameters.Add("fields", string.Join(",", fields));

            return await _vkontakte.GetAsync<object>("market.getComments", parameters);
        }

        /// <summary>
        /// Deletes an item's comment
        /// Docs: <see href="https://vk.com/dev/market.deleteComment">market.deleteComment</see>
        /// </summary>
        /// <param name="owner_id">identifier of an item owner community; "Note that community id in the 'owner_id' parameter should be negative number. For example 'owner_id'=-1 matches the [vk.com/apiclub|VK API] community "</param>
        /// <param name="comment_id">comment id</param>
        public async Task<object> DeleteComment(int? owner_id = null, int? comment_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (comment_id != null)
                parameters.Add("comment_id", comment_id.ToString());

            return await _vkontakte.GetAsync<object>("market.deleteComment", parameters);
        }

        /// <summary>
        /// Restores a recently deleted comment
        /// Docs: <see href="https://vk.com/dev/market.restoreComment">market.restoreComment</see>
        /// </summary>
        /// <param name="owner_id">identifier of an item owner community; "Note that community id in the 'owner_id' parameter should be negative number. For example 'owner_id'=-1 matches the [vk.com/apiclub|VK API] community "</param>
        /// <param name="comment_id">deleted comment id</param>
        public async Task<object> RestoreComment(int? owner_id = null, int? comment_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (comment_id != null)
                parameters.Add("comment_id", comment_id.ToString());

            return await _vkontakte.GetAsync<object>("market.restoreComment", parameters);
        }

        /// <summary>
        /// Chages item comment's text
        /// Docs: <see href="https://vk.com/dev/market.editComment">market.editComment</see>
        /// </summary>
        /// <param name="owner_id">ID of an item owner community.</param>
        /// <param name="comment_id">Comment ID.</param>
        /// <param name="message">New comment text (required if 'attachments' are not specified); ; 2048 symbols maximum.</param>
        /// <param name="attachments">Comma-separated list of objects attached to a comment. The field is submitted the following way: ; "'<owner_id>_<media_id>,<owner_id>_<media_id>'"; ; '' - media attachment type:; "'photo' - photo; 'video' - video; 'audio' - audio; 'doc' - document"; ; '<owner_id>' - media owner id; '<media_id>' - media attachment id; ; For example:; "photo100172_166443618,photo66748_265827614";</param>
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

            return await _vkontakte.GetAsync<object>("market.editComment", parameters);
        }

        /// <summary>
        /// Sends a complaint to the item's comment.
        /// Docs: <see href="https://vk.com/dev/market.reportComment">market.reportComment</see>
        /// </summary>
        /// <param name="owner_id">ID of an item owner community.</param>
        /// <param name="comment_id">Comment ID.</param>
        /// <param name="reason">Complaint reason. Possible values:; *'0' — spam;; *'1' — child porn;; *'2' — extremism;; *'3' — violence;; *'4' — drugs propaganda;; *'5' — adult materials;; *'6' — insult.</param>
        public async Task<object> ReportComment(int? owner_id = null, int? comment_id = null, int? reason = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (comment_id != null)
                parameters.Add("comment_id", comment_id.ToString());
            if (reason != null)
                parameters.Add("reason", reason.ToString());

            return await _vkontakte.GetAsync<object>("market.reportComment", parameters);
        }

        /// <summary>
        /// Returns a list of market categories.
        /// Docs: <see href="https://vk.com/dev/market.getCategories">market.getCategories</see>
        /// </summary>
        /// <param name="count">Number of results to return.</param>
        /// <param name="offset">Offset needed to return a specific subset of results.</param>
        public async Task<object> GetCategories(int? count = null, int? offset = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (count != null)
                parameters.Add("count", count.ToString());
            if (offset != null)
                parameters.Add("offset", offset.ToString());

            return await _vkontakte.GetAsync<object>("market.getCategories", parameters);
        }

        /// <summary>
        /// Sends a complaint to the item.
        /// Docs: <see href="https://vk.com/dev/market.report">market.report</see>
        /// </summary>
        /// <param name="owner_id">ID of an item owner community.</param>
        /// <param name="item_id">Item ID.</param>
        /// <param name="reason">Complaint reason. Possible values:; *'0' — spam;; *'1' — child porn;; *'2' — extremism;; *'3' — violence;; *'4' — drugs propaganda;; *'5' — adult materials;; *'6' — insult.</param>
        public async Task<object> Report(int? owner_id = null, int? item_id = null, int? reason = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (item_id != null)
                parameters.Add("item_id", item_id.ToString());
            if (reason != null)
                parameters.Add("reason", reason.ToString());

            return await _vkontakte.GetAsync<object>("market.report", parameters);
        }

        /// <summary>
        /// Ads a new item to the market.
        /// Docs: <see href="https://vk.com/dev/market.add">market.add</see>
        /// </summary>
        /// <param name="owner_id">ID of an item owner community.</param>
        /// <param name="name">Item name.</param>
        /// <param name="description">Item description.</param>
        /// <param name="category_id">Item category ID.</param>
        /// <param name="price">Item price.</param>
        /// <param name="deleted">Item status ('1' — deleted, '0' — not deleted).</param>
        /// <param name="main_photo_id">Cover photo ID.</param>
        /// <param name="photo_ids">IDs of additional photos.</param>
        public async Task<object> Add(int? owner_id = null, string name = null, string description = null, int? category_id = null, uint? price = null, bool? deleted = null, int? main_photo_id = null, IEnumerable<int?> photo_ids = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (name != null)
                parameters.Add("name", name);
            if (description != null)
                parameters.Add("description", description);
            if (category_id != null)
                parameters.Add("category_id", category_id.ToString());
            if (price != null)
                parameters.Add("price", price.ToString());
            if (deleted != null)
                parameters.Add("deleted", deleted.ToString());
            if (main_photo_id != null)
                parameters.Add("main_photo_id", main_photo_id.ToString());
            if (photo_ids != null)
                parameters.Add("photo_ids", string.Join(",", photo_ids));

            return await _vkontakte.GetAsync<object>("market.add", parameters);
        }

        /// <summary>
        /// Edits an item.
        /// Docs: <see href="https://vk.com/dev/market.edit">market.edit</see>
        /// </summary>
        /// <param name="owner_id">ID of an item owner community.</param>
        /// <param name="item_id">Item ID.</param>
        /// <param name="name">Item name.</param>
        /// <param name="description">Item description.</param>
        /// <param name="category_id">Item category ID.</param>
        /// <param name="price">Item price.</param>
        /// <param name="deleted">Item status ('1' — deleted, '0' — not deleted).</param>
        /// <param name="main_photo_id">Cover photo ID.</param>
        /// <param name="photo_ids">IDs of additional photos.</param>
        public async Task<object> Edit(int? owner_id = null, int? item_id = null, string name = null, string description = null, int? category_id = null, uint? price = null, bool? deleted = null, int? main_photo_id = null, IEnumerable<int?> photo_ids = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (item_id != null)
                parameters.Add("item_id", item_id.ToString());
            if (name != null)
                parameters.Add("name", name);
            if (description != null)
                parameters.Add("description", description);
            if (category_id != null)
                parameters.Add("category_id", category_id.ToString());
            if (price != null)
                parameters.Add("price", price.ToString());
            if (deleted != null)
                parameters.Add("deleted", deleted.ToString());
            if (main_photo_id != null)
                parameters.Add("main_photo_id", main_photo_id.ToString());
            if (photo_ids != null)
                parameters.Add("photo_ids", string.Join(",", photo_ids));

            return await _vkontakte.GetAsync<object>("market.edit", parameters);
        }

        /// <summary>
        /// Deletes an item.
        /// Docs: <see href="https://vk.com/dev/market.delete">market.delete</see>
        /// </summary>
        /// <param name="owner_id">ID of an item owner community.</param>
        /// <param name="item_id">Item ID.</param>
        public async Task<object> Delete(int? owner_id = null, int? item_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (item_id != null)
                parameters.Add("item_id", item_id.ToString());

            return await _vkontakte.GetAsync<object>("market.delete", parameters);
        }

        /// <summary>
        /// Restores recently deleted item
        /// Docs: <see href="https://vk.com/dev/market.restore">market.restore</see>
        /// </summary>
        /// <param name="owner_id">ID of an item owner community.</param>
        /// <param name="item_id">Deleted item ID.</param>
        public async Task<object> Restore(int? owner_id = null, int? item_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (item_id != null)
                parameters.Add("item_id", item_id.ToString());

            return await _vkontakte.GetAsync<object>("market.restore", parameters);
        }

        /// <summary>
        /// Changes item place in a collection.
        /// Docs: <see href="https://vk.com/dev/market.reorderItems">market.reorderItems</see>
        /// </summary>
        /// <param name="owner_id">ID of an item owner community.</param>
        /// <param name="album_id">ID of a collection to reorder items in. Set 0 to reorder full items list.</param>
        /// <param name="item_id">Item ID.</param>
        /// <param name="before">ID of an item to place current item before it.</param>
        /// <param name="after">ID of an item to place current item after it.</param>
        public async Task<object> ReorderItems(int? owner_id = null, int? album_id = null, int? item_id = null, int? before = null, int? after = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (album_id != null)
                parameters.Add("album_id", album_id.ToString());
            if (item_id != null)
                parameters.Add("item_id", item_id.ToString());
            if (before != null)
                parameters.Add("before", before.ToString());
            if (after != null)
                parameters.Add("after", after.ToString());

            return await _vkontakte.GetAsync<object>("market.reorderItems", parameters);
        }

        /// <summary>
        /// Reorders the collections list.
        /// Docs: <see href="https://vk.com/dev/market.reorderAlbums">market.reorderAlbums</see>
        /// </summary>
        /// <param name="owner_id">ID of an item owner community.</param>
        /// <param name="album_id">Collection ID.</param>
        /// <param name="before">ID of a collection to place current collection before it.</param>
        /// <param name="after">ID of a collection to place current collection after it.</param>
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

            return await _vkontakte.GetAsync<object>("market.reorderAlbums", parameters);
        }

        /// <summary>
        /// Creates new collection of items
        /// Docs: <see href="https://vk.com/dev/market.addAlbum">market.addAlbum</see>
        /// </summary>
        /// <param name="owner_id">ID of an item owner community.</param>
        /// <param name="title">Collection title.</param>
        /// <param name="photo_id">Cover photo ID.</param>
        /// <param name="main_album">Set as main ('1' – set, '0' – no).</param>
        public async Task<object> AddAlbum(int? owner_id = null, string title = null, int? photo_id = null, bool? main_album = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (title != null)
                parameters.Add("title", title);
            if (photo_id != null)
                parameters.Add("photo_id", photo_id.ToString());
            if (main_album != null)
                parameters.Add("main_album", main_album.ToString());

            return await _vkontakte.GetAsync<object>("market.addAlbum", parameters);
        }

        /// <summary>
        /// Edits a collection of items
        /// Docs: <see href="https://vk.com/dev/market.editAlbum">market.editAlbum</see>
        /// </summary>
        /// <param name="owner_id">ID of an collection owner community.</param>
        /// <param name="album_id">Collection ID.</param>
        /// <param name="title">Collection title.</param>
        /// <param name="photo_id">Cover photo id</param>
        /// <param name="main_album">Set as main ('1' – set, '0' – no).</param>
        public async Task<object> EditAlbum(int? owner_id = null, int? album_id = null, string title = null, int? photo_id = null, bool? main_album = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (album_id != null)
                parameters.Add("album_id", album_id.ToString());
            if (title != null)
                parameters.Add("title", title);
            if (photo_id != null)
                parameters.Add("photo_id", photo_id.ToString());
            if (main_album != null)
                parameters.Add("main_album", main_album.ToString());

            return await _vkontakte.GetAsync<object>("market.editAlbum", parameters);
        }

        /// <summary>
        /// Deletes a collection of items.
        /// Docs: <see href="https://vk.com/dev/market.deleteAlbum">market.deleteAlbum</see>
        /// </summary>
        /// <param name="owner_id">ID of an collection owner community.</param>
        /// <param name="album_id">Collection ID.</param>
        public async Task<object> DeleteAlbum(int? owner_id = null, int? album_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (album_id != null)
                parameters.Add("album_id", album_id.ToString());

            return await _vkontakte.GetAsync<object>("market.deleteAlbum", parameters);
        }

        /// <summary>
        /// Removes an item from one or multiple collections.
        /// Docs: <see href="https://vk.com/dev/market.removeFromAlbum">market.removeFromAlbum</see>
        /// </summary>
        /// <param name="owner_id">ID of an item owner community.</param>
        /// <param name="item_id">Item ID.</param>
        /// <param name="album_ids">Collections IDs to remove item from.</param>
        public async Task<object> RemoveFromAlbum(int? owner_id = null, int? item_id = null, IEnumerable<int?> album_ids = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (item_id != null)
                parameters.Add("item_id", item_id.ToString());
            if (album_ids != null)
                parameters.Add("album_ids", string.Join(",", album_ids));

            return await _vkontakte.GetAsync<object>("market.removeFromAlbum", parameters);
        }

        /// <summary>
        /// Adds an item to one or multiple collections.
        /// Docs: <see href="https://vk.com/dev/market.addToAlbum">market.addToAlbum</see>
        /// </summary>
        /// <param name="owner_id">ID of an item owner community.</param>
        /// <param name="item_id">Item ID.</param>
        /// <param name="album_ids">Collections IDs to add item to.</param>
        public async Task<object> AddToAlbum(int? owner_id = null, int? item_id = null, IEnumerable<int?> album_ids = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (item_id != null)
                parameters.Add("item_id", item_id.ToString());
            if (album_ids != null)
                parameters.Add("album_ids", string.Join(",", album_ids));

            return await _vkontakte.GetAsync<object>("market.addToAlbum", parameters);
        }

    }
}
