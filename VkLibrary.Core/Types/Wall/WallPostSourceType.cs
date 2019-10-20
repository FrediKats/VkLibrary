using System.Runtime.Serialization;

namespace VkLibrary.Core.Objects
{
    ///<summary>
    /// Type of post source
    ///</summary>
    public enum WallPostSourceType
    {
        [EnumMember(Value = "vk")]
        Vk,
        [EnumMember(Value = "widget")]
        Widget,
        [EnumMember(Value = "api")]
        Api,
        [EnumMember(Value = "rss")]
        Rss,
        [EnumMember(Value = "sms")]
        Sms
    }
}