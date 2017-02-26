namespace Filter
{
    using System.Collections.Generic;
    using System.Linq;
    using Filter.Rules;

    public static class FilterExtensions
    {
        public static bool Matches<T>(this T @this, Rule<T> rule)
            => rule.Matches(@this);

        public static IEnumerable<T> Filter<T>(this IEnumerable<T> @enumerable, Rule<T> rule)
            => @enumerable.Where(rule.Matches);
    }
}
