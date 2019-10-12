using VkLibrary.Codegen.Generators;

namespace VkLibrary.Codegen
{
    class Program
    {
        static void Main(string[] args)
        {
            string outputPath = "";
            FileGenerator.Process(outputPath);
        }
    }
}
