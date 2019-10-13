using System.Linq;
using Newtonsoft.Json.Linq;
using VkLibrary.Codegen.Types.TitleCase;

namespace VkLibrary.Codegen.Tools
{
    public static class TypeParser
    {
        public static ICustomCaseTitle ParseType(JToken body)
        {
            if (body["type"] == null)
            {
                return MatchDefaultType(GetTypeFromRef(body));
            }

            if (body["type"].Type == JTokenType.Array)
            {
                Log.Instance.Message($"Type composition: {body["type"].ToLogString()}");

                return UndefinedCaseTitle.Of("object");
            }

            if (body["type"].Value<string>() == "array")
            {
                return CamelCaseArrayTitle.Of(ParseType(body["items"]));
            }

            return MatchDefaultType(body.Value<string>("type"));
        }

        private static string GetTypeFromRef(JToken body)
        {
            return body["$ref"]
                .ToString()
                .Split('/')
                .Last();
        }

        private static ICustomCaseTitle MatchDefaultType(string type)
        {
            string result = type switch
            {
                "base" => "bool",
                "integer" => "int",
                "base_bool_int" => "int",
                "number" => "double",
                "String" => "string",
                _ => type
            };

            if (result != type)
                return UndefinedCaseTitle.Of(result);

            return CamelCaseTitle.Of(result);
        }
    }
}