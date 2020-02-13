using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VkApi.Wrapper.Responses.Account;
using VkApi.Wrapper.Types.Account;
using VkApi.Wrapper.Types.Base;

namespace VkApi.Wrapper.Methods
{
    public class Account
    {
        private readonly Vkontakte _vkontakte;

        internal Account(Vkontakte vkontakte) => _vkontakte = vkontakte;

        ///<summary>
        /// Changes a user password after access is successfully restored with the [vk.com/dev/auth.restore|auth.restore] method.
        ///</summary>
        public Task<AccountChangePasswordResponse> ChangePassword(String restoreSid = null, String changePasswordHash = null, String oldPassword = null, String newPassword = null)
        {
            var parameters = new Dictionary<string, string>();
            if (restoreSid != null)
                parameters.Add("restore_sid", restoreSid.ToApiString());
            if (changePasswordHash != null)
                parameters.Add("change_password_hash", changePasswordHash.ToApiString());
            if (oldPassword != null)
                parameters.Add("old_password", oldPassword.ToApiString());
            if (newPassword != null)
                parameters.Add("new_password", newPassword.ToApiString());
            return _vkontakte.RequestAsync<AccountChangePasswordResponse>("account.changePassword", parameters);
        }

        ///<summary>
        /// Returns a list of active ads (offers) which executed by the user will bring him/her respective number of votes to his balance in the application.
        ///</summary>
        public Task<AccountGetActiveOffersResponse> GetActiveOffers(int? offset = null, int? count = null)
        {
            var parameters = new Dictionary<string, string>();
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            return _vkontakte.RequestAsync<AccountGetActiveOffersResponse>("account.getActiveOffers", parameters);
        }

        //TODO: fix
        /////<summary>
        ///// Gets settings of the user in this application.
        /////</summary>
        //public Task<AccountGetAppPermissionsResponse> GetAppPermissions(int? userId = null)
        //{
        //    var parameters = new Dictionary<string, string>();
        //    if (userId != null)
        //        parameters.Add("user_id", userId.ToApiString());
        //    return _vkontakte.RequestAsync<AccountGetAppPermissionsResponse>("account.getAppPermissions", parameters);
        //}

        ///<summary>
        /// Returns a user's blacklist.
        ///</summary>
        public Task<AccountGetBannedResponse> GetBanned(int? offset = null, int? count = null)
        {
            var parameters = new Dictionary<string, string>();
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            return _vkontakte.RequestAsync<AccountGetBannedResponse>("account.getBanned", parameters);
        }

        ///<summary>
        /// Returns non-null values of user counters.
        ///</summary>
        public Task<AccountAccountCounters> GetCounters(String[] filter = null)
        {
            var parameters = new Dictionary<string, string>();
            if (filter != null)
                parameters.Add("filter", filter.ToApiString());
            return _vkontakte.RequestAsync<AccountAccountCounters>("account.getCounters", parameters);
        }

        ///<summary>
        /// Returns current account info.
        ///</summary>
        public Task<AccountInfo> GetInfo(String[] fields = null)
        {
            var parameters = new Dictionary<string, string>();
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            return _vkontakte.RequestAsync<AccountInfo>("account.getInfo", parameters);
        }

        ///<summary>
        /// Returns the current account info.
        ///</summary>
        public Task<AccountUserSettings> GetProfileInfo()
        {
            var parameters = new Dictionary<string, string>();
            return _vkontakte.RequestAsync<AccountUserSettings>("account.getProfileInfo", parameters);
        }

        ///<summary>
        /// Gets settings of push notifications.
        ///</summary>
        public Task<AccountPushSettings> GetPushSettings(String deviceId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (deviceId != null)
                parameters.Add("device_id", deviceId.ToApiString());
            return _vkontakte.RequestAsync<AccountPushSettings>("account.getPushSettings", parameters);
        }

