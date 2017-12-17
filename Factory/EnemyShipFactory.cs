public class EnemyShipFactory
{
    public EnemyShip MakeEnemyShip(EnemyShipEnum shipType)
    {
        EnemyShip shipChosen = null;

        switch (shipType)
        {
            case EnemyShipEnum.UFOEnemyShip:
                shipChosen = new UFOEnemyShip();
                break;
            case EnemyShipEnum.RocketEnemyShip:
                shipChosen = new RocketEnemyShip();
                break;
            case EnemyShipEnum.BigUFOEnemyShip:
                shipChosen = new BigUFOEnemyShip();
                break;
            default:
                shipChosen = null;
                break;
        }

        return shipChosen;
    }

}