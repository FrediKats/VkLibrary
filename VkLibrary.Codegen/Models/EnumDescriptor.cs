using System;
using System.Collections.Generic;
using System.Linq;
using VkLibrary.Codegen.Tools;
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

            //TODO: use without scope
            (string scope, string camelTitle) = item.Title.SplitWithScope();

            Scope = scope.TitleToCamelCaseStyle();
            Title = CamelCaseTitle.Of(item.Title);
            Description = item.Description;

            //Known problems: bug with groups_group_subject
            if (item.Title == "groups_group_subject")
            {
                Log.Instance.Message("Vk still have wrong type for groups_group_subject");
                InitAsInt(item);
            }
            if (item.Body.Value<string>("type") == "integer")
                InitAsInt(item);
            else
                InitAsString(item);
        }

        public string Scope { get; }
        public CamelCaseTitle Title { get; }
        public string Description { get; }
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

            if (item.Body[EnumNamesField] == null)
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