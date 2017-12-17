using System;
using System.Collections.Generic;

namespace MosheBinieli.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            InitPeople();
            DisplayPeopleList();
            ActivateChanges();
            DisplayPeopleList();
        }

        private static void InitPeople()
        {
            SingletonClass singleon = SingletonClass.Instance;
            List<People> peopleList = singleon.GetPeopleList();
            People person1 = new People() { age = 24, name = "Moshe Binieli", money = 20000, desc = "Test1" };
            People person2 = new People() { age = 23, name = "Ofeq Shany", money = 18000, desc = "Test2" };
            People person3 = new People() { age = 30, name = "Daniel Netzer", money = 13000, desc = "Test2" };
            peopleList.Add(person1);
            peopleList.Add(person2);
            peopleList.Add(person3);
        }

        private static void DisplayPeopleList()
        {
            SingletonClass singleon = SingletonClass.Instance;
            List<People> peopleList = singleon.GetPeopleList();
            foreach (People item in peopleList)
                Console.WriteLine($"{item.age}, {item.name}, {item.money}, {item.desc}");
        }

        private static void ActivateChanges()
        {
            IChanger changer = new FirstChanger();
            changer.change();
            changer = new SecondChanger();
            changer.change();
        }
    }
}
