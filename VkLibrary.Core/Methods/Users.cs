using System.Collections.Generic;
using System.Threading.Tasks;
using VkLibrary.Core.Responses.Users;
using VkLibrary.Core.Types.Users;

namespace VkLibrary.Core.Methods
{
    /// <summary>
    /// Users API section.
    /// </summary>
    public class Users
    {
        private readonly Vkontakte _vkontakte;

        internal Users(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        /// Returns detailed information on users.
        /// Docs: <see href="https://vk.com/dev/users.get">users.get</see>
        /// </summary>
        /// <param name="userIds">User IDs or screen names ('screen_name'). By default, current user ID.</param>
        /// <param name="fields">
        /// Profile fields to return. Sample values: 'nickname', 'screen_name', 'sex', 'bdate' (birthdate),
        /// 'city', 'country', 'timezone', 'photo', 'photo_medium', 'photo_big', 'has_mobile', 'contacts', 'education',
        /// 'online', 'counters', 'relation', 'last_seen', 'activity', 'can_write_private_message', 'can_see_all_posts',
        /// 'can_post', 'universities';
        /// </param>
        /// <param name="nameCase">
        /// Case for declension of user name and surname:; 'nom' — nominative (default); 'gen' — genitive ;
        /// 'dat' — dative; 'acc' — accusative ; 'ins' — instrumental ; 'abl' — prepositional
        /// </param>
        public async Task<IEnumerable<UserXtrCounters>> Get(IEnumerable<string> userIds = null,
            IEnumerable<string> fields = null, string nameCase = null)
        {
            var parameters = new Dictionary<string, string>();

            if (userIds != null)
                parameters.Add("user_ids", userIds.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            if (nameCase != null)
                parameters.Add("name_case", nameCase);

            return await _vkontakte.GetAsync<IEnumerable<UserXtrCounters>>("users.get", parameters);
        }

        /// <summary>
        /// Returns a list of users matching the search criteria.
        /// Docs: <see href="https://vk.com/dev/users.search">users.search</see>
        /// </summary>
        /// <param name="q">Search query string (e.g., 'Vasya Babich').</param>
        /// <param name="sort">Sort order:; '1' — by date registered; '0' — by rating</param>
        /// <param name="offset">Offset needed to return a specific subset of users.</param>
        /// <param name="count">Number of users to return.</param>
        /// <param name="fields">
        /// Profile fields to return. Sample values: 'nickname', 'screen_name', 'sex', 'bdate' (birthdate),
        /// 'city', 'country', 'timezone', 'photo', 'photo_medium', 'photo_big', 'has_mobile', 'rate', 'contacts', 'education',
        /// 'online';
        /// </param>
        /// <param name="city">City ID.</param>
        /// <param name="country">Country ID.</param>
        /// <param name="hometown">City name in a string.</param>
        /// <param name="universityCountry">ID of the country where the user graduated.</param>
        /// <param name="university">ID of the institution of higher education.</param>
        /// <param name="universityYear">Year of graduation from an institution of higher education.</param>
        /// <param name="universityFaculty">Faculty ID.</param>
        /// <param name="universityChair">Chair ID.</param>
        /// <param name="sex">'1' — female; '2' — male; '0' — any (default)</param>
        /// <param name="status">
        /// Relationship status:; '1' — Not married; '2' — In a relationship; '3' — Engaged; '4' — Married;
        /// '5' — It's complicated; '6' — Actively searching; '7' — In love
        /// </param>
        /// <param name="ageFrom">Minimum age.</param>
        /// <param name="ageTo">Maximum age.</param>
        /// <param name="birthDay">Day of birth.</param>
        /// <param name="birthMonth">Month of birth.</param>
        /// <param name="birthYear">Year of birth.</param>
        /// <param name="online">'1' — online only; '0' — all users</param>
        /// <param name="hasPhoto">'1' — with photo only; '0' — all users</param>
        /// <param name="schoolCountry">ID of the country where users finished school.</param>
        /// <param name="schoolCity">ID of the city where users finished school.</param>
        /// <param name="schoolClass"></param>
        /// <param name="school">ID of the school.</param>
        /// <param name="schoolYear">School graduation year.</param>
        /// <param name="religion">Users' religious affiliation.</param>
        /// <param name="interests">Users' interests.</param>
        /// <param name="company">Name of the company where users work.</param>
        /// <param name="position">Job position.</param>
        /// <param name="groupId">ID of a community to search in communities.</param>
        /// <param name="fromList"></param>
        public async Task<ApiItemsResponse<UserFull>> Search(string q = null, int? sort = null, int? offset = null,
            int? count = null, IEnumerable<string> fields = null, int? city = null, int? country = null,
            string hometown = null, int? universityCountry = null, int? university = null, int? universityYear = null,
            int? universityFaculty = null, int? universityChair = null, int? sex = null, int? status = null,
            int? ageFrom = null, int? ageTo = null, int? birthDay = null, int? birthMonth = null,
            int? birthYear = null, bool? online = null, bool? hasPhoto = null, int? schoolCountry = null,
            int? schoolCity = null, int? schoolClass = null, int? school = null, int? schoolYear = null,
            string religion = null, string interests = null, string company = null, string position = null,
            int? groupId = null, IEnumerable<string> fromList = null)
        {
            var parameters = new Dictionary<string, string>();

            if (q != null)
                parameters.Add("q", q);
            if (sort != null)
                parameters.Add("sort", sort.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            if (city != null)
                parameters.Add("city", city.ToApiString());
            if (country != null)
                parameters.Add("country", country.ToApiString());
            if (hometown != null)
                parameters.Add("hometown", hometown);
            if (universityCountry != null)
                parameters.Add("university_country", universityCountry.ToApiString());
            if (university != null)
                parameters.Add("university", university.ToApiString());
            if (universityYear != null)
                parameters.Add("university_year", universityYear.ToApiString());
            if (universityFaculty != null)
                parameters.Add("university_faculty", universityFaculty.ToApiString());
            if (universityChair != null)
                parameters.Add("university_chair", universityChair.ToApiString());
            if (sex != null)
                parameters.Add("sex", sex.ToApiString());
            if (status != null)
                parameters.Add("status", status.ToApiString());
            if (ageFrom != null)
                parameters.Add("age_from", ageFrom.ToApiString());
            if (ageTo != null)
                parameters.Add("age_to", ageTo.ToApiString());
            if (birthDay != null)
                parameters.Add("birth_day", birthDay.ToApiString());
            if (birthMonth != null)
                parameters.Add("birth_month", birthMonth.ToApiString());
            if (birthYear != null)
                parameters.Add("birth_year", birthYear.ToApiString());
            if (online != null)
                parameters.Add("online", online.ToApiString());
            if (hasPhoto != null)
                parameters.Add("has_photo", hasPhoto.ToApiString());
            if (schoolCountry != null)
                parameters.Add("school_country", schoolCountry.ToApiString());
            if (schoolCity != null)
                parameters.Add("school_city", schoolCity.ToApiString());
            if (schoolClass != null)
                parameters.Add("school_class", schoolClass.ToApiString());
            if (school != null)
                parameters.Add("school", school.ToApiString());
            if (schoolYear != null)
                parameters.Add("school_year", schoolYear.ToApiString());
            if (religion != null)
                parameters.Add("religion", religion);
            if (interests != null)
                parameters.Add("interests", interests);
            if (company != null)
                parameters.Add("company", company);
            if (position != null)
                parameters.Add("position", position);
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (fromList != null)
                parameters.Add("from_list", fromList.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<UserFull>>("users.search", parameters);
        }

        /// <summary>
        /// Returns information whether a user installed the application.
        /// Docs: <see href="https://vk.com/dev/users.isAppUser">users.isAppUser</see>
        /// </summary>
        /// <param name="userId"></param>
        public async Task<int> IsAppUser(int? userId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());

            return await _vkontakte.GetAsync<int>("users.isAppUser", parameters);
        }

        /// <summary>
        /// Returns a list of IDs of users and communities followed by the user.
        /// Docs: <see href="https://vk.com/dev/users.getSubscriptions">users.getSubscriptions</see>
        /// </summary>
        /// <param name="userId">User ID.</param>
        /// <param name="extended">
        /// '1' — to return a combined list of users and communities; '0' — to return separate lists of
        /// users and communities (default)
        /// </param>
        /// <param name="offset">Offset needed to return a specific subset of subscriptions.</param>
        /// <param name="count">Number of users and communities to return.</param>
        /// <param name="fields"></param>
        public async Task<GetSubscriptionsResponse> GetSubscriptions(int? userId = null, bool? extended = null,
            int? offset = null, int? count = null, IEnumerable<string> fields = null)
        {
            var parameters = new Dictionary<string, string>();

            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());

            return await _vkontakte.GetAsync<GetSubscriptionsResponse>("users.getSubscriptions", parameters);
        }

        /// <summary>
        /// Returns a list of IDs of followers of the user in question, sorted by date added, most recent first.
        /// Docs: <see href="https://vk.com/dev/users.getFollowers">users.getFollowers</see>
        /// </summary>
        /// <param name="userId">User ID.</param>
        /// <param name="offset">Offset needed to return a specific subset of followers.</param>
        /// <param name="count">Number of followers to return.</param>
        /// <param name="fields">
        /// Profile fields to return. Sample values: 'nickname', 'screen_name', 'sex', 'bdate' (birthdate),
        /// 'city', 'country', 'timezone', 'photo', 'photo_medium', 'photo_big', 'has_mobile', 'rate', 'contacts', 'education',
        /// 'online'.;
        /// </param>
        /// <param name="nameCase">
        /// Case for declension of user name and surname:; 'nom' — nominative (default); 'gen' — genitive ;
        /// 'dat' — dative; 'acc' — accusative ; 'ins' — instrumental ; 'abl' — prepositional
        /// </param>
        public async Task<ApiItemsResponse<T>> GetFollowers<T>(int? userId = null, int? offset = null,
            int? count = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            var parameters = new Dictionary<string, string>();

            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            if (nameCase != null)
                parameters.Add("name_case", nameCase);

            return await _vkontakte.GetAsync<ApiItemsResponse<T>>("users.getFollowers", parameters);
        }

        /// <summary>
        /// Reports (submits a complain about) a user.;
        /// Docs: <see href="https://vk.com/dev/users.report">users.report</see>
        /// </summary>
        /// <param name="userId">ID of the user about whom a complaint is being made.</param>
        /// <param name="type">
        /// Type of complaint:; 'porn' – pornography; 'spam' – spamming; 'insult' – abusive behavior;
        /// 'advertisment' – disruptive advertisements
        /// </param>
        /// <param name="comment">Comment describing the complaint.</param>
        public async Task<int> Report(int? userId = null, string type = null, string comment = null)
        {
            var parameters = new Dictionary<string, string>();

            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
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
        /// <param name="fields">
        /// list of additional fields to return.; Available values: sex, bdate, city, country, photo_50,
        /// photo_100, photo_200_orig, photo_200, photo_400_orig, photo_max, photo_max_orig, online, online_mobile, domain,
        /// has_mobile, contacts, connections, site, education, universities, schools, can_post, can_see_all_posts,
        /// can_see_audio, can_write_private_message, status, last_seen, common_count, relation, relatives, counters,
        /// screen_name, maiden_name, timezone, occupation
        /// </param>
        /// <param name="nameCase">
        /// Case for declension of user name and surname: ; nom –nominative (default) ; gen – genitive ;
        /// dat – dative ; acc – accusative ; ins – instrumental ; abl – prepositional
        /// </param>
        public async Task<ApiItemsResponse<UserFull>> GetNearby(uint? latitude = null, uint? longitude = null,
            int? accuracy = null, int? timeout = null, int? radius = null, IEnumerable<string> fields = null,
            string nameCase = null)
        {
            var parameters = new Dictionary<string, string>();

            if (latitude != null)
                parameters.Add("latitude", latitude.ToApiString());
            if (longitude != null)
                parameters.Add("longitude", longitude.ToApiString());
            if (accuracy != null)
                parameters.Add("accuracy", accuracy.ToApiString());
            if (timeout != null)
                parameters.Add("timeout", timeout.ToApiString());
            if (radius != null)
                parameters.Add("radius", radius.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            if (nameCase != null)
                parameters.Add("name_case", nameCase);

            return await _vkontakte.GetAsync<ApiItemsResponse<UserFull>>("users.getNearby", parameters);
        }
    }
}