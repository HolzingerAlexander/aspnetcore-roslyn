namespace DocumentFilter.Rules.Multi
{
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.CodeAnalysis;

    public class NoneApplyRule : DocumentRule
    {
        private readonly IEnumerable<DocumentRule> _rules;

        public NoneApplyRule(IEnumerable<DocumentRule> rules)
        {
            _rules = rules;
        }

        public override bool Matches(Document document) 
            => !_rules.Any(rule => rule.Matches(document));
    }
}