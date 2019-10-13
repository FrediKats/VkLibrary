using System;
using System.Collections.Generic;
using System.Linq;
using VkLibrary.Codegen.Types;
using VkLibrary.Codegen.Types.TitleCase;

namespace VkLibrary.Codegen.Models
{
    public class EnumDescriptor
    {
        public const string EnumField = "enum";
        public const string EnumNamesField = "enumNames";

        public EnumDescriptor(JsonSchemaItem item)
        {
            if (item.ObjectType != JsonSchemaItemType.Enum)
                throw new ArgumentException(item.ObjectType.ToString());

            Title = CamelCaseTitle.Of(item.Title);


            //TODO: bug with groups_group_subject
            if (item.Body.Value<string>("type") == "integer")
                InitAsInt(item);
            else
                InitAsString(item);
        }

        public CamelCaseTitle Title { get; }
        public List<EnumValueDescriptor> Values { get; set; }

        private void InitAsInt(JsonSchemaItem item)
        {
            var values = item.Body[EnumField].ToObject<List<int>>();
            var aliases = item.Body[EnumNamesField].ToObject<List<string>>();

            Values =
                values
                    .Zip(aliases, (value, alias) => new EnumValueDescriptor(CamelCaseTitle.Of(alias), value))
                    .ToList();
        }

        private void InitAsString(JsonSchemaItem item)
        {
            var values = item.Body[EnumField].ToObject<List<string>>();

            if (!item.Body.ContainsKey(EnumNamesField))
            {
                Values = values
                    .Select(v => new EnumValueDescriptor(CamelCaseTitle.Of(v)))
                    .ToList();
            }
            else
            {
                var description = item.Body[EnumNamesField].ToObject<List<string>>();

                Values = values
                    .Zip(description, (value, d) => new EnumValueDescriptor(CamelCaseTitle.Of(value), d))
                    .ToList();
            }
        }

        public override string ToString()
        {
            return $"[enum {Title}, values = \n\t{string.Join("\n\t", Values)}]";
        }
    }
}