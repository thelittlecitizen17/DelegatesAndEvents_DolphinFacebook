using MamaFacebook.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DolphinFacebook
{
    class FacebookClientFactory : IFacebookClientFactory
    {
        public IFacebookClient CreateClient(IDisplay display)
        {
            DolphinsFacebookClient facebookClient = new DolphinsFacebookClient(display.DisplayWallPost);
            return facebookClient;
        }
    }
}
