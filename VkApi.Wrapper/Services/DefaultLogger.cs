namespace VkApi.Wrapper.Services
{
    /// <summary>
    /// Default logger that outputs info into Debug output.
    /// </summary>
    public class DefaultLogger : ILogger
    {
        /// <summary>
        /// Stringifies passed object and dumps it into log output.
        /// </summary>
        /// <param name="o">Object to stringify and log.</param>
        public void Log(object o)
        {
#if DEBUG
            Debug.WriteLine(o?.ToString());
#endif
        }
    }
}