using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkLib.Methods
{
    /// <summary>
    /// Status API section.
    /// </summary>
    public class Status
    {
        private Vkontakte _vkontakte;

        internal Status(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        /// Returns data required to show the status of a user or community.
        /// Docs: <see href="https://vk.com/dev/status.get">status.get</see>
        /// </summary>
        /// <param name="user_id">User ID or community ID. Use a negative value to designate a community ID.</param>
        /// <param name="group_id"></param>
        public async Task<VkLib.Types.Status.Status> Get(int? user_id = null, int? group_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (user_id != null)
                parameters.Add("user_id", user_id.ToApiString());
            if (group_id != null)
                parameters.Add("group_id", group_id.ToApiString());

            return await _vkontakte.GetAsync<VkLib.Types.Status.Status>("status.get", parameters);
        }

        /// <summary>
        /// Sets a new status for the current user.
        /// Docs: <see href="https://vk.com/dev/status.set">status.set</see>
        /// </summary>
        /// <param name="text">Text of the new status.</param>
        /// <param name="group_id">Identifier of a community to set a status in. If left blank the status is set to current user.</param>
        public async Task<int> Set(string text = null, int? group_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (text != null)
                parameters.Add("text", text);
            if (group_id != null)
                parameters.Add("group_id", group_id.ToApiString());

            return await _vkontakte.GetAsync<int>("status.set", parameters);
        }

    }
}
