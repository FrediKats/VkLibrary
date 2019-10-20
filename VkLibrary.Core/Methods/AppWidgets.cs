using VkLibrary.Core.Objects;
using VkLibrary.Core.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VkLibrary.Core.Methods
{
    public class AppWidgets
    {
        private readonly Vkontakte _vkontakte;

        internal AppWidgets(Vkontakte vkontakte) => _vkontakte = vkontakte;

        ///<summary>
        /// Allows to update community app widget
        ///</summary>
        public Task<BaseOkResponse> Update(String code = null, String type = null)
        {
            var parameters = new Dictionary<string, string>();
            if (code != null)
                parameters.Add("code", code.ToApiString());
            if (type != null)
                parameters.Add("type", type.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("appWidgets.update", parameters);
        }
    }
}