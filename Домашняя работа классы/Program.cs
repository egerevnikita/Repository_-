using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Домашняя_работа_классы
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите число стороны a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число стороны b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число стороны c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            treygolnyk triangle = new treygolnyk(a, b, c);
            if (triangle.Proverka())
            {
                Console.WriteLine("Площадь треугольника по методу Герона равна: " + triangle.Vychyslenia());
            }
            else
            {
                Console.WriteLine("Не может быть треугольника с такими сторонами");
            }

            Console.ReadKey();
        }
        class treygolnyk
        {
         double a; 
         double b;
         double c;
        public treygolnyk(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public bool Proverka()
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }
        public double Vychyslenia()
        {
            double p = (a + b + c) / 2;
            double geron = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return geron;
       
        }
    }

    
    }
}
