using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ResponsiveTele
{
    class Utilities
    {
        private static String ResourceBaseAddress = "ResponsiveTele.Assets.";

        public static ImageSource Source(String FileName, Type ClassType)
        {
            return ImageSource.FromResource(ResourceBaseAddress + FileName, ClassType);
        }
    }
}
