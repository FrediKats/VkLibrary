using System.Runtime.Serialization;

namespace VkApi.Wrapper.Objects
{
    ///<summary>
    /// Ad atatus
    ///</summary>
    public enum AdsAdStatus
    {
        [EnumMember(Value = "stopped")]
        Stopped = 0,
        [EnumMember(Value = "started")]
        Started = 1,
        [EnumMember(Value = "deleted")]
        Deleted = 2
    }
}