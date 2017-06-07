using System.Collections.Generic;
using System.Threading.Tasks;

namespace VkLibrary.Core.Methods
{
    /// <summary>
    /// Apps API section.
    /// </summary>
    public class Apps
    {
        private readonly Vkontakte _vkontakte;
        internal Apps(Vkontakte vkontakte) => _vkontakte = vkontakte;

        /// <summary>
        /// Returns user score in app
        /// Docs: <see href="https://vk.com/dev/apps.getScore">apps.getScore</see>
        /// </summary>
        /// <param name="userId"></param>
        public Task<int?> GetScore(int? userId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());

            return _vkontakte.GetAsync<int?>("apps.getScore", parameters);
        }
    }
}