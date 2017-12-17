using System;

public class HighResolutionImage : IImage
{
    public HighResolutionImage(string imageFilePath)
    {
        Console.WriteLine("Loading image from real image ( Very heavy process )");
        loadImage(imageFilePath);
    }

    private void loadImage(string imageFilePath)
    {
        // load Image from disk into memory
        // this is heavy and costly operation
    }

    public void showImage()
    {
        Console.WriteLine("Showing image.");
        // Actual Image rendering logic
    }
}