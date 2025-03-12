using System;

namespace Assi2
{
    class PostProxy : Content
    {
        private Post _realPost;
        private int _id;
        private bool _isDownloaded = false;

        public PostProxy(int id)
        {
            _id = id;
        }

        public void InitializePost()
        {
            if (!_isDownloaded)
            {
                _realPost = new Post();
                _isDownloaded = true;
            }
        }

        public void Download()
        {
            if (!_isDownloaded)
            {
                _realPost = new FancyPost($"Post {_id}", "Downloaded Body");
                _isDownloaded = true;
            }
        }

        public override string GetPrintableTitle()
        {
            return _isDownloaded ? _realPost.GetPrintableTitle() : "[Loading Post...]";
        }

        public override string GetPrintableBody()
        {
            return _isDownloaded ? _realPost.GetPrintableBody() : "[Content not available]";
        }

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
