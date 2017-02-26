namespace DtoCreator
{
    using System.Collections.Generic;
    using System.Security;
    using Filter;
    using Filter.Rules;
    using Microsoft.CodeAnalysis;

    partial class DtoCreator
    {
        private readonly IEnumerable<Document> _documents;
        private readonly Project _outProject;
        private readonly string[] _outFolder;

        public DtoCreator(Project project, Rule<IPropertySymbol> propertyFilter = null, Rule<Document> fileFilter = null)
        {
            _outProject = project;
            _documents = fileFilter == null ? project.Documents : project.Documents.Filter(fileFilter);
            _outFolder = new string[]{};
        }
    }
}