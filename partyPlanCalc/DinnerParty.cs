using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partyPlanCalc
{
    public class DinnerParty
    {
        // constant for food cost
        public const int CostOfFoodPerPerson = 25;

        // class fields
        // v1:
        // private int NumberOfPeople;
        // public decimal CostOfBeveragesPerPerson;
        // public decimal CostOfDecorations = 0;
        //public int GetNumberOfPeople()
        //{
        //    return NumberOfPeople;
        //}

        // v2:
        public int NumberOfPeople { get; set; }
        public bool FancyDecoration { get; set; }
        public bool HealthyOption { get; set; }

        // constructor
        // v1:
        //public void SetPartyOptions(int people, bool fancy)
        //{
        //    NumberOfPeople = people;
        //    CalculateCostOfDecorations(fancy);
        //}

        // v2:
        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecoration)
        {
            NumberOfPeople = numberOfPeople;
            HealthyOption = healthyOption;
            FancyDecoration = fancyDecoration;
        }

        // calculators
        // v1:
        //public void SetHeathyOption(bool healthyOn)
        //{
        //    if (healthyOn)
        //    {
        //        CostOfBeveragesPerPerson = 5.00M;
        //    }
        //    else
        //    {
        //        CostOfBeveragesPerPerson = 20.00M;
        //    }
        //}
        //
        //public void CalculateCostOfDecorations(bool fancyOn)
        //{
        //    if (fancyOn)
        //    {
        //        CostOfDecorations = (NumberOfPeople * 15.00M) + 50.00M;
        //    }
        //    else
        //    {
        //        CostOfDecorations = (NumberOfPeople * 7.50M) + 30.00M;
        //    }
        //}
        //
        //public decimal CalculateCost(bool healthyOn)
        //{
        //    decimal totalCost = (NumberOfPeople * (CostOfFoodPerPerson + CostOfBeveragesPerPerson)) +
        //        CostOfDecorations;

        //    if (healthyOn)
        //    {
        //        return 0.95M * totalCost;
        //    }
        //    else
        //    {
        //        return totalCost;
        //    }
        //}

        // v2:
        private decimal CalculateCostOfDecoration()
        {
            decimal costOfDecorations;
            if (FancyDecoration)
            {
                costOfDecorations = (NumberOfPeople * 15.00M) + 50.00M;
            }
            else
            {
                costOfDecorations = (NumberOfPeople * 7.50M) + 30.00M;
            }

            return costOfDecorations;
        }

        private decimal CalculateCostOfBeveragesPerPerson()
        {
            decimal costOfBeveragesPerPerson;
            if (HealthyOption)
            {
                costOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                costOfBeveragesPerPerson = 20.00M;
            }

            return costOfBeveragesPerPerson;
        }

        public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecoration();
                totalCost += (NumberOfPeople * 
                    (CostOfFoodPerPerson + CalculateCostOfBeveragesPerPerson()));

                if (HealthyOption)
                {
                    totalCost *= 0.95M;
                }

                if (NumberOfPeople > 12)
                    totalCost += 100.00M;

                return totalCost;
            }
        }

    }
}
