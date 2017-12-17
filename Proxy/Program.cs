using System;

namespace MosheBinieli.Proxy
{
    class MainApp
    {
        static void Main()
        {
            Console.WriteLine("Proxy:");

            // assuming that the user selects a folder that has 3 images	
            //create the 3 images 	
            IImage highResolutionImage1 = new ImageProxy("sample/veryHighResPhoto1.jpeg");
            IImage highResolutionImage2 = new ImageProxy("sample/veryHighResPhoto2.jpeg");
            IImage highResolutionImage3 = new ImageProxy("sample/veryHighResPhoto3.jpeg");

            // assume that the user clicks on Image one item in a list
            // this would cause the program to call showImage() for that image only
            // note that in this case only image one was loaded into memory

            highResolutionImage1.showImage();
            Console.WriteLine("\nNot proxy:");

            // consider using the high resolution image object directly
            IImage highResolutionImageNoProxy1 = new HighResolutionImage("sample/veryHighResPhoto1.jpeg");
            IImage highResolutionImageNoProxy2 = new HighResolutionImage("sample/veryHighResPhoto2.jpeg");
            IImage highResolutionImageBoProxy3 = new HighResolutionImage("sample/veryHighResPhoto3.jpeg");

            // assume that the user selects image two item from images list
            highResolutionImageNoProxy2.showImage();
        }
    }
}

