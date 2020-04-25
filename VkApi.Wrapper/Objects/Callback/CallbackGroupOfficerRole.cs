using System.Runtime.Serialization;

namespace VkApi.Wrapper.Objects
{
    public enum CallbackGroupOfficerRole
    {
        [EnumMember(Value = "none")]
        None = 0,
        [EnumMember(Value = "moderator")]
        Moderator = 1,
        [EnumMember(Value = "editor")]
        Editor = 2,
        [EnumMember(Value = "administrator")]
        Administrator = 3
    }
}