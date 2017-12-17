using System;

public class Television : IElectronicDevice
{
    private int volume = 0;

    public void Off()
    {
        Console.WriteLine("TV is off.");
    }

    public void On()
    {
        Console.WriteLine("TV is on.");
    }

    public void VolumenDown()
    {
        this.volume--;
        Console.WriteLine("TV Volume is at: " + volume);
    }

    public void VolumeUp()
    {
        this.volume++;
        Console.WriteLine("TV Volume is at: " + volume);
    }
}