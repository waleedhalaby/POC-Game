using Game.simulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.model.disasters
{
    public class Disaster
    {
        public int StartCycle { get; }
        public Rescuable Target { get; }
        public bool Active { get; set; }

        public Disaster(int startCycle, Rescuable target)
        {
            StartCycle = startCycle;
            Target = target;
        }

        public virtual void Strike()
        {
            Target.StruckBy(this);
        }

        public virtual void CycleStep()
        {

        }
    }
}
