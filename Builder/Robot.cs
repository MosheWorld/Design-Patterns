public class Robot : IRobotPlan
{
    private string robotHead;
    private string robotTorso;
    private string robotArms;
    private string robotLegs;

    public void setRobotArms(string arms)
    {
        this.robotArms = arms;
    }

    public string getRobotArms()
    {
        return this.robotArms;
    }

    public void setRobotHead(string head)
    {
        this.robotHead = head;
    }

    public string getRobotHead()
    {
        return this.robotHead;
    }

    public void setRobotLegs(string legs)
    {
        this.robotLegs = legs;
    }

    public string getRobotLegs()
    {
        return this.robotLegs;
    }

    public void setRobotTorso(string torso)
    {
        this.robotTorso = torso;
    }

    public string getRobotTorso()
    {
        return this.robotTorso;
    }
}