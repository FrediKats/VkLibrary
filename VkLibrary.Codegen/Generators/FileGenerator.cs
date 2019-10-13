using System.Collections.Generic;
using System.IO;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Formatting;
using VkLibrary.Codegen.Models;

namespace VkLibrary.Codegen.Generators
{
    public static class FileGenerator
    {
        public static void Process(string directoryPath)
        {
            CheckFolder(directoryPath);

            List<ClassDescriptor> classes = JsonSchemaProvider.GetClassDescriptor();
            foreach (ClassDescriptor classDescriptor in classes)
            {
                CompilationUnitSyntax unit = ClassGenerator.Generate(classDescriptor);
                WriteToFile($"{directoryPath}{classDescriptor.Title.ToSharpString()}.cs", unit);
            }
            List<EnumDescriptor> enums = JsonSchemaProvider.GetEnumDescriptor();
            foreach (EnumDescriptor enumDescriptor in enums)
            {
                CompilationUnitSyntax unit = EnumGenerator.Generate(enumDescriptor);
                WriteToFile($"{directoryPath}{enumDescriptor.Title.ToSharpString()}.cs", unit);
            }
        }

        private static void WriteToFile(string path, CompilationUnitSyntax content)
        {
            using var workspace = new AdhocWorkspace();
            using var stream = new StreamWriter(File.Open(path, FileMode.OpenOrCreate));

            stream.Write(Formatter.Format(content, workspace).ToString());
        }

        private static void CheckFolder(string dirPath)
        {
            if (Directory.Exists(dirPath))
                Directory.Delete(dirPath, true);
            Directory.CreateDirectory(dirPath);
        }
    }
}