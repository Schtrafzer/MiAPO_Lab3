using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiAPO_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер фигуры, для которой нужно рассчитать объем:");
            Console.WriteLine("1 - Куб");
            Console.WriteLine("2 - Шар");
            Console.WriteLine("3 - Цилиндр");
            Console.WriteLine("4 - Конус");
            Console.WriteLine("5 - Пирамида");

            Geometry Volume_calculation = new Geometry();
            int Task_number = Convert.ToInt32(Console.ReadLine());
            switch (Task_number)
            {
                case 1:
                    Console.Clear();
                    Volume_calculation.Cybe();
                    break;
                case 2:
                    Console.Clear();
                    Volume_calculation.Ball();
                    break;
                case 3:
                    Console.Clear();
                    Volume_calculation.Cylinder();
                    break;
                case 4:
                    Console.Clear();
                    Volume_calculation.Cone();
                    break;
                case 5:
                    Console.Clear();
                    Volume_calculation.Pyramid();
                    break;
                default:
                    Console.WriteLine("Такого номера фигуры не существует.");
                    break;
            }

            Console.ReadLine();
        }

    }
}
