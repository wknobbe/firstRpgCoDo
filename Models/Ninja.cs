using System;

namespace firstRpgCoDo.Models
{
    class Ninja : Human
    {
        public Ninja(string name) : base(name, 3, 3, 175, 100) { }
        public override void Attack(Human target)
        {
            int damage = 5 * Dexterity;
            Random rand = new Random();
            if (rand.Next(0, 5) == 4)
            {
                damage += 10;
            }
            target.DealDamage(damage);
            Console.WriteLine($"Ninja {Name} attacked {target.Name} for {damage} damage!");
        }
        public void Steal(Human target)
        {
            target.DealDamage(5);
            Heal(5);
        }
    }
}