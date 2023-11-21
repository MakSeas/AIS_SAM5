using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS_SAM5
{
    public class Cottage : Building
    {
        int floorsNumber;
        double teritorrySqaure;

        public Cottage(string adress, double square, double teritorrySquare,int floorsNumber):base(adress, square)
        {
            this.floorsNumber = floorsNumber;
            this.teritorrySqaure = teritorrySquare;
        }

        public override string GetInfo()
        {
            return $"Коттедж расположен по адрессу {adress}\n" +
                $" Площадь коттеджа = {square}\n" +
                $" Плоащдь участка = {teritorrySqaure}\n" +
                $" Число этажей коттеджа = {floorsNumber}\n" +
                $" Кварпалата: {GetMonthlyPayment()}\n" +
                $" Стоимость ремонта: {GetRepairCost()}";
        }

        public override double GetMonthlyPayment()
        {
            return ((square * floorsNumber) + teritorrySqaure) * 2;
        }

        public override double GetRepairCost()
        {
            return (teritorrySqaure + (square * floorsNumber)) * 20;
        }
    }
}
