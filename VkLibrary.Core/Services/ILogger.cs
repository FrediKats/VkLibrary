namespace VkApi.Wrapper.Services
{
    /// <summary>
    /// Logger resonsible for logging every important event happend during VkLibrary.Core lifetime.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Logs information somehow.
        /// </summary>
        /// <param name="o">Object to log.</param>
        void Log(object o);
    }
}