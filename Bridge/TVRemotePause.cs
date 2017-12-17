using System;

public class TVRemotePause : RemoteButton
{
    public TVRemotePause(EntertainmentDevice newDevice) : base(newDevice)
    {
    }

    public override void ButtonNinePressed()
    {
        Console.WriteLine("TV was Paused");
    }
}