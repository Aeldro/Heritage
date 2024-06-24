using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Héritage
{
    internal class Human : Biped
    {
        public Human(string name) : base(name)
        {

        }

        public override void Move()
        {
            Console.WriteLine("Moving like a human...");
        }
    }
}
