using System.Runtime.Serialization;

namespace VkApi.Wrapper.Types.Groups
{
    ///<summary>
    /// Level of current user's credentials as manager
    ///</summary>
    public enum GroupsGroupXtrInvitedByAdminLevel
    {
        [EnumMember(Value = "moderator")]
        Moderator = 1,
        [EnumMember(Value = "editor")]
        Editor = 2,
        [EnumMember(Value = "administrator")]
        Administrator = 3
    }
}