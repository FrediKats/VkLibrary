using System.Runtime.Serialization;

namespace VkLibrary.Core.Objects
{
    ///<summary>
    /// Campaign type
    ///</summary>
    public enum AdsCampaignType
    {
        [EnumMember(Value = "normal")]
        Normal,
        [EnumMember(Value = "vk_apps_managed")]
        VkAppsManaged,
        [EnumMember(Value = "mobile_apps")]
        MobileApps,
        [EnumMember(Value = "promoted_posts")]
        PromotedPosts
    }
}