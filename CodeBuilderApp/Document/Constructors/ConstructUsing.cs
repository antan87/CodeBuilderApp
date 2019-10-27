using CodeBuilderApp.Document.Interfaces;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CodeBuilderApp.Document.Constructors
{
    public static class ConstructUsing
    {
        public static UsingDirectiveSyntax Create(IUsing element) => SyntaxFactory.UsingDirective(SyntaxFactory.ParseName(element.Name));
    }
}