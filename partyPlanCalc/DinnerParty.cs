using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partyPlanCalc
{
    class DinnerParty : Party
    {
        // class fields:
        public bool HealthyOption { get; set; }

        // constructor:
        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecoration)
        {
            NumberOfPeople = numberOfPeople;
            HealthyOption = healthyOption;
            FancyDecorations = fancyDecoration;
        }

        // calculators:
        private decimal CalculateCostOfBeveragesPerPerson()
        {
            decimal costOfBeveragesPerPerson;
            if (HealthyOption)
                costOfBeveragesPerPerson = 5.00M;
            else
                costOfBeveragesPerPerson = 20.00M;
            return costOfBeveragesPerPerson;
        }

        override public decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                if (HealthyOption)
                    totalCost *= 0.95M;
                return totalCost;
            }
        }

    }
}
