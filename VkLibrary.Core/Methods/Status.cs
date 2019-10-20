using VkLibrary.Core.Objects;
using VkLibrary.Core.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VkLibrary.Core.Methods
{
    public class Status
    {
        private readonly Vkontakte _vkontakte;

        internal Status(Vkontakte vkontakte) => _vkontakte = vkontakte;

        ///<summary>
        /// Returns data required to show the status of a user or community.
        ///</summary>
        public Task<StatusStatus> Get(int? userId = null, int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            return _vkontakte.RequestAsync<StatusStatus>("status.get", parameters);
        }

        ///<summary>
        /// Sets a new status for the current user.
        ///</summary>
        public Task<BaseOkResponse> Set(String text = null, int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (text != null)
                parameters.Add("text", text.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("status.set", parameters);
        }
    }
}