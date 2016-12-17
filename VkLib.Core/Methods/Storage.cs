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
        public async Task<object> Get(string key = null, IEnumerable<string> keys = null, int? user_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (key != null)
                parameters.Add("key", key);
            if (keys != null)
                parameters.Add("keys", string.Join(",", keys));
            if (user_id != null)
                parameters.Add("user_id", user_id.ToString());

            return await _vkontakte.GetAsync<object>("storage.get", parameters);
        }

        /// <summary>
        /// Saves a value of variable with the name set by 'key' parameter.
        /// Docs: <see href="https://vk.com/dev/storage.set">storage.set</see>
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="user_id"></param>
        public async Task<object> Set(string key = null, string value = null, int? user_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (key != null)
                parameters.Add("key", key);
            if (value != null)
                parameters.Add("value", value);
            if (user_id != null)
                parameters.Add("user_id", user_id.ToString());

            return await _vkontakte.GetAsync<object>("storage.set", parameters);
        }

        /// <summary>
        /// Returns the names of all variables.
        /// Docs: <see href="https://vk.com/dev/storage.getKeys">storage.getKeys</see>
        /// </summary>
        /// <param name="user_id">user id, whose variables names are returned if they were requested with a server method.</param>
        /// <param name="count">amount of variable names the info needs to be collected from.</param>
        public async Task<object> GetKeys(int? user_id = null, int? count = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (user_id != null)
                parameters.Add("user_id", user_id.ToString());
            if (count != null)
                parameters.Add("count", count.ToString());

            return await _vkontakte.GetAsync<object>("storage.getKeys", parameters);
        }

    }
}
