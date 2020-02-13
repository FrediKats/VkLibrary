using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VkApi.Wrapper.Types.Base;
using VkApi.Wrapper.Types.Secure;

namespace VkApi.Wrapper.Methods
{
    public class Secure
    {
        private readonly Vkontakte _vkontakte;

        internal Secure(Vkontakte vkontakte) => _vkontakte = vkontakte;

        ///<summary>
        /// Adds user activity information to an application
        ///</summary>
        public Task<BaseOkResponse> AddAppEvent(int? userId = null, int? activityId = null, int? value = null)
        {
            var parameters = new Dictionary<string, string>();
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (activityId != null)
                parameters.Add("activity_id", activityId.ToApiString());
            if (value != null)
                parameters.Add("value", value.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("secure.addAppEvent", parameters);
        }

        ///<summary>
        /// Checks the user authentication in 'IFrame' and 'Flash' apps using the 'access_token' parameter.
        ///</summary>
        public Task<SecureTokenChecked> CheckToken(String token = null, String ip = null)
        {
            var parameters = new Dictionary<string, string>();
            if (token != null)
                parameters.Add("token", token.ToApiString());
            if (ip != null)
                parameters.Add("ip", ip.ToApiString());
            return _vkontakte.RequestAsync<SecureTokenChecked>("secure.checkToken", parameters);
        }

        ///<summary>
        /// Returns payment balance of the application in hundredth of a vote.
        ///</summary>
        public Task<int> GetAppBalance()
        {
            var parameters = new Dictionary<string, string>();
            return _vkontakte.RequestAsync<int>("secure.getAppBalance", parameters);
        }

        ///<summary>
        /// Shows a list of SMS notifications sent by the application using [vk.com/dev/secure.sendSMSNotification|secure.sendSMSNotification] method.
        ///</summary>
        public Task<SecureSmsNotification[]> GetSMSHistory(int? userId = null, int? dateFrom = null, int? dateTo = null, int? limit = null)
        {
            var parameters = new Dictionary<string, string>();
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (dateFrom != null)
                parameters.Add("date_from", dateFrom.ToApiString());
            if (dateTo != null)
                parameters.Add("date_to", dateTo.ToApiString());
            if (limit != null)
                parameters.Add("limit", limit.ToApiString());
            return _vkontakte.RequestAsync<SecureSmsNotification[]>("secure.getSMSHistory", parameters);
        }

        ///<summary>
        /// Shows history of votes transaction between users and the application.
        ///</summary>
        public Task<SecureTransaction[]> GetTransactionsHistory(int? type = null, int? uidFrom = null, int? uidTo = null, int? dateFrom = null, int? dateTo = null, int? limit = null)
        {
            var parameters = new Dictionary<string, string>();
            if (type != null)
                parameters.Add("type", type.ToApiString());
            if (uidFrom != null)
                parameters.Add("uid_from", uidFrom.ToApiString());
            if (uidTo != null)
                parameters.Add("uid_to", uidTo.ToApiString());
            if (dateFrom != null)
                parameters.Add("date_from", dateFrom.ToApiString());
            if (dateTo != null)
                parameters.Add("date_to", dateTo.ToApiString());
            if (limit != null)
                parameters.Add("limit", limit.ToApiString());
            return _vkontakte.RequestAsync<SecureTransaction[]>("secure.getTransactionsHistory", parameters);
        }

        ///<summary>
        /// Returns one of the previously set game levels of one or more users in the application.
        ///</summary>
        public Task<SecureLevel[]> GetUserLevel(int[] userIds = null)
        {
            var parameters = new Dictionary<string, string>();
            if (userIds != null)
                parameters.Add("user_ids", userIds.ToApiString());
            return _vkontakte.RequestAsync<SecureLevel[]>("secure.getUserLevel", parameters);
        }

        ///<summary>
        /// Opens the game achievement and gives the user a sticker
        ///</summary>
        public Task<Object[]> GiveEventSticker(int[] userIds = null, int? achievementId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (userIds != null)
                parameters.Add("user_ids", userIds.ToApiString());
            if (achievementId != null)
                parameters.Add("achievement_id", achievementId.ToApiString());
            return _vkontakte.RequestAsync<Object[]>("secure.giveEventSticker", parameters);
        }

        ///<summary>
        /// Sends notification to the user.
        ///</summary>
        public Task<int[]> SendNotification(int[] userIds = null, int? userId = null, String message = null)
        {
            var parameters = new Dictionary<string, string>();
            if (userIds != null)
                parameters.Add("user_ids", userIds.ToApiString());
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (message != null)
                parameters.Add("message", message.ToApiString());
            return _vkontakte.RequestAsync<int[]>("secure.sendNotification", parameters);
        }

        ///<summary>
        /// Sends 'SMS' notification to a user's mobile device.
        ///</summary>
        public Task<BaseOkResponse> SendSMSNotification(int? userId = null, String message = null)
        {
            var parameters = new Dictionary<string, string>();
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (message != null)
                parameters.Add("message", message.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("secure.sendSMSNotification", parameters);
        }

        ///<summary>
        /// Sets a counter which is shown to the user in bold in the left menu.
        ///</summary>
        public Task<BaseOkResponse> SetCounter(String[] counters = null, int? userId = null, int? counter = null, Boolean? increment = null)
        {
            var parameters = new Dictionary<string, string>();
            if (counters != null)
                parameters.Add("counters", counters.ToApiString());
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (counter != null)
                parameters.Add("counter", counter.ToApiString());
            if (increment != null)
                parameters.Add("increment", increment.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("secure.setCounter", parameters);
        }
    }
}