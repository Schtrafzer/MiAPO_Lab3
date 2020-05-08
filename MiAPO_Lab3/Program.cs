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
            Console.WriteLine("Введите длинну ребра куба в сантиметрах:");
            double A = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Объем куба равен " + Math.Pow(A, 3) + " кубических сантиметров.");

            Console.WriteLine("Площадь поверхности куба равно " + 6 * Math.Pow(A, 2) + " квадратных сантиметров.");
            Console.ReadLine();
        }
    }
}
