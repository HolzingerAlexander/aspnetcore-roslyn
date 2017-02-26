namespace Filter.Rules
{
    using System;

    public class CustomRule<T> : Rule<T>
    {
        private readonly Func<T, bool> _func;

        public CustomRule(Func<T, bool> func)
        {
            _func = func;
        }

        public override bool Matches(T document) 
            => _func(document);

        public static Rule<T> Create(Func<T, bool> func)
            => new CustomRule<T>(func);
    }
}