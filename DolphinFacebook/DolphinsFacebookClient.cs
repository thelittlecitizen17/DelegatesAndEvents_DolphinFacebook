using System;
using System.Collections.Generic;
using System.Text;
using MamaFacebook;
using MamaFacebook.Abstract;

namespace DolphinFacebook
{
    class DolphinsFacebookClient : IFacebookClient
    {
        public event Action<string> NewWallPost;
        public DolphinsFacebookClient(Action<string> display)
        {
            NewWallPost = display;
        }

        public DolphinsFacebookClient()
        {
        }

        public void Subscribe(IFacebookClient publisher)
        {
            publisher.NewWallPost += NewWallPost;
        }

        public void Unsubscribe(IFacebookClient publisher)
        {
            publisher.NewWallPost -= NewWallPost;
        }

        public void WriteNewWallPost(string wallPost)
        {
            NewWallPost?.Invoke(wallPost);
        }

    }
}
