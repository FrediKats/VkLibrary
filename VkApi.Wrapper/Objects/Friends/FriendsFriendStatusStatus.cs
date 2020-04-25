using System.Runtime.Serialization;

namespace VkApi.Wrapper.Objects
{
    ///<summary>
    /// Friend status with the user
    ///</summary>
    public enum FriendsFriendStatusStatus
    {
        [EnumMember(Value = "not a friend")]
        NotAFriend = 0,
        [EnumMember(Value = "outcoming request")]
        OutcomingRequest = 1,
        [EnumMember(Value = "incoming request")]
        IncomingRequest = 2,
        [EnumMember(Value = "is friend")]
        IsFriend = 3
    }
}