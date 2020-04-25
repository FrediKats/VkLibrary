using System.Runtime.Serialization;

namespace VkApi.Wrapper.Objects
{
    ///<summary>
    /// Current user's role
    ///</summary>
    public enum AdsAccessRole
    {
        [EnumMember(Value = "admin")]
        Admin,
        [EnumMember(Value = "manager")]
        Manager,
        [EnumMember(Value = "reports")]
        Reports
    }
}