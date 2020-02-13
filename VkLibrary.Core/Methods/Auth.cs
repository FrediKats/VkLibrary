using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VkApi.Wrapper.Responses.Auth;
using VkApi.Wrapper.Types.Base;

namespace VkApi.Wrapper.Methods
{
    public class Auth
    {
        private readonly Vkontakte _vkontakte;

        internal Auth(Vkontakte vkontakte) => _vkontakte = vkontakte;

        ///<summary>
        /// Checks a user's phone number for correctness.
        ///</summary>
        public Task<BaseOkResponse> CheckPhone(String phone = null, int? clientId = null, String clientSecret = null, Boolean? authByPhone = null)
        {
            var parameters = new Dictionary<string, string>();
            if (phone != null)
                parameters.Add("phone", phone.ToApiString());
            if (clientId != null)
                parameters.Add("client_id", clientId.ToApiString());
            if (clientSecret != null)
                parameters.Add("client_secret", clientSecret.ToApiString());
            if (authByPhone != null)
                parameters.Add("auth_by_phone", authByPhone.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("auth.checkPhone", parameters);
        }

        ///<summary>
        /// Allows to restore account access using a code received via SMS. " This method is only available for apps with [vk.com/dev/auth_direct|Direct authorization] access. "
        ///</summary>
        public Task<AuthRestoreResponse> Restore(String phone = null, String lastName = null)
        {
            var parameters = new Dictionary<string, string>();
            if (phone != null)
                parameters.Add("phone", phone.ToApiString());
            if (lastName != null)
                parameters.Add("last_name", lastName.ToApiString());
            return _vkontakte.RequestAsync<AuthRestoreResponse>("auth.restore", parameters);
        }
    }
}