using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Héritage
{
    internal abstract class Quadruped : Animal
    {
        protected Quadruped(string name) : base(name, 4)
        {

        }

        public override void Move()
        {
            Console.WriteLine("Moving like a quadruped...");
        }
    }
}
