using System.Runtime.Serialization;

namespace VkApi.Wrapper.Objects
{
    ///<summary>
    /// Cost type
    ///</summary>
    public enum AdsAdCostType
    {
        [EnumMember(Value = "per clicks")]
        PerClicks = 0,
        [EnumMember(Value = "per impressions")]
        PerImpressions = 1,
        [EnumMember(Value = "per actions")]
        PerActions = 2,
        [EnumMember(Value = "per impressions optimized")]
        PerImpressionsOptimized = 3
    }
}