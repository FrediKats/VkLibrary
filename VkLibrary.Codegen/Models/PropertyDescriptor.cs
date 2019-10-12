using System.Linq;
using Newtonsoft.Json.Linq;
using VkLibrary.Codegen.Tools;
using VkLibrary.Codegen.Types.TitleCase;

namespace VkLibrary.Codegen.Models
{
    public class PropertyDescriptor
    {
        public ICustomCaseTitle Title { get; set; }
        public ICustomCaseTitle Type { get; set; }
        public string Description { get; set; }

        public static PropertyDescriptor Create(string key, JToken body)
        {
            //TODO: check default type like base_bool
            JToken type = body["type"];
            if (type == null)
            {
                Log.Instance.Message($"Type not defined: key - {key}, ref - {body["$ref"].ToLogString()}");
                return new PropertyDescriptor
                {
                    Title = CamelCaseTitle.Of(key),
                    Type = CamelCaseTitle.Of(body["$ref"].ToString().Split('/').Last()),
                    Description = body.Value<string>("description")
                };
            }

            if (type.Type == JTokenType.Array)
            {
                Log.Instance.Message($"Type composition: key - {key}, type - {body["type"].ToLogString()}");
                return new PropertyDescriptor
                {
                    Title = CamelCaseTitle.Of(key),
                    Type = UndefinedCaseTitle.Of(body["type"]?.ToString()),
                    Description = body.Value<string>("description")
                };
            }

            return new PropertyDescriptor
            {
                Title = CamelCaseTitle.Of(key),
                Type = CamelCaseTitle.Of(body["type"].ToString()),
                Description = body.Value<string>("description")
            };
        }

        public override string ToString()
        {
            return $"[type = {Type}, title = {Title}, desc = {Description}]";
        }
    }
}