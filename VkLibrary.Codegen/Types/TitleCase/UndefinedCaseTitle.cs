namespace VkLibrary.Codegen.Types.TitleCase
{
    public class UndefinedCaseTitle : ICustomCaseTitle
    {
        public UndefinedCaseTitle(string value)
        {
            OriginalValue = value;
            SharpValue = value;
        }

        public UndefinedCaseTitle(string originalValue, string value)
        {
            OriginalValue = originalValue;
            SharpValue = value;
        }

        public string OriginalValue { get; }
        public string SharpValue { get; }

        public string ToSharpString() => SharpValue;
        public string ToOriginalString() => OriginalValue;

        public static UndefinedCaseTitle Of(string value)
        {
            return new UndefinedCaseTitle(value);
        }

        public static UndefinedCaseTitle Of(string originalValue, string value)
        {
            return new UndefinedCaseTitle(originalValue, value);
        }

        public override string ToString()
        {
            return SharpValue;
        }
    }
}