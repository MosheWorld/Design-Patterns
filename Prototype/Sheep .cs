using System;
public class Sheep : IAnimal
{
    public string Voice { get; set; }
    public Sheep()
    {
        Console.WriteLine("Sheep has been created");
        this.Voice = "Hulala baby";
    }

    public IAnimal MakeCopy()
    {
        Console.WriteLine("Sheep has being made");
        Sheep sheepObject = null;

        try
        {
            sheepObject = (Sheep)this.MemberwiseClone();
        }
        catch (Exception ex)
        {
            Console.WriteLine("The Sheep was Turned to Mush", ex);
        }

        return sheepObject;
    }
}