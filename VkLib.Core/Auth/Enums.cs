using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkLib.Auth
{
    [Flags]
    public enum ScopeSettings
    {
        CanNotify = 1,

        CanAccessFriends = 2,

        CanAccessPhotos = 4,

        CanAccessAudios = 8,

        CanAccessVideos = 16,

        CanAccessWiki = 128,

        CanAddAppLinkToUserMenu = 256,

        CanAccessStatus = 1024,

        CanAccessNotes = 2048,

        CanAccessMessages = 4096,

        CanAccessWall = 8192,

        CanAccessAdsCabinet = 32768,

        CanAccessDocs = 131072,

        CanAccessGroups = 262144,

        IamTheGod = 140492191,
    }

    /// <summary>
    /// Authorization block display type.
    /// </summary>
    public enum AuthDisplayType
    {
        /// <summary>
        /// Desktop pbrowser page.
        /// </summary>
        Page,

        /// <summary>
        /// Popup view.
        /// </summary>
        Popup,

        /// <summary>
        /// Mobile view. (Preffered for modile devices)
        /// </summary>
        Mobile
    }
}
