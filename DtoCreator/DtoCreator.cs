namespace DtoCreator
{
    using System.Collections.Generic;
    using Microsoft.CodeAnalysis;
    using Microsoft.DotNet.ProjectModel.Workspaces;

    public class DtoCreator
    {
        private readonly IEnumerable<Document> _documents;

        public DtoCreator(IEnumerable<Document> documents)
        {
            _documents = documents;
        }

        public DtoCreator(ProjectJsonWorkspace workspace)
            
    }
}