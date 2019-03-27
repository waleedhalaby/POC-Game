using Game.model.disasters;
using Game.model.events;
using Game.model.infrastructure;
using Game.model.people;
using Game.model.units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.simulation
{
    public class Simulator : WorldListener
    {
        private int _currentCycle;
        private List<ResidentialBuilding> _buildings;
        private List<Citizen> _citizens;
        private List<Disaster> _plannedDisasters;
        private List<Disaster> _executedDisasters;
        private Address[][] _world;
        public List<Unit> EmergencyUnits { get; }

        public Simulator()
        {

        }

        public bool CheckGameOver()
        {
            if (_plannedDisasters.Count() == 0 && 
                (_citizens.Count() > 0 || _buildings.Count() > 0) && //ALIVE CITIZENS OR NOT DESTROYED BUILDINGS
                EmergencyUnits.Count(x => x.UnitState != UnitState.IDLE) > 0)
                return false;
            return true;
        }

        public int CalculateCasualties()
        {
            return _citizens.Count(x => x.State == CitizenState.DECEASED);
        }

        public void NextCycle()
        {
            //Implement it ur own
        }

        private void loadUnits(string filePath)
        {

        }

        private void loadBuildings(string filePath)
        {

        }

        private void loadCitizens(string filePath)
        {

        }

        private void loadDisasters(string filePath)
        {

        }

        public void AssignAddress(Simulatable sim, int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
