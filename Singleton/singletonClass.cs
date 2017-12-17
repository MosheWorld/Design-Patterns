using System.Collections.Generic;

public class SingletonClass
{
    private static volatile SingletonClass instance;
    private List<People> peopleList = new List<People>();
    private static object syncRoot = new object();

    private SingletonClass() { }

    public static SingletonClass Instance
    {
        get
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                        instance = new SingletonClass();
                }
            }

            return instance;
        }
    }

    public List<People> GetPeopleList(){
        return this.peopleList;
    }
}