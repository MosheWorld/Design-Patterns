using System;

public class EnemyTank : IEnemyAttacker
{
    Random random = new Random();
    
    public void AssignDriver(string driverName)
    {
        Console.WriteLine(driverName + " is driving the tank");
    }

    public void DriveForward()
    {
        int movement = random.Next(5) + 1;
        Console.WriteLine("Enemy Tank moves " + movement + " spaces");
    }

    public void FireWeapon()
    {
        int attackDamage = random.Next(10) + 1;
        Console.WriteLine("Enemy Tank Does " + attackDamage + " Damage");
    }
}