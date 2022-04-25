using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STP_ISS_analyzer.Models
{
    internal class Position
    {
        
        public List<Transition> transitionsList = new List<Transition>();

        public string Name { get; }

        public Position(string name)
        {
            Name = name;

            transitionsList = new List<Transition>();
        }
    }
}
