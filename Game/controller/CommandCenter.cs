using Game.model.infrastructure;
using Game.model.people;
using Game.model.units;
using Game.simulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.controller
{
    public class CommandCenter
    {
        private Simulator _engine;
        private List<ResidentialBuilding> _visibleBuildings;
        private List<Citizen> _visibleCitizens;
        private List<Unit> _emergencyUnits;

        public CommandCenter()
        {

        }
    }
}
