using System;

/*
 * Name: Logan McCallum Student Number: 1152955 Section: 2
 * Name: Spencer Martin Student Number: 1040415 Section: 2
 * Name: Ashley Burley-Denis Student Number: 0908968 Section: 1
 */

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
        public override string GetPrintableTitle() => "***Downloaded***------";
        public override string GetPrintableBody() => "-=-=-=-=" + Body + "-=-=-=-=";
    }
}