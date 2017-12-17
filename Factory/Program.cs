using System;

namespace MosheBinieli.Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            EnemyShipFactory shipFactory = new EnemyShipFactory();

            EnemyShip theEnemy = null;

            theEnemy = shipFactory.MakeEnemyShip(EnemyShipEnum.UFOEnemyShip);
            DoStuffEnemy(theEnemy);

            theEnemy = shipFactory.MakeEnemyShip(EnemyShipEnum.RocketEnemyShip);
            DoStuffEnemy(theEnemy);

            theEnemy = shipFactory.MakeEnemyShip(EnemyShipEnum.BigUFOEnemyShip);
            DoStuffEnemy(theEnemy);
        }
        public static void DoStuffEnemy(EnemyShip anEnemyShip)
        {
            anEnemyShip.DisplayEnemyShip();
            anEnemyShip.FollowHeroShip();
            anEnemyShip.EeemyShipShoots();
        }
    }
}
