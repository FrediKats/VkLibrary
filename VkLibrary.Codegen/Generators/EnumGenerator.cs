using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using VkLibrary.Codegen.Models;
using VkLibrary.Codegen.Types;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace VkLibrary.Codegen.Generators
{
    public class EnumGenerator
    {
        public static CompilationUnitSyntax Generate(string namespaceIdentifier, EnumDescriptor enumDescriptor, EntityType entityType)
        {
            return CommonGenerator
                .CreateWithUsingAndNamespace(
                    namespaceIdentifier,
                    GenerateMainModel(enumDescriptor),
                    entityType);
        }

        private static MemberDeclarationSyntax GenerateMainModel(EnumDescriptor enumDescriptor)
        {
            EnumMemberDeclarationSyntax[] values = enumDescriptor
                .Values
                .Select(GenerateEnumValue)
                .ToArray();

            return EnumDeclaration(enumDescriptor.Title.ToSharpString())
                .AddModifiers(
                    Token(
                        CommonGenerator.AddComment(enumDescriptor.Description),
                        SyntaxKind.PublicKeyword,
                        TriviaList()))
                .AddMembers(values);
        }

        private static EnumMemberDeclarationSyntax GenerateEnumValue(EnumValueDescriptor enumValue)
        {
            EnumMemberDeclarationSyntax res =
                EnumMemberDeclaration(
                        Identifier(enumValue.Name.ToSharpString()))
                    .AddAttributeLists(
                        AttributeList(
                                SingletonSeparatedList(
                                    Attribute(
                                            IdentifierName("EnumMember"))
                                        .AddArgumentListArguments(
                                            AttributeArgument(
                                                    LiteralExpression(
                                                        SyntaxKind.StringLiteralExpression,
                                                        Literal(enumValue.Name.ToOriginalString())))
                                                .WithNameEquals(
                                                    NameEquals(
                                                        IdentifierName("Value"))))))
                            .WithOpenBracketToken(
                                Token(
                                    CommonGenerator.AddComment(enumValue.Description),
                                    SyntaxKind.OpenBracketToken,
                                    TriviaList())));

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