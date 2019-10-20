using System.Runtime.Serialization;

namespace VkLibrary.Core.Objects
{
    ///<summary>
    /// Object type
    ///</summary>
    public enum SearchHintType
    {
        [EnumMember(Value = "group")]
        Group,
        [EnumMember(Value = "profile")]
        Profile,
        [EnumMember(Value = "vk_app")]
        VkApp
    }
}