using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS_SAM5
{
    public class Balcony : Addition
    {
        double balconySquare;

        public Balcony(Building theBuilding, double balconySquare):base(theBuilding)
        {
            this.balconySquare = balconySquare;
        }

        public override string GetInfo()
        {
            return theBuilding.GetInfo() + $"Лоджия площадью {balconySquare}\n";
        }

        public override double GetMonthlyPayment()
        {
            return theBuilding.GetMonthlyPayment() + balconySquare * 5;
        }

        public override double GetRepairCost()
        {
            return theBuilding.GetRepairCost() + balconySquare * 20;
        }
    }
}
