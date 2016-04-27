using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partyPlanCalc
{
    class Party
    {
        // constant for food cost
        public const int CostOfFoodPerPerson = 25;

        // class fields:
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }

        // calculators:
        private decimal CalculateCostOfDecoration()
        {
            decimal costOfDecorations;
            if (FancyDecorations)
                costOfDecorations = (NumberOfPeople * 15.00M) + 50.00M;
            else
                costOfDecorations = (NumberOfPeople * 7.50M) + 30.00M;
            return costOfDecorations;
        }

        virtual public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecoration();
                totalCost += NumberOfPeople * CostOfFoodPerPerson;

                if (NumberOfPeople > 12)
                    totalCost += 100.00M;

                return totalCost;
            }
        }
    }
}
