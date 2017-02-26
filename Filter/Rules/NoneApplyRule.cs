namespace Filter.Rules
{
    using System.Collections.Generic;
    using System.Linq;

    public class NoneApplyRule<T> : Rule<T>
    {
        private readonly IEnumerable<Rule<T>> _rules;

        public NoneApplyRule(IEnumerable<Rule<T>> rules)
        {
            _rules = rules;
        }

        public override bool Matches(T obj) 
            => !_rules.Any(rule => obj.Matches(rule));

        public static Rule<T> Create(IEnumerable<Rule<T>> rules)
            => new NoneApplyRule<T>(rules);
    }
}