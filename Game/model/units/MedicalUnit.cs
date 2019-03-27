using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.simulation;
using Game.model.people;
using Game.model.infrastructure;

namespace Game.model.units
{
    public class MedicalUnit : Unit
    {
        private int _healingAmount;
        public int TreatmentAmount { get; }
        public MedicalUnit(string id, Address location, int stepsPerCycle) : base(id, location, stepsPerCycle)
        {
            TreatmentAmount = 10;
            _healingAmount = 10;
        }

        public override void Treat()
        {
            base.Treat();
            if (Target.GetType() == typeof(Citizen))
            {
                ((Citizen)Target).SetBloodLoss(((Citizen)Target).BloodLoss - TreatmentAmount);
                ((Citizen)Target).SetToxicity(((Citizen)Target).Toxicity - TreatmentAmount);
                if (((Citizen)Target).BloodLoss == 0 && ((Citizen)Target).Toxicity == 0)
                    Heal();
            }

            //Implement for Resendential Building
        }

        public void Heal()
        {
            if (Target.GetType() == typeof(Citizen))
            {
                ((Citizen)Target).SetHp(((Citizen)Target).HP + _healingAmount);
                if (((Citizen)Target).BloodLoss == 100)
                {
                    ((Citizen)Target).State = CitizenState.RESCUED;
                    JobsDone();
                }
            }
        }
    }
}
