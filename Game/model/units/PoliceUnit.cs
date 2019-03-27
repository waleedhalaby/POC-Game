using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.simulation;
using Game.model.people;

namespace Game.model.units
{
    public class PoliceUnit : Unit
    {
        public List<Citizen> Passengers { get; }
        public int MaxCapacity { get; }
        public int DistanceToBase { get; set; }
        public PoliceUnit(string id, Address location, int stepsPerCycle, int maxCapacity) : base(id, location, stepsPerCycle)
        {
            MaxCapacity = maxCapacity;
        }
    }
}
