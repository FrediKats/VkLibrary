using System.Runtime.Serialization;

namespace VkApi.Wrapper.Objects
{
    public enum NewsfeedItemWallpostFeedbackType
    {
        [EnumMember(Value = "buttons")]
        Buttons,
        [EnumMember(Value = "stars")]
        Stars
    }
}