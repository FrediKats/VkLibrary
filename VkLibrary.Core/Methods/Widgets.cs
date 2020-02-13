using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VkApi.Wrapper.Responses.Widgets;
using VkApi.Wrapper.Types.Users;

namespace VkApi.Wrapper.Methods
{
    public class Widgets
    {
        private readonly Vkontakte _vkontakte;

        internal Widgets(Vkontakte vkontakte) => _vkontakte = vkontakte;

        ///<summary>
        /// Gets a list of comments for the page added through the [vk.com/dev/Comments|Comments widget].
        ///</summary>
        public Task<WidgetsGetCommentsResponse> GetComments(int? widgetApiId = null, String url = null, String pageId = null, String order = null, UsersFields[] fields = null, int? offset = null, int? count = null)
        {
            var parameters = new Dictionary<string, string>();
            if (widgetApiId != null)
                parameters.Add("widget_api_id", widgetApiId.ToApiString());
            if (url != null)
                parameters.Add("url", url.ToApiString());
            if (pageId != null)
                parameters.Add("page_id", pageId.ToApiString());
            if (order != null)
                parameters.Add("order", order.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            return _vkontakte.RequestAsync<WidgetsGetCommentsResponse>("widgets.getComments", parameters);
        }

        ///<summary>
        /// Gets a list of application/site pages where the [vk.com/dev/Comments|Comments widget] or [vk.com/dev/Like|Like widget] is installed.
        ///</summary>
        public Task<WidgetsGetPagesResponse> GetPages(int? widgetApiId = null, String order = null, String period = null, int? offset = null, int? count = null)
        {
            var parameters = new Dictionary<string, string>();
            if (widgetApiId != null)
                parameters.Add("widget_api_id", widgetApiId.ToApiString());
            if (order != null)
                parameters.Add("order", order.ToApiString());
            if (period != null)
                parameters.Add("period", period.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            return _vkontakte.RequestAsync<WidgetsGetPagesResponse>("widgets.getPages", parameters);
        }
    }
}