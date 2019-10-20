using System.Runtime.Serialization;

namespace VkLibrary.Core.Objects
{
    ///<summary>
    /// Returns 1 if request has been processed successfully
    ///</summary>
    public enum BaseOkResponse
    {
        [EnumMember(Value = "ok")]
        Ok = 1
    }
}