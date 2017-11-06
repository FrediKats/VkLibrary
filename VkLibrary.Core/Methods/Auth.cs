using System.Collections.Generic;
using System.Threading.Tasks;
using VkLibrary.Core.Responses.Auth;

namespace VkLibrary.Core.Methods
{
    /// <summary>
    /// Auth API section.
    /// </summary>
    public class Auth
    {
        private readonly Vkontakte _vkontakte;
        internal Auth(Vkontakte vkontakte) => _vkontakte = vkontakte;

        /// <summary>
        /// Checks a user's phone number for correctness.
        /// Docs: <see href="https://vk.com/dev/auth.checkPhone">auth.checkPhone</see>
        /// </summary>
        /// <param name="phone">Phone number.</param>
        /// <param name="clientId">User ID.</param>
        /// <param name="clientSecret"></param>
        /// <param name="authByPhone"></param>
        public Task<int> CheckPhone(string phone = null, int? clientId = null, string clientSecret = null,
            bool? authByPhone = null)
        {
            var parameters = new Dictionary<string, string>();

            if (phone != null)
                parameters.Add("phone", phone);
            if (clientId != null)
                parameters.Add("client_id", clientId.ToApiString());
            if (clientSecret != null)
                parameters.Add("client_secret", clientSecret);
            if (authByPhone != null)
                parameters.Add("auth_by_phone", authByPhone.ToApiString());

            return _vkontakte.RequestAsync<int>("auth.checkPhone", parameters);
        }

        /// <summary>
        /// Registers a new user by phone number.
        /// Docs: <see href="https://vk.com/dev/auth.signup">auth.signup</see>
        /// </summary>
        /// <param name="firstName">User's first name.</param>
        /// <param name="lastName">User's surname.</param>
        /// <param name="clientId">Your application ID.</param>
        /// <param name="clientSecret"></param>
        /// <param name="phone">
        /// User's phone number. Can be pre-checked with the auth.checkPhone
        /// method.
        /// </param>
        /// <param name="password">
        /// User's password (minimum of 6 characters). Can be specified later with the
        /// auth.confirm method.
        /// </param>
        /// <param name="testMode">
        /// '1' — test mode, in which the user will not be registered and the phone number will not be
        /// checked for availability; '0' — default mode (default)
        /// </param>
        /// <param name="voice">
        /// '1' — call the phone number and leave a voice message of the authorization code; '0' — send the
        /// code by SMS (default)
        /// </param>
        /// <param name="sex">'1' — female; '2' — male</param>
        /// <param name="sid">Session ID required for method recall when SMS was not delivered.</param>
        public Task<SignupResponse> Signup(string firstName = null, string lastName = null,
            int? clientId = null, string clientSecret = null, string phone = null, string password = null,
            bool? testMode = null, bool? voice = null, int? sex = null, string sid = null)
        {
            var parameters = new Dictionary<string, string>();

            if (firstName != null)
                parameters.Add("first_name", firstName);
            if (lastName != null)
                parameters.Add("last_name", lastName);
            if (clientId != null)
                parameters.Add("client_id", clientId.ToApiString());
            if (clientSecret != null)
                parameters.Add("client_secret", clientSecret);
            if (phone != null)
                parameters.Add("phone", phone);
            if (password != null)
                parameters.Add("password", password);
            if (testMode != null)
                parameters.Add("test_mode", testMode.ToApiString());
            if (voice != null)
                parameters.Add("voice", voice.ToApiString());
            if (sex != null)
                parameters.Add("sex", sex.ToApiString());
            if (sid != null)
                parameters.Add("sid", sid);

            return _vkontakte.RequestAsync<SignupResponse>("auth.signup", parameters);
        }

        /// <summary>
        /// Completes a user's registration (begun with the auth.signup method) using an authorization
        /// code.
        /// Docs: <see href="https://vk.com/dev/auth.confirm">auth.confirm</see>
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="phone"></param>
        /// <param name="code"></param>
        /// <param name="password"></param>
        /// <param name="testMode"></param>
        /// <param name="intro"></param>
        public Task<ConfirmResponse> Confirm(int? clientId = null, string clientSecret = null,
            string phone = null, string code = null, string password = null, bool? testMode = null, int? intro = null)
        {
            var parameters = new Dictionary<string, string>();

            if (clientId != null)
                parameters.Add("client_id", clientId.ToApiString());
            if (clientSecret != null)
                parameters.Add("client_secret", clientSecret);
            if (phone != null)
                parameters.Add("phone", phone);
            if (code != null)
                parameters.Add("code", code);
            if (password != null)
                parameters.Add("password", password);
            if (testMode != null)
                parameters.Add("test_mode", testMode.ToApiString());
            if (intro != null)
                parameters.Add("intro", intro.ToApiString());

            return _vkontakte.RequestAsync<ConfirmResponse>("auth.confirm", parameters);
        }

        /// <summary>
        /// Allows to restore account access using a code received via SMS.; ; " This method is only available for apps with
        /// Direct authorization access. "
        /// Docs: <see href="https://vk.com/dev/auth.restore">auth.restore</see>
        /// </summary>
        /// <param name="phone">user phone number.</param>
        public Task<RestoreResponse> Restore(string phone = null)
        {
            var parameters = new Dictionary<string, string>();

            if (phone != null)
                parameters.Add("phone", phone);

            return _vkontakte.RequestAsync<RestoreResponse>("auth.restore", parameters);
        }
    }
}