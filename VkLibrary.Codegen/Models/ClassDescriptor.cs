using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using VkLibrary.Codegen.Tools;
using VkLibrary.Codegen.Types;
using VkLibrary.Codegen.Types.TitleCase;

namespace VkLibrary.Codegen.Models
{
    public class ClassDescriptor
    {
        public const string ClassPropertiesField = "properties";
        public const string AllOfGroupField = "allOf";
        public const string OneOfGroupField = "oneOf";

        public ClassDescriptor(JsonSchemaItem item)
        {
            if (item.ObjectType != JsonSchemaItemType.Class)
                throw new ArgumentException(item.ObjectType.ToString());

            //TODO: use without scope
            (string scope, string camelTitle) = item.Title.SplitWithScope();

            Scope = scope.TitleToCamelCaseStyle();
            Title = CamelCaseTitle.Of(item.Title);
            Description = item.Description;

            JToken propertiesObject;
            if (item.Body[AllOfGroupField] != null)
            {
                propertiesObject = item.Body[AllOfGroupField].FirstOrDefault(t => t[ClassPropertiesField] != null);
                BaseClasses = item.Body[AllOfGroupField]
                    .Where(t => t["$ref"] != null)
                    .Select(TypeParser.ParseType)
                    .ToList();
            }
            else if (item.Body[OneOfGroupField] != null)
            {
                propertiesObject = item.Body[OneOfGroupField].FirstOrDefault(t => t[ClassPropertiesField] != null);
                BaseClasses = item.Body[OneOfGroupField]
                    .Where(t => t["$ref"] != null)
                    .Select(TypeParser.ParseType)
                    .ToList();
            }
            else
            {
                propertiesObject = item.Body;
            }

            if (propertiesObject != null)
                PropertyDescriptors =
                    JsonConvert
                        .DeserializeObject<Dictionary<string, JObject>>(propertiesObject[ClassPropertiesField].ToString())
                        .Select(p => PropertyDescriptor.Create(p.Key, p.Value))
                        .ToList();
        }

        public void MergePropertiesFromBaseClasses(List<ClassDescriptor> classes)
        {
            PropertyDescriptors
                .AddRange(classes
                    .Where(c => c.Title.ToOriginalString() == Title.ToOriginalString() && c != this)
                    .SelectMany(c => c.PropertyDescriptors));
        }

        public string Scope { get; }
        public ICustomCaseTitle Title { get; }
        public string Description { get; }
        public List<ICustomCaseTitle> BaseClasses { get; } = new List<ICustomCaseTitle>();
        public List<PropertyDescriptor> PropertyDescriptors { get; } = new List<PropertyDescriptor>();

        public override string ToString()
        {
            return $"[title = {Title}, properties = \n\t{string.Join("\n\t", PropertyDescriptors)}]";
        }
    }
}