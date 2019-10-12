namespace VkLibrary.Codegen.Types.TitleCase
{
    public class UndefinedCaseTitle : ICustomCaseTitle
    {
        public UndefinedCaseTitle(string value)
        {
            OriginalValue = value;
        }

        public string OriginalValue { get; }

        public string ToSharpString()
        {
            return OriginalValue;
        }

        public string ToOriginalString()
        {
            return OriginalValue;
        }

        public static UndefinedCaseTitle Of(string value)
        {
            return new UndefinedCaseTitle(value);
        }

        public override string ToString()
        {
            return OriginalValue;
        }
    }
}