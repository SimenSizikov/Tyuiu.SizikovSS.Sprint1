using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SizikovSS.Sprint1.Task3.V18.Lib;

namespace Tyuiu.SizikovSS.Sprint1.Task3.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Сизиков С. С. | РППб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #2                                                             *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Сизиков Семён Станиславович | РППб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет, сколько квадратов со стороной C  *");
            Console.WriteLine("* можно разместить внутри прямоугольника с размерами A x B без наложений. *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x, y ,z;

            Console.WriteLine("Введите первую сторону прямоугольника: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите вторую сторону прямоугольника: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите сторону квадрата: ");
            z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Площадь прямоугольника равна " + x*y + ".");

            Console.WriteLine("Площадь квадрата равна " + z*z +".");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("квадратов без наложений помещается внутри прямоугольника: " + ds.HowManySquares(x, y, z) + ".");

            Console.ReadKey();
        }
    }
}
