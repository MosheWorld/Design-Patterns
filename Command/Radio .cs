using System;

public class Radio : IElectronicDevice
{
    private int volume = 0;

    public void Off()
    {
        Console.WriteLine("Radio is off");
    }

    public void On()
    {
        Console.WriteLine("Radio is on");
    }

    public void VolumenDown()
    {
        this.volume--;
        Console.WriteLine("Radio Volume is at: " + volume);
    }

    public void VolumeUp()
    {
        this.volume++;
        Console.WriteLine("Radio Volume is at: " + volume);
    }
}