using System.Collections.Generic;
using System.Threading.Tasks;
using VkLibrary.Core.Types.Secure;

namespace VkLibrary.Core.Methods
{
    /// <summary>
    /// Secure API section.
    /// </summary>
    public class Secure
    {
        private readonly Vkontakte _vkontakte;
        internal Secure(Vkontakte vkontakte) => _vkontakte = vkontakte;

        /// <summary>
        /// Checks the user authentication in 'IFrame' and 'Flash' apps using the 'access_token' parameter.
        /// Docs: <see href="https://vk.com/dev/secure.checkToken">secure.checkToken</see>
        /// </summary>
        /// <param name="token">client 'access_token'</param>
        /// <param name="ip">
        /// user 'ip address'. Note that user may access using the 'ipv6' address, in this case it is required to
        /// transmit the 'ipv6' address. ; If not transmitted, the address will not be checked.
        /// </param>
        public Task<TokenChecked> CheckToken(string token = null, string ip = null)
        {
            var parameters = new Dictionary<string, string>();

            if (token != null)
                parameters.Add("token", token);
            if (ip != null)
                parameters.Add("ip", ip);

            return _vkontakte.GetAsync<TokenChecked>("secure.checkToken", parameters);
        }
    }
}