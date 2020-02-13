using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VkApi.Wrapper.Responses.Search;

namespace VkApi.Wrapper.Methods
{
    public class Search
    {
        private readonly Vkontakte _vkontakte;

        internal Search(Vkontakte vkontakte) => _vkontakte = vkontakte;

        ///<summary>
        /// Allows the programmer to do a quick search for any substring.
        ///</summary>
        public Task<SearchGetHintsResponse> GetHints(String q = null, int? offset = null, int? limit = null, String[] filters = null, String[] fields = null, Boolean? searchGlobal = null)
        {
            var parameters = new Dictionary<string, string>();
            if (q != null)
                parameters.Add("q", q.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (limit != null)
                parameters.Add("limit", limit.ToApiString());
            if (filters != null)
                parameters.Add("filters", filters.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            if (searchGlobal != null)
                parameters.Add("search_global", searchGlobal.ToApiString());
            return _vkontakte.RequestAsync<SearchGetHintsResponse>("search.getHints", parameters);
        }
    }
}