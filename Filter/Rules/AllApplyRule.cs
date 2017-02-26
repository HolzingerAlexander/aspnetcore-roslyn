namespace Filter.Rules
{
    using System.Collections.Generic;
    using System.Linq;

    public class AllApplyRule<T> : Rule<T>
    {
        private readonly IEnumerable<Rule<T>> _rules;

        public AllApplyRule(IEnumerable<Rule<T>> rules)
        {
            _rules = rules;
        }

        public override bool Matches(T obj)
            => _rules.All(rule => obj.Matches(rule));

        public static AllApplyRule<T> Create(IEnumerable<Rule<T>> rules)
            => new AllApplyRule<T>(rules);
    }
}