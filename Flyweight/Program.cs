using System;
using System.Collections.Generic;

namespace MosheBinieli.Flyweight
{
    class MainApp
    {
        static void Main()
        {
            CharacterFactory factory = new CharacterFactory();

            string document = "AAZZBBZB";
            char[] chars = document.ToCharArray();

            int pointSize = 10;

            foreach (char c in chars)
            {
                pointSize++;
                Character character = factory.GetCharacter(c);
                character.Display(pointSize);
            }
        }
    }
}


