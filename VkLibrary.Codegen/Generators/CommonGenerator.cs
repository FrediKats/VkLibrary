using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace VkLibrary.Codegen.Generators
{
    public class CommonGenerator
    {
        public static CompilationUnitSyntax CreateWithUsingAndNamespace(string namespaceIdentifier,
            MemberDeclarationSyntax member)
        {
            UsingDirectiveSyntax[] usingList =
            {
                UsingDirective(IdentifierName("Newtonsoft.Json")),
                UsingDirective(IdentifierName("System")),
                UsingDirective(IdentifierName("System.Runtime.Serialization"))
            };

            return
                CompilationUnit()
                    .AddUsings(usingList)
                    .WithMembers(
                        SingletonList<MemberDeclarationSyntax>(
                            NamespaceDeclaration(IdentifierName(namespaceIdentifier))
                                .AddMembers(member)));
        }

        public static SyntaxTriviaList AddComment(string commentText)
        {
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
                                                                DocumentationCommentExterior("    ///")),
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
                                                        DocumentationCommentExterior("    ///")),
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