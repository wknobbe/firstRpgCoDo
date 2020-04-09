using System;

namespace firstRpgCoDo
{
    class Program
    {
        class Human
        {
            public string Name;
            public int Strength;
            public int Intelligence;
            public int Dexterity;
            private int health;
            public Human(string name)
            {
                Name = name;
                Strength = 3;
                Intelligence = 3;
                Dexterity = 3;
                health = 100;
            }
            public Human(string name, int str, int itl, int dex, int hea)
            {
                Name = name;
                Strength = str;
                Intelligence = itl;
                Dexterity = dex;
                health = hea;
            }
            public int Attack(Human target)
            {
                int damage = 5 * Strength;
                target.health -= damage;
                return target.health;
            }
        }
        static void Main(string[] args)
        {
            Human alpha = new Human("Alpha");
            Console.Write($"Name:{alpha.Name}, Strength:{alpha.Strength}, Intelligence:{alpha.Intelligence}, Dexterity:{alpha.Dexterity}");
        }
    }
}
