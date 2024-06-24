using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Héritage
{
    internal abstract class Animal
    {
        public string _name;
        protected int _legsCount;
        protected Animal(string name, int legsCount)
        {
            this._name = name;
            this._legsCount = legsCount;
        }
        public virtual void Move()
        {
            Console.WriteLine("Moving like an animal...");
        }

        public virtual void Eat()
        {
            Console.WriteLine("Nom nom nom...");
        }
    }
}