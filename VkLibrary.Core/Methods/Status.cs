using System.Collections.Generic;
using System.Threading.Tasks;

namespace VkLibrary.Core.Methods
{
    /// <summary>
    /// Status API section.
    /// </summary>
    public class Status
    {
        private readonly Vkontakte _vkontakte;
        internal Status(Vkontakte vkontakte) => _vkontakte = vkontakte;

        /// <summary>
        /// Returns data required to show the status of a user or community.
        /// Docs: <see href="https://vk.com/dev/status.get">status.get</see>
        /// </summary>
        /// <param name="userId">User ID or community ID. Use a negative value to designate a community ID.</param>
        /// <param name="groupId"></param>
        public Task<Types.Status.Status> Get(int? userId = null, int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());

            return _vkontakte.RequestAsync<Types.Status.Status>("status.get", parameters);
        }

        /// <summary>
        /// Sets a new status for the current user.
        /// Docs: <see href="https://vk.com/dev/status.set">status.set</see>
        /// </summary>
        /// <param name="text">Text of the new status.</param>
        /// <param name="groupId">Identifier of a community to set a status in. If left blank the status is set to current user.</param>
        public Task<int> Set(string text = null, int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (text != null)
                parameters.Add("text", text);
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());

            return _vkontakte.RequestAsync<int>("status.set", parameters);
        }
    }
}