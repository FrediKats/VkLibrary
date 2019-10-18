using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using VkLibrary.Codegen.Models;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace VkLibrary.Codegen.Generators
{
    public class MethodGenerator
    {
        public static CompilationUnitSyntax Generate(string title, List<MethodDescriptor> methodScopeData)
        {
            return CommonGenerator
                .CreateWithUsingAndNamespace("VkLibrary.Core.Types", GenerateMainModel(title, methodScopeData))
                .NormalizeWhitespace();
        }

        private static MemberDeclarationSyntax GenerateMainModel(string title, List<MethodDescriptor> methodScopeData)
        {
            FieldDeclarationSyntax vkontakteField = FieldDeclaration(
                    VariableDeclaration(
                            IdentifierName("Vkontakte"))
                        .WithVariables(
                            SingletonSeparatedList(
                                VariableDeclarator(
                                    Identifier("_vkontakte")))))
                .WithModifiers(
                    TokenList(
                        Token(SyntaxKind.PrivateKeyword),
                        Token(SyntaxKind.ReadOnlyKeyword)));

            ConstructorDeclarationSyntax constructor = ConstructorDeclaration(
                    Identifier(title))
                .WithModifiers(
                    TokenList(
                        Token(SyntaxKind.InternalKeyword)))
                .WithParameterList(
                    ParameterList(
                        SingletonSeparatedList(
                            Parameter(
                                    Identifier("vkontakte"))
                                .WithType(
                                    IdentifierName("Vkontakte")))))
                .WithExpressionBody(
                    ArrowExpressionClause(
                        AssignmentExpression(
                            SyntaxKind.SimpleAssignmentExpression,
                            IdentifierName("_vkontakte"),
                            IdentifierName("vkontakte"))))
                .WithSemicolonToken(
                    Token(SyntaxKind.SemicolonToken));

            MemberDeclarationSyntax[] methods = methodScopeData.Select(GenerateMethod).ToArray();

            return ClassDeclaration(title)
                .WithModifiers(
                    TokenList(
                        Token(SyntaxKind.PublicKeyword)))
                .AddMembers(vkontakteField, constructor)
                .AddMembers(methods);
        }

        public static MemberDeclarationSyntax GenerateMethod(MethodDescriptor methodDescriptor)
        {
            GenericNameSyntax type = GenericName(
                    Identifier("IEnumerable"))
                .WithTypeArgumentList(
                    TypeArgumentList(
                        SingletonSeparatedList<TypeSyntax>(
                            QualifiedName(
                                QualifiedName(
                                    IdentifierName("Types"),
                                    IdentifierName("Ads")),
                                IdentifierName("Account")))));

            LocalDeclarationStatementSyntax dictionary = LocalDeclarationStatement(
                VariableDeclaration(
                        IdentifierName("var"))
                    .AddVariables(
                        VariableDeclarator(
                                Identifier("parameters"))
                            .WithInitializer(
                                EqualsValueClause(
                                    ObjectCreationExpression(
                                            GenericName(
                                                    Identifier("Dictionary"))
                                                .WithTypeArgumentList(
                                                    TypeArgumentList(
                                                        SeparatedList<TypeSyntax>(
                                                            new SyntaxNodeOrToken[]
                                                            {
                                                                PredefinedType(
                                                                    Token(SyntaxKind
                                                                        .StringKeyword)),
                                                                Token(SyntaxKind
                                                                    .CommaToken),
                                                                PredefinedType(
                                                                    Token(SyntaxKind
                                                                        .StringKeyword))
                                                            }))))
                                        .WithArgumentList(
                                            ArgumentList())))));

            ReturnStatementSyntax returnStatement = ReturnStatement(
                InvocationExpression(
                        MemberAccessExpression(
                            SyntaxKind.SimpleMemberAccessExpression,
                            IdentifierName("_vkontakte"),
                            GenericName(
                                    Identifier("RequestAsync"))
                                .WithTypeArgumentList(
                                    TypeArgumentList(
                                        SingletonSeparatedList<TypeSyntax>(
                                            type)))))
                    .WithArgumentList(
                        ArgumentList(
                            SeparatedList<ArgumentSyntax>(
                                new SyntaxNodeOrToken[]
                                {
                                    Argument(
                                        LiteralExpression(
                                            SyntaxKind.StringLiteralExpression,
                                            Literal("ads.getAccounts"))),
                                    Token(SyntaxKind.CommaToken),
                                    Argument(
                                        IdentifierName("parameters"))
                                }))));

            //TODO: parameters generation

            MethodDeclarationSyntax method = MethodDeclaration(
                    GenericName(
                            Identifier("Task"))
                        .WithTypeArgumentList(
                            TypeArgumentList(
                                SingletonSeparatedList<TypeSyntax>(
                                    type))),
                    Identifier(methodDescriptor.Title.ToSharpString()))
                .WithModifiers(
                    TokenList(
                        Token(
                            CommonGenerator.AddComment(methodDescriptor.Descriptor),
                            SyntaxKind.PublicKeyword,
                            TriviaList())))
                .WithBody(
                    Block(
                        dictionary,
                        returnStatement));

            return method;
        }
    }
}