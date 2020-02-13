using System.Runtime.Serialization;

namespace VkApi.Wrapper.Types.Groups
{
    public enum GroupsGroupMarketCurrency
    {
        [EnumMember(Value = "russian rubles")]
        RussianRubles = 643,
        [EnumMember(Value = "ukrainian hryvnia")]
        UkrainianHryvnia = 980,
        [EnumMember(Value = "kazakh tenge")]
        KazakhTenge = 398,
        [EnumMember(Value = "euro")]
        Euro = 978,
        [EnumMember(Value = "us dollars")]
        UsDollars = 840
    }
}