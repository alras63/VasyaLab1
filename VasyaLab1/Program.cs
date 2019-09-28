using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VasyaLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вариант 14
            Console.WriteLine("Привет! Введите неотрицательное число (радиус)");

            string radiusS = Console.ReadLine();

            double radiusD;

            if (Double.TryParse(radiusS, out radiusD) && radiusD > 0)
            {

                //условие треугольника: x<0; y<0; y>=-R; x>=-R
                //условие окружности: x>0; y>0; x^2+y^2<=R^2

                Console.WriteLine("Введите произвольную координату X точки");
                string xStr = Console.ReadLine();

                Console.WriteLine("Введите произвольную координату Y точки");
                string yStr = Console.ReadLine();

                double x, y;
                if (Double.TryParse(xStr, out x) && Double.TryParse(yStr, out y))
                {
                    if ((x < 0 && y < 0 && y > -radiusD && x > -radiusD) || (x > 0 && y > 0 && Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(radiusD, 2)))
                    {
                        Console.WriteLine("Точка с заданными координатами попадает в закрашенную область");
                    }
                    else
                    {
                        Console.WriteLine("Точка с заданными координатами НЕ попадает в закрашенную область");

                    }
                }
                else
                {
                    Console.WriteLine("Ваше число не соответствует требованиям");
                }
            }
            else
            {
                Console.WriteLine("Ваше число не соответствует требованиям");
            }
            Console.ReadLine();
        }
    }
}
