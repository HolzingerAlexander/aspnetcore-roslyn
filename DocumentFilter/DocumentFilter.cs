namespace DocumentFilter
{
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using global::DocumentFilter.Rules;
    using Microsoft.CodeAnalysis;

    public class DocumentFilter
    {
        public DocumentRule Rule { get; private set; }

        public DocumentFilter(DocumentRule rule)
        {
            this.Rule = rule;
        }

        public IEnumerable<Document> Filter(IEnumerable<Document> documents) 
            => documents.Where(document => Rule.Matches(document));

        public static bool MatchesRule(Document document, DocumentRule rule)
            => rule.Matches(document);
    }
}
