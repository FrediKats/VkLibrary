using System.Runtime.Serialization;

namespace VkApi.Wrapper.Objects
{
    public enum CallbackGroupJoinType
    {
        [EnumMember(Value = "join")]
        Join,
        [EnumMember(Value = "unsure")]
        Unsure,
        [EnumMember(Value = "accepted")]
        Accepted,
        [EnumMember(Value = "approved")]
        Approved,
        [EnumMember(Value = "request")]
        Request
    }
}