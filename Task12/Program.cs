using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            Сircle.Length(2.5);
            Сircle.Square(5);
            Сircle.Point(3, 10, -10, 3, 2);
            Console.ReadKey();
        }
    }
    public static class Сircle
    {

        public static void Length(double r)
        {
            double c = 2 * Math.PI * r;
            Console.WriteLine("Длина окружности: с={0:F2}", c);
        }
        public static void Square(double r)
        {
            double S = Math.PI * Math.Pow(r, 2);
            Console.WriteLine("Площадь окружности: S={0:F2}", S);
        }
        public static void Point(double r, double x, double y, double x0, double y0)
        {
            double CheckPoint = Math.Sqrt(Math.Pow((x - x0), 2) + Math.Pow((y - y0), 2));
            if (CheckPoint < r)
            {
                Console.WriteLine("Точка принадлежит окружности");
            }
            else
            {
                if (CheckPoint == r)
                {
                    Console.WriteLine("Точка располагается на окружности");
                }
                else
                {
                    Console.WriteLine("Точка НЕ принадлежит окружности");
                }
            }
        }
    }
}
    

