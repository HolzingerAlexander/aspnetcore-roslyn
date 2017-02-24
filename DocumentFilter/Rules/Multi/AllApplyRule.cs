namespace DocumentFilter.Rules.Multi
{
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.CodeAnalysis;

    public class AllApplyRule : DocumentRule
    {
        private readonly IEnumerable<DocumentRule> _rules;

        public AllApplyRule(IEnumerable<DocumentRule> rules)
        {
            _rules = rules;
        }

        public override bool Matches(Document document)
            => _rules.All(rule => rule.Matches(document));
    }
}