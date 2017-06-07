using System.Collections.Generic;
using System.Threading.Tasks;
using VkLibrary.Core.Types.Search;

namespace VkLibrary.Core.Methods
{
    /// <summary>
    /// Search API section.
    /// </summary>
    public class Search
    {
        private readonly Vkontakte _vkontakte;
        internal Search(Vkontakte vkontakte) => _vkontakte = vkontakte;

        /// <summary>
        /// Allows the programmer to do a quick search for any substring.
        /// Docs: <see href="https://vk.com/dev/search.getHints">search.getHints</see>
        /// </summary>
        /// <param name="q">Search query string.</param>
        /// <param name="limit">Maximum number of results to return.</param>
        /// <param name="filters"></param>
        /// <param name="searchGlobal"></param>
        public Task<IEnumerable<Hint>> GetHints(string q = null, int? limit = null,
            IEnumerable<string> filters = null, bool? searchGlobal = null)
        {
            var parameters = new Dictionary<string, string>();

            if (q != null)
                parameters.Add("q", q);
            if (limit != null)
                parameters.Add("limit", limit.ToApiString());
            if (filters != null)
                parameters.Add("filters", filters.ToApiString());
            if (searchGlobal != null)
                parameters.Add("search_global", searchGlobal.ToApiString());

            return _vkontakte.GetAsync<IEnumerable<Hint>>("search.getHints", parameters);
        }
    }
}