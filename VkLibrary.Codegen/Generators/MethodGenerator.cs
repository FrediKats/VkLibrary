using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using VkLibrary.Codegen.Models;
using VkLibrary.Codegen.Types.TitleCase;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace VkLibrary.Codegen.Generators
{
    public class MethodGenerator
    {
        public static CompilationUnitSyntax Generate(ICustomCaseTitle scope, List<MethodDescriptor> methodDescriptor)
        {
            return CommonGenerator
                .CreateWithUsingAndNamespace("VkLibrary.Core.Types", GenerateMainModel(scope, methodDescriptor))
                .NormalizeWhitespace();
        }

        private static MemberDeclarationSyntax GenerateMainModel(ICustomCaseTitle scope, List<MethodDescriptor> methodDescriptor)
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
                    Identifier(scope.ToSharpString()))
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

            List<MethodDeclarationSyntax> methods = methodDescriptor.Select(GenerateMethod).ToList();

            return ClassDeclaration(scope.ToSharpString())
                .WithModifiers(
                    TokenList(
                        Token(SyntaxKind.PublicKeyword)))
                .WithMembers(
                    List(
                        new MemberDeclarationSyntax[]
                        {
                            vkontakteField,
                            constructor,
                            
                        }));
        }

        public static MethodDeclarationSyntax GenerateMethod(MethodDescriptor methodDescriptor)
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

            var dictionary = LocalDeclarationStatement(
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

            var returnStatement = ReturnStatement(
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
                    Identifier("GetAccounts"))
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