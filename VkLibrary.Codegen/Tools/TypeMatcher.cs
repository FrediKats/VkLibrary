using VkLibrary.Codegen.Types.TitleCase;

namespace VkLibrary.Codegen.Tools
{
    public static class TypeMatcher
    {
        public static ICustomCaseTitle MathDefaultType(string type)
        {
            string result = type switch
            {
                "base" => "bool",
                "integer" => "int",
                "base_bool_int" => "int",
                //TODO: validate
                "number" => "int",
                "String" => "string",
                _ => type
            };

            if (result != type)
                return UndefinedCaseTitle.Of(result);

            return CamelCaseTitle.Of(result);
        }
    }
}