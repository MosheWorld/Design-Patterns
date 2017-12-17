using System.Collections.Generic;

public class SecondChanger : IChanger
{
    public void change()
    {
        SingletonClass singleon = SingletonClass.Instance;
        List<People> peopleList = singleon.GetPeopleList();
        peopleList[1].desc = "Changed by SecondChanger";
    }
}