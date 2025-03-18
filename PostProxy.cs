using System;

/*
 * Name: Logan McCallum Student Number: 1152955 Section: 2
 * Name: Spencer Martin Student Number: 1040415 Section: 2
 * Name: Ashley Burley-Denis Student Number: 0908968 Section: 1
 */

namespace Assi2
{

    //PostProxy Class, Extends Content Class, Holds downloaded
    //Posts In memory to be used by the program.
    class PostProxy : Content
    {
        //PostProxy object variables
        private Post _realPost;
        private int _id;
        private bool _isDownloaded = false;

        //default constructor, sets an ID that will be passed to the post object
        public PostProxy(int id)
        {
            _id = id;
        }

        //InitializePost method, creates a new post and
        //confirms that it is stored in memory.
        public void InitializePost()
        {
            if (!_isDownloaded)
            {
                _realPost = new Post();
                _isDownloaded = true;
            }
        }

        //Download Method. 
        public void Download()
        {
            if (!_isDownloaded)
            {
                _realPost = new FancyPost("Downloaded", "Downloaded Body");

                _isDownloaded = true;
            }
        }

        //GetPrintableTitle overide method. Firstly checks that the post has been downloaded,
        //if so it gets the Post title using the objects GetPrintableTitle() method,
        //otherwise it returns a default statement.
        public override string GetPrintableTitle()
        {
            return _isDownloaded ? _realPost.GetPrintableTitle() : "[Loading Post...]";
        }

        //GetPrintableBody overide method. Firstly checks that the post has been downloaded,
        //if so it gets the Post body using the objects GetPrintableTitle() method,
        //otherwise it returns a default statement.
        public override string GetPrintableBody()
        {
            return _isDownloaded ? _realPost.GetPrintableBody() : "[Content not available]";
        }


        //Clone Override method, makes a duplicate of the Post object,
        //also checks if the _realPost is fancy or not and returns the proper object accordingly.
        public override Content Clone()
        {
            PostProxy clone = new PostProxy(_id);
            if (_realPost != null)
            {
                // Ensure cloned post is also a FancyPost if downloaded
                if (_realPost is FancyPost)
                    clone._realPost = new FancyPost(_realPost.Title, _realPost.Body);
                else
                    clone._realPost = new Post(_realPost.Title, _realPost.Body);

                clone._isDownloaded = true;
            }
            return clone;
        }

        //Setter methods, both methods first check if
        //The Post has been downloaded to the Proxy, if not it runs the Download() Method.
        //Otherwise, the method sets the inputted string to the Post object's title/body
        public void SetTitle(string title)
        {
            if (!_isDownloaded) Download();
            _realPost.Title = title;
        }

        public void SetBody(string body)
        {
            if (!_isDownloaded) Download();
            _realPost.Body = body;
        }
    }
}
