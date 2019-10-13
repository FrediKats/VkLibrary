using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using VkLibrary.Codegen.Models;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace VkLibrary.Codegen.Generators
{
    public class EnumGenerator
    {
        public static CompilationUnitSyntax Generate(EnumDescriptor enumDescriptor)
        {
            return CommonGenerator
                .CreateUsingAndNamespace()
                .WithMembers(SingletonList(GenerateMainModel(enumDescriptor)))
                .NormalizeWhitespace();
        }

        private static MemberDeclarationSyntax GenerateMainModel(EnumDescriptor enumDescriptor)
        {
            //TODO: add description
            return EnumDeclaration(enumDescriptor.Title.ToSharpString())
                .WithModifiers(
                    TokenList(
                        Token(
                            CommonGenerator.AddComment(enumDescriptor.Title.ToOriginalString()),
                            SyntaxKind.PublicKeyword,
                            TriviaList())))
                .WithMembers(
                    SeparatedList(enumDescriptor.Values.Select(GenerateEnumValue)));
        }

        private static EnumMemberDeclarationSyntax GenerateEnumValue(EnumValueDescriptor enumValue)
        {
            EnumMemberDeclarationSyntax res = EnumMemberDeclaration(
                    Identifier(enumValue.Name.ToSharpString()))
                .WithAttributeLists(
                    SingletonList(
                        AttributeList(
                                SingletonSeparatedList(
                                    Attribute(
                                            IdentifierName("EnumMember"))
                                        .WithArgumentList(
                                            AttributeArgumentList(
                                                SingletonSeparatedList(
                                                    AttributeArgument(
                                                            LiteralExpression(
                                                                SyntaxKind.StringLiteralExpression,
                                                                Literal(enumValue.Name.ToOriginalString())))
                                                        .WithNameEquals(
                                                            NameEquals(
                                                                IdentifierName("Value"))))))))
                            .WithOpenBracketToken(
                                Token(
                                    CommonGenerator.AddComment(enumValue.Description),
                                    SyntaxKind.OpenBracketToken,
                                    TriviaList()))));

            if (enumValue.Value.HasValue)
                res = res
                    .WithEqualsValue(
                        EqualsValueClause(
                            LiteralExpression(
                                SyntaxKind.NumericLiteralExpression,
                                Literal(enumValue.Value.Value))));

            return res;
        }
    }
}