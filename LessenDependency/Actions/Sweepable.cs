using LessenDependency.Actions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessenDependency.Actions
{
    internal class Sweepable : IAction
    {
        public void Action()
        {
            this.Sweep();
        }

        public void Sweep()
        {
            Console.WriteLine("Sweep");
        }
    }
}
