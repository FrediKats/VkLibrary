using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VkApi.Wrapper.Responses.Utils;
using VkApi.Wrapper.Types.Base;
using VkApi.Wrapper.Types.Utils;

namespace VkApi.Wrapper.Methods
{
    public class Utils
    {
        private readonly Vkontakte _vkontakte;

        internal Utils(Vkontakte vkontakte) => _vkontakte = vkontakte;

        ///<summary>
        /// Checks whether a link is blocked in VK.
        ///</summary>
        public Task<UtilsLinkChecked> CheckLink(String url = null)
        {
            var parameters = new Dictionary<string, string>();
            if (url != null)
                parameters.Add("url", url.ToApiString());
            return _vkontakte.RequestAsync<UtilsLinkChecked>("utils.checkLink", parameters);
        }

        ///<summary>
        /// Deletes shortened link from user's list.
        ///</summary>
        public Task<BaseOkResponse> DeleteFromLastShortened(String key = null)
        {
            var parameters = new Dictionary<string, string>();
            if (key != null)
                parameters.Add("key", key.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("utils.deleteFromLastShortened", parameters);
        }

        ///<summary>
        /// Returns a list of user's shortened links.
        ///</summary>
        public Task<UtilsGetLastShortenedLinksResponse> GetLastShortenedLinks(int? count = null, int? offset = null)
        {
            var parameters = new Dictionary<string, string>();
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            return _vkontakte.RequestAsync<UtilsGetLastShortenedLinksResponse>("utils.getLastShortenedLinks", parameters);
        }

        ///<summary>
        /// Returns stats data for shortened link.
        ///</summary>
        public Task<UtilsLinkStats> GetLinkStats(String key = null, String source = null, String accessKey = null, String interval = null, int? intervalsCount = null, Boolean? extended = null)
        {
            var parameters = new Dictionary<string, string>();
            if (key != null)
                parameters.Add("key", key.ToApiString());
            if (source != null)
                parameters.Add("source", source.ToApiString());
            if (accessKey != null)
                parameters.Add("access_key", accessKey.ToApiString());
            if (interval != null)
                parameters.Add("interval", interval.ToApiString());
            if (intervalsCount != null)
                parameters.Add("intervals_count", intervalsCount.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            return _vkontakte.RequestAsync<UtilsLinkStats>("utils.getLinkStats", parameters);
        }

        ///<summary>
        /// Returns the current time of the VK server.
        ///</summary>
        public Task<int> GetServerTime()
        {
            var parameters = new Dictionary<string, string>();
            return _vkontakte.RequestAsync<int>("utils.getServerTime", parameters);
        }

        ///<summary>
        /// Allows to receive a link shortened via vk.cc.
        ///</summary>
        public Task<UtilsShortLink> GetShortLink(String url = null, Boolean? _private = null)
        {
            var parameters = new Dictionary<string, string>();
            if (url != null)
                parameters.Add("url", url.ToApiString());
            if (_private != null)
                parameters.Add("private", _private.ToApiString());
            return _vkontakte.RequestAsync<UtilsShortLink>("utils.getShortLink", parameters);
        }

        ///<summary>
        /// Detects a type of object (e.g., user, community, application) and its ID by screen name.
        ///</summary>
        public Task<UtilsDomainResolved> ResolveScreenName(String screenName = null)
        {
            var parameters = new Dictionary<string, string>();
            if (screenName != null)
                parameters.Add("screen_name", screenName.ToApiString());
            return _vkontakte.RequestAsync<UtilsDomainResolved>("utils.resolveScreenName", parameters);
        }
    }
}