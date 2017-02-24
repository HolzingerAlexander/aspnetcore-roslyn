namespace DocumentFilter.Rules
{
    using Microsoft.CodeAnalysis;

    public abstract class DocumentRule
    {
        public abstract bool Matches(Document document);
    }
}