using System.Runtime.Serialization;

namespace VkLibrary.Core.Objects
{
    ///<summary>
    /// Information whether community is closed
    ///</summary>
    public enum GroupsGroupIsClosed
    {
        [EnumMember(Value = "open")]
        Open = 0,
        [EnumMember(Value = "closed")]
        Closed = 1,
        [EnumMember(Value = "private")]
        Private = 2
    }
}