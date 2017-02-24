using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkLib.Methods
{
    /// <summary>
    /// Storage API section.
    /// </summary>
    public class Storage
    {
        private Vkontakte _vkontakte;

        internal Storage(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        /// Returns a value of variable with the name set by key parameter.
        /// Docs: <see href="https://vk.com/dev/storage.get">storage.get</see>
        /// </summary>
        /// <param name="key"></param>
        /// <param name="keys"></param>
        /// <param name="user_id"></param>
        public async Task<string> Get(string key = null, IEnumerable<string> keys = null, int? user_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (key != null)
                parameters.Add("key", key);
            if (keys != null)
                parameters.Add("keys", keys.ToApiString());
            if (user_id != null)
                parameters.Add("user_id", user_id.ToApiString());

            return await _vkontakte.GetAsync<string>("storage.get", parameters);
        }

        /// <summary>
        /// Saves a value of variable with the name set by 'key' parameter.
        /// Docs: <see href="https://vk.com/dev/storage.set">storage.set</see>
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="user_id"></param>
        public async Task<int> Set(string key = null, string value = null, int? user_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (key != null)
                parameters.Add("key", key);
            if (value != null)
                parameters.Add("value", value);
            if (user_id != null)
                parameters.Add("user_id", user_id.ToApiString());

            return await _vkontakte.GetAsync<int>("storage.set", parameters);
        }

        /// <summary>
        /// Returns the names of all variables.
        /// Docs: <see href="https://vk.com/dev/storage.getKeys">storage.getKeys</see>
        /// </summary>
        /// <param name="user_id">user id, whose variables names are returned if they were requested with a server method.</param>
        /// <param name="count">amount of variable names the info needs to be collected from.</param>
        public async Task<IEnumerable<string>> GetKeys(int? user_id = null, int? count = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (user_id != null)
                parameters.Add("user_id", user_id.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());

            return await _vkontakte.GetAsync<IEnumerable<string>>("storage.getKeys", parameters);
        }

    }
}
