using VkLibrary.Core.Objects;
using VkLibrary.Core.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VkLibrary.Core.Methods
{
    public class Fave
    {
        private readonly Vkontakte _vkontakte;

        internal Fave(Vkontakte vkontakte) => _vkontakte = vkontakte;

        ///<summary>
        /// Adds a link to user faves.
        ///</summary>
        public Task<BaseOkResponse> AddLink(String link = null)
        {
            var parameters = new Dictionary<string, string>();
            if (link != null)
                parameters.Add("link", link.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("fave.addLink", parameters);
        }

        ///<summary>
        /// Removes link from the user's faves.
        ///</summary>
        public Task<BaseOkResponse> RemoveLink(String linkId = null, String link = null)
        {
            var parameters = new Dictionary<string, string>();
            if (linkId != null)
                parameters.Add("link_id", linkId.ToApiString());
            if (link != null)
                parameters.Add("link", link.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("fave.removeLink", parameters);
        }
    }
}