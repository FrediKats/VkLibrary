namespace VkLibrary.Codegen.Types.TitleCase
{
    public class UndefinedCaseTitle : ICustomCaseTitle
    {
        private readonly string _originalValue;
        private readonly string _sharpValue;

        public UndefinedCaseTitle(string value)
        {
            _originalValue = value;
            _sharpValue = value;
        }

        public UndefinedCaseTitle(string originalValue, string value)
        {
            _originalValue = originalValue;
            _sharpValue = value;
        }

        public string ToSharpString()
        {
            return _sharpValue;
        }

        public string ToOriginalString()
        {
            return _originalValue;
        }

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
            return _sharpValue;
        }
    }
}