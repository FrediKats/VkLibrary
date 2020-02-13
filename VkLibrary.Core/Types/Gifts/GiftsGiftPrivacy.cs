using System.Runtime.Serialization;

namespace VkApi.Wrapper.Types.Gifts
{
    ///<summary>
    /// Gift privacy
    ///</summary>
    public enum GiftsGiftPrivacy
    {
        [EnumMember(Value = "name and message for all")]
        NameAndMessageForAll = 0,
        [EnumMember(Value = "name for all")]
        NameForAll = 1,
        [EnumMember(Value = "name and message for recipient only")]
        NameAndMessageForRecipientOnly = 2
    }
}