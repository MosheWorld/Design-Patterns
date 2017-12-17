using System;
using System.Collections.Generic;

namespace MosheBinieli.Command
{
    class Program
    {
        static void Main(string[] args)
        {
            IElectronicDevice newDevice = TVRemote.GetDevice();

            ICommand onCommand = new TurnTVOn(newDevice);
            DeviceButton onPressed = new DeviceButton(onCommand);
            onPressed.press();

            ICommand offCommand = new TurnTVOff(newDevice);
            onPressed = new DeviceButton(offCommand);
            onPressed.press();

            ICommand volUpCommand = new TurnTVUp(newDevice);
            onPressed = new DeviceButton(volUpCommand);
            onPressed.press();
            onPressed.press();
            onPressed.press();

            ICommand volDownCommand = new TurnTVDown(newDevice);
            onPressed = new DeviceButton(volDownCommand);
            onPressed.press();

            // ---------------------------------- //

            Television theTV = new Television();
            Radio theRadio = new Radio();

            List<IElectronicDevice> allDevices = new List<IElectronicDevice>();
            allDevices.Add(theTV);
            allDevices.Add(theRadio);

            TurnItAllOff turnOffDevices = new TurnItAllOff(allDevices);
            DeviceButton turnThemOff = new DeviceButton(turnOffDevices);
            turnThemOff.press();
        }
    }
}
