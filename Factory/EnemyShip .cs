using System;

public abstract class EnemyShip
{
    public string name { get; set; }
    public double speed { get; set; }
    public double directionX { get; set; }
    public double directionY { get; set; }
    public double amtDamage { get; set; }

    public void FollowHeroShip()
    {
        Console.WriteLine(this.name + " is following the hero");
    }

    public void DisplayEnemyShip()
    {
        Console.WriteLine(this.name + " is on the screen");
    }

    public void EeemyShipShoots()
    {
        Console.WriteLine(this.name + " attacks and does " + this.amtDamage + " damage to hero");
    }
}