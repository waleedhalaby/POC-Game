using Game.model.disasters;
using Game.model.events;
using Game.simulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.model.people
{
    public class Citizen : Rescuable, Simulatable
    {
        private SOSListener EmergencyService;
        public WorldListener WorldListener { get; set; }
        public CitizenState State { get; set; }
        public Address Location { get; set; }
        public Disaster Disaster { get; }
        public string NationalID { get; }
        public string Name { get; }
        public int Age { get; }
        public int HP { get; set; }
        public int BloodLoss { get; set; }
        public int Toxicity { get; set; }
        public Citizen(Address location, string nationalID, string name, int age)
        {
            Location = location;
            NationalID = nationalID;
            Name = name;
            Age = age;
            State = CitizenState.SAFE;
            HP = 100;
            BloodLoss = 0;
            Toxicity = 0;
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

        public void CycleStep()
        {
            if (BloodLoss > 0 && BloodLoss < 30)
                SetHp(HP - 5);
            if (Toxicity > 0 && Toxicity < 30)
                SetHp(HP - 5);

            if (BloodLoss >= 30 && BloodLoss < 70)
                SetHp(HP - 10);
            if (Toxicity >= 30 && Toxicity < 70)
                SetHp(HP - 10);

            if (BloodLoss >= 70)
                SetHp(HP - 15);
            if (Toxicity >= 70)
                SetHp(HP - 15);
        }

        public void SetHp(int hp)
        {
            if (hp >= 0 && hp <= 100)
                HP = hp;
            if (HP == 0)
                State = CitizenState.DECEASED;
        }

        public void SetBloodLoss(int bloodLoss)
        {
            if (bloodLoss >= 0 && bloodLoss <= 100)
                BloodLoss = bloodLoss;
            if (BloodLoss == 100)
                SetHp(0);
        }

        public void SetToxicity(int toxicity)
        {
            if (toxicity >= 0 && toxicity <= 100)
                Toxicity = toxicity;
            if(Toxicity == 100)
                SetHp(0);
        }
    }
}
