using System.Runtime.Serialization;

namespace VkApi.Wrapper.Objects
{
    ///<summary>
    /// Information whether user can start the lead
    ///</summary>
    public enum LeadsCheckedResult
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }
}