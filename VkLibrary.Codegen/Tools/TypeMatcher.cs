using System.Linq;
using Newtonsoft.Json.Linq;
using VkLibrary.Codegen.Types.TitleCase;

namespace VkLibrary.Codegen.Tools
{
    public static class TypeMatcher
    {
        public static ICustomCaseTitle MatchDefaultType(JToken body)
        {
            return MatchDefaultType(body["$ref"].ToString().Split('/').Last());
        }

        public static ICustomCaseTitle MatchDefaultType(string type)
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