using System.Collections.Generic;
using System.Threading.Tasks;
using VkLibrary.Core.Types.Notifications;

namespace VkLibrary.Core.Methods
{
    /// <summary>
    /// Notifications API section.
    /// </summary>
    public class Notifications
    {
        private readonly Vkontakte _vkontakte;

        internal Notifications(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        /// Returns a list of notifications about other users' feedback to the current user's wall posts.
        /// Docs: <see href="https://vk.com/dev/notifications.get">notifications.get</see>
        /// </summary>
        /// <param name="count">Number of notifications to return.</param>
        /// <param name="startFrom"></param>
        /// <param name="filters">
        /// Type of notifications to return:; 'wall' — wall posts; 'mentions' — mentions in wall posts,
        /// comments, or topics; 'comments' — comments to wall posts, photos, and videos; 'likes' — likes; 'reposted' — wall
        /// posts that are copied from the current user's wall; 'followers' — new followers; 'friends' — accepted friend
        /// requests
        /// </param>
        /// <param name="startTime">Earliest timestamp (in Unix time) of a notification to return. By default, 24 hours ago.</param>
        /// <param name="endTime">Latest timestamp (in Unix time) of a notification to return. By default, the current time.</param>
        public Task<ApiItemsResponse<Notification>> Get(int? count = null, string startFrom = null,
            IEnumerable<string> filters = null, int? startTime = null, int? endTime = null)
        {
            var parameters = new Dictionary<string, string>();

            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (startFrom != null)
                parameters.Add("start_from", startFrom);
            if (filters != null)
                parameters.Add("filters", filters.ToApiString());
            if (startTime != null)
                parameters.Add("start_time", startTime.ToApiString());
            if (endTime != null)
                parameters.Add("end_time", endTime.ToApiString());

            return _vkontakte.GetAsync<ApiItemsResponse<Notification>>("notifications.get", parameters);
        }

        /// <summary>
        /// Resets the counter of new notifications about other users' feedback to the current user's wall posts.
        /// Docs: <see href="https://vk.com/dev/notifications.markAsViewed">notifications.markAsViewed</see>
        /// </summary>
        public Task<int> MarkAsViewed()
        {
            var parameters = new Dictionary<string, string>();


            return _vkontakte.GetAsync<int>("notifications.markAsViewed", parameters);
        }
    }
}