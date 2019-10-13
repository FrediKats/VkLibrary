using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using VkLibrary.Codegen.Models;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace VkLibrary.Codegen.Generators
{
    public class ClassGenerator
    {
        public static CompilationUnitSyntax Generate(ClassDescriptor classDescriptor)
        {
            return CommonGenerator.CreateUsingAndNamespace()
                .AddMembers(GenerateMainModel(classDescriptor))
                .NormalizeWhitespace();
        }

        private static MemberDeclarationSyntax GenerateMainModel(ClassDescriptor classDescriptor)
        {
            MemberDeclarationSyntax[] properties = classDescriptor
                .PropertyDescriptors
                .Select(GenerateProperties)
                .ToArray();

            //TODO: class description
            return
                ClassDeclaration(classDescriptor.Title.ToSharpString())
                    .AddModifiers(
                            Token(
                                CommonGenerator.AddComment($"API {classDescriptor.Title.ToOriginalString()} object."),
                                SyntaxKind.PublicKeyword,
                                TriviaList()))
                    .WithMembers(
                        List(properties));
        }

        private static MemberDeclarationSyntax GenerateProperties(PropertyDescriptor propertyDescriptor)
        {
            string propertyType = propertyDescriptor.Type.ToString();
            string propertyName = propertyDescriptor.Title.ToSharpString();
            string propertyComment = propertyDescriptor.Description;
            string propertyJsonName = propertyDescriptor.Title.ToOriginalString();

            return PropertyDeclaration(
                    ParseTypeName(propertyType),
                    Identifier(propertyName))
                .AddAttributeLists(
                    AttributeList(
                            SingletonSeparatedList(
                                Attribute(
                                        IdentifierName("JsonProperty"))
                                    .AddArgumentListArguments(
                                        AttributeArgument(
                                            LiteralExpression(
                                                SyntaxKind
                                                    .StringLiteralExpression,
                                                Literal(propertyJsonName))))))
                        .WithOpenBracketToken(
                            Token(
                                CommonGenerator.AddComment(propertyComment),
                                SyntaxKind.OpenBracketToken,
                                TriviaList())))
                .AddModifiers(
                    Token(SyntaxKind.PublicKeyword))
                .WithAccessorList(
                    AccessorList(
                        List(
                            new[]
                            {
                                AccessorDeclaration(
                                        SyntaxKind.GetAccessorDeclaration)
                                    .WithSemicolonToken(
                                        Token(SyntaxKind.SemicolonToken)),
                                AccessorDeclaration(
                                        SyntaxKind.SetAccessorDeclaration)
                                    .WithSemicolonToken(
                                        Token(SyntaxKind.SemicolonToken))
                            })));
        }
    }
}