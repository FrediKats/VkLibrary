using System.Collections.Generic;

namespace VkLibrary.Codegen.Tools
{
    public class TypeProvider
    {
        public static readonly TypeProvider Instance = new TypeProvider();

        public Dictionary<string, string> Mapper { get; } = new Dictionary<string, string>();

        public void Register(string alias, string originalType)
        {
            Mapper[alias] = originalType;
        }

        public string Resolve(string alias)
        {
            if (!Mapper.ContainsKey(alias))
                return alias;

            string type = Mapper[alias];
            Log.Instance.Message($"Replace [{alias}] with [{type}]");
            return type;
        }
    }
}