using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VkApi.Wrapper.Types.Stats;

namespace VkApi.Wrapper.Methods
{
    public class Stats
    {
        private readonly Vkontakte _vkontakte;

        internal Stats(Vkontakte vkontakte) => _vkontakte = vkontakte;

        ///<summary>
        /// Returns statistics of a community or an application.
        ///</summary>
        public Task<StatsPeriod[]> Get(int? groupId = null, int? appId = null, int? timestampFrom = null, int? timestampTo = null, String interval = null, int? intervalsCount = null, String[] filters = null, String[] statsGroups = null, Boolean? extended = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (appId != null)
                parameters.Add("app_id", appId.ToApiString());
            if (timestampFrom != null)
                parameters.Add("timestamp_from", timestampFrom.ToApiString());
            if (timestampTo != null)
                parameters.Add("timestamp_to", timestampTo.ToApiString());
            if (interval != null)
                parameters.Add("interval", interval.ToApiString());
            if (intervalsCount != null)
                parameters.Add("intervals_count", intervalsCount.ToApiString());
            if (filters != null)
                parameters.Add("filters", filters.ToApiString());
            if (statsGroups != null)
                parameters.Add("stats_groups", statsGroups.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            return _vkontakte.RequestAsync<StatsPeriod[]>("stats.get", parameters);
        }

        ///<summary>
        /// Returns stats for a wall post.
        ///</summary>
        public Task<StatsWallpostStat[]> GetPostReach(String ownerId = null, int? postId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (postId != null)
                parameters.Add("post_id", postId.ToApiString());
            return _vkontakte.RequestAsync<StatsWallpostStat[]>("stats.getPostReach", parameters);
        }
    }
}