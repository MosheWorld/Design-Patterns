using System.Collections.Generic;

public class FirstChanger : IChanger
{
    public void change()
    {
        SingletonClass singleon = SingletonClass.Instance;
        List<People> peopleList = singleon.GetPeopleList();
        peopleList[0].desc = "Changed by FirstChanger";
    }
}