using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkLib.Methods
{
    /// <summary>
    /// Auth API section.
    /// </summary>
    public class Auth
    {
        private Vkontakte _vkontakte;

        internal Auth(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        /// Checks a user's phone number for correctness.
        /// Docs: <see href="https://vk.com/dev/auth.checkPhone">auth.checkPhone</see>
        /// </summary>
        /// <param name="phone">Phone number.</param>
        /// <param name="client_id">User ID.</param>
        /// <param name="client_secret"></param>
        /// <param name="auth_by_phone"></param>
        public async Task<int> CheckPhone(string phone = null, int? client_id = null, string client_secret = null, bool? auth_by_phone = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (phone != null)
                parameters.Add("phone", phone);
            if (client_id != null)
                parameters.Add("client_id", client_id.ToString());
            if (client_secret != null)
                parameters.Add("client_secret", client_secret);
            if (auth_by_phone != null)
                parameters.Add("auth_by_phone", auth_by_phone.ToString());

            return await _vkontakte.GetAsync<int>("auth.checkPhone", parameters);
        }

        /// <summary>
        /// Registers a new user by phone number.
        /// Docs: <see href="https://vk.com/dev/auth.signup">auth.signup</see>
        /// </summary>
        /// <param name="first_name">User's first name.</param>
        /// <param name="last_name">User's surname.</param>
        /// <param name="client_id">Your application ID.</param>
        /// <param name="client_secret"></param>
        /// <param name="phone">User's phone number. Can be pre-checked with the [vk.com/dev/auth.checkPhone|auth.checkPhone] method.</param>
        /// <param name="password">User's password (minimum of 6 characters). Can be specified later with the [vk.com/dev/auth.confirm|auth.confirm] method.</param>
        /// <param name="test_mode">'1' — test mode, in which the user will not be registered and the phone number will not be checked for availability; '0' — default mode (default)</param>
        /// <param name="voice">'1' — call the phone number and leave a voice message of the authorization code; '0' — send the code by SMS (default)</param>
        /// <param name="sex">'1' — female; '2' — male</param>
        /// <param name="sid">Session ID required for method recall when SMS was not delivered.</param>
        public async Task<VkLib.Responses.Auth.SignupResponse> Signup(string first_name = null, string last_name = null, int? client_id = null, string client_secret = null, string phone = null, string password = null, bool? test_mode = null, bool? voice = null, int? sex = null, string sid = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (first_name != null)
                parameters.Add("first_name", first_name);
            if (last_name != null)
                parameters.Add("last_name", last_name);
            if (client_id != null)
                parameters.Add("client_id", client_id.ToString());
            if (client_secret != null)
                parameters.Add("client_secret", client_secret);
            if (phone != null)
                parameters.Add("phone", phone);
            if (password != null)
                parameters.Add("password", password);
            if (test_mode != null)
                parameters.Add("test_mode", test_mode.ToString());
            if (voice != null)
                parameters.Add("voice", voice.ToString());
            if (sex != null)
                parameters.Add("sex", sex.ToString());
            if (sid != null)
                parameters.Add("sid", sid);

            return await _vkontakte.GetAsync<VkLib.Responses.Auth.SignupResponse>("auth.signup", parameters);
        }

        /// <summary>
        /// Completes a user's registration (begun with the [vk.com/dev/auth.signup|auth.signup] method) using an authorization code.
        /// Docs: <see href="https://vk.com/dev/auth.confirm">auth.confirm</see>
        /// </summary>
        /// <param name="client_id"></param>
        /// <param name="client_secret"></param>
        /// <param name="phone"></param>
        /// <param name="code"></param>
        /// <param name="password"></param>
        /// <param name="test_mode"></param>
        /// <param name="intro"></param>
        public async Task<VkLib.Responses.Auth.ConfirmResponse> Confirm(int? client_id = null, string client_secret = null, string phone = null, string code = null, string password = null, bool? test_mode = null, int? intro = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (client_id != null)
                parameters.Add("client_id", client_id.ToString());
            if (client_secret != null)
                parameters.Add("client_secret", client_secret);
            if (phone != null)
                parameters.Add("phone", phone);
            if (code != null)
                parameters.Add("code", code);
            if (password != null)
                parameters.Add("password", password);
            if (test_mode != null)
                parameters.Add("test_mode", test_mode.ToString());
            if (intro != null)
                parameters.Add("intro", intro.ToString());

            return await _vkontakte.GetAsync<VkLib.Responses.Auth.ConfirmResponse>("auth.confirm", parameters);
        }

        /// <summary>
        /// Allows to restore account access using a code received via SMS.; ; " This method is only available for apps with [vk.com/dev/auth_direct|Direct authorization] access. "
        /// Docs: <see href="https://vk.com/dev/auth.restore">auth.restore</see>
        /// </summary>
        /// <param name="phone">user phone number.</param>
        public async Task<VkLib.Responses.Auth.RestoreResponse> Restore(string phone = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (phone != null)
                parameters.Add("phone", phone);

            return await _vkontakte.GetAsync<VkLib.Responses.Auth.RestoreResponse>("auth.restore", parameters);
        }

    }
}
