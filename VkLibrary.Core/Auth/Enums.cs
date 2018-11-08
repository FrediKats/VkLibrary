using System;

namespace VkLibrary.Core.Auth
{
    /// <summary>
    /// VKontakte access scope settings.
    /// </summary>
    [Flags]
    public enum ScopeSettings
    {
        /// <summary>
        /// App can notify user.
        /// </summary>
        CanNotify = 1,

        /// <summary>
        /// App can access friends.
        /// </summary>
        CanAccessFriends = 2,

        /// <summary>
        /// App can acccess photos.
        /// </summary>
        CanAccessPhotos = 4,

        /// <summary>
        /// App can access audios.
        /// </summary>
        CanAccessAudios = 8,

        /// <summary>
        /// App can access videos.
        /// </summary>
        CanAccessVideos = 16,

        /// <summary>
        /// App can access wikis.
        /// </summary>
        CanAccessWiki = 128,

        /// <summary>
        /// App can manage left-menu links.
        /// </summary>
        CanAddAppLinkToUserMenu = 256,

        /// <summary>
        /// App can modify status.
        /// </summary>
        CanAccessStatus = 1024,

        /// <summary>
        /// App can modify notes.
        /// </summary>
        CanAccessNotes = 2048,

        /// <summary>
        /// App has access to messages.
        /// </summary>
        CanAccessMessages = 4096,

        /// <summary>
        /// App can access wall.
        /// </summary>
        CanAccessWall = 8192,

        /// <summary>
        /// App can access cabinet/ads.
        /// </summary>
        CanAccessAdsCabinet = 32768,

        /// <summary>
        /// App can access API at any time.
        /// </summary>
        CanAccessOffline = 65536,

        /// <summary>
        /// App can access docs.
        /// </summary>
        CanAccessDocs = 131072,

        /// <summary>
        /// App can access docs.
        /// </summary>
        CanAccessGroups = 262144,

        /// <summary>
        /// Root permissions.
        /// </summary>
        IamTheGod = 140492191
    }

    /// <summary>
    /// Authorization block display type.
    /// </summary>
    public enum AuthDisplayType
    {
        /// <summary>
        /// Desktop browser page.
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