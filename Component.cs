using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgPatternsLab2
{
    abstract class Component
    {
        public Component() { }

        public string Name { get; set; }

        public abstract string Operation();

        public abstract void Display(int depth);

        public virtual void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(Component component)
        {
            throw new NotImplementedException();
        }

        
        public virtual bool IsComposite()
        {
            return true;
        }
        public Component(string name)
        {
            Name = name;
        }
    }
}
