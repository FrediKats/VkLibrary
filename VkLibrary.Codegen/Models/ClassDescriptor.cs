using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using VkLibrary.Codegen.Types;
using VkLibrary.Codegen.Types.TitleCase;

namespace VkLibrary.Codegen.Models
{
    public class ClassDescriptor
    {
        public const string ClassPropertiesField = "properties";

        public ClassDescriptor(JsonSchemaItem item)
        {
            if (item.ObjectType != JsonSchemaItemType.Class)
                throw new ArgumentException(item.ObjectType.ToString());

            Title = CamelCaseTitle.Of(item.Title);

            PropertyDescriptors =
                JsonConvert
                    .DeserializeObject<Dictionary<string, JObject>>(item.Body[ClassPropertiesField].ToString())
                    .Select(p => PropertyDescriptor.Create(p.Key, p.Value))
                    .ToList();
        }

        public ICustomCaseTitle Title { get; set; }
        public List<PropertyDescriptor> PropertyDescriptors { get; set; }

        public override string ToString()
        {
            return $"[title = {Title}, properties = \n\t{string.Join("\n\t", PropertyDescriptors)}]";
        }
    }
}