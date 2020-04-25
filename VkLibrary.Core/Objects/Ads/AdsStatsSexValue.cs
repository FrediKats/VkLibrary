using System.Runtime.Serialization;

namespace VkApi.Wrapper.Objects
{
    ///<summary>
    /// Sex
    ///</summary>
    public enum AdsStatsSexValue
    {
        ///<summary>
        /// female
        ///</summary>
        [EnumMember(Value = "f")]
        F,
        ///<summary>
        /// male
        ///</summary>
        [EnumMember(Value = "m")]
        M
    }
}