using System;

namespace MosheBinieli.Builder
{
    class Program
    {
        public static void Main(string[] args)
        {
            OldRobotBuilder oldStyleRobot = new OldRobotBuilder();
            RobotEngineer robotEngineer = new RobotEngineer(oldStyleRobot);

            robotEngineer.MakeRobot();

            Robot firstRobot = robotEngineer.GetRobot();

            Console.WriteLine(firstRobot.getRobotHead());
            Console.WriteLine(firstRobot.getRobotArms());
            Console.WriteLine(firstRobot.getRobotTorso());
            Console.WriteLine(firstRobot.getRobotLegs());
        }
    }
}
