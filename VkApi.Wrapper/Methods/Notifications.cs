using VkApi.Wrapper.Objects;
using VkApi.Wrapper.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Methods
{
    public class Notifications
    {
        private readonly Vkontakte _vkontakte;

        internal Notifications(Vkontakte vkontakte) => _vkontakte = vkontakte;

        ///<summary>
        /// Returns a list of notifications about other users' feedback to the current user's wall posts.
        ///</summary>
        public Task<NotificationsGetResponse> Get(int? count = null, String startFrom = null, String[] filters = null, int? startTime = null, int? endTime = null)
        {
            var parameters = new Dictionary<string, string>();
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (startFrom != null)
                parameters.Add("start_from", startFrom.ToApiString());
            if (filters != null)
                parameters.Add("filters", filters.ToApiString());
            if (startTime != null)
                parameters.Add("start_time", startTime.ToApiString());
            if (endTime != null)
                parameters.Add("end_time", endTime.ToApiString());
            return _vkontakte.RequestAsync<NotificationsGetResponse>("notifications.get", parameters);
        }

        ///<summary>
        /// Resets the counter of new notifications about other users' feedback to the current user's wall posts.
        ///</summary>
        public Task<int> MarkAsViewed()
        {
            var parameters = new Dictionary<string, string>();
            return _vkontakte.RequestAsync<int>("notifications.markAsViewed", parameters);
        }
    }
}