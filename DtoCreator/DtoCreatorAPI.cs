namespace DtoCreator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.CSharp.Syntax;

    partial class DtoCreator
    {
        // Data-Properties
        private SyntaxTree Tree { get; }

        private Func<PropertyDeclarationSyntax, bool> PropertyValid { get; set; }

        public string CreateDto() => TransformText();

        public string NamespaceName { get; private set; }

        public string ClassName { get; private set; }

        public DtoCreator(SyntaxTree tree,
            Func<PropertyDeclarationSyntax, bool> propertyValid,
            string namespaceName = "DTOs", string className = "Dto")
        {
            Tree = tree;
            PropertyValid = propertyValid;
            NamespaceName = namespaceName;
            ClassName = className;
        }

        // Helper-Properties
        private CompilationUnitSyntax SyntaxRoot
            => Tree.GetRoot() as CompilationUnitSyntax;

        private IEnumerable<PropertyDeclarationSyntax> Properties
            => SyntaxRoot.DescendantNodes().OfType<PropertyDeclarationSyntax>();

        private IEnumerable<PropertyDeclarationSyntax> ValidProperties
            => Properties.Where(PropertyValid);

        private IEnumerable<UsingDirectiveSyntax> Usings
            => SyntaxRoot.DescendantNodes().OfType<UsingDirectiveSyntax>();
    }
}