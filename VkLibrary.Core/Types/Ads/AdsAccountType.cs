using System.Runtime.Serialization;

namespace VkLibrary.Core.Objects
{
    ///<summary>
    /// Account type
    ///</summary>
    public enum AdsAccountType
    {
        [EnumMember(Value = "general")]
        General,
        [EnumMember(Value = "agency")]
        Agency
    }
}