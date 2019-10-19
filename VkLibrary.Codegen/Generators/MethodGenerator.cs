using System;
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
            FieldDeclarationSyntax vkontakteField =
                FieldDeclaration(
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

            ConstructorDeclarationSyntax constructor =
                ConstructorDeclaration(
                        Identifier(title))
                    .WithModifiers(TokenList(
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

            var statements = new List<MemberDeclarationSyntax>();
            statements.Add(vkontakteField);
            statements.Add(constructor);
            statements.AddRange(methodScopeData.Select(m => GenerateMethod(title, m)).ToList());

            return ClassDeclaration(title)
                .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword)))
                .WithMembers(List(statements));
        }

        public static MemberDeclarationSyntax GenerateMethod(string title, MethodDescriptor methodDescriptor)
        {
            GenericNameSyntax type =
                GenericName(
                        Identifier("Task"))
                    .WithTypeArgumentList(
                        TypeArgumentList(
                            SingletonSeparatedList<TypeSyntax>(
                                IdentifierName(methodDescriptor.ResponseType.ToSharpString()))));

            LocalDeclarationStatementSyntax dictionary = LocalDeclarationStatement(
                VariableDeclaration(
                        IdentifierName("var"))
                    .WithVariables(
                        SingletonSeparatedList(
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
                                            ArgumentList()))))));

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
                                            Literal(methodDescriptor.Title.ToOriginalString()))),
                                    Token(SyntaxKind.CommaToken),
                                    Argument(
                                        IdentifierName("parameters"))
                                }))));

            //TODO: parameters generation
            IfStatementSyntax[] agruments = methodDescriptor
                .MethodParameterDescriptors
                .Select(ArgumentInsertStatement)
                .ToArray();

            var statements = new List<StatementSyntax>();
            statements.Add(dictionary);
            statements.AddRange(agruments);
            statements.Add(returnStatement);

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
                .WithParameterList(
                    ParameterList(
                        SeparatedList(
                            methodDescriptor.MethodParameterDescriptors
                            .Select(GenerateParameters)
                            .ToArray())))
                .WithBody(
                    Block(
                        statements));

            return method;
        }

        private static ParameterSyntax GenerateParameters(MethodParameterDescriptor methodParameterDescriptor)
        {
            //TODO: check for nullability
            string type = methodParameterDescriptor.Type.ToSharpString();
            if (type == "int" || type == "Boolean" || type == "double")
                type += "?";

            return
                Parameter(
                        Identifier(methodParameterDescriptor.Title.ToSharpString()))
                    .WithType(
                        IdentifierName(
                            type))
                    .WithDefault(
                        EqualsValueClause(
                            LiteralExpression(
                                SyntaxKind.NullLiteralExpression)));
        }

        private static IfStatementSyntax ArgumentInsertStatement(MethodParameterDescriptor methodParameterDescriptor)
        {
            string parameterName = methodParameterDescriptor.Title.ToSharpString();

            IfStatementSyntax ifStatement = IfStatement(
                BinaryExpression(
                    SyntaxKind.NotEqualsExpression,
                    IdentifierName(parameterName),
                    LiteralExpression(
                        SyntaxKind.NullLiteralExpression)),
                ExpressionStatement(
                    InvocationExpression(
                            MemberAccessExpression(
                                SyntaxKind.SimpleMemberAccessExpression,
                                IdentifierName("parameters"),
                                IdentifierName("Add")))
                        .WithArgumentList(
                            ArgumentList(
                                SeparatedList<ArgumentSyntax>(
                                    new SyntaxNodeOrToken[]
                                    {
                                        Argument(
                                            LiteralExpression(
                                                SyntaxKind.StringLiteralExpression,
                                                Literal(methodParameterDescriptor.Title.ToOriginalString()))),
                                        Token(SyntaxKind.CommaToken),
                                        Argument(
                                            InvocationExpression(
                                                MemberAccessExpression(
                                                    SyntaxKind.SimpleMemberAccessExpression,
                                                    IdentifierName(parameterName),
                                                    IdentifierName("ToApiString"))))
                                    })))));

            return ifStatement;
        }
    }
}