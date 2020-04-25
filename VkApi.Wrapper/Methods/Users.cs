using VkApi.Wrapper.Objects;
using VkApi.Wrapper.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Methods
{
    public class Users
    {
        private readonly Vkontakte _vkontakte;

        internal Users(Vkontakte vkontakte) => _vkontakte = vkontakte;

        ///<summary>
        /// Returns detailed information on users.
        ///</summary>
        public Task<UsersUserXtrCounters[]> Get(String[] userIds = null, UsersFields[] fields = null, String nameCase = null)
        {
            var parameters = new Dictionary<string, string>();
            if (userIds != null)
                parameters.Add("user_ids", userIds.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            if (nameCase != null)
                parameters.Add("name_case", nameCase.ToApiString());
            return _vkontakte.RequestAsync<UsersUserXtrCounters[]>("users.get", parameters);
        }

        ///<summary>
        /// Returns a list of IDs of followers of the user in question, sorted by date added, most recent first.
        ///</summary>
        public Task<UsersGetFollowersResponse> GetFollowers(int? userId = null, int? offset = null, int? count = null, UsersFields[] fields = null, String nameCase = null)
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
                parameters.Add("name_case", nameCase.ToApiString());
            return _vkontakte.RequestAsync<UsersGetFollowersResponse>("users.getFollowers", parameters);
        }

        ///<summary>
        /// Returns a list of IDs of users and communities followed by the user.
        ///</summary>
        public Task<UsersGetSubscriptionsResponse> GetSubscriptions(int? userId = null, Boolean? extended = null, int? offset = null, int? count = null, UsersFields[] fields = null)
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
            return _vkontakte.RequestAsync<UsersGetSubscriptionsResponse>("users.getSubscriptions", parameters);
        }

        ///<summary>
        /// Reports (submits a complain about) a user.
        ///</summary>
        public Task<BaseOkResponse> Report(int? userId = null, String type = null, String comment = null)
        {
            var parameters = new Dictionary<string, string>();
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (type != null)
                parameters.Add("type", type.ToApiString());
            if (comment != null)
                parameters.Add("comment", comment.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("users.report", parameters);
        }

        ///<summary>
        /// Returns a list of users matching the search criteria.
        ///</summary>
        public Task<UsersSearchResponse> Search(String q = null, int? sort = null, int? offset = null, int? count = null, UsersFields[] fields = null, int? city = null, int? country = null, String hometown = null, int? universityCountry = null, int? university = null, int? universityYear = null, int? universityFaculty = null, int? universityChair = null, int? sex = null, int? status = null, int? ageFrom = null, int? ageTo = null, int? birthDay = null, int? birthMonth = null, int? birthYear = null, Boolean? online = null, Boolean? hasPhoto = null, int? schoolCountry = null, int? schoolCity = null, int? schoolClass = null, int? school = null, int? schoolYear = null, String religion = null, String company = null, String position = null, int? groupId = null, String[] fromList = null)
        {
            var parameters = new Dictionary<string, string>();
            if (q != null)
                parameters.Add("q", q.ToApiString());
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
                parameters.Add("hometown", hometown.ToApiString());
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
                parameters.Add("religion", religion.ToApiString());
            if (company != null)
                parameters.Add("company", company.ToApiString());
            if (position != null)
                parameters.Add("position", position.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (fromList != null)
                parameters.Add("from_list", fromList.ToApiString());
            return _vkontakte.RequestAsync<UsersSearchResponse>("users.search", parameters);
        }
    }
}