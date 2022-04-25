using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STP_ISS_analyzer.Models
{
    public class Position
    {
        
        public List<Transition> transitionsList = new List<Transition>();

        public int id { get; set; }
        public string name { get; set; }
        public int chipAmount { get; set; }


        public Position(string name, int id)
        {
            this.name = name;
            this.id = id;

            transitionsList = new List<Transition>();
        }

        public void AddChip(int ammountToAdd)
        {
            this.chipAmount += ammountToAdd;
        }

    }
}
