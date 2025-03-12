using System;

namespace Assi2
{
    //fancyPost class, extends Post,
    //used to change the formatting of the Post's get methods strings.
    class FancyPost : Post
    {
        public FancyPost(string t, string b) : base(t, b) { }

        public override string GetPrintableTitle() => "*** " + Title.ToUpper() + " ***";
        public override string GetPrintableBody() => "~~~ " + Body + " ~~~";
    }
}