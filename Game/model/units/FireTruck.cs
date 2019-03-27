using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.simulation;

namespace Game.model.units
{
    public class FireTruck : FireUnit
    {
        public FireTruck(string id, Address location, int stepsPerCycle) : base(id, location, stepsPerCycle)
        {
        }
    }
}
