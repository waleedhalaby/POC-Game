using Game.model.people;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.model.disasters
{
    public class Injury : Disaster
    {
        private Citizen _target;
        private int _cycle;
        public Injury(int cycle, Citizen target) : base(cycle, target)
        {
            _cycle = cycle;
            _target = target;
        }

        public override void Strike()
        {
            _target.SetBloodLoss(_target.BloodLoss + 30);
        }

        public override void CycleStep()
        {
            _target.SetBloodLoss(_target.BloodLoss + 10);
        }
    }
}
