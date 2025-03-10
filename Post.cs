using System;

namespace Assi2
{
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

        public override string GetPrintableTitle() => "Post Title: " + Title;
        public override string GetPrintableBody() => "Post Body: " + Body;
    }
}