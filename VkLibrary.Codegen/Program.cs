using VkLibrary.Codegen.Generators;

namespace VkLibrary.Codegen
{
    class Program
    {
        static void Main()
        {
            string outputPath = "GeneratedModels";
            FileGenerator.Process(outputPath);
        }
    }
}
