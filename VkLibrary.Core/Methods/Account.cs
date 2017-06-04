using System.Collections.Generic;
using System.Threading.Tasks;
using VkLibrary.Core.Responses.Account;
using VkLibrary.Core.Types.Account;
using VkLibrary.Core.Types.Users;

namespace VkLibrary.Core.Methods
{
    /// <summary>
    /// Account API section.
    /// </summary>
    public class Account
    {
        private readonly Vkontakte _vkontakte;
        internal Account(Vkontakte vkontakte) => _vkontakte = vkontakte;

        /// <summary>
        /// Returns non-null values of user counters.
        /// Docs: <see href="https://vk.com/dev/account.getCounters">account.getCounters</see>
        /// </summary>
        /// <param name="filter">Counters to be returned (friends, messages, photos, videos, notes, gifts, events, groups, sdk).</param>
        public async Task<AccountCounters> GetCounters(IEnumerable<string> filter = null)
        {
            var parameters = new Dictionary<string, string>();

            if (filter != null)
                parameters.Add("filter", filter.ToApiString());

            return await _vkontakte.GetAsync<AccountCounters>("account.getCounters", parameters);
        }

        /// <summary>
        /// Sets an application screen name (up to 17 characters), that is shown to the user in the left menu.
        /// Docs: <see href="https://vk.com/dev/account.setNameInMenu">account.setNameInMenu</see>
        /// </summary>
        /// <param name="userId">User ID.</param>
        /// <param name="name">Application screen name.</param>
        public async Task<int> SetNameInMenu(int? userId = null, string name = null)
        {
            var parameters = new Dictionary<string, string>();

            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (name != null)
                parameters.Add("name", name);

            return await _vkontakte.GetAsync<int>("account.setNameInMenu", parameters);
        }

        /// <summary>
        /// Marks the current user as online for 15 minutes.
        /// Docs: <see href="https://vk.com/dev/account.setOnline">account.setOnline</see>
        /// </summary>
        /// <param name="voip">'1' if videocalls are available for current device.</param>
        public async Task<int> SetOnline(bool? voip = null)
        {
            var parameters = new Dictionary<string, string>();

            if (voip != null)
                parameters.Add("voip", voip.ToApiString());

            return await _vkontakte.GetAsync<int>("account.setOnline", parameters);
        }

        /// <summary>
        /// Marks a current user as offline.
        /// Docs: <see href="https://vk.com/dev/account.setOffline">account.setOffline</see>
        /// </summary>
        public async Task<int> SetOffline()
        {
            var parameters = new Dictionary<string, string>();


            return await _vkontakte.GetAsync<int>("account.setOffline", parameters);
        }

        /// <summary>
        /// Allows to search the VK users using phone numbers, e-mail addresses and user IDs on other services.
        /// Docs: <see href="https://vk.com/dev/account.lookupContacts">account.lookupContacts</see>
        /// </summary>
        /// <param name="contacts">List of contacts separated with commas</param>
        /// <param name="service">
        /// String identifier of a service which contacts are used for searching. Possible values: ; * email;
        /// * phone; * twitter; * facebook; * odnoklassniki; * instagram; * google
        /// </param>
        /// <param name="mycontact">Contact of a current user on a specified service</param>
        /// <param name="returnAll">
        /// '1' – also return contacts found using this service before, '0' – return only contacts found
        /// using 'contacts' field.
        /// </param>
        /// <param name="fields">
        /// Profile fields to return. Possible values: 'nickname, domain, sex, bdate, city, country, timezone,
        /// photo_50, photo_100, photo_200_orig, has_mobile, contacts, education, online, relation, last_seen, status,
        /// can_write_private_message, can_see_all_posts, can_post, universities'.
        /// </param>
        public async Task<LookupResult> LookupContacts(IEnumerable<string> contacts = null, string service = null,
            string mycontact = null, bool? returnAll = null, IEnumerable<string> fields = null)
        {
            var parameters = new Dictionary<string, string>();

            if (contacts != null)
                parameters.Add("contacts", contacts.ToApiString());
            if (service != null)
                parameters.Add("service", service);
            if (mycontact != null)
                parameters.Add("mycontact", mycontact);
            if (returnAll != null)
                parameters.Add("return_all", returnAll.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());

            return await _vkontakte.GetAsync<LookupResult>("account.lookupContacts", parameters);
        }

