using Game.model.infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.model.disasters
{
    public class Fire : Disaster
    {
        private ResidentialBuilding _target;
        private int _cycle;
        public Fire(int cycle, ResidentialBuilding target) : base(cycle, target)
        {
            _cycle = cycle;
            _target = target;
        }

        public override void Strike()
        {
            _target.SetFireDamage(_target.FireDamage + 10);
        }

        public override void CycleStep()
        {
            _target.SetFireDamage(_target.FireDamage + 10);
        }
    }
}
