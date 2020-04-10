using System;

namespace firstRpgCoDo.Models
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
            public Human(string name, int str, int itl, int dex, int hp)
            {
                Name = name;
                Strength = str;
                Intelligence = itl;
                Dexterity = dex;
                health = hp;
            }
            public virtual void Attack(Human target)
            {
                int damage = 3 * Strength;
                target.health -= damage;
                Console.WriteLine($"{Name} attacked {target.Name} for {damage} damage!");
            }
            public void DealDamage(int damage)
            {
                health -= damage;
            }
            public void Heal(int life)
            {
                health += life;
                Console.WriteLine($"{Name} has gained {life} health!");
            }
            public void CriticalHit()
            {
                if(health < 50)
                {
                    health = 0;
                    Console.WriteLine("Finish Him!");
                }
            }
        }
}