using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkLib.Methods
{
    /// <summary>
    /// Fave API section.
    /// </summary>
    public class Fave
    {
        private Vkontakte _vkontakte;

        internal Fave(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        /// Returns a list of users whom the current user has bookmarked.; ;
        /// Docs: <see href="https://vk.com/dev/fave.getUsers">fave.getUsers</see>
        /// </summary>
        /// <param name="offset">Offset needed to return a specific subset of users.</param>
        /// <param name="count">Number of users to return.</param>
        public async Task<ApiItemsResponse<VkLib.Types.Users.UserMin>> GetUsers(int? offset = null, int? count = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<VkLib.Types.Users.UserMin>>("fave.getUsers", parameters);
        }

        /// <summary>
        /// Returns a list of photos that the current user has liked.; ;
        /// Docs: <see href="https://vk.com/dev/fave.getPhotos">fave.getPhotos</see>
        /// </summary>
        /// <param name="offset">Offset needed to return a specific subset of photos.</param>
        /// <param name="count">Number of photos to return.</param>
        /// <param name="photo_sizes">'1' — to return photo sizes in a [vk.com/dev/photo_sizes|special format].</param>
        public async Task<ApiItemsResponse<VkLib.Types.Photos.Photo>> GetPhotos(int? offset = null, int? count = null, bool? photo_sizes = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (photo_sizes != null)
                parameters.Add("photo_sizes", photo_sizes.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<VkLib.Types.Photos.Photo>>("fave.getPhotos", parameters);
        }

        /// <summary>
        /// Returns a list of wall posts that the current user has liked.;
        /// Docs: <see href="https://vk.com/dev/fave.getPosts">fave.getPosts</see>
        /// </summary>
        /// <param name="offset">Offset needed to return a specific subset of posts.</param>
        /// <param name="count">Number of posts to return.</param>
        /// <param name="extended">'1' — to return additional 'wall', 'profiles', and 'groups' fields.; ; By default: '0'.</param>
        public async Task<VkLib.Responses.Newsfeed.NewsFeedResponse> GetPosts(int? offset = null, int? count = null, bool? extended = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());

            return await _vkontakte.GetAsync<VkLib.Responses.Newsfeed.NewsFeedResponse>("fave.getPosts", parameters);
        }

        /// <summary>
        /// Returns a list of videos that the current user has liked.;
        /// Docs: <see href="https://vk.com/dev/fave.getVideos">fave.getVideos</see>
        /// </summary>
        /// <param name="offset">Offset needed to return a specific subset of videos.</param>
        /// <param name="count">Number of videos to return.</param>
        /// <param name="extended">Return an additional information about videos. Also returns all owners profiles and groups.</param>
        public async Task<ApiItemsResponse<VkLib.Types.Video.VideoFull>> GetVideos(int? offset = null, int? count = null, bool? extended = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<VkLib.Types.Video.VideoFull>>("fave.getVideos", parameters);
        }

        /// <summary>
        /// Returns a list of links that the current user has bookmarked.
        /// Docs: <see href="https://vk.com/dev/fave.getLinks">fave.getLinks</see>
        /// </summary>
        /// <param name="offset">Offset needed to return a specific subset of users.</param>
        /// <param name="count">Number of results to return.</param>
        public async Task<ApiItemsResponse<VkLib.Types.Fave.FavesLink>> GetLinks(int? offset = null, int? count = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<VkLib.Types.Fave.FavesLink>>("fave.getLinks", parameters);
        }

        /// <summary>
        /// Returns market items bookmarked by current user.
        /// Docs: <see href="https://vk.com/dev/fave.getMarketItems">fave.getMarketItems</see>
        /// </summary>
        /// <param name="count">Number of results to return. ;</param>
        /// <param name="extended">'1' – to return additional fields 'likes, can_comment, can_repost, photos'. By default: '0'.</param>
        public async Task<ApiItemsResponse<VkLib.Types.Market.MarketItem>> GetMarketItems(int? count = null, bool? extended = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<VkLib.Types.Market.MarketItem>>("fave.getMarketItems", parameters);
        }

        /// <summary>
        /// Adds a profile to user faves.
        /// Docs: <see href="https://vk.com/dev/fave.addUser">fave.addUser</see>
        /// </summary>
        /// <param name="user_id">Profile ID.</param>
        public async Task<int> AddUser(int? user_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (user_id != null)
                parameters.Add("user_id", user_id.ToApiString());

            return await _vkontakte.GetAsync<int>("fave.addUser", parameters);
        }

        /// <summary>
        /// Removes a profile from user faves.
        /// Docs: <see href="https://vk.com/dev/fave.removeUser">fave.removeUser</see>
        /// </summary>
        /// <param name="user_id">Profile ID.</param>
        public async Task<int> RemoveUser(int? user_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (user_id != null)
                parameters.Add("user_id", user_id.ToApiString());

            return await _vkontakte.GetAsync<int>("fave.removeUser", parameters);
        }

        /// <summary>
        /// Adds a community to user faves.
        /// Docs: <see href="https://vk.com/dev/fave.addGroup">fave.addGroup</see>
        /// </summary>
        /// <param name="group_id">Community ID.</param>
        public async Task<int> AddGroup(int? group_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToApiString());

            return await _vkontakte.GetAsync<int>("fave.addGroup", parameters);
        }

        /// <summary>
        /// Removes a community from user faves.
        /// Docs: <see href="https://vk.com/dev/fave.removeGroup">fave.removeGroup</see>
        /// </summary>
        /// <param name="group_id">Community ID.</param>
        public async Task<int> RemoveGroup(int? group_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToApiString());

            return await _vkontakte.GetAsync<int>("fave.removeGroup", parameters);
        }

        /// <summary>
        /// Adds a link to user faves.
        /// Docs: <see href="https://vk.com/dev/fave.addLink">fave.addLink</see>
        /// </summary>
        /// <param name="link">Link URL.</param>
        /// <param name="text">Description text.</param>
        public async Task<int> AddLink(string link = null, string text = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (link != null)
                parameters.Add("link", link);
            if (text != null)
                parameters.Add("text", text);

            return await _vkontakte.GetAsync<int>("fave.addLink", parameters);
        }

        /// <summary>
        /// Removes link from the user's faves.
        /// Docs: <see href="https://vk.com/dev/fave.removeLink">fave.removeLink</see>
        /// </summary>
        /// <param name="link_id">Link ID (can be obtained by [vk.com/dev/faves.getLinks|faves.getLinks] method).</param>
        public async Task<int> RemoveLink(string link_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (link_id != null)
                parameters.Add("link_id", link_id);

            return await _vkontakte.GetAsync<int>("fave.removeLink", parameters);
        }

    }
}
