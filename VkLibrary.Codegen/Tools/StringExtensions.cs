namespace VkLibrary.Codegen.Tools
{
    public static class StringExtensions
    {
        public static string ToLogString<T>(this T instance)
        {
            return instance.ToString().Replace('\n', ' ');
        }
    }
}