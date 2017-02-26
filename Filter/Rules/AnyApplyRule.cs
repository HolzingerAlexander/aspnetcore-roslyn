﻿namespace Filter.Rules
{
    using System.Collections.Generic;
    using System.Linq;

    public class AnyApplyRule<T> : Rule<T>
    {
        private readonly IEnumerable<Rule<T>> _rules;

        public AnyApplyRule(IEnumerable<Rule<T>> rules)
        {
            this._rules = rules;
        }

        public override bool Matches(T obj) 
            => _rules.Any(rule => rule.Matches(obj));

        public static Rule<T> Create(IEnumerable<Rule<T>> rules)
            => new AnyApplyRule<T>(rules);
    }
}