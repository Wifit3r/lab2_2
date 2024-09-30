using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgPatternsLab2
{
    class Personal : Component
    {
        public Personal(string name) : base(name) { }
        public string position { get; set; }
        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + Name);
        }

        public override string Operation()
        {
            throw new NotImplementedException();
        }
    }
}
