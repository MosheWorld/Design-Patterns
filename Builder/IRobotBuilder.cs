public interface IRobotBuilder
{
    void buildRobotHead(string str);
    void buildRobotTorso(string str);
    void buildRobotArms(string str);
    void buildRobotLegs(string str);
    Robot GetRobot();
}