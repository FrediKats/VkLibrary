using System;

namespace VkApi.Wrapper.LongPolling.User
{
    /// <summary>
    /// Each dialog has flags, which are values received by summing up 
    /// any of the following parameters. Flags are set only for community dialogs.
    /// </summary>
    [Flags]
    public enum DialogFlags
    {
        /// <summary>
        /// Important dialog.
        /// </summary>
        Important = 1,

        /// <summary>
        /// Dialog with a community reply.
        /// </summary>
        Answered = 2
    }
}
