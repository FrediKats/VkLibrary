using System.Collections.Generic;
using System.Threading.Tasks;
using VkLib.Responses.Widgets;

namespace VkLib.Methods
{
    /// <summary>
    ///     Widgets API section.
    /// </summary>
    public class Widgets
    {
        private readonly Vkontakte _vkontakte;

        internal Widgets(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        ///     Gets a list of comments for the page added through the [vk.com/dev/Comments|Comments widget].
        ///     Docs: <see href="https://vk.com/dev/widgets.getComments">widgets.getComments</see>
        /// </summary>
        /// <param name="widgetApiId"></param>
        /// <param name="url"></param>
        /// <param name="pageId"></param>
        /// <param name="order"></param>
        /// <param name="fields"></param>
        /// <param name="count"></param>
        public async Task<GetCommentsResponse> GetComments(int? widgetApiId = null, string url = null,
            string pageId = null, string order = null, IEnumerable<string> fields = null, int? count = null)
        {
            var parameters = new Dictionary<string, string>();

            if (widgetApiId != null)
                parameters.Add("widget_api_id", widgetApiId.ToApiString());
            if (url != null)
                parameters.Add("url", url);
            if (pageId != null)
                parameters.Add("page_id", pageId);
            if (order != null)
                parameters.Add("order", order);
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());

            return await _vkontakte.GetAsync<GetCommentsResponse>("widgets.getComments", parameters);
        }

        /// <summary>
        ///     Gets a list of application/site pages where the [vk.com/dev/Comments|Comments widget] or [vk.com/dev/Like|Like
        ///     widget] is installed.
        ///     Docs: <see href="https://vk.com/dev/widgets.getPages">widgets.getPages</see>
        /// </summary>
        /// <param name="widgetApiId"></param>
        /// <param name="order"></param>
        /// <param name="period"></param>
        /// <param name="count"></param>
        public async Task<GetPagesResponse> GetPages(int? widgetApiId = null, string order = null,
            string period = null, int? count = null)
        {
            var parameters = new Dictionary<string, string>();

            if (widgetApiId != null)
                parameters.Add("widget_api_id", widgetApiId.ToApiString());
            if (order != null)
                parameters.Add("order", order);
            if (period != null)
                parameters.Add("period", period);
            if (count != null)
                parameters.Add("count", count.ToApiString());

            return await _vkontakte.GetAsync<GetPagesResponse>("widgets.getPages", parameters);
        }
    }
}