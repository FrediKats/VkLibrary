using System;

namespace VkLibrary.Core.LongPolling.Flags
{
    /// <summary>
    /// If mode contains flag 64, then in messages with code 8 (friend is offline), 
    /// extra data $extra will return in the third field. From this you can get 
    /// the platform ID $platform_id = $extra &amp; 0xFF ( = $extra % 256), 
    /// from which the user got online. 
    /// </summary>
    [Flags]
    public enum PlatformFlags
    {
        /// <summary>
        /// Mobile website version or unidentified mobile app.
        /// </summary>
        Mobile = 1,

        /// <summary>
        /// Official app for iPhone.
        /// </summary>
        /// ReSharper disable once InconsistentNaming
        iPhone = 2,

        /// <summary>
        /// Official app for iPad.
        /// </summary>
        /// ReSharper disable once InconsistentNaming
        iPad = 3,

        /// <summary>
        /// Official app for Android.
        /// </summary>
        Android = 4,

        /// <summary>   
        /// Official app for Windows Phone.
        /// </summary>
        /// ReSharper disable once InconsistentNaming
        wPhone = 5,

        /// <summary>
        /// Official app for Windows 8.
        /// </summary>
        Windows = 6,

        /// <summary>
        /// Full website version or unidentified apps.
        /// </summary>
        Web = 7
    }
}
