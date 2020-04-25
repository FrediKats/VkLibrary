using System.Runtime.Serialization;

namespace VkApi.Wrapper.Objects
{
    ///<summary>
    /// Type of online status of group
    ///</summary>
    public enum GroupsOnlineStatusType
    {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "online")]
        Online,
        [EnumMember(Value = "answer_mark")]
        AnswerMark
    }
}