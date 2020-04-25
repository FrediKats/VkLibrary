using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using VkLibrary.Codegen.Types;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace VkLibrary.Codegen.Generators
{
    public class CommonGenerator
    {
        public const string ResponseNamespace = "VkApi.Wrapper.Responses";
        public const string ObjectNamespace = "VkApi.Wrapper.Objects";
        public const string MethodNamespace = "VkApi.Wrapper.Methods";


        public static CompilationUnitSyntax CreateWithUsingAndNamespace(string namespaceIdentifier,
            MemberDeclarationSyntax member,
            EntityType entityType)
        {
            return
                CompilationUnit()
                    .AddUsings(GetUsingList(entityType))
                    .WithMembers(
                        SingletonList<MemberDeclarationSyntax>(
                            NamespaceDeclaration(IdentifierName(namespaceIdentifier))
                                .AddMembers(member)));
        }

        private static UsingDirectiveSyntax[] GetUsingList(EntityType entityType)
        {
            switch (entityType)
            {
                case EntityType.ObjectClass:
                    return new[]
                    {
                        UsingDirective(IdentifierName("Newtonsoft.Json")),
                        UsingDirective(IdentifierName("System")),
                        UsingDirective(IdentifierName("System.Collections.Generic"))
                    };

                case EntityType.ObjectEnum:
                    return new[]
                    {
                        UsingDirective(IdentifierName("System.Runtime.Serialization"))
                    };

                case EntityType.Response:
                    return new[]
                    {
                        UsingDirective(IdentifierName("Newtonsoft.Json")),
                        UsingDirective(IdentifierName(ObjectNamespace)),
                        UsingDirective(IdentifierName("System")),
                        UsingDirective(IdentifierName("System.Collections.Generic")),
                        UsingDirective(IdentifierName("System.Runtime.Serialization")),
                        UsingDirective(IdentifierName("System.Threading.Tasks"))
                    };

                case EntityType.Method:
                    return new[]
                    {
                        UsingDirective(IdentifierName(ObjectNamespace)),
                        UsingDirective(IdentifierName(ResponseNamespace)),
                        UsingDirective(IdentifierName("System")),
                        UsingDirective(IdentifierName("System.Collections.Generic")),
                        UsingDirective(IdentifierName("System.Threading.Tasks"))
                    };

                default:
                    throw new ArgumentOutOfRangeException(nameof(entityType), entityType, null);
            }
        }

        public static SyntaxTriviaList AddComment(string commentText)
        {
            if (string.IsNullOrEmpty(commentText))
                return new SyntaxTriviaList();

            return TriviaList(
                Trivia(
                    DocumentationCommentTrivia(
                        SyntaxKind.SingleLineDocumentationCommentTrivia,
                        List(
                            new XmlNodeSyntax[]
                            {
                                XmlExampleElement(
                                        SingletonList<XmlNodeSyntax>(
                                            XmlText()
                                                .WithTextTokens(
                                                    TokenList(
                                                        XmlTextNewLine(
                                                            TriviaList(),
                                                            "\n",
                                                            "\n",
                                                            TriviaList()),
                                                        XmlTextLiteral(
                                                            TriviaList(
                                                                DocumentationCommentExterior("///")),
                                                            $" {commentText}",
                                                            $" {commentText}",
                                                            TriviaList()),
                                                        XmlTextNewLine(
                                                            TriviaList(),
                                                            "\n",
                                                            "\n",
                                                            TriviaList())))))
                                    .WithStartTag(
                                        XmlElementStartTag(
                                                XmlName(
                                                    Identifier("summary")))
                                            .WithLessThanToken(
                                                Token(
                                                    TriviaList(
                                                        DocumentationCommentExterior("///")),
                                                    SyntaxKind.LessThanToken,
                                                    TriviaList())))
                                    .WithEndTag(
                                        XmlElementEndTag(
                                                XmlName(
                                                    Identifier("summary")))
                                            .WithLessThanSlashToken(
                                                Token(
                                                    TriviaList(
                                                        DocumentationCommentExterior("///")),
                                                    SyntaxKind.LessThanSlashToken,
                                                    TriviaList()))),
                                XmlText()
                                    .WithTextTokens(
                                        TokenList(
                                            XmlTextNewLine(
                                                TriviaList(),
                                                "\n",
                                                "\n",
                                                TriviaList())))
                            }))));
        }
    }
}