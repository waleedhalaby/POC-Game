using Game.model.disasters;
using Game.model.events;
using Game.model.people;
using Game.simulation;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.model.infrastructure
{
    public class ResidentialBuilding : Simulatable,Rescuable
    {
        private Random rand;
        private SOSListener EmergencyService;
        public Address Location { get; }
        public int StructuralIntegrity { get; set; }
        public int FireDamage { get; set; }
        public int GasLevel { get; set; }
        public int FoundationDamage { get; set; }
        public List<Citizen> Occupants { get; }
        public Disaster Disaster { get; }
        public ResidentialBuilding(Address location)
        {
            rand = new Random();
            Location = location;
            StructuralIntegrity = 100;
            FireDamage = 0;
            GasLevel = 0;
            FoundationDamage = 0;
        }

        public void CycleStep()
        {
            if (FoundationDamage > 0)
                SetStructuralIntegrity(StructuralIntegrity - rand.Next(5,10));

            if (FireDamage > 0 && FireDamage < 30)
                SetStructuralIntegrity(StructuralIntegrity - 3);
            if (FireDamage >= 30 && FireDamage < 70)
                SetStructuralIntegrity(StructuralIntegrity - 5);
            if (FireDamage >= 70)
                SetStructuralIntegrity(StructuralIntegrity - 7);
        }

        public void StruckBy(Disaster d)
        {
            EmergencyService.ReceiveSOSCall(d.Target);
        }

        public Address GetLocation()
        {
            return Location;
        }

        public Disaster GetDisaster()
        {
            return Disaster;
        }

        public void SetStructuralIntegrity(int structuralIntegrity)
        {
            if (structuralIntegrity >= 0)
                StructuralIntegrity = structuralIntegrity;
            if (StructuralIntegrity == 0)
            {
                foreach (var citizen in Occupants)
                    citizen.SetHp(0);
            }
        }

        public void SetFireDamage(int fireDamage)
        {
            if (fireDamage >= 0 && fireDamage <= 100)
                FireDamage = fireDamage;
        }

        public void SetGasLevel(int gasLevel)
        {
            if (gasLevel >= 0 && gasLevel <= 100)
                GasLevel = gasLevel;
            if (GasLevel == 100)
            {
                foreach (var citizen in Occupants)
                    citizen.SetHp(0);
            }
        }

        public void SetFoundationDamage(int foundationDamage)
        {
            if (foundationDamage >= 100)
                SetStructuralIntegrity(0);
        }
    }
}
