using System;
using System.Collections.Generic;

namespace MosheBinieli.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            CloneFactory animalMaker = new CloneFactory();
            Sheep sally = new Sheep();

            Sheep clonedSheep = (Sheep)animalMaker.GetClone(sally);

            Console.WriteLine(sally);
            Console.WriteLine(clonedSheep);

            Console.WriteLine(sally.Voice);
            Console.WriteLine(clonedSheep.Voice);
        }
    }
}
