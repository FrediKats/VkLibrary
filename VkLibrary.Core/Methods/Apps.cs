using System.Collections.Generic;
using System.Threading.Tasks;

namespace VkLibrary.Core.Methods
{
    /// <summary>
    /// Apps API section.
    /// </summary>
    public class Apps
    {
        private readonly VkLibrary _vkontakte;

        internal Apps(VkLibrary vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        /// Returns user score in app
        /// Docs: <see href="https://vk.com/dev/apps.getScore">apps.getScore</see>
        /// </summary>
        /// <param name="userId"></param>
        public async Task<int?> GetScore(int? userId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());

            return await _vkontakte.GetAsync<int?>("apps.getScore", parameters);
        }
    }
}