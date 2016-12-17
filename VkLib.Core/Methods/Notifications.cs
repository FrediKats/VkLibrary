using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkLib.Methods
{
    /// <summary>
    /// Notifications API section.
    /// </summary>
    public class Notifications
    {
        private Vkontakte _vkontakte;

        internal Notifications(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        /// Returns a list of notifications about other users' feedback to the current user's wall posts.
        /// Docs: <see href="https://vk.com/dev/notifications.get">notifications.get</see>
        /// </summary>
        /// <param name="count">Number of notifications to return.</param>
        /// <param name="start_from"></param>
        /// <param name="filters">Type of notifications to return:; 'wall' — wall posts; 'mentions' — mentions in wall posts, comments, or topics; 'comments' — comments to wall posts, photos, and videos; 'likes' — likes; 'reposted' — wall posts that are copied from the current user's wall; 'followers' — new followers; 'friends' — accepted friend requests</param>
        /// <param name="start_time">Earliest timestamp (in Unix time) of a notification to return. By default, 24 hours ago.</param>
        /// <param name="end_time">Latest timestamp (in Unix time) of a notification to return. By default, the current time.</param>
        public async Task<object> Get(int? count = null, string start_from = null, IEnumerable<string> filters = null, int? start_time = null, int? end_time = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (count != null)
                parameters.Add("count", count.ToString());
            if (start_from != null)
                parameters.Add("start_from", start_from);
            if (filters != null)
                parameters.Add("filters", string.Join(",", filters));
            if (start_time != null)
                parameters.Add("start_time", start_time.ToString());
            if (end_time != null)
                parameters.Add("end_time", end_time.ToString());

            return await _vkontakte.GetAsync<object>("notifications.get", parameters);
        }

        /// <summary>
        /// Resets the counter of new notifications about other users' feedback to the current user's wall posts.
        /// Docs: <see href="https://vk.com/dev/notifications.markAsViewed">notifications.markAsViewed</see>
        /// </summary>
        public async Task<object> MarkAsViewed()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();


            return await _vkontakte.GetAsync<object>("notifications.markAsViewed", parameters);
        }

    }
}
