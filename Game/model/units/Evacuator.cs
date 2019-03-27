using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.simulation;

namespace Game.model.units
{
    public class Evacuator : PoliceUnit
    {
        public Evacuator(string id, Address location, int stepsPerCycle, int maxCapacity) : base(id, location, stepsPerCycle, maxCapacity)
        {
        }
    }
}
