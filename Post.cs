using System;

namespace Assi2
{
    //Post class, extends Content class, used for storing the post data.
    class Post : Content
    {
        //post object variables
        public string Title { get; set; }
        public string Body { get; set; }

        //post default constructor, sets the posts
        //title and body as a default to eventually be updated
        public Post(string t = "Default Title", string b = "Default Body")
        {
            Title = t;
            Body = b;
        }

        //Clone method override, returns
        //a duplicate of the post as a new object.
        public override Content Clone()
        {
            return new Post(Title, Body);
        }

        //get methods, returns the posts title or body
        //as a string for prinitng to the console.
        public override string GetPrintableTitle() => "Post Title: " + Title;
        public override string GetPrintableBody() => "Post Body: " + Body;
    }
}