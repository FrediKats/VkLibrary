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

            ICustomCaseTitle type = TypeParser.ParseType(body);
            return new PropertyDescriptor
            {
                Title = CamelCaseTitle.Of(key),
                Type = type,
                Description = body.Value<string>("description")
            };
        }

        public override string ToString()
        {
            return $"[type = {Type}, title = {Title}, desc = {Description}]";
        }
    }
}