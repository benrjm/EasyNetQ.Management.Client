﻿namespace EasyNetQ.Management.Client.Tests
{
    /// <summary>
    /// Category specifiying that a test has to be explicitly named before it
    /// is run.
    /// </summary>
    public class ExplicitAttribute : CategoryAttribute
    {
        public ExplicitAttribute()
            : base(Category.Explicit)
        { }

        public ExplicitAttribute(string skipReason)
            : base(Category.Explicit)
        {
            SkipReason = skipReason;
        }

        public string SkipReason { get; set; }
    }
}
