using System;

public class EnemyRobot
{
    Random random = new Random();

    public void SmashWithHands()
    {
        int attackDamage = random.Next(10) + 1;
        Console.WriteLine("Enemy Robot Causes " + attackDamage + " Damage With Its Hands");
    }

    public void WalkForward()
    {
        int movement = random.Next(5) + 1;
        Console.WriteLine("Enemy Robot Walks Forward " + movement + " spaces");
    }

    public void ReactToHuman(string driverName)
    {
        Console.WriteLine("Enemy Robot Tramps on " + driverName);
    }
}