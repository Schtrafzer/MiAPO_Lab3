using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiAPO_Lab3
{
    class Geometry
    {
        public void Cybe()
        {
            Console.WriteLine("Введите длинну ребра куба в сантиметрах:");
            double A = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Объем куба равен " + Math.Pow(A, 3) + " кубических сантиметров.");
        }

        public void Ball()
        {
            Console.WriteLine("Введите радиус шара в сантиметрах:");
            double R = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Объем шара равен " + (4 * (3.14 * Math.Pow(R, 3)) / 3) + " кубических сантиметров.");
        }

        public void Cylinder()
        {
            Console.WriteLine("Введите радиус основания цилиндра в сантиметрах:");
            double R = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите высоту цилиндра в сантиметрах:");
            double H = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Объем цилиндра равен " + (3.14 * Math.Pow(R,2) * H) + " кубических сантиметров.");
        }

        public void Cone()
        {
            Console.WriteLine("Введите радиус основания конуса в сантиметрах:");
            double R = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите высоту конуса в сантиметрах:");
            double H = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Объем конуса равен " + ((3 * 3.14 * Math.Pow(R, 2) * H) / 3) + " кубических сантиметров.");
        }

        public void Pyramid()
        {
            Console.WriteLine("Введите длинну ребра A основания пирамиды в сантиметрах:");
            double A = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите длинну ребра B основания пирамиды в сантиметрах:");
            double B = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите высоту пирамиды в сантиметрах:");
            double H = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Объем пирамиды равен " + ((A * B * H) / 3) + " кубических сантиметров.");
        }
    }
}
