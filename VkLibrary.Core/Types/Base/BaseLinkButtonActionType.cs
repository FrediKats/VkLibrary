using System.Runtime.Serialization;

namespace VkApi.Wrapper.Types.Base
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