using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkLib.Methods
{
    /// <summary>
    /// Places API section.
    /// </summary>
    public class Places
    {
        private Vkontakte _vkontakte;

        internal Places(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        /// Adds a new location to the location database.
        /// Docs: <see href="https://vk.com/dev/places.add">places.add</see>
        /// </summary>
        /// <param name="type">ID of the location's type (e.g., '1' — Home, '2' — Work). To get location type IDs, use the [vk.com/dev/places.getTypes|places.getTypes] method.</param>
        /// <param name="title">Title of the location.</param>
        /// <param name="latitude">Geographical latitude, in degrees (from '-90' to '90').</param>
        /// <param name="longitude">Geographical longitude, in degrees (from '-180' to '180').</param>
        /// <param name="country">ID of the location's country. To get country IDs, use the [vk.com/dev/database.getCountries|database.getCountries] method.</param>
        /// <param name="city">ID of the location's city. To get city IDs, use the [vk.com/dev/database.getCities|database.getCities] method.</param>
        /// <param name="address">Street address of the location (e.g., '125 Elm Street').</param>
        public async Task<VkLib.Responses.Places.AddResponse> Add(int? type = null, string title = null, uint? latitude = null, uint? longitude = null, int? country = null, int? city = null, string address = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (type != null)
                parameters.Add("type", type.ToApiString());
            if (title != null)
                parameters.Add("title", title);
            if (latitude != null)
                parameters.Add("latitude", latitude.ToApiString());
            if (longitude != null)
                parameters.Add("longitude", longitude.ToApiString());
            if (country != null)
                parameters.Add("country", country.ToApiString());
            if (city != null)
                parameters.Add("city", city.ToApiString());
            if (address != null)
                parameters.Add("address", address);

            return await _vkontakte.GetAsync<VkLib.Responses.Places.AddResponse>("places.add", parameters);
        }

        /// <summary>
        /// Returns information about locations by their IDs.
        /// Docs: <see href="https://vk.com/dev/places.getById">places.getById</see>
        /// </summary>
        /// <param name="places">Location IDs.</param>
        public async Task<IEnumerable<VkLib.Types.Places.PlaceMin>> GetById(IEnumerable<int?> places = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (places != null)
                parameters.Add("places", places.ToApiString());

            return await _vkontakte.GetAsync<IEnumerable<VkLib.Types.Places.PlaceMin>>("places.getById", parameters);
        }

        /// <summary>
        /// Returns a list of locations that match the search criteria.
        /// Docs: <see href="https://vk.com/dev/places.search">places.search</see>
        /// </summary>
        /// <param name="q">Search query string.</param>
        /// <param name="city">City ID.</param>
        /// <param name="latitude">Geographical latitude of the initial search point, in degrees (from '-90' to '90').</param>
        /// <param name="longitude">Geographical longitude of the initial search point, in degrees (from '-180' to '180').</param>
        /// <param name="radius">Radius of the search zone:; '1' — 100 m. (default); '2' — 800 m.; '3' — 6 km.; '4' — 50 km.</param>
        /// <param name="offset">Offset needed to return a specific subset of locations.</param>
        /// <param name="count">Number of locations to return.</param>
        public async Task<ApiItemsResponse<VkLib.Types.Places.PlaceFull>> Search(string q = null, int? city = null, uint? latitude = null, uint? longitude = null, int? radius = null, int? offset = null, int? count = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (q != null)
                parameters.Add("q", q);
            if (city != null)
                parameters.Add("city", city.ToApiString());
            if (latitude != null)
                parameters.Add("latitude", latitude.ToApiString());
            if (longitude != null)
                parameters.Add("longitude", longitude.ToApiString());
            if (radius != null)
                parameters.Add("radius", radius.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<VkLib.Types.Places.PlaceFull>>("places.search", parameters);
        }

        /// <summary>
        /// Checks a user in at the specified location.
        /// Docs: <see href="https://vk.com/dev/places.checkin">places.checkin</see>
        /// </summary>
        /// <param name="place_id">Location ID.</param>
        /// <param name="text">Text of the comment on the check-in (255 characters maximum; line breaks not supported).</param>
        /// <param name="latitude">Geographical latitude of the check-in, in degrees (from '-90' to '90').</param>
        /// <param name="longitude">Geographical longitude of the check-in, in degrees (from '-180' to '180').</param>
        /// <param name="friends_only">'1' — Check-in will be available only for friends.; '0' — Check-in will be available for all users (default).</param>
        /// <param name="services">List of services or websites (e.g., 'twitter', 'facebook') to which the check-in will be exported, if the user has set up the respective option.</param>
        public async Task<VkLib.Responses.Places.CheckinResponse> Checkin(int? place_id = null, string text = null, uint? latitude = null, uint? longitude = null, bool? friends_only = null, IEnumerable<string> services = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (place_id != null)
                parameters.Add("place_id", place_id.ToApiString());
            if (text != null)
                parameters.Add("text", text);
            if (latitude != null)
                parameters.Add("latitude", latitude.ToApiString());
            if (longitude != null)
                parameters.Add("longitude", longitude.ToApiString());
            if (friends_only != null)
                parameters.Add("friends_only", friends_only.ToApiString());
            if (services != null)
                parameters.Add("services", services.ToApiString());

            return await _vkontakte.GetAsync<VkLib.Responses.Places.CheckinResponse>("places.checkin", parameters);
        }

        /// <summary>
        /// Returns a list of user check-ins at locations according to the set parameters.
        /// Docs: <see href="https://vk.com/dev/places.getCheckins">places.getCheckins</see>
        /// </summary>
        /// <param name="latitude">Geographical latitude of the initial search point, in degrees (from '-90' to '90').</param>
        /// <param name="longitude">Geographical longitude of the initial search point, in degrees (from '-180' to '180').</param>
        /// <param name="place">Location ID of check-ins to return. (Ignored if 'latitude' and 'longitude' are specified.)</param>
        /// <param name="user_id"></param>
        /// <param name="offset">Offset needed to return a specific subset of check-ins. (Ignored if 'timestamp' is not null.)</param>
        /// <param name="count">Number of check-ins to return. (Ignored if 'timestamp' is not null.)</param>
        /// <param name="timestamp">Specifies that only those check-ins created after the specified timestamp will be returned.</param>
        /// <param name="friends_only">'1' — to return only check-ins with set geographical coordinates. (Ignored if 'latitude' and 'longitude' are not set.)</param>
        /// <param name="need_places">'1' — to return location information with the check-ins. (Ignored if 'place' is not set.);</param>
        public async Task<ApiItemsResponse<VkLib.Types.Places.Checkin>> GetCheckins(uint? latitude = null, uint? longitude = null, int? place = null, int? user_id = null, int? offset = null, int? count = null, int? timestamp = null, bool? friends_only = null, bool? need_places = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (latitude != null)
                parameters.Add("latitude", latitude.ToApiString());
            if (longitude != null)
                parameters.Add("longitude", longitude.ToApiString());
            if (place != null)
                parameters.Add("place", place.ToApiString());
            if (user_id != null)
                parameters.Add("user_id", user_id.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (timestamp != null)
                parameters.Add("timestamp", timestamp.ToApiString());
            if (friends_only != null)
                parameters.Add("friends_only", friends_only.ToApiString());
            if (need_places != null)
                parameters.Add("need_places", need_places.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<VkLib.Types.Places.Checkin>>("places.getCheckins", parameters);
        }

        /// <summary>
        /// Returns a list of all types of locations.
        /// Docs: <see href="https://vk.com/dev/places.getTypes">places.getTypes</see>
        /// </summary>
        public async Task<IEnumerable<VkLib.Types.Places.Types>> GetTypes()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();


            return await _vkontakte.GetAsync<IEnumerable<VkLib.Types.Places.Types>>("places.getTypes", parameters);
        }

    }
}
