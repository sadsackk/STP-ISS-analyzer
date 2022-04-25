using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STP_ISS_analyzer.Models
{
    public class Transition
    {
        public List<Position> positionList = new List<Position>();

        public string Name { get; }

        public Transition(string name)
        {
            Name = name;
            positionList = new List<Position>();
        }
    }
}
