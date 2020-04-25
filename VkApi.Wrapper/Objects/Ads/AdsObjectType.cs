using System.Runtime.Serialization;

namespace VkApi.Wrapper.Objects
{
    ///<summary>
    /// Object type
    ///</summary>
    public enum AdsObjectType
    {
        [EnumMember(Value = "ad")]
        Ad,
        [EnumMember(Value = "campaign")]
        Campaign,
        [EnumMember(Value = "client")]
        Client,
        [EnumMember(Value = "office")]
        Office
    }
}