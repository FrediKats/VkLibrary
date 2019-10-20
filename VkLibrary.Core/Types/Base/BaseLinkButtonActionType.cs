using System.Runtime.Serialization;

namespace VkLibrary.Core.Objects
{
    ///<summary>
    /// Action type
    ///</summary>
    public enum BaseLinkButtonActionType
    {
        ///<summary>
        /// open_url
        ///</summary>
        [EnumMember(Value = "open_url")]
        OpenUrl
    }
}