using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkLib.Methods
{
    /// <summary>
    /// Utils API section.
    /// </summary>
    public class Utils
    {
        private Vkontakte _vkontakte;

        internal Utils(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        /// Checks whether a link is blocked in VK.
        /// Docs: <see href="https://vk.com/dev/utils.checkLink">utils.checkLink</see>
        /// </summary>
        /// <param name="url">Link to check (e.g., 'http://google.com').</param>
        public async Task<object> CheckLink(string url = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (url != null)
                parameters.Add("url", url);

            return await _vkontakte.GetAsync<object>("utils.checkLink", parameters);
        }

        /// <summary>
        /// Detects a type of object (e.g., user, community, application) and its ID by screen name.
        /// Docs: <see href="https://vk.com/dev/utils.resolveScreenName">utils.resolveScreenName</see>
        /// </summary>
        /// <param name="screen_name">Screen name of the user, community (e.g., 'apiclub,' 'andrew', or 'rules_of_war'), or application.</param>
        public async Task<object> ResolveScreenName(string screen_name = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (screen_name != null)
                parameters.Add("screen_name", screen_name);

            return await _vkontakte.GetAsync<object>("utils.resolveScreenName", parameters);
        }

        /// <summary>
        /// Returns the current time of the VK server.
        /// Docs: <see href="https://vk.com/dev/utils.getServerTime">utils.getServerTime</see>
        /// </summary>
        public async Task<object> GetServerTime()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();


            return await _vkontakte.GetAsync<object>("utils.getServerTime", parameters);
        }

    }
}
