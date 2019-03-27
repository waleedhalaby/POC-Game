using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.simulation;
using Game.model.infrastructure;

namespace Game.model.disasters
{
    public class Collapse : Disaster
    {
        private ResidentialBuilding _target;
        private int _cycle;
        public Collapse(int cycle, ResidentialBuilding target) : base(cycle, target)
        {
            _cycle = cycle;
            _target = target;
        }

        public override void Strike()
        {
            _target.SetFoundationDamage(_target.FoundationDamage + 10);
        }

        public override void CycleStep()
        {
            _target.SetFoundationDamage(_target.FoundationDamage + 10);
        }
    }
}
