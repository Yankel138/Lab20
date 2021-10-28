using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20
{
    class Program
    {
        delegate double MyDelegate(double rad);
        static void Main(string[] args)
        {
            Console.Write("Введите радиус: ");
            double rad = Convert.ToDouble(Console.ReadLine());
            MyDelegate myDelegate = new MyDelegate(Length);
            Console.WriteLine($"Длина окружности с радиусом {rad} = {myDelegate?.Invoke(rad):f2}");
            myDelegate += Square;
            Console.WriteLine($"Площадь круга с радиусом {rad} = {myDelegate?.Invoke(rad):f2}");
            myDelegate += Volume;
            Console.WriteLine($"Объем шара с радиусом {rad} = {myDelegate?.Invoke(rad):f2}");

            Console.ReadKey();
        }



        static double Length(double rad)
        {
            return 2 * Math.PI * rad;
        }

        static double Square(double rad)
        {
            return Math.PI * rad * rad;
        }

        static double Volume(double rad)
        {
            return Math.PI * Math.Pow(rad, 3) * 4 / 3;
        }
    }
}
