using System.Runtime.Serialization;

namespace VkLibrary.Core.Objects
{
    ///<summary>
    /// Object type
    ///</summary>
    public enum UtilsDomainResolvedType
    {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "group")]
        Group,
        [EnumMember(Value = "application")]
        Application,
        [EnumMember(Value = "page")]
        Page
    }
}