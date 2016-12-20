using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkLib.Methods
{
    /// <summary>
    /// Widgets API section.
    /// </summary>
    public class Widgets
    {
        private Vkontakte _vkontakte;

        internal Widgets(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        /// Gets a list of comments for the page added through the [vk.com/dev/Comments|Comments widget].
        /// Docs: <see href="https://vk.com/dev/widgets.getComments">widgets.getComments</see>
        /// </summary>
        /// <param name="widget_api_id"></param>
        /// <param name="url"></param>
        /// <param name="page_id"></param>
        /// <param name="order"></param>
        /// <param name="fields"></param>
        /// <param name="count"></param>
        public async Task<VkLib.Responses.Widgets.GetCommentsResponse> GetComments(int? widget_api_id = null, string url = null, string page_id = null, string order = null, IEnumerable<string> fields = null, int? count = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (widget_api_id != null)
                parameters.Add("widget_api_id", widget_api_id.ToString());
            if (url != null)
                parameters.Add("url", url);
            if (page_id != null)
                parameters.Add("page_id", page_id);
            if (order != null)
                parameters.Add("order", order);
            if (fields != null)
                parameters.Add("fields", string.Join(",", fields));
            if (count != null)
                parameters.Add("count", count.ToString());

            return await _vkontakte.GetAsync<VkLib.Responses.Widgets.GetCommentsResponse>("widgets.getComments", parameters);
        }

        /// <summary>
        /// Gets a list of application/site pages where the [vk.com/dev/Comments|Comments widget] or [vk.com/dev/Like|Like widget] is installed.
        /// Docs: <see href="https://vk.com/dev/widgets.getPages">widgets.getPages</see>
        /// </summary>
        /// <param name="widget_api_id"></param>
        /// <param name="order"></param>
        /// <param name="period"></param>
        /// <param name="count"></param>
        public async Task<VkLib.Responses.Widgets.GetPagesResponse> GetPages(int? widget_api_id = null, string order = null, string period = null, int? count = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (widget_api_id != null)
                parameters.Add("widget_api_id", widget_api_id.ToString());
            if (order != null)
                parameters.Add("order", order);
            if (period != null)
                parameters.Add("period", period);
            if (count != null)
                parameters.Add("count", count.ToString());

            return await _vkontakte.GetAsync<VkLib.Responses.Widgets.GetPagesResponse>("widgets.getPages", parameters);
        }

    }
}
