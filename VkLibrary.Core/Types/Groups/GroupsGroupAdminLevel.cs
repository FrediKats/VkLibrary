using System.Runtime.Serialization;

namespace VkLibrary.Core.Objects
{
    ///<summary>
    /// Level of current user's credentials as manager
    ///</summary>
    public enum GroupsGroupAdminLevel
    {
        [EnumMember(Value = "moderator")]
        Moderator = 1,
        [EnumMember(Value = "editor")]
        Editor = 2,
        [EnumMember(Value = "administrator")]
        Administrator = 3
    }
}