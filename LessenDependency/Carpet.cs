using LessenDependency.Actions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessenDependency
{
    internal class Carpet
    {

        public Carpet(params IAction[] actions)
        {
            this.actions.AddRange(actions);
        }

        public int Width { get; set; }

        public List<IAction> actions = new List<IAction>();


    }
}
