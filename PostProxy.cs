using System;

namespace Assi2
{
    class PostProxy : Content
    {
        private Post _realPost;
        private int _id;

        public PostProxy(int id)
        {
            _id = id;
        }

        public void Download()
        {
            _realPost = new FancyPost($"Post {_id}", $"This is the content of post {_id}.");
        }

        public override Content Clone()
        {
            return new PostProxy(_id);
        }

        public override string GetPrintableTitle()
        {
            return _realPost != null ? _realPost.Title : "[Loading Post...]";
        }

        public override string GetPrintableBody()
        {
            return _realPost != null ? _realPost.Body : "[Content not available]";
        }

        public void SetTitle(string title)
        {
            if (_realPost != null)
                _realPost.Title = title;
        }

        public void SetBody(string body)
        {
            if (_realPost != null)
                _realPost.Body = body;
        }
    }
}