using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Héritage
{
    internal abstract class Biped : Animal
    {
        protected Biped(string name) : base(name, 2)
        {

        }

        public override void Move()
        {
            Console.WriteLine("Moving like a biped...");
        }
    }
}
