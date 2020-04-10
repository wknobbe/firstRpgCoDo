using System;
using firstRpgCoDo.Models;

namespace firstRpgCoDo
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Samuri alpha = new Samuri("Alpha");
            Console.WriteLine($"Name:{alpha.Name}, Strength:{alpha.Strength}, Intelligence:{alpha.Intelligence}, Dexterity:{alpha.Dexterity}");
            Wizard beta = new Wizard("Beta");
            alpha.Meditate();
        }
    }
}
