using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS_SAM5
{
    public class CabelTV : Addition
    {
        double payment;

        public CabelTV(Building theBuilding, double payment) : base(theBuilding)
        {
            this.payment = payment;
        }

        public override string GetInfo()
        {
            return theBuilding.GetInfo() + $"Кабельное телевидение с тарифом {payment}\n";
        }

        public override double GetMonthlyPayment()
        {
            return theBuilding.GetMonthlyPayment() + payment;
        }

        public override double GetRepairCost()
        {
            return theBuilding.GetRepairCost();
        }
    }
}
