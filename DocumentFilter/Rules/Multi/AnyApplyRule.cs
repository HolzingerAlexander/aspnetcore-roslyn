namespace DocumentFilter.Rules.Multi
{
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.CodeAnalysis;

    public class AnyApplyRule : DocumentRule
    {
        private readonly IEnumerable<DocumentRule> _rules;

        public AnyApplyRule(IEnumerable<DocumentRule> rules)
        {
            this._rules = rules;
        }

        public override bool Matches(Document document) 
            => _rules.Any(rule => rule.Matches(document));
    }
}