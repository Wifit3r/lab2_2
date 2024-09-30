using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProgPatternsLab2
{
    internal class Structure : Component
    {
        public List<Personal> personals { get; set; }
        private List<Component> _children = new List<Component>();
        public Structure(string name) : base(name) { }
        public void Add(Component component)
        {
            _children.Add(component);
        }
        public void Remove(Component component)
        {
            _children.Remove(component);
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new String('/', depth) + this.Name);
            foreach (Component component in _children)
            {
                component.Display(depth + 1);
            }
            
        }

        public override string Operation()
        {
            throw new NotImplementedException();
        }
    }
}
