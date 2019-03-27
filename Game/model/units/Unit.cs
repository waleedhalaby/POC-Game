using Game.simulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.model.events;
using Game.model.people;

namespace Game.model.units
{
    public class Unit : Simulatable, SOSResponder
    {
        public int DistanceToTarget { get; set; }
        public WorldListener WorldListener { get; set; }

        public string UnitID { get; }
        public UnitState UnitState { get; set; }
        public Address Location { get; set; }
        public Rescuable Target { get; set; }
        public int StepsPerCycle { get; }
        public Unit(string id, Address location, int stepsPerCycle)
        {
            UnitID = id;
            Location = location;
            StepsPerCycle = stepsPerCycle;
            UnitState = UnitState.IDLE;
        }

        public void CycleStep()
        {
            if(UnitState != UnitState.IDLE && Target != null)
            {
                if(DistanceToTarget + StepsPerCycle > 0)
                    DistanceToTarget -= StepsPerCycle;
                else if(DistanceToTarget == 0)
                {
                    Treat();
                }
            }
        }

        public virtual void Treat()
        {
            UnitState = UnitState.TREATING;
        }

        public void JobsDone()
        {
            UnitState = UnitState.IDLE;
        }

        public void Respond(Rescuable r)
        {
            Target = r;
            UnitState = UnitState.RESPONDING;
            //Set Distance To Target
        }
    }
}
