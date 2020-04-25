using System.Runtime.Serialization;

namespace VkApi.Wrapper.Objects
{
    public enum StoriesUploadLinkText
    {
        [EnumMember(Value = "to_store")]
        ToStore,
        [EnumMember(Value = "vote")]
        Vote,
        [EnumMember(Value = "more")]
        More,
        [EnumMember(Value = "book")]
        Book,
        [EnumMember(Value = "order")]
        Order,
        [EnumMember(Value = "enroll")]
        Enroll,
        [EnumMember(Value = "fill")]
        Fill,
        [EnumMember(Value = "signup")]
        Signup,
        [EnumMember(Value = "buy")]
        Buy,
        [EnumMember(Value = "ticket")]
        Ticket,
        [EnumMember(Value = "write")]
        Write,
        [EnumMember(Value = "open")]
        Open,
        [EnumMember(Value = "learn_more")]
        LearnMore,
        [EnumMember(Value = "view")]
        View,
        [EnumMember(Value = "go_to")]
        GoTo,
        [EnumMember(Value = "contact")]
        Contact,
        [EnumMember(Value = "watch")]
        Watch,
        [EnumMember(Value = "play")]
        Play,
        [EnumMember(Value = "install")]
        Install,
        [EnumMember(Value = "read")]
        Read,
        [EnumMember(Value = "calendar")]
        Calendar
    }
}