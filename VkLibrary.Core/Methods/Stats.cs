using System.Collections.Generic;
using System.Threading.Tasks;
using VkLibrary.Core.Types.Stats;

namespace VkLibrary.Core.Methods
{
    /// <summary>
    /// Stats API section.
    /// </summary>
    public class Stats
    {
        private readonly Vkontakte _vkontakte;
        internal Stats(Vkontakte vkontakte) => _vkontakte = vkontakte;

        /// <summary>
        /// Returns statistics of a community or an application.
        /// Docs: <see href="https://vk.com/dev/stats.get">stats.get</see>
        /// </summary>
        /// <param name="groupId">Community ID.</param>
        /// <param name="appId">Application ID.</param>
        /// <param name="dateFrom">Latest datestamp (in Unix time) of statistics to return.</param>
        /// <param name="dateTo">End datestamp (in Unix time) of statistics to return.</param>
        public Task<IEnumerable<Period>> Get(int? groupId = null, int? appId = null, string dateFrom = null,
            string dateTo = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (appId != null)
                parameters.Add("app_id", appId.ToApiString());
            if (dateFrom != null)
                parameters.Add("date_from", dateFrom);
            if (dateTo != null)
                parameters.Add("date_to", dateTo);

            return _vkontakte.RequestAsync<IEnumerable<Period>>("stats.get", parameters);
        }

        /// <summary>
        /// Docs: <see href="https://vk.com/dev/stats.trackVisitor">stats.trackVisitor</see>
        /// </summary>
        public Task<int> TrackVisitor()
        {
            var parameters = new Dictionary<string, string>();


            return _vkontakte.RequestAsync<int>("stats.trackVisitor", parameters);
        }

        /// <summary>
        /// Returns stats for a wall post.
        /// Docs: <see href="https://vk.com/dev/stats.getPostReach">stats.getPostReach</see>
        /// </summary>
        /// <param name="ownerId">post owner community id. Specify with "-" sign.</param>
        /// <param name="postId">
        /// wall post id. Note that stats are available only for '300' last (newest) posts on a community
        /// wall.
        /// </param>
        public Task<IEnumerable<WallpostStat>> GetPostReach(int? ownerId = null, int? postId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (postId != null)
                parameters.Add("post_id", postId.ToApiString());

            return _vkontakte.RequestAsync<IEnumerable<WallpostStat>>("stats.getPostReach", parameters);
        }
    }
}