        /// <summary>
        /// Subscribes an iOS/Android/Windows Phone-based device to receive push notifications
        /// Docs: <see href="https://vk.com/dev/account.registerDevice">account.registerDevice</see>
        /// </summary>
        /// <param name="token">
        /// Device token used to send notifications. (for mpns, the token shall be URL for sending of
        /// notifications)
        /// </param>
        /// <param name="deviceModel">String name of device model.</param>
        /// <param name="deviceYear">Device year.</param>
        /// <param name="deviceId">Unique device ID.</param>
        /// <param name="systemVersion">String version of device operating system.</param>
        /// <param name="settings">Push settings in a [vk.com/dev/push_settings|special format].</param>
        public async Task<int> RegisterDevice(string token = null, string deviceModel = null, int? deviceYear = null,
            string deviceId = null, string systemVersion = null, string settings = null)
        {
            var parameters = new Dictionary<string, string>();

            if (token != null)
                parameters.Add("token", token);
            if (deviceModel != null)
                parameters.Add("device_model", deviceModel);
            if (deviceYear != null)
                parameters.Add("device_year", deviceYear.ToApiString());
            if (deviceId != null)
                parameters.Add("device_id", deviceId);
            if (systemVersion != null)
                parameters.Add("system_version", systemVersion);
            if (settings != null)
                parameters.Add("settings", settings);

            return await _vkontakte.GetAsync<int>("account.registerDevice", parameters);
        }

        /// <summary>
        /// Unsubscribes a device from push notifications.
        /// Docs: <see href="https://vk.com/dev/account.unregisterDevice">account.unregisterDevice</see>
        /// </summary>
        /// <param name="deviceId">Unique device ID.</param>
        public async Task<int> UnregisterDevice(string deviceId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (deviceId != null)
                parameters.Add("device_id", deviceId);

            return await _vkontakte.GetAsync<int>("account.unregisterDevice", parameters);
        }

        /// <summary>
        /// Mutes push notifications for the set period of time.
        /// Docs: <see href="https://vk.com/dev/account.setSilenceMode">account.setSilenceMode</see>
        /// </summary>
        /// <param name="deviceId">Unique device ID.</param>
        /// <param name="time">Time in seconds for what notifications should be disabled. '-1' to disable forever.</param>
        /// <param name="peerId">
        /// Destination ID.; "For user:; 'User ID', e.g. '12345'.; ; For chat:; '2000000000' + 'Chat ID',
        /// e.g. '2000000001'.; ; For community:; '- Community ID', e.g. '-12345'.; "
        /// </param>
        /// <param name="sound">
        /// '1' — to enable sound in this dialog, '0' — to disable sound. Only if 'peer_id' contains user or
        /// community ID.
        /// </param>
        public async Task<int> SetSilenceMode(string deviceId = null, int? time = null, int? peerId = null,
            int? sound = null)
        {
            var parameters = new Dictionary<string, string>();

            if (deviceId != null)
                parameters.Add("device_id", deviceId);
            if (time != null)
                parameters.Add("time", time.ToApiString());
            if (peerId != null)
                parameters.Add("peer_id", peerId.ToApiString());
            if (sound != null)
                parameters.Add("sound", sound.ToApiString());

            return await _vkontakte.GetAsync<int>("account.setSilenceMode", parameters);
        }

        /// <summary>
        /// Gets settings of push notifications.
        /// Docs: <see href="https://vk.com/dev/account.getPushSettings">account.getPushSettings</see>
        /// </summary>
        /// <param name="deviceId">Unique device ID.</param>
        public async Task<PushSettings> GetPushSettings(string deviceId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (deviceId != null)
                parameters.Add("device_id", deviceId);

            return await _vkontakte.GetAsync<PushSettings>("account.getPushSettings", parameters);
        }

        /// <summary>
        /// Change push settings.
        /// Docs: <see href="https://vk.com/dev/account.setPushSettings">account.setPushSettings</see>
        /// </summary>
        /// <param name="deviceId">Unique device ID.</param>
        /// <param name="settings">Push settings in a [vk.com/dev/push_settings|special format].</param>
        /// <param name="key">Notification key.</param>
        /// <param name="value">New value for the key in a [vk.com/dev/push_settings|special format].</param>
        public async Task<int> SetPushSettings(string deviceId = null, string settings = null, string key = null,
            IEnumerable<string> value = null)
        {
            var parameters = new Dictionary<string, string>();

            if (deviceId != null)
                parameters.Add("device_id", deviceId);
            if (settings != null)
                parameters.Add("settings", settings);
            if (key != null)
                parameters.Add("key", key);
            if (value != null)
                parameters.Add("value", value.ToApiString());

            return await _vkontakte.GetAsync<int>("account.setPushSettings", parameters);
        }

