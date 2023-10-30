using LessenDependency.Actions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessenDependency.Actions
{
    internal class ArtExhibit : IAction
    {
        public void Exhibit()
        {
            Console.WriteLine("Exhibit");
        }

        public void Action()
        {
            this.Exhibit();
        }


    }
}
