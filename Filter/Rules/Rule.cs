namespace Filter.Rules
{
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Rule<T>
    {
        public abstract bool Matches(T obj);

        public IEnumerable<T> Filter(IEnumerable<T> enumerable)
            => enumerable.Where(this.Matches);
    }
}