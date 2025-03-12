using System;

namespace Assi2
{
    //Post class, extends Content class, used for storing the post data.
    class Post : Content
    {
        public string Title { get; set; }
        public string Body { get; set; }

        public Post(string t = "Default Title", string b = "Default Body")
        {
            Title = t;
            Body = b;
        }

        public override Content Clone()
        {
            return new Post(Title, Body);
        }

        public override string GetPrintableTitle() => "***DOWNLOADED***------";
        public override string GetPrintableBody() => "-=-=-=-=" + Body + "-=-=-=-=";
    }
}