﻿using System;

// ReSharper disable CheckNamespace
namespace ExCSS
// ReSharper restore CheckNamespace
{
    public class SupportsRule : ConditionalRule
    {
        private string _condition;

        public SupportsRule() : this(null)
        {}

        internal SupportsRule(StyleSheet context) : base(context)
        {
            RuleType = RuleType.Supports;
            _condition = string.Empty;
        }

        public override string Condition
        {
            get { return _condition; }
            set { _condition = value; }
        }

        public override string ToString()
        {
            var declarations = string.Join(" ", Declarations);

            return string.Format("@supports {0}{{{1}}}", _condition, declarations);
        }
    }
}
