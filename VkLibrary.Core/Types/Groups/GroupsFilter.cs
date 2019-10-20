using System.Runtime.Serialization;

namespace VkLibrary.Core.Objects
{
    public enum GroupsFilter
    {
        [EnumMember(Value = "admin")]
        Admin,
        [EnumMember(Value = "editor")]
        Editor,
        [EnumMember(Value = "moder")]
        Moder,
        [EnumMember(Value = "groups")]
        Groups,
        [EnumMember(Value = "publics")]
        Publics,
        [EnumMember(Value = "events")]
        Events,
        [EnumMember(Value = "has_addresses")]
        HasAddresses
    }
}