        /// <summary>
        /// Gets settings of the user in this application.
        /// Docs: <see href="https://vk.com/dev/account.getAppPermissions">account.getAppPermissions</see>
        /// </summary>
        /// <param name="userId">User ID whose settings information shall be got. By default: current user.</param>
        public async Task<int?> GetAppPermissions(int? userId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());

            return await _vkontakte.GetAsync<int?>("account.getAppPermissions", parameters);
        }

        /// <summary>
        /// Returns a list of active ads (offers) which executed by the user will bring him/her respective number of votes to
        /// his balance in the application.
        /// Docs: <see href="https://vk.com/dev/account.getActiveOffers">account.getActiveOffers</see>
        /// </summary>
        /// <param name="count">Number of results to return.</param>
        public async Task<ApiItemsResponse<Offer>> GetActiveOffers(int? count = null)
        {
            var parameters = new Dictionary<string, string>();

            if (count != null)
                parameters.Add("count", count.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<Offer>>("account.getActiveOffers", parameters);
        }

        /// <summary>
        /// Adds user to the banlist.
        /// Docs: <see href="https://vk.com/dev/account.banUser">account.banUser</see>
        /// </summary>
        /// <param name="userId">User ID.</param>
        public async Task<int> BanUser(int? userId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());

            return await _vkontakte.GetAsync<int>("account.banUser", parameters);
        }

        /// <summary>
        /// Deletes user from the blacklist.
        /// Docs: <see href="https://vk.com/dev/account.unbanUser">account.unbanUser</see>
        /// </summary>
        /// <param name="userId">User ID.</param>
        public async Task<int> UnbanUser(int? userId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());

