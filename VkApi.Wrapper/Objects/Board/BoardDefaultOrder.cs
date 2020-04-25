using System.Runtime.Serialization;

namespace VkApi.Wrapper.Objects
{
    ///<summary>
    /// Sort type
    ///</summary>
    public enum BoardDefaultOrder
    {
        [EnumMember(Value = "desc_updated")]
        DescUpdated = 1,
        [EnumMember(Value = "desc_created")]
        DescCreated = 2,
        [EnumMember(Value = "asc_updated")]
        AscUpdated = -1,
        [EnumMember(Value = "asc_created")]
        AscCreated = -2
    }
}