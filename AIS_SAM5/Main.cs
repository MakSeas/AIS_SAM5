using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmimatedTextWriter;

//Копирайт : Гришин Максим Андреевич ИТБ-212.

namespace AIS_SAM5
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Building> buildings = new List<Building>();
            AnimatedTextWriter.enableAnimation = false;
            
            int textDrawingTime = 15;

            while (true)
            {
                AnimatedTextWriter.WriteAnimatedText("\nДоступны основные действия: \n" +
                    "0 - Создать объект недвижимости\n" +
                    "1 - Действия с существующими объектами недвижимости\n", textDrawingTime, true);            

                

                int mainAction = int.Parse(Console.ReadLine());

                switch (mainAction)
                {
                    case 0:
                        {
                            bool creation=true;

                            while (creation)
                            {
                                AnimatedTextWriter.WriteAnimatedText("\nДоступны для создания:\n" +
                                    "0 - Квартира\n" +
                                    "1 - Коттедж\n" +
                                    "2 - Вернуться к выбору основных действий\n", textDrawingTime, true);                            

                                int creationAction = int.Parse(Console.ReadLine());

                                switch (creationAction)
                                {
                                    case 0:
                                        {
                                            AnimatedTextWriter.WriteAnimatedText("\nСоздание квартиры:", textDrawingTime, true);
                                            AnimatedTextWriter.WriteAnimatedText("Введите адресс квартиры: ", textDrawingTime, false);

                                            string adress = Console.ReadLine();
                                            AnimatedTextWriter.WriteAnimatedText("Введите площадь квартиры: ", textDrawingTime, false);
                                            double square = double.Parse(Console.ReadLine());
                                            AnimatedTextWriter.WriteAnimatedText("Введите этаж квартиры: ", textDrawingTime, false);
                                            int floor = int.Parse(Console.ReadLine());

                                            buildings.Add(new Appartaments(adress, square, floor));
                                            AnimatedTextWriter.WriteAnimatedText("Квартира создана", textDrawingTime, true);
                                        }
                                        break;
                                    case 1:
                                        {
                                            AnimatedTextWriter.WriteAnimatedText("\nСоздание коттеджа:", textDrawingTime, true);
                                            AnimatedTextWriter.WriteAnimatedText("Введите адресс коттеджа: ", textDrawingTime, false);
                                            string adress = Console.ReadLine();

                                            AnimatedTextWriter.WriteAnimatedText("Введите площадь участка: ", textDrawingTime, false);
                                            double areaSquare = double.Parse(Console.ReadLine());
                                            AnimatedTextWriter.WriteAnimatedText("Введите площадь коттеджа: ", textDrawingTime, false);
                                            double square = double.Parse(Console.ReadLine());
                                            AnimatedTextWriter.WriteAnimatedText("Введите кол-во этажей коттеджа: ", textDrawingTime, false);
                                            int floor = int.Parse(Console.ReadLine());

                                            buildings.Add(new Cottage(adress, square, areaSquare, floor));
                                            AnimatedTextWriter.WriteAnimatedText("Коттедж создан", textDrawingTime, true);
                                        }
                                        break;
                                    case 2:
                                        {
                                            creation = false;
                                        }
                                        break;
                                }
                            }
                        }
                        break;
                    case 1:
                        {
                            

                            if (buildings.Count() == 0)
                                AnimatedTextWriter.WriteAnimatedText("\nНедвижимость отсутствует", textDrawingTime, true);
                            else
                            {
                                AnimatedTextWriter.WriteAnimatedText("\nВыберете объект недвижимости: ", textDrawingTime, true);

                                int k = 0;

                                foreach(Building building in buildings)
                                {

                                    AnimatedTextWriter.WriteAnimatedText($"{k} - {building.GetInfo()}", textDrawingTime, true);

                                    k++;
                                }

                                AnimatedTextWriter.WriteAnimatedText($"{k} - Вернуться к основным действиям", textDrawingTime, true);

                                int act = int.Parse(Console.ReadLine());

                               
                                    if (act < k)
                                    {
                                        bool buildingActions = true;

                                        while (buildingActions)
                                        {
                                            AnimatedTextWriter.WriteAnimatedText($"\n{buildings[act].GetInfo()}\n", textDrawingTime, true);

                                            AnimatedTextWriter.WriteAnimatedText($"\n0 - Пристроить лоджию\n" +
                                                $"1 - Установить счетчики\n" +
                                                $"2 - Установить натяжной потолок\n" +
                                                $"3 - Провести кабельное ТВ\n" +
                                                $"4 - Показать информацию\n" +
                                                $"5 - Вернуться к выбору объекта недвижимости\n", textDrawingTime, true);

                                             int objectAction = int.Parse(Console.ReadLine());

                                            switch (objectAction)
                                            {
                                                case 0:
                                                {
                                                    AnimatedTextWriter.WriteAnimatedText($"\nВведите площадь лоджии: ", textDrawingTime, false);
                                                    double sqr = double.Parse(Console.ReadLine());

                                                    buildings[act] = new Balcony(buildings[act], sqr);
                                                    AnimatedTextWriter.WriteAnimatedText($"\nЛоджия добавлена", textDrawingTime, false);
                                                }
                                                break;
                                                case 1:
                                                {
                                                    AnimatedTextWriter.WriteAnimatedText($"\nВведите показания счетчиков: ", textDrawingTime, false);
                                                    double dat = double.Parse(Console.ReadLine());

                                                    buildings[act] = new Counter(buildings[act], dat);
                                                    AnimatedTextWriter.WriteAnimatedText($"\nСчетчики добавлены", textDrawingTime, false);
                                                }
                                                break;
                                                case 2: 
                                                {
                                                    AnimatedTextWriter.WriteAnimatedText($"\nВведите площадь потолка: ", textDrawingTime, false);
                                                    double sqr = double.Parse(Console.ReadLine());

                                                    buildings[act] = new HangedCeiling(buildings[act], sqr);
                                                    AnimatedTextWriter.WriteAnimatedText($"\nНатяжной потолок добавлен", textDrawingTime, false);
                                                }
                                                break;
                                                case 3:
                                                {
                                                    AnimatedTextWriter.WriteAnimatedText($"\nВведите тариф на телевидение: ", textDrawingTime, false);
                                                    double pay = double.Parse(Console.ReadLine());

                                                    buildings[act] = new CabelTV(buildings[act], pay);
                                                    AnimatedTextWriter.WriteAnimatedText($"\nКабельное ТВ добавлено", textDrawingTime, false);
                                                }
                                                break;
                                                case 4:
                                                {
                                                    AnimatedTextWriter.WriteAnimatedText($"\n{buildings[act].GetInfo()}", textDrawingTime, true);                                            
                                                }break;
                                                case 5:
                                                {
                                                    buildingActions = false;
                                                }
                                                break;
                                            }
                                        }   
                                    }                          
                            }
                        }
                        break;
                }
            }
        }
    }
}
