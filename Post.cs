using System;

namespace Assi2
{
    //Post class, extends Content class, used for storing the post data.
    class Post : Content
    {
        //post object variables
        public string Title { get; set; }
        public string Body { get; set; }


        //Post default constructor, creates a Post object and
        //sets the title and body to default to be changed by the program.
        public Post(string t = "Default Title", string b = "Default Body")
        {
            Title = t;
            Body = b;
        }

        //Clone method overide, returns a duplicate of the Post object.
        public override Content Clone()
        {
            return new Post(Title, Body);
        }

        //Get methods, returns the Post's Title/Body,
        //formatting them into strings then returning them.
        public override string GetPrintableTitle() => "***DOWNLOADED***------";
        public override string GetPrintableBody() => "-=-=-=-=" + Body + "-=-=-=-=";
    }
}