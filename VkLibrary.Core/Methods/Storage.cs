using System.Collections.Generic;
using System.Threading.Tasks;

namespace VkLibrary.Core.Methods
{
    /// <summary>
    /// Storage API section.
    /// </summary>
    public class Storage
    {
        private readonly Vkontakte _vkontakte;

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
        /// <param name="userId"></param>
        public Task<string> Get(string key = null, IEnumerable<string> keys = null, int? userId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (key != null)
                parameters.Add("key", key);
            if (keys != null)
                parameters.Add("keys", keys.ToApiString());
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());

            return _vkontakte.GetAsync<string>("storage.get", parameters);
        }

        /// <summary>
        /// Saves a value of variable with the name set by 'key' parameter.
        /// Docs: <see href="https://vk.com/dev/storage.set">storage.set</see>
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="userId"></param>
        public Task<int> Set(string key = null, string value = null, int? userId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (key != null)
                parameters.Add("key", key);
            if (value != null)
                parameters.Add("value", value);
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());

            return _vkontakte.GetAsync<int>("storage.set", parameters);
        }

        /// <summary>
        /// Returns the names of all variables.
        /// Docs: <see href="https://vk.com/dev/storage.getKeys">storage.getKeys</see>
        /// </summary>
        /// <param name="userId">user id, whose variables names are returned if they were requested with a server method.</param>
        /// <param name="count">amount of variable names the info needs to be collected from.</param>
        public Task<IEnumerable<string>> GetKeys(int? userId = null, int? count = null)
        {
            var parameters = new Dictionary<string, string>();

            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());

            return _vkontakte.GetAsync<IEnumerable<string>>("storage.getKeys", parameters);
        }
    }
}