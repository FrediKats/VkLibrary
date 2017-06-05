using System.Collections.Generic;
using System.Threading.Tasks;
using VkLibrary.Core.Types.Utils;

namespace VkLibrary.Core.Methods
{
    /// <summary>
    /// Utils API section.
    /// </summary>
    public class Utils
    {
        private readonly Vkontakte _vkontakte;
        internal Utils(Vkontakte vkontakte) => _vkontakte = vkontakte;

        /// <summary>
        /// Checks whether a link is blocked in VK.
        /// Docs: <see href="https://vk.com/dev/utils.checkLink">utils.checkLink</see>
        /// </summary>
        /// <param name="url">Link to check (e.g., 'http://google.com').</param>
        public async Task<LinkChecked> CheckLink(string url = null)
        {
            var parameters = new Dictionary<string, string>();
            if (url != null) parameters.Add("url", url);
            return await _vkontakte.GetAsync<LinkChecked>("utils.checkLink", parameters);
        }

        /// <summary>
        /// Detects a type of object (e.g., user, community, application) and its ID by screen name.
        /// Docs: <see href="https://vk.com/dev/utils.resolveScreenName">utils.resolveScreenName</see>
        /// </summary>
        /// <param name="screenName">
        /// Screen name of the user, community (e.g., 'apiclub,' 'andrew', or 'rules_of_war'), or
        /// application.
        /// </param>
        public async Task<DomainResolved> ResolveScreenName(string screenName = null)
        {
            var parameters = new Dictionary<string, string>();
            if (screenName != null) parameters.Add("screen_name", screenName);
            return await _vkontakte.GetAsync<DomainResolved>("utils.resolveScreenName", parameters);
        }

        /// <summary>
        /// Returns the current time of the VK server.
        /// Docs: <see href="https://vk.com/dev/utils.getServerTime">utils.getServerTime</see>
        /// </summary>
        public async Task<int?> GetServerTime() => 
            await _vkontakte.GetAsync<int?>("utils.getServerTime", 
                new Dictionary<string, string>());

        /// <summary>
        /// Allows to receive a link shortened via vk.cc. 
        /// Docs: <see href="https://vk.com/dev/utils.getShortLink">utils.getShortLink</see>
        /// </summary>
        /// <param name="url">URL to be shortened.</param>
        /// <param name="private_"></param>
        public async Task<LinkInfo> GetShortLink(string url = null, bool? private_ = null)
        {
            var parameters = new Dictionary<string, string>();

            if (url != null)
                parameters.Add("url", url.ToApiString());
            if (private_ != null)
                parameters.Add("private", private_.ToApiString());

            return await _vkontakte.GetAsync<LinkInfo>("utils.getShortLink", parameters);
        }

        /// <summary>
        /// Returns stats data for shortened link. 
        /// Docs: <see href="https://vk.com/dev/utils.getLinkStats">utils.getLinkStats</see>
        /// </summary>
        /// <param name="key">Returns stats data for shortened link.</param>
        /// <param name="accessKey">Access key for private link stats</param>
        /// <param name="interval">Interval. Possible values: hour; day; week; month; forever.</param>
        /// <param name="intervalsCount">Number of intervals to return. </param>
        /// <param name="extended">
        /// 1 — to return extended stats data (sex, age, geo).
        ///  0 (by default) — to return views number only.
        /// </param>
        public async Task<LinkInfoXtrStats> GetLinkStats(string key, string accessKey = null, 
            string interval = null, int? intervalsCount = null, bool? extended = null)
        {
            var parameters = new Dictionary<string, string>();

            if (key != null)
                parameters.Add("key", key.ToApiString());
            if (accessKey != null)
                parameters.Add("access_key", accessKey.ToApiString());
            if (interval != null)
                parameters.Add("interval", interval.ToApiString());
            if (intervalsCount != null)
                parameters.Add("intervals_count", intervalsCount.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());

            return await _vkontakte.GetAsync<LinkInfoXtrStats>("utils.getLinkStats", parameters);
        }

        /// <summary>
        /// Returns a list of user's shortened links. 
        /// Docs: <see href="https://vk.com/dev/utils.getLastShortenedLinks">utils.getLastShortenedLinks</see>
        /// </summary>
        /// <param name="count">Number of links to return.</param>
        /// <param name="offset">Offset needed to return a specific subset of links.</param>
        public async Task<ApiItemsResponse<LinkInfoFull>> GetLastShortenedLinks(int? count = null, int? offset = null)
        {
            var parameters = new Dictionary<string, string>();

            if (count != null) parameters.Add("count", count.ToApiString());
            if (offset != null) parameters.Add("offset", offset.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<LinkInfoFull>>("utils.getLastShortenedLinks", parameters);
        }

        /// <summary>
        /// Deletes shortened link from user's list. 
        /// </summary>
        /// <param name="key">Link key (characters after "vk.cc"). </param>
        public async Task<int?> DeleteFromLastShortened(string key)
        {
            var parameters = new Dictionary<string, string>();
            if (key != null) parameters.Add("key", key);
            return await _vkontakte.GetAsync<int?>("utils.deleteFromLastShortened", parameters);
        }
    }
}