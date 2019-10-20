using System.Runtime.Serialization;

namespace VkLibrary.Core.Objects
{
    ///<summary>
    /// Information whether the item is available
    ///</summary>
    public enum MarketMarketItemAvailability
    {
        [EnumMember(Value = "available")]
        Available = 0,
        [EnumMember(Value = "removed")]
        Removed = 1,
        [EnumMember(Value = "unavailable")]
        Unavailable = 2
    }
}