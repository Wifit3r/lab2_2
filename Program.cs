using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using ProgPatternsLab2;

namespace lab2
{
    class Program
    {
        static void Main() {
            Structure structure = new Structure("Main");
            structure.Add(new Personal("Anton"));
            structure.Add(new Personal("Ivan"));
            Structure structure1 = new Structure("Second");
            Structure structure2 = new Structure("Thrid");
            structure1.Add(new Personal("Andriy"));
            structure1.Add(new Personal("Vasya"));
            structure1.Add(new Personal("Victor"));
            structure2.Add(new Personal("Milan"));
            structure2.Add(new Personal("Mario"));
            structure2.Add(new Personal("Gorge"));
            structure1.Add(structure2);
            structure.Add(structure1);
            structure.Add(new Personal("Oleg"));
            structure.Add(new Personal("Artur"));
            structure.Display(1);
        }
    }
}