            return await _vkontakte.GetAsync<int>("account.unbanUser", parameters);
        }

        /// <summary>
        /// Returns a user's blacklist.
        /// Docs: <see href="https://vk.com/dev/account.getBanned">account.getBanned</see>
        /// </summary>
        /// <param name="offset">Offset needed to return a specific subset of results.</param>
        /// <param name="count">Number of results to return.</param>
        public async Task<ApiItemsResponse<UserMin>> GetBanned(int? offset = null, int? count = null)
        {
            var parameters = new Dictionary<string, string>();

            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<UserMin>>("account.getBanned", parameters);
        }

        /// <summary>
        /// Returns current account info.
        /// Docs: <see href="https://vk.com/dev/account.getInfo">account.getInfo</see>
        /// </summary>
        /// <param name="fields">
        /// Fields to return. Possible values:; *'country' — user country;; *'https_required' — is "HTTPS
        /// only" option enabled;; *'own_posts_default' — is "Show my posts only" option is enabled;; *'no_wall_replies' — are
        /// wall replies disabled or not;; *'intro' — is intro passed by user or not;; *'lang' — user language.; ; By default:
        /// all.
        /// </param>
        public async Task<Info> GetInfo(IEnumerable<string> fields = null)
        {
            var parameters = new Dictionary<string, string>();

            if (fields != null)
                parameters.Add("fields", fields.ToApiString());

            return await _vkontakte.GetAsync<Info>("account.getInfo", parameters);
        }

        /// <summary>
        /// Allows to edit the current account info.
        /// Docs: <see href="https://vk.com/dev/account.setInfo">account.setInfo</see>
        /// </summary>
        /// <param name="name">Setting name.</param>
        /// <param name="value">Setting value.</param>
        public async Task<int> SetInfo(string name = null, string value = null)
        {
            var parameters = new Dictionary<string, string>();

            if (name != null)
                parameters.Add("name", name);
            if (value != null)
                parameters.Add("value", value);

            return await _vkontakte.GetAsync<int>("account.setInfo", parameters);
        }

        /// <summary>
        /// Changes a user password after access is successfully restored with the [vk.com/dev/auth.restore|auth.restore]
        /// method.
        /// Docs: <see href="https://vk.com/dev/account.changePassword">account.changePassword</see>
        /// </summary>
        /// <param name="restoreSid">
        /// Session id received after the [vk.com/dev/auth.restore|auth.restore] method is executed.; (If
        /// the password is changed right after the access was restored)
        /// </param>
        /// <param name="changePasswordHash">
        /// Hash received after a successful OAuth authorization with a code got by SMS.; (If
        /// the password is changed right after the access was restored)
        /// </param>
        /// <param name="oldPassword">Current user password.</param>
        /// <param name="newPassword">New password that will be set as a current</param>
        public async Task<ChangePasswordResponse> ChangePassword(string restoreSid = null,
            string changePasswordHash = null, string oldPassword = null, string newPassword = null)
        {
            var parameters = new Dictionary<string, string>();

            if (restoreSid != null)
                parameters.Add("restore_sid", restoreSid);
            if (changePasswordHash != null)
                parameters.Add("change_password_hash", changePasswordHash);
            if (oldPassword != null)
                parameters.Add("old_password", oldPassword);
            if (newPassword != null)
                parameters.Add("new_password", newPassword);

            return await _vkontakte.GetAsync<ChangePasswordResponse>("account.changePassword", parameters);
        }

        /// <summary>
        /// Returns the current account info.
        /// Docs: <see href="https://vk.com/dev/account.getProfileInfo">account.getProfileInfo</see>
        /// </summary>
        public async Task<UserSettings> GetProfileInfo()
        {
            var parameters = new Dictionary<string, string>();


            return await _vkontakte.GetAsync<UserSettings>("account.getProfileInfo", parameters);
        }

        /// <summary>
        /// Edits current profile info.
        /// Docs: <see href="https://vk.com/dev/account.saveProfileInfo">account.saveProfileInfo</see>
        /// </summary>
        /// <param name="firstName">User first name.</param>
        /// <param name="lastName">User last name.</param>
        /// <param name="maidenName">User maiden name (female only)</param>
        /// <param name="screenName">User screen name.</param>
        /// <param name="cancelRequestId">
        /// ID of the name change request to be canceled. If this parameter is sent, all the others
        /// are ignored.
        /// </param>
        /// <param name="sex">User sex. Possible values: ; * '1' – female;; * '2' – male.</param>
        /// <param name="relation">
        /// User relationship status. Possible values: ; * '1' – single;; * '2' – in a relationship;; * '3'
        /// – engaged;; * '4' – married;; * '5' – it's complicated;; * '6' – actively searching;; * '7' – in love;; * '0' – not
        /// specified.
        /// </param>
        /// <param name="relationPartnerId">ID of the relationship partner.</param>
        /// <param name="bdate">User birth date, format: DD.MM.YYYY.</param>
        /// <param name="bdateVisibility">
        /// Birth date visibility. Returned values: ; * '1' – show birth date;; * '2' – show only
        /// month and day;; * '0' – hide birth date.
        /// </param>
        /// <param name="homeTown">User home town.</param>
        /// <param name="countryId">User country.</param>
        /// <param name="cityId">User city.</param>
        /// <param name="status">Status text.</param>
        public async Task<SaveProfileInfoResponse> SaveProfileInfo(string firstName = null, string lastName = null,
            string maidenName = null, string screenName = null, int? cancelRequestId = null, int? sex = null,
            int? relation = null, int? relationPartnerId = null, string bdate = null, int? bdateVisibility = null,
            string homeTown = null, int? countryId = null, int? cityId = null, string status = null)
        {
            var parameters = new Dictionary<string, string>();

            if (firstName != null)
                parameters.Add("first_name", firstName);
            if (lastName != null)
                parameters.Add("last_name", lastName);
            if (maidenName != null)
                parameters.Add("maiden_name", maidenName);
            if (screenName != null)
                parameters.Add("screen_name", screenName);
            if (cancelRequestId != null)
                parameters.Add("cancel_request_id", cancelRequestId.ToApiString());
            if (sex != null)
                parameters.Add("sex", sex.ToApiString());
            if (relation != null)
                parameters.Add("relation", relation.ToApiString());
            if (relationPartnerId != null)
                parameters.Add("relation_partner_id", relationPartnerId.ToApiString());
            if (bdate != null)
                parameters.Add("bdate", bdate);
            if (bdateVisibility != null)
                parameters.Add("bdate_visibility", bdateVisibility.ToApiString());
            if (homeTown != null)
                parameters.Add("home_town", homeTown);
            if (countryId != null)
                parameters.Add("country_id", countryId.ToApiString());
            if (cityId != null)
                parameters.Add("city_id", cityId.ToApiString());
            if (status != null)
                parameters.Add("status", status);

            return await _vkontakte.GetAsync<SaveProfileInfoResponse>("account.saveProfileInfo", parameters);
        }
    }
}