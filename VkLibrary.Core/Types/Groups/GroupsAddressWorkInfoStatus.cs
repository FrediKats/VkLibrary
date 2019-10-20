using System.Runtime.Serialization;

namespace VkLibrary.Core.Objects
{
    ///<summary>
    /// Status of information about timetable
    ///</summary>
    public enum GroupsAddressWorkInfoStatus
    {
        [EnumMember(Value = "no_information")]
        NoInformation,
        [EnumMember(Value = "temporarily_closed")]
        TemporarilyClosed,
        [EnumMember(Value = "always_opened")]
        AlwaysOpened,
        [EnumMember(Value = "timetable")]
        Timetable,
        [EnumMember(Value = "forever_closed")]
        ForeverClosed
    }
}