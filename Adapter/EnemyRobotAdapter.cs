using System;

public class EnemyRobotAdapter : IEnemyAttacker
{

    EnemyRobot theRobot = new EnemyRobot();

    public EnemyRobotAdapter(EnemyRobot newRobot)
    {
        this.theRobot = newRobot;
    }

    public void AssignDriver(string driverName)
    {
        this.theRobot.ReactToHuman(driverName);
    }

    public void DriveForward()
    {
        this.theRobot.WalkForward();
    }

    public void FireWeapon()
    {
        this.theRobot.SmashWithHands();
    }
}