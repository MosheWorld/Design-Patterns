public class OldRobotBuilder : IRobotBuilder
{
    private Robot robot;

    public OldRobotBuilder()
    {
        this.robot = new Robot();
    }

    public void buildRobotArms(string str)
    {
        this.robot.setRobotArms(str);
    }

    public void buildRobotHead(string str)
    {
        this.robot.setRobotHead(str);
    }

    public void buildRobotLegs(string str)
    {
        this.robot.setRobotLegs(str);
    }

    public void buildRobotTorso(string str)
    {
        this.robot.setRobotTorso(str);
    }

    public Robot GetRobot()
    {
        return this.robot;
    }
}