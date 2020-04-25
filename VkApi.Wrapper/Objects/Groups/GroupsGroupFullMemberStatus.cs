using System.Runtime.Serialization;

namespace VkApi.Wrapper.Objects
{
    public enum GroupsGroupFullMemberStatus
    {
        [EnumMember(Value = "not a member")]
        NotAMember = 0,
        [EnumMember(Value = "member")]
        Member = 1,
        [EnumMember(Value = "not sure")]
        NotSure = 2,
        [EnumMember(Value = "declined")]
        Declined = 3,
        [EnumMember(Value = "has sent a request")]
        HasSentARequest = 4,
        [EnumMember(Value = "invited")]
        Invited = 5
    }
}