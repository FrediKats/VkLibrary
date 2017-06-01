using System.Collections.Generic;
using System.Threading.Tasks;
using VkLib.Types.Utils;

namespace VkLib.Methods
{
    /// <summary>
    ///     Utils API section.
    /// </summary>
    public class Utils
    {
        private readonly Vkontakte _vkontakte;

        internal Utils(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        ///     Checks whether a link is blocked in VK.
        ///     Docs: <see href="https://vk.com/dev/utils.checkLink">utils.checkLink</see>
        /// </summary>
        /// <param name="url">Link to check (e.g., 'http://google.com').</param>
        public async Task<LinkChecked> CheckLink(string url = null)
        {
            var parameters = new Dictionary<string, string>();

            if (url != null)
                parameters.Add("url", url);

            return await _vkontakte.GetAsync<LinkChecked>("utils.checkLink", parameters);
        }

        /// <summary>
        ///     Detects a type of object (e.g., user, community, application) and its ID by screen name.
        ///     Docs: <see href="https://vk.com/dev/utils.resolveScreenName">utils.resolveScreenName</see>
        /// </summary>
        /// <param name="screenName">
        ///     Screen name of the user, community (e.g., 'apiclub,' 'andrew', or 'rules_of_war'), or
        ///     application.
        /// </param>
        public async Task<DomainResolved> ResolveScreenName(string screenName = null)
        {
            var parameters = new Dictionary<string, string>();

            if (screenName != null)
                parameters.Add("screen_name", screenName);

            return await _vkontakte.GetAsync<DomainResolved>("utils.resolveScreenName", parameters);
        }

        /// <summary>
        ///     Returns the current time of the VK server.
        ///     Docs: <see href="https://vk.com/dev/utils.getServerTime">utils.getServerTime</see>
        /// </summary>
        public async Task<int?> GetServerTime()
        {
            var parameters = new Dictionary<string, string>();


            return await _vkontakte.GetAsync<int?>("utils.getServerTime", parameters);
        }
    }
}