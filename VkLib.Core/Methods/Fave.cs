using System.Collections.Generic;
using System.Threading.Tasks;
using VkLib.Responses.Newsfeed;
using VkLib.Types.Fave;
using VkLib.Types.Market;
using VkLib.Types.Photos;
using VkLib.Types.Users;
using VkLib.Types.Video;

namespace VkLib.Methods
{
    /// <summary>
    ///     Fave API section.
    /// </summary>
    public class Fave
    {
        private readonly Vkontakte _vkontakte;

        internal Fave(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        ///     Returns a list of users whom the current user has bookmarked.; ;
        ///     Docs: <see href="https://vk.com/dev/fave.getUsers">fave.getUsers</see>
        /// </summary>
        /// <param name="offset">Offset needed to return a specific subset of users.</param>
        /// <param name="count">Number of users to return.</param>
        public async Task<ApiItemsResponse<UserMin>> GetUsers(int? offset = null, int? count = null)
        {
            var parameters = new Dictionary<string, string>();

            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<UserMin>>("fave.getUsers", parameters);
        }

        /// <summary>
        ///     Returns a list of photos that the current user has liked.; ;
        ///     Docs: <see href="https://vk.com/dev/fave.getPhotos">fave.getPhotos</see>
        /// </summary>
        /// <param name="offset">Offset needed to return a specific subset of photos.</param>
        /// <param name="count">Number of photos to return.</param>
        /// <param name="photoSizes">'1' — to return photo sizes in a [vk.com/dev/photo_sizes|special format].</param>
        public async Task<ApiItemsResponse<Photo>> GetPhotos(int? offset = null, int? count = null,
            bool? photoSizes = null)
        {
            var parameters = new Dictionary<string, string>();

            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (photoSizes != null)
                parameters.Add("photo_sizes", photoSizes.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<Photo>>("fave.getPhotos", parameters);
        }

        /// <summary>
        ///     Returns a list of wall posts that the current user has liked.;
        ///     Docs: <see href="https://vk.com/dev/fave.getPosts">fave.getPosts</see>
        /// </summary>
        /// <param name="offset">Offset needed to return a specific subset of posts.</param>
        /// <param name="count">Number of posts to return.</param>
        /// <param name="extended">'1' — to return additional 'wall', 'profiles', and 'groups' fields.; ; By default: '0'.</param>
        public async Task<NewsFeedResponse> GetPosts(int? offset = null, int? count = null, bool? extended = null)
        {
            var parameters = new Dictionary<string, string>();

            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());

            return await _vkontakte.GetAsync<NewsFeedResponse>("fave.getPosts", parameters);
        }

        /// <summary>
        ///     Returns a list of videos that the current user has liked.;
        ///     Docs: <see href="https://vk.com/dev/fave.getVideos">fave.getVideos</see>
        /// </summary>
        /// <param name="offset">Offset needed to return a specific subset of videos.</param>
        /// <param name="count">Number of videos to return.</param>
        /// <param name="extended">Return an additional information about videos. Also returns all owners profiles and groups.</param>
        public async Task<ApiItemsResponse<VideoFull>> GetVideos(int? offset = null, int? count = null,
            bool? extended = null)
        {
            var parameters = new Dictionary<string, string>();

            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<VideoFull>>("fave.getVideos", parameters);
        }

        /// <summary>
        ///     Returns a list of links that the current user has bookmarked.
        ///     Docs: <see href="https://vk.com/dev/fave.getLinks">fave.getLinks</see>
        /// </summary>
        /// <param name="offset">Offset needed to return a specific subset of users.</param>
        /// <param name="count">Number of results to return.</param>
        public async Task<ApiItemsResponse<FavesLink>> GetLinks(int? offset = null, int? count = null)
        {
            var parameters = new Dictionary<string, string>();

            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<FavesLink>>("fave.getLinks", parameters);
        }

        /// <summary>
        ///     Returns market items bookmarked by current user.
        ///     Docs: <see href="https://vk.com/dev/fave.getMarketItems">fave.getMarketItems</see>
        /// </summary>
        /// <param name="count">Number of results to return. ;</param>
        /// <param name="extended">'1' – to return additional fields 'likes, can_comment, can_repost, photos'. By default: '0'.</param>
        public async Task<ApiItemsResponse<MarketItem>> GetMarketItems(int? count = null, bool? extended = null)
        {
            var parameters = new Dictionary<string, string>();

            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<MarketItem>>("fave.getMarketItems", parameters);
        }

        /// <summary>
        ///     Adds a profile to user faves.
        ///     Docs: <see href="https://vk.com/dev/fave.addUser">fave.addUser</see>
        /// </summary>
        /// <param name="userId">Profile ID.</param>
        public async Task<int> AddUser(int? userId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());

            return await _vkontakte.GetAsync<int>("fave.addUser", parameters);
        }

        /// <summary>
        ///     Removes a profile from user faves.
        ///     Docs: <see href="https://vk.com/dev/fave.removeUser">fave.removeUser</see>
        /// </summary>
        /// <param name="userId">Profile ID.</param>
        public async Task<int> RemoveUser(int? userId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());

            return await _vkontakte.GetAsync<int>("fave.removeUser", parameters);
        }

        /// <summary>
        ///     Adds a community to user faves.
        ///     Docs: <see href="https://vk.com/dev/fave.addGroup">fave.addGroup</see>
        /// </summary>
        /// <param name="groupId">Community ID.</param>
        public async Task<int> AddGroup(int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());

            return await _vkontakte.GetAsync<int>("fave.addGroup", parameters);
        }

        /// <summary>
        ///     Removes a community from user faves.
        ///     Docs: <see href="https://vk.com/dev/fave.removeGroup">fave.removeGroup</see>
        /// </summary>
        /// <param name="groupId">Community ID.</param>
        public async Task<int> RemoveGroup(int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());

            return await _vkontakte.GetAsync<int>("fave.removeGroup", parameters);
        }

        /// <summary>
        ///     Adds a link to user faves.
        ///     Docs: <see href="https://vk.com/dev/fave.addLink">fave.addLink</see>
        /// </summary>
        /// <param name="link">Link URL.</param>
        /// <param name="text">Description text.</param>
        public async Task<int> AddLink(string link = null, string text = null)
        {
            var parameters = new Dictionary<string, string>();

            if (link != null)
                parameters.Add("link", link);
            if (text != null)
                parameters.Add("text", text);

            return await _vkontakte.GetAsync<int>("fave.addLink", parameters);
        }

        /// <summary>
        ///     Removes link from the user's faves.
        ///     Docs: <see href="https://vk.com/dev/fave.removeLink">fave.removeLink</see>
        /// </summary>
        /// <param name="linkId">Link ID (can be obtained by [vk.com/dev/faves.getLinks|faves.getLinks] method).</param>
        public async Task<int> RemoveLink(string linkId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (linkId != null)
                parameters.Add("link_id", linkId);

            return await _vkontakte.GetAsync<int>("fave.removeLink", parameters);
        }
    }
}