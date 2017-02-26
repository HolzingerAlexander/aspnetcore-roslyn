namespace Filter.Rules
{
    public abstract class Rule<T>
    {
        public abstract bool Matches(T obj);
    }
}