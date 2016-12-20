using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkLib.Methods
{
    /// <summary>
    /// Search API section.
    /// </summary>
    public class Search
    {
        private Vkontakte _vkontakte;

        internal Search(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        /// Allows the programmer to do a quick search for any substring.
        /// Docs: <see href="https://vk.com/dev/search.getHints">search.getHints</see>
        /// </summary>
        /// <param name="q">Search query string.</param>
        /// <param name="limit">Maximum number of results to return.</param>
        /// <param name="filters"></param>
        /// <param name="search_global"></param>
        public async Task<IEnumerable<VkLib.Types.Search.Hint>> GetHints(string q = null, int? limit = null, IEnumerable<string> filters = null, bool? search_global = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (q != null)
                parameters.Add("q", q);
            if (limit != null)
                parameters.Add("limit", limit.ToString());
            if (filters != null)
                parameters.Add("filters", string.Join(",", filters));
            if (search_global != null)
                parameters.Add("search_global", search_global.ToString());

            return await _vkontakte.GetAsync<IEnumerable<VkLib.Types.Search.Hint>>("search.getHints", parameters);
        }

    }
}
