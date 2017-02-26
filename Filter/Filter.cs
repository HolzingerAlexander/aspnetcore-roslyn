namespace Filter
{
    using System.Collections.Generic;
    using System.Linq;
    using Filter.Rules;

    public class Filter<T>
    {
        public Rule<T> Rule { get; private set; }

        public Filter(Rule<T> rule)
        {
            this.Rule = rule;
        }

        public IEnumerable<T> Filtrate(IEnumerable<T> enumerable) 
            => enumerable.Where(obj => Rule.Matches(obj));

        public static bool MatchesRule(T obj, Rule<T> rule)
            => rule.Matches(obj);
    }
}
