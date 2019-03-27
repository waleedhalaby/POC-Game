using Game.model.disasters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.simulation
{
    public interface Rescuable
    {
        void StruckBy(Disaster d);
        Address GetLocation();
        Disaster GetDisaster();
    }
}
