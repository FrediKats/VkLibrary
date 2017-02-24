using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkLib.Methods
{
    /// <summary>
    /// Apps API section.
    /// </summary>
    public class Apps
    {
        private Vkontakte _vkontakte;

        internal Apps(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        /// Returns user score in app
        /// Docs: <see href="https://vk.com/dev/apps.getScore">apps.getScore</see>
        /// </summary>
        /// <param name="user_id"></param>
        public async Task<int?> GetScore(int? user_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (user_id != null)
                parameters.Add("user_id", user_id.ToApiString());

            return await _vkontakte.GetAsync<int?>("apps.getScore", parameters);
        }

    }
}
