using System;

public class ImageProxy : IImage
{
    private string imageFilePath;
    private IImage proxifiedImage;

    public ImageProxy(string imageFilePath)
    {
        Console.WriteLine("Saving image path in Proxy");
        this.imageFilePath = imageFilePath;
    }

    public void showImage()
    {
        proxifiedImage = new HighResolutionImage(imageFilePath);
        proxifiedImage.showImage();
    }
}