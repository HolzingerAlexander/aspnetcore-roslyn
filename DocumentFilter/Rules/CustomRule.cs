namespace RuleChecker.Rules
{
    using System;
    using DocumentFilter.Rules;
    using Microsoft.CodeAnalysis;

    public class CustomRule : DocumentRule
    {
        private readonly Func<Document, bool> _func;

        public CustomRule(Func<Document, bool> func)
        {
            _func = func;
        }

        public override bool Matches(Document document) 
            => _func(document);
    }
}