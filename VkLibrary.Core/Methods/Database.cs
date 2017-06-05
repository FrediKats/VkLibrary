using System.Collections.Generic;
using System.Threading.Tasks;
using VkLibrary.Core.Types.Base;
using VkLibrary.Core.Types.Database;

namespace VkLibrary.Core.Methods
{
    /// <summary>
    /// Database API section.
    /// </summary>
    public class Database
    {
        private readonly Vkontakte _vkontakte;

        internal Database(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        /// Returns a list of countries.
        /// Docs: <see href="https://vk.com/dev/database.getCountries">database.getCountries</see>
        /// </summary>
        /// <param name="needAll">
        /// '1' — to return a full list of all countries; '0' — to return a list of countries near the
        /// current user's country (default).;
        /// </param>
        /// <param name="code">Country codes in [vk.com/dev/country_codes|ISO 3166-1 alpha-2] standard.</param>
        /// <param name="offset">Offset needed to return a specific subset of countries.</param>
        /// <param name="count">Number of countries to return.</param>
        public Task<ApiItemsResponse<Country>> GetCountries(bool? needAll = null, string code = null,
            int? offset = null, int? count = null)
        {
            var parameters = new Dictionary<string, string>();

            if (needAll != null)
                parameters.Add("need_all", needAll.ToApiString());
            if (code != null)
                parameters.Add("code", code);
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());

            return _vkontakte.GetAsync<ApiItemsResponse<Country>>("database.getCountries", parameters);
        }

        /// <summary>
        /// Returns a list of regions.
        /// Docs: <see href="https://vk.com/dev/database.getRegions">database.getRegions</see>
        /// </summary>
        /// <param name="countryId">Country ID, received in [vk.com/dev/database.getCountries|database.getCountries] method.</param>
        /// <param name="q">Search query.</param>
        /// <param name="offset">Offset needed to return specific subset of regions.</param>
        /// <param name="count">Number of regions to return.</param>
        public Task<ApiItemsResponse<Region>> GetRegions(int? countryId = null, string q = null,
            int? offset = null, int? count = null)
        {
            var parameters = new Dictionary<string, string>();

            if (countryId != null)
                parameters.Add("country_id", countryId.ToApiString());
            if (q != null)
                parameters.Add("q", q);
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());

            return _vkontakte.GetAsync<ApiItemsResponse<Region>>("database.getRegions", parameters);
        }

        /// <summary>
        /// Returns information about streets by their IDs.
        /// Docs: <see href="https://vk.com/dev/database.getStreetsById">database.getStreetsById</see>
        /// </summary>
        /// <param name="streetIds">Street IDs.</param>
        public Task<IEnumerable<Street>> GetStreetsById(IEnumerable<int?> streetIds = null)
        {
            var parameters = new Dictionary<string, string>();

            if (streetIds != null)
                parameters.Add("street_ids", streetIds.ToApiString());

            return _vkontakte.GetAsync<IEnumerable<Street>>("database.getStreetsById", parameters);
        }

        /// <summary>
        /// Returns information about countries by their IDs.
        /// Docs: <see href="https://vk.com/dev/database.getCountriesById">database.getCountriesById</see>
        /// </summary>
        /// <param name="countryIds">Country IDs.</param>
        public Task<IEnumerable<Country>> GetCountriesById(IEnumerable<int?> countryIds = null)
        {
            var parameters = new Dictionary<string, string>();

            if (countryIds != null)
                parameters.Add("country_ids", countryIds.ToApiString());

            return _vkontakte.GetAsync<IEnumerable<Country>>("database.getCountriesById", parameters);
        }

        /// <summary>
        /// Returns a list of cities.
        /// Docs: <see href="https://vk.com/dev/database.getCities">database.getCities</see>
        /// </summary>
        /// <param name="countryId">Country ID.</param>
        /// <param name="regionId">Region ID.</param>
        /// <param name="q">Search query.</param>
        /// <param name="needAll">
        /// '1' — to return all cities in the country; '0' — to return major cities in the country
        /// (default);
        /// </param>
        /// <param name="offset">Offset needed to return a specific subset of cities.</param>
        /// <param name="count">Number of cities to return.</param>
        public Task<ApiItemsResponse<City>> GetCities(int? countryId = null, int? regionId = null,
            string q = null, bool? needAll = null, int? offset = null, int? count = null)
        {
            var parameters = new Dictionary<string, string>();

            if (countryId != null)
                parameters.Add("country_id", countryId.ToApiString());
            if (regionId != null)
                parameters.Add("region_id", regionId.ToApiString());
            if (q != null)
                parameters.Add("q", q);
            if (needAll != null)
                parameters.Add("need_all", needAll.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());

            return _vkontakte.GetAsync<ApiItemsResponse<City>>("database.getCities", parameters);
        }

