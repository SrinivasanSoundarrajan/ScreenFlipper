using System;
using System.Windows.Forms;

namespace Flipper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executing Screen Flipper!");

            if (SystemInformation.ScreenOrientation == ScreenOrientation.Angle0)
            {
                Console.WriteLine("Current orientation is Landscape. So changing to Portrait ...");
                Display.Rotate(1, Display.Orientations.DEGREES_CW_270);
            }
            else
            {
                Console.WriteLine("Current orientation is NOT Landscape. So resetting to Landscape...");
                Display.Rotate(1, Display.Orientations.DEGREES_CW_0);
            }

            Console.WriteLine("Done. Exiting...");
        }
    }
}


