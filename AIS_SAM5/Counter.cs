using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS_SAM5
{
    public class Counter : Addition
    {
        double data;

        public Counter(Building theBuilding, double data) : base(theBuilding)
        {
            this.data = data;
        }

        public override string GetInfo()
        {
            return theBuilding.GetInfo()+$"Счетчик воды и электроэнергии. Показания: {data}\n";
        }

        public override double GetMonthlyPayment()
        {
            return theBuilding.GetMonthlyPayment() - data * 2;
        }

        public override double GetRepairCost()
        {
            return theBuilding.GetRepairCost() - data * 2;
        }
    }
}
