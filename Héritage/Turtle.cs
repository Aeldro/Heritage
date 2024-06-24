using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Héritage
{
    internal class Turtle : Quadruped
    {
        public Turtle(string name) : base(name)
        {

        }

        public override void Move()
        {
            Console.WriteLine("Moving like a turtle...so slow...");
        }
    }
}
