using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkLib.Methods
{
    /// <summary>
    /// Users API section.
    /// </summary>
    public class Users
    {
        private Vkontakte _vkontakte;

        internal Users(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        /// Returns detailed information on users.
        /// Docs: <see href="https://vk.com/dev/users.get">users.get</see>
        /// </summary>
        /// <param name="user_ids">User IDs or screen names ('screen_name'). By default, current user ID.</param>
        /// <param name="fields">Profile fields to return. Sample values: 'nickname', 'screen_name', 'sex', 'bdate' (birthdate), 'city', 'country', 'timezone', 'photo', 'photo_medium', 'photo_big', 'has_mobile', 'contacts', 'education', 'online', 'counters', 'relation', 'last_seen', 'activity', 'can_write_private_message', 'can_see_all_posts', 'can_post', 'universities';</param>
        /// <param name="name_case">Case for declension of user name and surname:; 'nom' — nominative (default); 'gen' — genitive ; 'dat' — dative; 'acc' — accusative ; 'ins' — instrumental ; 'abl' — prepositional</param>
        public async Task<IEnumerable<VkLib.Types.Users.UserXtrCounters>> Get(IEnumerable<string> user_ids = null, IEnumerable<string> fields = null, string name_case = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (user_ids != null)
                parameters.Add("user_ids", string.Join(",", user_ids));
            if (fields != null)
                parameters.Add("fields", string.Join(",", fields));
            if (name_case != null)
                parameters.Add("name_case", name_case);

            return await _vkontakte.GetAsync<IEnumerable<VkLib.Types.Users.UserXtrCounters>>("users.get", parameters);
        }

        /// <summary>
        /// Returns a list of users matching the search criteria.
        /// Docs: <see href="https://vk.com/dev/users.search">users.search</see>
        /// </summary>
        /// <param name="q">Search query string (e.g., 'Vasya Babich').</param>
        /// <param name="sort">Sort order:; '1' — by date registered; '0' — by rating</param>
        /// <param name="offset">Offset needed to return a specific subset of users.</param>
        /// <param name="count">Number of users to return.</param>
        /// <param name="fields">Profile fields to return. Sample values: 'nickname', 'screen_name', 'sex', 'bdate' (birthdate), 'city', 'country', 'timezone', 'photo', 'photo_medium', 'photo_big', 'has_mobile', 'rate', 'contacts', 'education', 'online';</param>
        /// <param name="city">City ID.</param>
        /// <param name="country">Country ID.</param>
        /// <param name="hometown">City name in a string.</param>
        /// <param name="university_country">ID of the country where the user graduated.</param>
        /// <param name="university">ID of the institution of higher education.</param>
        /// <param name="university_year">Year of graduation from an institution of higher education.</param>
        /// <param name="university_faculty">Faculty ID.</param>
        /// <param name="university_chair">Chair ID.</param>
        /// <param name="sex">'1' — female; '2' — male; '0' — any (default)</param>
        /// <param name="status">Relationship status:; '1' — Not married; '2' — In a relationship; '3' — Engaged; '4' — Married; '5' — It's complicated; '6' — Actively searching; '7' — In love</param>
        /// <param name="age_from">Minimum age.</param>
        /// <param name="age_to">Maximum age.</param>
        /// <param name="birth_day">Day of birth.</param>
        /// <param name="birth_month">Month of birth.</param>
        /// <param name="birth_year">Year of birth.</param>
        /// <param name="online">'1' — online only; '0' — all users</param>
        /// <param name="has_photo">'1' — with photo only; '0' — all users</param>
        /// <param name="school_country">ID of the country where users finished school.</param>
        /// <param name="school_city">ID of the city where users finished school.</param>
        /// <param name="school_class"></param>
        /// <param name="school">ID of the school.</param>
        /// <param name="school_year">School graduation year.</param>
        /// <param name="religion">Users' religious affiliation.</param>
        /// <param name="interests">Users' interests.</param>
        /// <param name="company">Name of the company where users work.</param>
        /// <param name="position">Job position.</param>
        /// <param name="group_id">ID of a community to search in communities.</param>
        /// <param name="from_list"></param>
        public async Task<ApiItemsResponse<VkLib.Types.Users.UserFull>> Search(string q = null, int? sort = null, int? offset = null, int? count = null, IEnumerable<string> fields = null, int? city = null, int? country = null, string hometown = null, int? university_country = null, int? university = null, int? university_year = null, int? university_faculty = null, int? university_chair = null, int? sex = null, int? status = null, int? age_from = null, int? age_to = null, int? birth_day = null, int? birth_month = null, int? birth_year = null, bool? online = null, bool? has_photo = null, int? school_country = null, int? school_city = null, int? school_class = null, int? school = null, int? school_year = null, string religion = null, string interests = null, string company = null, string position = null, int? group_id = null, IEnumerable<string> from_list = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (q != null)
                parameters.Add("q", q);
            if (sort != null)
                parameters.Add("sort", sort.ToString());
            if (offset != null)
                parameters.Add("offset", offset.ToString());
            if (count != null)
                parameters.Add("count", count.ToString());
            if (fields != null)
                parameters.Add("fields", string.Join(",", fields));
            if (city != null)
                parameters.Add("city", city.ToString());
            if (country != null)
                parameters.Add("country", country.ToString());
            if (hometown != null)
                parameters.Add("hometown", hometown);
            if (university_country != null)
                parameters.Add("university_country", university_country.ToString());
            if (university != null)
                parameters.Add("university", university.ToString());
            if (university_year != null)
                parameters.Add("university_year", university_year.ToString());
            if (university_faculty != null)
                parameters.Add("university_faculty", university_faculty.ToString());
            if (university_chair != null)
                parameters.Add("university_chair", university_chair.ToString());
            if (sex != null)
                parameters.Add("sex", sex.ToString());
            if (status != null)
                parameters.Add("status", status.ToString());
            if (age_from != null)
                parameters.Add("age_from", age_from.ToString());
            if (age_to != null)
                parameters.Add("age_to", age_to.ToString());
            if (birth_day != null)
                parameters.Add("birth_day", birth_day.ToString());
            if (birth_month != null)
                parameters.Add("birth_month", birth_month.ToString());
            if (birth_year != null)
                parameters.Add("birth_year", birth_year.ToString());
            if (online != null)
                parameters.Add("online", online.ToString());
            if (has_photo != null)
                parameters.Add("has_photo", has_photo.ToString());
            if (school_country != null)
                parameters.Add("school_country", school_country.ToString());
            if (school_city != null)
                parameters.Add("school_city", school_city.ToString());
            if (school_class != null)
                parameters.Add("school_class", school_class.ToString());
            if (school != null)
                parameters.Add("school", school.ToString());
            if (school_year != null)
                parameters.Add("school_year", school_year.ToString());
            if (religion != null)
                parameters.Add("religion", religion);
            if (interests != null)
                parameters.Add("interests", interests);
            if (company != null)
                parameters.Add("company", company);
            if (position != null)
                parameters.Add("position", position);
            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());
            if (from_list != null)
                parameters.Add("from_list", string.Join(",", from_list));

            return await _vkontakte.GetAsync<ApiItemsResponse<VkLib.Types.Users.UserFull>>("users.search", parameters);
        }

        /// <summary>
        /// Returns information whether a user installed the application.
        /// Docs: <see href="https://vk.com/dev/users.isAppUser">users.isAppUser</see>
        /// </summary>
        /// <param name="user_id"></param>
        public async Task<int> IsAppUser(int? user_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (user_id != null)
                parameters.Add("user_id", user_id.ToString());

            return await _vkontakte.GetAsync<int>("users.isAppUser", parameters);
        }

        /// <summary>
        /// Returns a list of IDs of users and communities followed by the user.
        /// Docs: <see href="https://vk.com/dev/users.getSubscriptions">users.getSubscriptions</see>
        /// </summary>
        /// <param name="user_id">User ID.</param>
        /// <param name="extended">'1' — to return a combined list of users and communities; '0' — to return separate lists of users and communities (default)</param>
        /// <param name="offset">Offset needed to return a specific subset of subscriptions.</param>
        /// <param name="count">Number of users and communities to return.</param>
        /// <param name="fields"></param>
        public async Task<VkLib.Responses.Users.GetSubscriptionsResponse> GetSubscriptions(int? user_id = null, bool? extended = null, int? offset = null, int? count = null, IEnumerable<string> fields = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (user_id != null)
                parameters.Add("user_id", user_id.ToString());
            if (extended != null)
                parameters.Add("extended", extended.ToString());
            if (offset != null)
                parameters.Add("offset", offset.ToString());
            if (count != null)
                parameters.Add("count", count.ToString());
            if (fields != null)
                parameters.Add("fields", string.Join(",", fields));

            return await _vkontakte.GetAsync<VkLib.Responses.Users.GetSubscriptionsResponse>("users.getSubscriptions", parameters);
        }

        /// <summary>
        /// Returns a list of IDs of followers of the user in question, sorted by date added, most recent first.
        /// Docs: <see href="https://vk.com/dev/users.getFollowers">users.getFollowers</see>
        /// </summary>
        /// <param name="user_id">User ID.</param>
        /// <param name="offset">Offset needed to return a specific subset of followers.</param>
        /// <param name="count">Number of followers to return.</param>
        /// <param name="fields">Profile fields to return. Sample values: 'nickname', 'screen_name', 'sex', 'bdate' (birthdate), 'city', 'country', 'timezone', 'photo', 'photo_medium', 'photo_big', 'has_mobile', 'rate', 'contacts', 'education', 'online'.;</param>
        /// <param name="name_case">Case for declension of user name and surname:; 'nom' — nominative (default); 'gen' — genitive ; 'dat' — dative; 'acc' — accusative ; 'ins' — instrumental ; 'abl' — prepositional</param>
        public async Task<ApiItemsResponse<int?>> GetFollowers(int? user_id = null, int? offset = null, int? count = null, IEnumerable<string> fields = null, string name_case = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (user_id != null)
                parameters.Add("user_id", user_id.ToString());
            if (offset != null)
                parameters.Add("offset", offset.ToString());
            if (count != null)
                parameters.Add("count", count.ToString());
            if (fields != null)
                parameters.Add("fields", string.Join(",", fields));
            if (name_case != null)
                parameters.Add("name_case", name_case);

            return await _vkontakte.GetAsync<ApiItemsResponse<int?>>("users.getFollowers", parameters);
        }

        /// <summary>
        /// Reports (submits a complain about) a user.;
        /// Docs: <see href="https://vk.com/dev/users.report">users.report</see>
        /// </summary>
        /// <param name="user_id">ID of the user about whom a complaint is being made.</param>
        /// <param name="type">Type of complaint:; 'porn' – pornography; 'spam' – spamming; 'insult' – abusive behavior; 'advertisment' – disruptive advertisements</param>
        /// <param name="comment">Comment describing the complaint.</param>
        public async Task<int> Report(int? user_id = null, string type = null, string comment = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (user_id != null)
                parameters.Add("user_id", user_id.ToString());
            if (type != null)
                parameters.Add("type", type);
            if (comment != null)
                parameters.Add("comment", comment);

            return await _vkontakte.GetAsync<int>("users.report", parameters);
        }

        /// <summary>
        /// Indexes current user location and returns nearby users.
        /// Docs: <see href="https://vk.com/dev/users.getNearby">users.getNearby</see>
        /// </summary>
        /// <param name="latitude">geographic latitude of the place a user is located, in degrees (from -90 to 90)</param>
        /// <param name="longitude">geographic longitude of the place a user is located, in degrees (from -180 to 180)</param>
        /// <param name="accuracy">current location accuracy in meters</param>
        /// <param name="timeout">time when a user disappears from location search results, in seconds</param>
        /// <param name="radius">search zone radius type (1 to 4); :* 1 – 300 m;; :* 2 – 2400 m;; :* 3 – 18 km;; :* 4 – 150 km.</param>
        /// <param name="fields">list of additional fields to return.; Available values: sex, bdate, city, country, photo_50, photo_100, photo_200_orig, photo_200, photo_400_orig, photo_max, photo_max_orig, online, online_mobile, domain, has_mobile, contacts, connections, site, education, universities, schools, can_post, can_see_all_posts, can_see_audio, can_write_private_message, status, last_seen, common_count, relation, relatives, counters, screen_name, maiden_name, timezone, occupation</param>
        /// <param name="name_case">Case for declension of user name and surname: ; nom –nominative (default) ; gen – genitive ; dat – dative ; acc – accusative ; ins – instrumental ; abl – prepositional</param>
        public async Task<ApiItemsResponse<VkLib.Types.Users.UserFull>> GetNearby(uint? latitude = null, uint? longitude = null, int? accuracy = null, int? timeout = null, int? radius = null, IEnumerable<string> fields = null, string name_case = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (latitude != null)
                parameters.Add("latitude", latitude.ToString());
            if (longitude != null)
                parameters.Add("longitude", longitude.ToString());
            if (accuracy != null)
                parameters.Add("accuracy", accuracy.ToString());
            if (timeout != null)
                parameters.Add("timeout", timeout.ToString());
            if (radius != null)
                parameters.Add("radius", radius.ToString());
            if (fields != null)
                parameters.Add("fields", string.Join(",", fields));
            if (name_case != null)
                parameters.Add("name_case", name_case);

            return await _vkontakte.GetAsync<ApiItemsResponse<VkLib.Types.Users.UserFull>>("users.getNearby", parameters);
        }

    }
}
