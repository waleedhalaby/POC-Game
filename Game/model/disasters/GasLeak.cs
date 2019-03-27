using Game.model.infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.model.disasters
{
    public class GasLeak : Disaster
    {
        private ResidentialBuilding _target;
        private int _cycle;
        public GasLeak(int cycle, ResidentialBuilding target) : base(cycle, target)
        {
            _cycle = cycle;
            _target = target;
        }

        public override void Strike()
        {
            _target.SetGasLevel(_target.GasLevel + 15);
        }

        public override void CycleStep()
        {
            _target.SetGasLevel(_target.GasLevel + 15);
        }
    }
}
