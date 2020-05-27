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
            Control();
        }

        static void Control()
        {
            
            Console.Clear();

            Console.WriteLine("Поиск объемов фигур.");
            Console.WriteLine();

            Console.WriteLine("Доступные фигуры:");
            Console.WriteLine("1. Параллелепипед");
            Console.WriteLine("2. Шар");
            Console.WriteLine("3. Цилиндр");
            Console.WriteLine("4. Конус");
            Console.WriteLine("5. Пирамида");
            Console.WriteLine();

            Console.Write("Введите номер фигуры, для который будет подсчитан объем: ");
            int InsertNumber = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            switch (InsertNumber)
            {
                case 1:
                    Parallelepiped();
                    break;
                case 2:
                    Ball();
                    break;
                case 3:
                    Cylinder();
                    break;
                case 4:
                    Cone();
                    break;
                case 5:                    
                    Pyramid();
                    break;                
            }

            Console.Clear();

            Console.WriteLine("Подсчитать объем для другой фигуры?");
            Console.WriteLine("1 - Да");
            Console.WriteLine("2 - Нет");
            Console.WriteLine();

            Console.Write("Ваш ответ: ");
            InsertNumber = Convert.ToInt32(Console.ReadLine());

            if (InsertNumber == 1)
                Control();
        }

        static void Parallelepiped()
        {
            Console.Write("Введите длинну параллелепипеда: ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Введите ширину параллелепипеда: ");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Введите высоту параллелепипеда: ");
            double C = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            double Volume = A * B * C;
            Console.WriteLine("Объем паралелепипеда равен ~" + Math.Round(Volume) + " см^2");

            Console.ReadLine();
        }

        static void Ball()
        {
            Console.Write("Введите радиус шара: ");
            double R = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            double Volume = (4 * Math.PI * Math.Pow(R, 3)) / 3;
            Console.WriteLine("Объем шара равен ~" + Math.Round(Volume) + " см^2");

            Console.ReadLine();
        }

        static void Cylinder()
        {
            Console.Write("Введите радиус основания цилиндра: ");
            double R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Введите высоту цилиндра: ");
            double H = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            double Volume = Math.PI * Math.Pow(R, 2) * H;
            Console.WriteLine("Объем цилиндра равен ~" + Math.Round(Volume) + " см^2");

            Console.ReadLine();
        }

        static void Cone()
        {
            Console.Write("Введите радиус основания конуса: ");
            double R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Введите высоту конуса: ");
            double H = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            double Volume = (Math.PI * Math.Pow(R, 2) * H) / 3;
            Console.WriteLine("Объем конуса равен ~" + Math.Round(Volume) + " см^2");

            Console.ReadLine();
        }
                
        static void Pyramid()
        {
            Console.Write("Введите высоту пирамиды: ");
            double H = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Введите длинну основания пирамиды: ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            
            Console.Write("Введите ширину основания пирамиды: ");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            double Volume = ((A * B) * H) / 3;
            Console.WriteLine("Объем пирамиды равен ~" + Math.Round(Volume) + " см^2");

            Console.ReadLine();
        }

    }
}
