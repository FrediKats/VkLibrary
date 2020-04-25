using System.Runtime.Serialization;

namespace VkApi.Wrapper.Objects
{
    public enum PagesPrivacySettings
    {
        [EnumMember(Value = "community managers only")]
        CommunityManagersOnly = 0,
        [EnumMember(Value = "community members only")]
        CommunityMembersOnly = 1,
        [EnumMember(Value = "everyone")]
        Everyone = 2
    }
}