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
            var provider = new JsonSchemaProvider();

            CheckFolder(directoryPath);
            List<ClassDescriptor> classes = provider.GetClassDescriptor();
            List<EnumDescriptor> enums = provider.GetEnumDescriptor();

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

            provider.GetUndefined()
                .ForEach(i => Log.Instance.Message(i.Body.ToString()));
        }

        private static void WriteToFile(string path, CompilationUnitSyntax content)
        {
            using (var workspace = new AdhocWorkspace())
            {
                SyntaxNode formated = Formatter.Format(content, workspace);
                using (var stream = new StreamWriter(File.Open(path, FileMode.OpenOrCreate)))
                {
                    stream.Write(formated.ToString());
                }
            }
        }

        private static void CheckFolder(string dirPath)
        {
            if (Directory.Exists(dirPath))
                Directory.Delete(dirPath, true);
            Directory.CreateDirectory(dirPath);
        }
    }
}