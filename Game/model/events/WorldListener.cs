using Game.simulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.model.events
{
    public interface WorldListener
    {
        void AssignAddress(Simulatable sim, int x, int y);
    }
}
