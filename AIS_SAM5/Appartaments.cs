using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS_SAM5
{
    public class Appartaments : Building
    {
        int floor;

        public Appartaments(string adress, double square, int floor) : base(adress,square)
        {
            this.floor = floor;
        }

        public override string GetInfo()
        {
            return $"Квартира расположена по адрессу {adress} на {floor} этаже.\n" +
                $"Площадь квартиры = {square}\n" +
                $"Кварплата: {GetMonthlyPayment()}\n" +
                $"Стоимость ремонта: {GetRepairCost()}\n";
        }

        public override double GetMonthlyPayment()
        {
            return (square*5)+(floor * 2);
        }

        public override double GetRepairCost()
        {
            return (square*20) + floor * 3;
        }
    }
}
