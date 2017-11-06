using System.Collections.Generic;
using System.Threading.Tasks;
using VkLibrary.Core.Responses.Widgets;

namespace VkLibrary.Core.Methods
{
    /// <summary>
    /// Widgets API section.
    /// </summary>
    public class Widgets
    {
        private readonly Vkontakte _vkontakte;
        internal Widgets(Vkontakte vkontakte) => _vkontakte = vkontakte;

        /// <summary>
        /// Gets a list of comments for the page added through the Comments widget.
        /// Docs: <see href="https://vk.com/dev/widgets.getComments">widgets.getComments</see>
        /// </summary>
        public Task<GetCommentsResponse> GetComments(int? widgetApiId = null, string url = null,
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

            return _vkontakte.RequestAsync<GetCommentsResponse>("widgets.getComments", parameters);
        }

        /// <summary>
        /// Gets a list of application/site pages where the Comments widget or Like widget is installed.
        /// Docs: <see href="https://vk.com/dev/widgets.getPages">widgets.getPages</see>
        /// </summary>
        public Task<GetPagesResponse> GetPages(int? widgetApiId = null, string order = null,
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

            return _vkontakte.RequestAsync<GetPagesResponse>("widgets.getPages", parameters);
        }
    }
}