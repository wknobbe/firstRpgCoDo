using System;

namespace firstRpgCoDo.Models
{
    class Wizard : Human
    {
        public Wizard(string name) : base(name, 3, 25, 3, 50) { }
        public override void Attack(Human target)
        {
            int damage = 5 * Intelligence;
            target.DealDamage(damage);
            Console.WriteLine($"Wizard {Name} attacked {target.Name} for {damage} damage!");
            Heal(damage);
        }
        public void WizardHeal(Human target)
        {
            int life = 10 * Intelligence;
            target.Heal(life);
            Console.WriteLine($"The Wizard has healed {target.Name}");
        }
    }
}