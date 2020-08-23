using MamaFacebook.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DolphinFacebook
{
    class Display : IDisplay
    {
        public void DisplayWallPost(string wallPost)
        {
            Console.WriteLine(wallPost);
        }
    }
}
