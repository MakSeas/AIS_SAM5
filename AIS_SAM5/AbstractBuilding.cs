using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS_SAM5
{
    public abstract class Building
    {
        public string adress;
        public double square; 

        public Building(string adress, double square)
        {
            this.adress = adress;
            this.square = square;
        }

        public Building()
        {

        }

        public abstract string GetInfo();

        public abstract double GetRepairCost();

        public abstract double GetMonthlyPayment();
    }
}