        /// <summary>
        /// Returns information about cities by their IDs.
        /// Docs: <see href="https://vk.com/dev/database.getCitiesById">database.getCitiesById</see>
        /// </summary>
        /// <param name="cityIds">City IDs.</param>
        public Task<IEnumerable<Object>> GetCitiesById(IEnumerable<int?> cityIds = null)
        {
            var parameters = new Dictionary<string, string>();

            if (cityIds != null)
                parameters.Add("city_ids", cityIds.ToApiString());

            return _vkontakte.GetAsync<IEnumerable<Object>>("database.getCitiesById", parameters);
        }

        /// <summary>
        /// Returns a list of higher education institutions.
        /// Docs: <see href="https://vk.com/dev/database.getUniversities">database.getUniversities</see>
        /// </summary>
        /// <param name="q">Search query.</param>
        /// <param name="countryId">Country ID.</param>
        /// <param name="cityId">City ID.</param>
        /// <param name="offset">Offset needed to return a specific subset of universities.</param>
        /// <param name="count">Number of universities to return.</param>
        public Task<ApiItemsResponse<University>> GetUniversities(string q = null, int? countryId = null,
            int? cityId = null, int? offset = null, int? count = null)
        {
            var parameters = new Dictionary<string, string>();

            if (q != null)
                parameters.Add("q", q);
            if (countryId != null)
                parameters.Add("country_id", countryId.ToApiString());
            if (cityId != null)
                parameters.Add("city_id", cityId.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());

            return _vkontakte.GetAsync<ApiItemsResponse<University>>("database.getUniversities", parameters);
        }

        /// <summary>
        /// Returns a list of schools.
        /// Docs: <see href="https://vk.com/dev/database.getSchools">database.getSchools</see>
        /// </summary>
        /// <param name="q">Search query.</param>
        /// <param name="cityId">City ID.</param>
        /// <param name="offset">Offset needed to return a specific subset of schools.</param>
        /// <param name="count">Number of schools to return.</param>
        public Task<ApiItemsResponse<School>> GetSchools(string q = null, int? cityId = null, int? offset = null,
            int? count = null)
        {
            var parameters = new Dictionary<string, string>();

            if (q != null)
                parameters.Add("q", q);
            if (cityId != null)
                parameters.Add("city_id", cityId.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());

            return _vkontakte.GetAsync<ApiItemsResponse<School>>("database.getSchools", parameters);
        }

        /// <summary>
        /// Returns a list of school classes specified for the country.
        /// Docs: <see href="https://vk.com/dev/database.getSchoolClasses">database.getSchoolClasses</see>
        /// </summary>
        /// <param name="countryId">Country ID.</param>
        public Task<IEnumerable<IEnumerable<string>>> GetSchoolClasses(int? countryId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (countryId != null)
                parameters.Add("country_id", countryId.ToApiString());

            return _vkontakte.GetAsync<IEnumerable<IEnumerable<string>>>("database.getSchoolClasses", parameters);
        }

        /// <summary>
        /// Returns a list of faculties (i.e., university departments).;
        /// Docs: <see href="https://vk.com/dev/database.getFaculties">database.getFaculties</see>
        /// </summary>
        /// <param name="universityId">University ID.</param>
        /// <param name="offset">Offset needed to return a specific subset of faculties.</param>
        /// <param name="count">Number of faculties to return.</param>
        public Task<ApiItemsResponse<Faculty>> GetFaculties(int? universityId = null, int? offset = null,
            int? count = null)
        {
            var parameters = new Dictionary<string, string>();

            if (universityId != null)
                parameters.Add("university_id", universityId.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());

            return _vkontakte.GetAsync<ApiItemsResponse<Faculty>>("database.getFaculties", parameters);
        }

        /// <summary>
        /// Returns list of chairs on a specified faculty.
        /// Docs: <see href="https://vk.com/dev/database.getChairs">database.getChairs</see>
        /// </summary>
        /// <param name="facultyId">id of the faculty to get chairs from</param>
        /// <param name="offset">offset required to get a certain subset of chairs</param>
        /// <param name="count">amount of chairs to get</param>
        public Task<ApiItemsResponse<Object>> GetChairs(int? facultyId = null, int? offset = null,
            int? count = null)
        {
            var parameters = new Dictionary<string, string>();

            if (facultyId != null)
                parameters.Add("faculty_id", facultyId.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());

            return _vkontakte.GetAsync<ApiItemsResponse<Object>>("database.getChairs", parameters);
        }
    }
}