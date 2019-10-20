using System.Runtime.Serialization;

namespace VkLibrary.Core.Objects
{
    public enum UsersUserRelation
    {
        [EnumMember(Value = "not specified")]
        NotSpecified = 0,
        [EnumMember(Value = "single")]
        Single = 1,
        [EnumMember(Value = "in a relationship")]
        InARelationship = 2,
        [EnumMember(Value = "engaged")]
        Engaged = 3,
        [EnumMember(Value = "married")]
        Married = 4,
        [EnumMember(Value = "complicated")]
        Complicated = 5,
        [EnumMember(Value = "actively searching")]
        ActivelySearching = 6,
        [EnumMember(Value = "in love")]
        InLove = 7,
        [EnumMember(Value = "in a civil union")]
        InACivilUnion = 8
    }
}