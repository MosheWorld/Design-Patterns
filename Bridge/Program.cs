using System;

namespace MosheBinieli.Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteButton theTV = new TVRemoteMute(new TVDevice(1, 200));
            RemoteButton theTV2 = new TVRemotePause(new TVDevice(1, 200));

            Console.WriteLine("Test TV with Mute");
            theTV.ButtonFivePressed();
            theTV.ButtonSixPressed();
            theTV.ButtonNinePressed();
            theTV.DeviceFeedback();

            Console.WriteLine("\nTest TV with Pause");
            theTV2.ButtonFivePressed();
            theTV2.ButtonSixPressed();
            theTV2.ButtonNinePressed();
            theTV2.DeviceFeedback();
        }
    }
}
