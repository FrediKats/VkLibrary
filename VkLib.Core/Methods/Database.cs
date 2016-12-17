using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkLib.Methods
{
    /// <summary>
    /// Database API section.
    /// </summary>
    public class Database
    {
        private Vkontakte _vkontakte;

        internal Database(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        /// Returns a list of countries.
        /// Docs: <see href="https://vk.com/dev/database.getCountries">database.getCountries</see>
        /// </summary>
        /// <param name="need_all">'1' — to return a full list of all countries; '0' — to return a list of countries near the current user's country (default).;</param>
        /// <param name="code">Country codes in [vk.com/dev/country_codes|ISO 3166-1 alpha-2] standard.</param>
        /// <param name="offset">Offset needed to return a specific subset of countries.</param>
        /// <param name="count">Number of countries to return.</param>
        public async Task<object> GetCountries(bool? need_all = null, string code = null, int? offset = null, int? count = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (need_all != null)
                parameters.Add("need_all", need_all.ToString());
            if (code != null)
                parameters.Add("code", code);
            if (offset != null)
                parameters.Add("offset", offset.ToString());
            if (count != null)
                parameters.Add("count", count.ToString());

            return await _vkontakte.GetAsync<object>("database.getCountries", parameters);
        }

        /// <summary>
        /// Returns a list of regions.
        /// Docs: <see href="https://vk.com/dev/database.getRegions">database.getRegions</see>
        /// </summary>
        /// <param name="country_id">Country ID, received in [vk.com/dev/database.getCountries|database.getCountries] method.</param>
        /// <param name="q">Search query.</param>
        /// <param name="offset">Offset needed to return specific subset of regions.</param>
        /// <param name="count">Number of regions to return.</param>
        public async Task<object> GetRegions(int? country_id = null, string q = null, int? offset = null, int? count = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (country_id != null)
                parameters.Add("country_id", country_id.ToString());
            if (q != null)
                parameters.Add("q", q);
            if (offset != null)
                parameters.Add("offset", offset.ToString());
            if (count != null)
                parameters.Add("count", count.ToString());

            return await _vkontakte.GetAsync<object>("database.getRegions", parameters);
        }

        /// <summary>
        /// Returns information about streets by their IDs.
        /// Docs: <see href="https://vk.com/dev/database.getStreetsById">database.getStreetsById</see>
        /// </summary>
        /// <param name="street_ids">Street IDs.</param>
        public async Task<object> GetStreetsById(IEnumerable<int?> street_ids = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (street_ids != null)
                parameters.Add("street_ids", string.Join(",", street_ids));

            return await _vkontakte.GetAsync<object>("database.getStreetsById", parameters);
        }

        /// <summary>
        /// Returns information about countries by their IDs.
        /// Docs: <see href="https://vk.com/dev/database.getCountriesById">database.getCountriesById</see>
        /// </summary>
        /// <param name="country_ids">Country IDs.</param>
        public async Task<object> GetCountriesById(IEnumerable<int?> country_ids = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (country_ids != null)
                parameters.Add("country_ids", string.Join(",", country_ids));

            return await _vkontakte.GetAsync<object>("database.getCountriesById", parameters);
        }

        /// <summary>
        /// Returns a list of cities.
        /// Docs: <see href="https://vk.com/dev/database.getCities">database.getCities</see>
        /// </summary>
        /// <param name="country_id">Country ID.</param>
        /// <param name="region_id">Region ID.</param>
        /// <param name="q">Search query.</param>
        /// <param name="need_all">'1' — to return all cities in the country; '0' — to return major cities in the country (default);</param>
        /// <param name="offset">Offset needed to return a specific subset of cities.</param>
        /// <param name="count">Number of cities to return.</param>
        public async Task<object> GetCities(int? country_id = null, int? region_id = null, string q = null, bool? need_all = null, int? offset = null, int? count = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (country_id != null)
                parameters.Add("country_id", country_id.ToString());
            if (region_id != null)
                parameters.Add("region_id", region_id.ToString());
            if (q != null)
                parameters.Add("q", q);
            if (need_all != null)
                parameters.Add("need_all", need_all.ToString());
            if (offset != null)
                parameters.Add("offset", offset.ToString());
            if (count != null)
                parameters.Add("count", count.ToString());

            return await _vkontakte.GetAsync<object>("database.getCities", parameters);
        }

        /// <summary>
        /// Returns information about cities by their IDs.
        /// Docs: <see href="https://vk.com/dev/database.getCitiesById">database.getCitiesById</see>
        /// </summary>
        /// <param name="city_ids">City IDs.</param>
        public async Task<object> GetCitiesById(IEnumerable<int?> city_ids = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (city_ids != null)
                parameters.Add("city_ids", string.Join(",", city_ids));

            return await _vkontakte.GetAsync<object>("database.getCitiesById", parameters);
        }

        /// <summary>
        /// Returns a list of higher education institutions.
        /// Docs: <see href="https://vk.com/dev/database.getUniversities">database.getUniversities</see>
        /// </summary>
        /// <param name="q">Search query.</param>
        /// <param name="country_id">Country ID.</param>
        /// <param name="city_id">City ID.</param>
        /// <param name="offset">Offset needed to return a specific subset of universities.</param>
        /// <param name="count">Number of universities to return.</param>
        public async Task<object> GetUniversities(string q = null, int? country_id = null, int? city_id = null, int? offset = null, int? count = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (q != null)
                parameters.Add("q", q);
            if (country_id != null)
                parameters.Add("country_id", country_id.ToString());
            if (city_id != null)
                parameters.Add("city_id", city_id.ToString());
            if (offset != null)
                parameters.Add("offset", offset.ToString());
            if (count != null)
                parameters.Add("count", count.ToString());

            return await _vkontakte.GetAsync<object>("database.getUniversities", parameters);
        }

        /// <summary>
        /// Returns a list of schools.
        /// Docs: <see href="https://vk.com/dev/database.getSchools">database.getSchools</see>
        /// </summary>
        /// <param name="q">Search query.</param>
        /// <param name="city_id">City ID.</param>
        /// <param name="offset">Offset needed to return a specific subset of schools.</param>
        /// <param name="count">Number of schools to return.</param>
        public async Task<object> GetSchools(string q = null, int? city_id = null, int? offset = null, int? count = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (q != null)
                parameters.Add("q", q);
            if (city_id != null)
                parameters.Add("city_id", city_id.ToString());
            if (offset != null)
                parameters.Add("offset", offset.ToString());
            if (count != null)
                parameters.Add("count", count.ToString());

            return await _vkontakte.GetAsync<object>("database.getSchools", parameters);
        }

        /// <summary>
        /// Returns a list of school classes specified for the country.
        /// Docs: <see href="https://vk.com/dev/database.getSchoolClasses">database.getSchoolClasses</see>
        /// </summary>
        /// <param name="country_id">Country ID.</param>
        public async Task<object> GetSchoolClasses(int? country_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (country_id != null)
                parameters.Add("country_id", country_id.ToString());

            return await _vkontakte.GetAsync<object>("database.getSchoolClasses", parameters);
        }

        /// <summary>
        /// Returns a list of faculties (i.e., university departments).;
        /// Docs: <see href="https://vk.com/dev/database.getFaculties">database.getFaculties</see>
        /// </summary>
        /// <param name="university_id">University ID.</param>
        /// <param name="offset">Offset needed to return a specific subset of faculties.</param>
        /// <param name="count">Number of faculties to return.</param>
        public async Task<object> GetFaculties(int? university_id = null, int? offset = null, int? count = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (university_id != null)
                parameters.Add("university_id", university_id.ToString());
            if (offset != null)
                parameters.Add("offset", offset.ToString());
            if (count != null)
                parameters.Add("count", count.ToString());

            return await _vkontakte.GetAsync<object>("database.getFaculties", parameters);
        }

        /// <summary>
        /// Returns list of chairs on a specified faculty.
        /// Docs: <see href="https://vk.com/dev/database.getChairs">database.getChairs</see>
        /// </summary>
        /// <param name="faculty_id">id of the faculty to get chairs from</param>
        /// <param name="offset">offset required to get a certain subset of chairs</param>
        /// <param name="count">amount of chairs to get</param>
        public async Task<object> GetChairs(int? faculty_id = null, int? offset = null, int? count = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (faculty_id != null)
                parameters.Add("faculty_id", faculty_id.ToString());
            if (offset != null)
                parameters.Add("offset", offset.ToString());
            if (count != null)
                parameters.Add("count", count.ToString());

            return await _vkontakte.GetAsync<object>("database.getChairs", parameters);
        }

    }
}
