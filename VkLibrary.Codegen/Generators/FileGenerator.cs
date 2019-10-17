using System.Collections.Generic;
using System.IO;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Formatting;
using VkLibrary.Codegen.Models;
using VkLibrary.Codegen.Tools;

namespace VkLibrary.Codegen.Generators
{
    public static class FileGenerator
    {
        public static void Process(string directoryPath)
        {
            if (Directory.Exists(directoryPath))
                Directory.Delete(directoryPath, true);

            var provider = new JsonSchemaProvider();
            GenerateFromObject(provider, $"{directoryPath}/Objects/");
            GenerateFromResponses(provider, $"{directoryPath}/Responses/");
        }

        private static void GenerateFromObject(JsonSchemaProvider provider, string directoryPath)
        {
            List<ClassDescriptor> classes = provider.GetObjectClassDescriptor();
            List<EnumDescriptor> enums = provider.GetObjectEnumDescriptor();

            foreach (ClassDescriptor classDescriptor in classes)
            {
                classDescriptor.MergePropertiesFromBaseClasses(classes);
                CompilationUnitSyntax unit = ClassGenerator.Generate(classDescriptor);
                WriteToFile($"{directoryPath}{classDescriptor.Title.ToSharpString()}.cs", unit);
            }

            foreach (EnumDescriptor enumDescriptor in enums)
            {
                CompilationUnitSyntax unit = EnumGenerator.Generate(enumDescriptor);
                WriteToFile($"{directoryPath}{enumDescriptor.Title.ToSharpString()}.cs", unit);
            }

            provider.GetUndefined().ForEach(i => Log.Instance.Message(i.Body.ToString()));
        }

        private static void GenerateFromResponses(JsonSchemaProvider provider, string directoryPath)
        {
            List<ClassDescriptor> responses = provider.GetResponseClassDescriptors();
            foreach (ClassDescriptor classDescriptor in responses)
            {
                CompilationUnitSyntax unit = ClassGenerator.Generate(classDescriptor);
                WriteToFile($"{directoryPath}{classDescriptor.Title.ToSharpString()}.cs", unit);
            }
            provider.GetUndefined().ForEach(i => Log.Instance.Message(i.Body.ToString()));
        }

        private static void WriteToFile(string path, CompilationUnitSyntax content)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(path));

            using (var workspace = new AdhocWorkspace())
            {
                SyntaxNode formated = Formatter.Format(content, workspace);
                using (var stream = new StreamWriter(File.Open(path, FileMode.OpenOrCreate)))
                {
                    stream.Write(formated.ToString());
                }
            }
        }
    }
}