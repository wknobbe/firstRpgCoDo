using System;

namespace firstRpgCoDo.Models
{
    class Samuri : Human
    {
        public Samuri(string name) : base(name, 3, 3, 3, 200)
        {

        }
        public override void Attack(Human target)
        {
            base.Attack(target);
            target.CriticalHit();
        }
        public void Meditate()
        {
            Heal(200);
        }
    }
}