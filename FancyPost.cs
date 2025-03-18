using System;

/*
 * Name: Logan McCallum Student Number: 1152955 Section: 2
 * Name: Spencer Martin Student Number: 1040415 Section: 2
 * Name: Ashley Burley-Denis Student Number: 0908968 Section: 1
 */

namespace Assi2
{
    //fancyPost class, extends Post,
    //used to change the formatting of the Post's get methods strings.
    class FancyPost : Post
    {
        public FancyPost(string t, string b) : base(t, b) { }

        public override string GetPrintableTitle() => "***" + Title + "***\n------";
        public override string GetPrintableBody() => "-=-=-=-=-\n" + Body + "\n-=-=-=-=-";
    }
}