using System;

namespace Assi2
{
    class FancyPost : Post
    {
        public FancyPost(string t, string b) : base(t, b) { }

        public override string GetPrintableTitle() => "*** " + Title.ToUpper() + " ***";
        public override string GetPrintableBody() => "~~~ " + Body + " ~~~";
    }
}