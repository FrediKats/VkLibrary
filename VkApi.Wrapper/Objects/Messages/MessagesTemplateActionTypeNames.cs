using System.Runtime.Serialization;

namespace VkApi.Wrapper.Objects
{
    ///<summary>
    /// Template action type names
    ///</summary>
    public enum MessagesTemplateActionTypeNames
    {
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "start")]
        Start,
        [EnumMember(Value = "location")]
        Location,
        [EnumMember(Value = "vkpay")]
        Vkpay,
        [EnumMember(Value = "open_app")]
        OpenApp,
        [EnumMember(Value = "open_photo")]
        OpenPhoto,
        [EnumMember(Value = "open_link")]
        OpenLink
    }
}