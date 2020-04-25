using System.Runtime.Serialization;

namespace VkApi.Wrapper.Objects
{
    ///<summary>
    /// Section title
    ///</summary>
    public enum SearchHintSection
    {
        [EnumMember(Value = "groups")]
        Groups,
        [EnumMember(Value = "events")]
        Events,
        [EnumMember(Value = "publics")]
        Publics,
        [EnumMember(Value = "correspondents")]
        Correspondents,
        [EnumMember(Value = "people")]
        People,
        [EnumMember(Value = "friends")]
        Friends,
        [EnumMember(Value = "mutual_friends")]
        MutualFriends
    }
}