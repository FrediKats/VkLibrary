using System.Runtime.Serialization;

namespace VkLibrary.Core.Objects
{
    ///<summary>
    /// Campaign status
    ///</summary>
    public enum AdsCampaignStatus
    {
        [EnumMember(Value = "stopped")]
        Stopped = 0,
        [EnumMember(Value = "started")]
        Started = 1,
        [EnumMember(Value = "deleted")]
        Deleted = 2
    }
}