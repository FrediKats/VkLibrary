using System.Collections.Generic;
using System.Threading.Tasks;
using VkApi.Wrapper.Responses.Gifts;

namespace VkApi.Wrapper.Methods
{
    public class Gifts
    {
        private readonly Vkontakte _vkontakte;

        internal Gifts(Vkontakte vkontakte) => _vkontakte = vkontakte;

        ///<summary>
        /// Returns a list of user gifts.
        ///</summary>
        public Task<GiftsGetResponse> Get(int? userId = null, int? count = null, int? offset = null)
        {
            var parameters = new Dictionary<string, string>();
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            return _vkontakte.RequestAsync<GiftsGetResponse>("gifts.get", parameters);
        }
    }
}