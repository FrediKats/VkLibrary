using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace VkLibrary.Codegen.Generators
{
    public class CommonGenerator
    {
        public static CompilationUnitSyntax GenerateWithUsing(
            string namespaceIdentifier,
            params UsingDirectiveSyntax[] usingList)
        {
            return
                CompilationUnit()
                    .WithUsings(
                        List(usingList))
                    .WithMembers(
                        SingletonList<MemberDeclarationSyntax>(
                            NamespaceDeclaration(IdentifierName(namespaceIdentifier))));
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
                                XmlText()
                                    .WithTextTokens(
                                        TokenList(
                                            XmlTextLiteral(
                                                TriviaList(
                                                    DocumentationCommentExterior("///")),
                                                " ",
                                                " ",
                                                TriviaList()))),
                                XmlExampleElement(
                                        SingletonList<XmlNodeSyntax>(
                                            XmlText()
                                                .WithTextTokens(
                                                    TokenList(XmlTextNewLine(
                                                        TriviaList(),
                                                        "\n",
                                                        "\n",
                                                        TriviaList()), XmlTextLiteral(
                                                        TriviaList(
                                                            DocumentationCommentExterior(
                                                                "///")),
                                                        $" {commentText}",
                                                        $" {commentText}",
                                                        TriviaList()), XmlTextNewLine(
                                                        TriviaList(),
                                                        "\n",
                                                        "\n",
                                                        TriviaList()), XmlTextLiteral(
                                                        TriviaList(
                                                            DocumentationCommentExterior(
                                                                "///")),
                                                        " ",
                                                        " ",
                                                        TriviaList())))))
                                    .WithStartTag(
                                        XmlElementStartTag(
                                            XmlName(
                                                Identifier("summary"))))
                                    .WithEndTag(
                                        XmlElementEndTag(
                                            XmlName(
                                                Identifier("summary")))),
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