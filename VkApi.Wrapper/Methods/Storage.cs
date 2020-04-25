using VkApi.Wrapper.Objects;
using VkApi.Wrapper.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Methods
{
    public class Storage
    {
        private readonly Vkontakte _vkontakte;

        internal Storage(Vkontakte vkontakte) => _vkontakte = vkontakte;

        ///<summary>
        /// Returns a value of variable with the name set by key parameter.
        ///</summary>
        public Task<StorageValue[]> Get(String key = null, String[] keys = null, int? userId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (key != null)
                parameters.Add("key", key.ToApiString());
            if (keys != null)
                parameters.Add("keys", keys.ToApiString());
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            return _vkontakte.RequestAsync<StorageValue[]>("storage.get", parameters);
        }

        ///<summary>
        /// Returns the names of all variables.
        ///</summary>
        public Task<String[]> GetKeys(int? userId = null, int? offset = null, int? count = null)
        {
            var parameters = new Dictionary<string, string>();
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            return _vkontakte.RequestAsync<String[]>("storage.getKeys", parameters);
        }

        ///<summary>
        /// Saves a value of variable with the name set by 'key' parameter.
        ///</summary>
        public Task<BaseOkResponse> Set(String key = null, String value = null, int? userId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (key != null)
                parameters.Add("key", key.ToApiString());
            if (value != null)
                parameters.Add("value", value.ToApiString());
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("storage.set", parameters);
        }
    }
}