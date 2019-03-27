using Game.model.people;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.model.disasters
{
    public class Infection : Disaster
    {
        private Citizen _target;
        private int _cycle;
        public Infection(int cycle, Citizen target) : base(cycle, target)
        {
            _cycle = cycle;
            _target = target;
        }

        public override void Strike()
        {
            _target.SetToxicity(_target.Toxicity + 25);
        }

        public override void CycleStep()
        {
            _target.SetToxicity(_target.Toxicity + 15);
        }
    }
}
