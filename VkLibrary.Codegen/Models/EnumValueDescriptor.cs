using VkLibrary.Codegen.Types.TitleCase;

namespace VkLibrary.Codegen.Models
{
    public class EnumValueDescriptor
    {
        public EnumValueDescriptor(CamelCaseTitle name) : this(name, new int(), string.Empty)
        {
        }

        public EnumValueDescriptor(CamelCaseTitle name, string description) : this(name, new int(), description)
        {
        }

        public EnumValueDescriptor(CamelCaseTitle name, int? value) : this(name, value, string.Empty)
        {
        }


        public EnumValueDescriptor(CamelCaseTitle name, int? value, string description)
        {
            Name = name;
            Value = value;
            Description = description;
        }

        public CamelCaseTitle Name { get; }
        public int? Value { get; }
        public string Description { get; }

        public override string ToString()
        {
            return $"[JsonName = {Name.OriginalValue}]{Name} = {Value} //{Description}";
        }
    }
}