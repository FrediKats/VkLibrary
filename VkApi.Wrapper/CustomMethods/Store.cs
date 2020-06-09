using System.Collections.Generic;
using System.Threading.Tasks;
using VkApi.Wrapper.CustomObjects;

namespace VkApi.Wrapper.CustomMethods
{
    public class Store
    {
        private readonly Vkontakte _vkontakte;

        internal Store(Vkontakte vkontakte) => _vkontakte = vkontakte;

        public Task<StickersKeywordsResponse> GetStickersKeywords()
        {
            var parameters = new Dictionary<string, string>();
            return _vkontakte.RequestAsync<StickersKeywordsResponse>("store.getStickersKeywords", parameters);
        }
    }
}