        ///<summary>
        /// Subscribes an iOS/Android/Windows Phone-based device to receive push notifications
        ///</summary>
        public Task<BaseOkResponse> RegisterDevice(String token = null, String deviceModel = null, int? deviceYear = null, String deviceId = null, String systemVersion = null, String settings = null, Boolean? sandbox = null)
        {
            var parameters = new Dictionary<string, string>();
            if (token != null)
                parameters.Add("token", token.ToApiString());
            if (deviceModel != null)
                parameters.Add("device_model", deviceModel.ToApiString());
            if (deviceYear != null)
                parameters.Add("device_year", deviceYear.ToApiString());
            if (deviceId != null)
                parameters.Add("device_id", deviceId.ToApiString());
            if (systemVersion != null)
                parameters.Add("system_version", systemVersion.ToApiString());
            if (settings != null)
                parameters.Add("settings", settings.ToApiString());
            if (sandbox != null)
                parameters.Add("sandbox", sandbox.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("account.registerDevice", parameters);
        }

        ///<summary>
        /// Edits current profile info.
        ///</summary>
        public Task<AccountSaveProfileInfoResponse> SaveProfileInfo(String firstName = null, String lastName = null, String maidenName = null, String screenName = null, int? cancelRequestId = null, int? sex = null, int? relation = null, int? relationPartnerId = null, String bdate = null, int? bdateVisibility = null, String homeTown = null, int? countryId = null, int? cityId = null, String status = null)
        {
            var parameters = new Dictionary<string, string>();
            if (firstName != null)
                parameters.Add("first_name", firstName.ToApiString());
            if (lastName != null)
                parameters.Add("last_name", lastName.ToApiString());
            if (maidenName != null)
                parameters.Add("maiden_name", maidenName.ToApiString());
            if (screenName != null)
                parameters.Add("screen_name", screenName.ToApiString());
            if (cancelRequestId != null)
                parameters.Add("cancel_request_id", cancelRequestId.ToApiString());
            if (sex != null)
                parameters.Add("sex", sex.ToApiString());
            if (relation != null)
                parameters.Add("relation", relation.ToApiString());
            if (relationPartnerId != null)
                parameters.Add("relation_partner_id", relationPartnerId.ToApiString());
            if (bdate != null)
                parameters.Add("bdate", bdate.ToApiString());
            if (bdateVisibility != null)
                parameters.Add("bdate_visibility", bdateVisibility.ToApiString());
            if (homeTown != null)
                parameters.Add("home_town", homeTown.ToApiString());
            if (countryId != null)
                parameters.Add("country_id", countryId.ToApiString());
            if (cityId != null)
                parameters.Add("city_id", cityId.ToApiString());
            if (status != null)
                parameters.Add("status", status.ToApiString());
            return _vkontakte.RequestAsync<AccountSaveProfileInfoResponse>("account.saveProfileInfo", parameters);
        }

        ///<summary>
        /// Allows to edit the current account info.
        ///</summary>
        public Task<BaseOkResponse> SetInfo(String name = null, String value = null)
        {
            var parameters = new Dictionary<string, string>();
            if (name != null)
                parameters.Add("name", name.ToApiString());
            if (value != null)
                parameters.Add("value", value.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("account.setInfo", parameters);
        }

        ///<summary>
        /// Sets an application screen name (up to 17 characters), that is shown to the user in the left menu.
        ///</summary>
        public Task<BaseOkResponse> SetNameInMenu(int? userId = null, String name = null)
        {
            var parameters = new Dictionary<string, string>();
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (name != null)
                parameters.Add("name", name.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("account.setNameInMenu", parameters);
        }

        ///<summary>
        /// Marks a current user as offline.
        ///</summary>
        public Task<BaseOkResponse> SetOffline()
        {
            var parameters = new Dictionary<string, string>();
            return _vkontakte.RequestAsync<BaseOkResponse>("account.setOffline", parameters);
        }

        ///<summary>
        /// Marks the current user as online for 15 minutes.
        ///</summary>
        public Task<BaseOkResponse> SetOnline(Boolean? voip = null)
        {
            var parameters = new Dictionary<string, string>();
            if (voip != null)
                parameters.Add("voip", voip.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("account.setOnline", parameters);
        }

        ///<summary>
        /// Change push settings.
        ///</summary>
        public Task<BaseOkResponse> SetPushSettings(String deviceId = null, String settings = null, String key = null, String[] value = null)
        {
            var parameters = new Dictionary<string, string>();
            if (deviceId != null)
                parameters.Add("device_id", deviceId.ToApiString());
            if (settings != null)
                parameters.Add("settings", settings.ToApiString());
            if (key != null)
                parameters.Add("key", key.ToApiString());
            if (value != null)
                parameters.Add("value", value.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("account.setPushSettings", parameters);
        }

        ///<summary>
        /// Mutes push notifications for the set period of time.
        ///</summary>
        public Task<BaseOkResponse> SetSilenceMode(String deviceId = null, int? time = null, int? peerId = null, int? sound = null)
        {
            var parameters = new Dictionary<string, string>();
            if (deviceId != null)
                parameters.Add("device_id", deviceId.ToApiString());
            if (time != null)
                parameters.Add("time", time.ToApiString());
            if (peerId != null)
                parameters.Add("peer_id", peerId.ToApiString());
            if (sound != null)
                parameters.Add("sound", sound.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("account.setSilenceMode", parameters);
        }

        ///<summary>
        /// Unsubscribes a device from push notifications.
        ///</summary>
        public Task<BaseOkResponse> UnregisterDevice(String deviceId = null, Boolean? sandbox = null)
        {
            var parameters = new Dictionary<string, string>();
            if (deviceId != null)
                parameters.Add("device_id", deviceId.ToApiString());
            if (sandbox != null)
                parameters.Add("sandbox", sandbox.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("account.unregisterDevice", parameters);
        }
    }
}