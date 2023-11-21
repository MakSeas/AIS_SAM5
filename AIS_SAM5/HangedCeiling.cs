using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS_SAM5
{
    public class HangedCeiling : Addition
    {
        double ceilingSquare;

        public HangedCeiling(Building theBuilding, double ceilingSquare) : base(theBuilding)
        {
            this.ceilingSquare=ceilingSquare;
        }

        public override string GetInfo()
        {
            return theBuilding.GetInfo()+$"Навесной потолок площадью {ceilingSquare}\n";
        }

        public override double GetMonthlyPayment()
        {
            return theBuilding.GetMonthlyPayment() + ceilingSquare * 2;
        }

        public override double GetRepairCost()
        {
            return theBuilding.GetRepairCost() + ceilingSquare * 10;
        }
    }
}
