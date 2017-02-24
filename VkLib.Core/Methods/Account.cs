using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkLib.Methods
{
    /// <summary>
    /// Account API section.
    /// </summary>
    public class Account
    {
        private Vkontakte _vkontakte;

        internal Account(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        /// Returns non-null values of user counters.
        /// Docs: <see href="https://vk.com/dev/account.getCounters">account.getCounters</see>
        /// </summary>
        /// <param name="filter">Counters to be returned (friends, messages, photos, videos, notes, gifts, events, groups, sdk).</param>
        public async Task<VkLib.Types.Account.AccountCounters> GetCounters(IEnumerable<string> filter = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (filter != null)
                parameters.Add("filter", filter.ToApiString());

            return await _vkontakte.GetAsync<VkLib.Types.Account.AccountCounters>("account.getCounters", parameters);
        }

        /// <summary>
        /// Sets an application screen name (up to 17 characters), that is shown to the user in the left menu.
        /// Docs: <see href="https://vk.com/dev/account.setNameInMenu">account.setNameInMenu</see>
        /// </summary>
        /// <param name="user_id">User ID.</param>
        /// <param name="name">Application screen name.</param>
        public async Task<int> SetNameInMenu(int? user_id = null, string name = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (user_id != null)
                parameters.Add("user_id", user_id.ToApiString());
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
            Dictionary<string, string> parameters = new Dictionary<string, string>();

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
            Dictionary<string, string> parameters = new Dictionary<string, string>();


            return await _vkontakte.GetAsync<int>("account.setOffline", parameters);
        }

        /// <summary>
        /// Allows to search the VK users using phone numbers, e-mail addresses and user IDs on other services.
        /// Docs: <see href="https://vk.com/dev/account.lookupContacts">account.lookupContacts</see>
        /// </summary>
        /// <param name="contacts">List of contacts separated with commas</param>
        /// <param name="service">String identifier of a service which contacts are used for searching. Possible values: ; * email; * phone; * twitter; * facebook; * odnoklassniki; * instagram; * google</param>
        /// <param name="mycontact">Contact of a current user on a specified service</param>
        /// <param name="return_all">'1' – also return contacts found using this service before, '0' – return only contacts found using 'contacts' field.</param>
        /// <param name="fields">Profile fields to return. Possible values: 'nickname, domain, sex, bdate, city, country, timezone, photo_50, photo_100, photo_200_orig, has_mobile, contacts, education, online, relation, last_seen, status, can_write_private_message, can_see_all_posts, can_post, universities'.</param>
        public async Task<VkLib.Types.Account.LookupResult> LookupContacts(IEnumerable<string> contacts = null, string service = null, string mycontact = null, bool? return_all = null, IEnumerable<string> fields = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (contacts != null)
                parameters.Add("contacts", contacts.ToApiString());
            if (service != null)
                parameters.Add("service", service);
            if (mycontact != null)
                parameters.Add("mycontact", mycontact);
            if (return_all != null)
                parameters.Add("return_all", return_all.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());

            return await _vkontakte.GetAsync<VkLib.Types.Account.LookupResult>("account.lookupContacts", parameters);
        }

        /// <summary>
        /// Subscribes an iOS/Android/Windows Phone-based device to receive push notifications
        /// Docs: <see href="https://vk.com/dev/account.registerDevice">account.registerDevice</see>
        /// </summary>
        /// <param name="token">Device token used to send notifications. (for mpns, the token shall be URL for sending of notifications)</param>
        /// <param name="device_model">String name of device model.</param>
        /// <param name="device_year">Device year.</param>
        /// <param name="device_id">Unique device ID.</param>
        /// <param name="system_version">String version of device operating system.</param>
        /// <param name="settings">Push settings in a [vk.com/dev/push_settings|special format].</param>
        public async Task<int> RegisterDevice(string token = null, string device_model = null, int? device_year = null, string device_id = null, string system_version = null, string settings = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (token != null)
                parameters.Add("token", token);
            if (device_model != null)
                parameters.Add("device_model", device_model);
            if (device_year != null)
                parameters.Add("device_year", device_year.ToApiString());
            if (device_id != null)
                parameters.Add("device_id", device_id);
            if (system_version != null)
                parameters.Add("system_version", system_version);
            if (settings != null)
                parameters.Add("settings", settings);

            return await _vkontakte.GetAsync<int>("account.registerDevice", parameters);
        }

        /// <summary>
        /// Unsubscribes a device from push notifications.
        /// Docs: <see href="https://vk.com/dev/account.unregisterDevice">account.unregisterDevice</see>
        /// </summary>
        /// <param name="device_id">Unique device ID.</param>
        public async Task<int> UnregisterDevice(string device_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (device_id != null)
                parameters.Add("device_id", device_id);

            return await _vkontakte.GetAsync<int>("account.unregisterDevice", parameters);
        }

        /// <summary>
        /// Mutes push notifications for the set period of time.
        /// Docs: <see href="https://vk.com/dev/account.setSilenceMode">account.setSilenceMode</see>
        /// </summary>
        /// <param name="device_id">Unique device ID.</param>
        /// <param name="time">Time in seconds for what notifications should be disabled. '-1' to disable forever.</param>
        /// <param name="peer_id">Destination ID.; "For user:; 'User ID', e.g. '12345'.; ; For chat:; '2000000000' + 'Chat ID', e.g. '2000000001'.; ; For community:; '- Community ID', e.g. '-12345'.; "</param>
        /// <param name="sound">'1' — to enable sound in this dialog, '0' — to disable sound. Only if 'peer_id' contains user or community ID.</param>
        public async Task<int> SetSilenceMode(string device_id = null, int? time = null, int? peer_id = null, int? sound = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (device_id != null)
                parameters.Add("device_id", device_id);
            if (time != null)
                parameters.Add("time", time.ToApiString());
            if (peer_id != null)
                parameters.Add("peer_id", peer_id.ToApiString());
            if (sound != null)
                parameters.Add("sound", sound.ToApiString());

            return await _vkontakte.GetAsync<int>("account.setSilenceMode", parameters);
        }

        /// <summary>
        /// Gets settings of push notifications.
        /// Docs: <see href="https://vk.com/dev/account.getPushSettings">account.getPushSettings</see>
        /// </summary>
        /// <param name="device_id">Unique device ID.</param>
        public async Task<VkLib.Types.Account.PushSettings> GetPushSettings(string device_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (device_id != null)
                parameters.Add("device_id", device_id);

            return await _vkontakte.GetAsync<VkLib.Types.Account.PushSettings>("account.getPushSettings", parameters);
        }

        /// <summary>
        /// Change push settings.
        /// Docs: <see href="https://vk.com/dev/account.setPushSettings">account.setPushSettings</see>
        /// </summary>
        /// <param name="device_id">Unique device ID.</param>
        /// <param name="settings">Push settings in a [vk.com/dev/push_settings|special format].</param>
        /// <param name="key">Notification key.</param>
        /// <param name="value">New value for the key in a [vk.com/dev/push_settings|special format].</param>
        public async Task<int> SetPushSettings(string device_id = null, string settings = null, string key = null, IEnumerable<string> value = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (device_id != null)
                parameters.Add("device_id", device_id);
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
        /// <param name="user_id">User ID whose settings information shall be got. By default: current user.</param>
        public async Task<int?> GetAppPermissions(int? user_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (user_id != null)
                parameters.Add("user_id", user_id.ToApiString());

            return await _vkontakte.GetAsync<int?>("account.getAppPermissions", parameters);
        }

        /// <summary>
        /// Returns a list of active ads (offers) which executed by the user will bring him/her respective number of votes to his balance in the application.
        /// Docs: <see href="https://vk.com/dev/account.getActiveOffers">account.getActiveOffers</see>
        /// </summary>
        /// <param name="count">Number of results to return.</param>
        public async Task<ApiItemsResponse<VkLib.Types.Account.Offer>> GetActiveOffers(int? count = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (count != null)
                parameters.Add("count", count.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<VkLib.Types.Account.Offer>>("account.getActiveOffers", parameters);
        }

        /// <summary>
        /// Adds user to the banlist.
        /// Docs: <see href="https://vk.com/dev/account.banUser">account.banUser</see>
        /// </summary>
        /// <param name="user_id">User ID.</param>
        public async Task<int> BanUser(int? user_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (user_id != null)
                parameters.Add("user_id", user_id.ToApiString());

            return await _vkontakte.GetAsync<int>("account.banUser", parameters);
        }

        /// <summary>
        /// Deletes user from the blacklist.
        /// Docs: <see href="https://vk.com/dev/account.unbanUser">account.unbanUser</see>
        /// </summary>
        /// <param name="user_id">User ID.</param>
        public async Task<int> UnbanUser(int? user_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (user_id != null)
                parameters.Add("user_id", user_id.ToApiString());

            return await _vkontakte.GetAsync<int>("account.unbanUser", parameters);
        }

        /// <summary>
        /// Returns a user's blacklist.
        /// Docs: <see href="https://vk.com/dev/account.getBanned">account.getBanned</see>
        /// </summary>
        /// <param name="offset">Offset needed to return a specific subset of results.</param>
        /// <param name="count">Number of results to return.</param>
        public async Task<ApiItemsResponse<VkLib.Types.Users.UserMin>> GetBanned(int? offset = null, int? count = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<VkLib.Types.Users.UserMin>>("account.getBanned", parameters);
        }

        /// <summary>
        /// Returns current account info.
        /// Docs: <see href="https://vk.com/dev/account.getInfo">account.getInfo</see>
        /// </summary>
        /// <param name="fields">Fields to return. Possible values:; *'country' — user country;; *'https_required' — is "HTTPS only" option enabled;; *'own_posts_default' — is "Show my posts only" option is enabled;; *'no_wall_replies' — are wall replies disabled or not;; *'intro' — is intro passed by user or not;; *'lang' — user language.; ; By default: all.</param>
        public async Task<VkLib.Types.Account.Info> GetInfo(IEnumerable<string> fields = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (fields != null)
                parameters.Add("fields", fields.ToApiString());

            return await _vkontakte.GetAsync<VkLib.Types.Account.Info>("account.getInfo", parameters);
        }

        /// <summary>
        /// Allows to edit the current account info.
        /// Docs: <see href="https://vk.com/dev/account.setInfo">account.setInfo</see>
        /// </summary>
        /// <param name="name">Setting name.</param>
        /// <param name="value">Setting value.</param>
        public async Task<int> SetInfo(string name = null, string value = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (name != null)
                parameters.Add("name", name);
            if (value != null)
                parameters.Add("value", value);

            return await _vkontakte.GetAsync<int>("account.setInfo", parameters);
        }

        /// <summary>
        /// Changes a user password after access is successfully restored with the [vk.com/dev/auth.restore|auth.restore] method.
        /// Docs: <see href="https://vk.com/dev/account.changePassword">account.changePassword</see>
        /// </summary>
        /// <param name="restore_sid">Session id received after the [vk.com/dev/auth.restore|auth.restore] method is executed.; (If the password is changed right after the access was restored)</param>
        /// <param name="change_password_hash">Hash received after a successful OAuth authorization with a code got by SMS.; (If the password is changed right after the access was restored)</param>
        /// <param name="old_password">Current user password.</param>
        /// <param name="new_password">New password that will be set as a current</param>
        public async Task<VkLib.Responses.Account.ChangePasswordResponse> ChangePassword(string restore_sid = null, string change_password_hash = null, string old_password = null, string new_password = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (restore_sid != null)
                parameters.Add("restore_sid", restore_sid);
            if (change_password_hash != null)
                parameters.Add("change_password_hash", change_password_hash);
            if (old_password != null)
                parameters.Add("old_password", old_password);
            if (new_password != null)
                parameters.Add("new_password", new_password);

            return await _vkontakte.GetAsync<VkLib.Responses.Account.ChangePasswordResponse>("account.changePassword", parameters);
        }

        /// <summary>
        /// Returns the current account info.
        /// Docs: <see href="https://vk.com/dev/account.getProfileInfo">account.getProfileInfo</see>
        /// </summary>
        public async Task<VkLib.Types.Account.UserSettings> GetProfileInfo()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();


            return await _vkontakte.GetAsync<VkLib.Types.Account.UserSettings>("account.getProfileInfo", parameters);
        }

        /// <summary>
        /// Edits current profile info.
        /// Docs: <see href="https://vk.com/dev/account.saveProfileInfo">account.saveProfileInfo</see>
        /// </summary>
        /// <param name="first_name">User first name.</param>
        /// <param name="last_name">User last name.</param>
        /// <param name="maiden_name">User maiden name (female only)</param>
        /// <param name="screen_name">User screen name.</param>
        /// <param name="cancel_request_id">ID of the name change request to be canceled. If this parameter is sent, all the others are ignored.</param>
        /// <param name="sex">User sex. Possible values: ; * '1' – female;; * '2' – male.</param>
        /// <param name="relation">User relationship status. Possible values: ; * '1' – single;; * '2' – in a relationship;; * '3' – engaged;; * '4' – married;; * '5' – it's complicated;; * '6' – actively searching;; * '7' – in love;; * '0' – not specified.</param>
        /// <param name="relation_partner_id">ID of the relationship partner.</param>
        /// <param name="bdate">User birth date, format: DD.MM.YYYY.</param>
        /// <param name="bdate_visibility">Birth date visibility. Returned values: ; * '1' – show birth date;; * '2' – show only month and day;; * '0' – hide birth date.</param>
        /// <param name="home_town">User home town.</param>
        /// <param name="country_id">User country.</param>
        /// <param name="city_id">User city.</param>
        /// <param name="status">Status text.</param>
        public async Task<VkLib.Responses.Account.SaveProfileInfoResponse> SaveProfileInfo(string first_name = null, string last_name = null, string maiden_name = null, string screen_name = null, int? cancel_request_id = null, int? sex = null, int? relation = null, int? relation_partner_id = null, string bdate = null, int? bdate_visibility = null, string home_town = null, int? country_id = null, int? city_id = null, string status = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (first_name != null)
                parameters.Add("first_name", first_name);
            if (last_name != null)
                parameters.Add("last_name", last_name);
            if (maiden_name != null)
                parameters.Add("maiden_name", maiden_name);
            if (screen_name != null)
                parameters.Add("screen_name", screen_name);
            if (cancel_request_id != null)
                parameters.Add("cancel_request_id", cancel_request_id.ToApiString());
            if (sex != null)
                parameters.Add("sex", sex.ToApiString());
            if (relation != null)
                parameters.Add("relation", relation.ToApiString());
            if (relation_partner_id != null)
                parameters.Add("relation_partner_id", relation_partner_id.ToApiString());
            if (bdate != null)
                parameters.Add("bdate", bdate);
            if (bdate_visibility != null)
                parameters.Add("bdate_visibility", bdate_visibility.ToApiString());
            if (home_town != null)
                parameters.Add("home_town", home_town);
            if (country_id != null)
                parameters.Add("country_id", country_id.ToApiString());
            if (city_id != null)
                parameters.Add("city_id", city_id.ToApiString());
            if (status != null)
                parameters.Add("status", status);

            return await _vkontakte.GetAsync<VkLib.Responses.Account.SaveProfileInfoResponse>("account.saveProfileInfo", parameters);
        }

    }
}
