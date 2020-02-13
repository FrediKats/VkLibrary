using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VkApi.Wrapper.Responses.Database;
using VkApi.Wrapper.Types.Base;
using VkApi.Wrapper.Types.Database;

namespace VkApi.Wrapper.Methods
{
    public class Database
    {
        private readonly Vkontakte _vkontakte;

        internal Database(Vkontakte vkontakte) => _vkontakte = vkontakte;

        ///<summary>
        /// Returns list of chairs on a specified faculty.
        ///</summary>
        public Task<DatabaseGetChairsResponse> GetChairs(int? facultyId = null, int? offset = null, int? count = null)
        {
            var parameters = new Dictionary<string, string>();
            if (facultyId != null)
                parameters.Add("faculty_id", facultyId.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            return _vkontakte.RequestAsync<DatabaseGetChairsResponse>("database.getChairs", parameters);
        }

        ///<summary>
        /// Returns a list of cities.
        ///</summary>
        public Task<DatabaseGetCitiesResponse> GetCities(int? countryId = null, int? regionId = null, String q = null, Boolean? needAll = null, int? offset = null, int? count = null)
        {
            var parameters = new Dictionary<string, string>();
            if (countryId != null)
                parameters.Add("country_id", countryId.ToApiString());
            if (regionId != null)
                parameters.Add("region_id", regionId.ToApiString());
            if (q != null)
                parameters.Add("q", q.ToApiString());
            if (needAll != null)
                parameters.Add("need_all", needAll.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            return _vkontakte.RequestAsync<DatabaseGetCitiesResponse>("database.getCities", parameters);
        }

        ///<summary>
        /// Returns information about cities by their IDs.
        ///</summary>
        public Task<BaseObject[]> GetCitiesById(int[] cityIds = null)
        {
            var parameters = new Dictionary<string, string>();
            if (cityIds != null)
                parameters.Add("city_ids", cityIds.ToApiString());
            return _vkontakte.RequestAsync<BaseObject[]>("database.getCitiesById", parameters);
        }

        ///<summary>
        /// Returns a list of countries.
        ///</summary>
        public Task<DatabaseGetCountriesResponse> GetCountries(Boolean? needAll = null, String code = null, int? offset = null, int? count = null)
        {
            var parameters = new Dictionary<string, string>();
            if (needAll != null)
                parameters.Add("need_all", needAll.ToApiString());
            if (code != null)
                parameters.Add("code", code.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            return _vkontakte.RequestAsync<DatabaseGetCountriesResponse>("database.getCountries", parameters);
        }

        ///<summary>
        /// Returns information about countries by their IDs.
        ///</summary>
        public Task<BaseCountry[]> GetCountriesById(int[] countryIds = null)
        {
            var parameters = new Dictionary<string, string>();
            if (countryIds != null)
                parameters.Add("country_ids", countryIds.ToApiString());
            return _vkontakte.RequestAsync<BaseCountry[]>("database.getCountriesById", parameters);
        }

        ///<summary>
        /// Returns a list of faculties (i.e., university departments).
        ///</summary>
        public Task<DatabaseGetFacultiesResponse> GetFaculties(int? universityId = null, int? offset = null, int? count = null)
        {
            var parameters = new Dictionary<string, string>();
            if (universityId != null)
                parameters.Add("university_id", universityId.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            return _vkontakte.RequestAsync<DatabaseGetFacultiesResponse>("database.getFaculties", parameters);
        }

        ///<summary>
        /// Get metro stations by city
        ///</summary>
        public Task<DatabaseGetMetroStationsResponse> GetMetroStations(int? cityId = null, int? offset = null, int? count = null, Boolean? extended = null)
        {
            var parameters = new Dictionary<string, string>();
            if (cityId != null)
                parameters.Add("city_id", cityId.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            return _vkontakte.RequestAsync<DatabaseGetMetroStationsResponse>("database.getMetroStations", parameters);
        }

        ///<summary>
        /// Get metro station by his id
        ///</summary>
        public Task<DatabaseStation[]> GetMetroStationsById(int[] stationIds = null)
        {
            var parameters = new Dictionary<string, string>();
            if (stationIds != null)
                parameters.Add("station_ids", stationIds.ToApiString());
            return _vkontakte.RequestAsync<DatabaseStation[]>("database.getMetroStationsById", parameters);
        }

        ///<summary>
        /// Returns a list of regions.
        ///</summary>
        public Task<DatabaseGetRegionsResponse> GetRegions(int? countryId = null, String q = null, int? offset = null, int? count = null)
        {
            var parameters = new Dictionary<string, string>();
            if (countryId != null)
                parameters.Add("country_id", countryId.ToApiString());
            if (q != null)
                parameters.Add("q", q.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            return _vkontakte.RequestAsync<DatabaseGetRegionsResponse>("database.getRegions", parameters);
        }

        ///<summary>
        /// Returns a list of school classes specified for the country.
        ///</summary>
        public Task<object[][]> GetSchoolClasses(int? countryId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (countryId != null)
                parameters.Add("country_id", countryId.ToApiString());
            return _vkontakte.RequestAsync<object[][]>("database.getSchoolClasses", parameters);
        }

        ///<summary>
        /// Returns a list of schools.
        ///</summary>
        public Task<DatabaseGetSchoolsResponse> GetSchools(String q = null, int? cityId = null, int? offset = null, int? count = null)
        {
            var parameters = new Dictionary<string, string>();
            if (q != null)
                parameters.Add("q", q.ToApiString());
            if (cityId != null)
                parameters.Add("city_id", cityId.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            return _vkontakte.RequestAsync<DatabaseGetSchoolsResponse>("database.getSchools", parameters);
        }

        ///<summary>
        /// Returns a list of higher education institutions.
        ///</summary>
        public Task<DatabaseGetUniversitiesResponse> GetUniversities(String q = null, int? countryId = null, int? cityId = null, int? offset = null, int? count = null)
        {
            var parameters = new Dictionary<string, string>();
            if (q != null)
                parameters.Add("q", q.ToApiString());
            if (countryId != null)
                parameters.Add("country_id", countryId.ToApiString());
            if (cityId != null)
                parameters.Add("city_id", cityId.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            return _vkontakte.RequestAsync<DatabaseGetUniversitiesResponse>("database.getUniversities", parameters);
        }
    }
}