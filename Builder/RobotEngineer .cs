public class RobotEngineer
{
    private IRobotBuilder robotBuilder;

    public RobotEngineer(IRobotBuilder newRobot)
    {
        this.robotBuilder = newRobot;
    }

    public Robot GetRobot()
    {
        return this.robotBuilder.GetRobot();
    }

    public void MakeRobot()
    {
        this.robotBuilder.buildRobotArms("New Arms");
        this.robotBuilder.buildRobotHead("New Head");
        this.robotBuilder.buildRobotTorso("New Legs");
        this.robotBuilder.buildRobotLegs("New Torso");
    }
}