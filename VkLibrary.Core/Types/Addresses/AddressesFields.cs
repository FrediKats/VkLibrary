using System.Runtime.Serialization;

namespace VkApi.Wrapper.Types.Addresses
{
    public enum AddressesFields
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "title")]
        Title,
        [EnumMember(Value = "address")]
        Address,
        [EnumMember(Value = "additional_address")]
        AdditionalAddress,
        [EnumMember(Value = "country_id")]
        CountryId,
        [EnumMember(Value = "city_id")]
        CityId,
        [EnumMember(Value = "metro_station_id")]
        MetroStationId,
        [EnumMember(Value = "latitude")]
        Latitude,
        [EnumMember(Value = "longitude")]
        Longitude,
        [EnumMember(Value = "distance")]
        Distance,
        [EnumMember(Value = "work_info_status")]
        WorkInfoStatus,
        [EnumMember(Value = "timetable")]
        Timetable,
        [EnumMember(Value = "phone")]
        Phone,
        [EnumMember(Value = "time_offset")]
        TimeOffset
    }
}