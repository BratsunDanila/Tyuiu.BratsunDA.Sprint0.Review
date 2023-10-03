using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BratsunDA.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.BratsunDA.Sprint0.TaskReview.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0| Выполнил: Брацун Д. А. | ПКТБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #0                                                               *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание #TaskReview                                                     *");
            Console.WriteLine("* Вариант #0                                                              *");
            Console.WriteLine("* Выполнил: Брацун Данила Александрович | ПКТБ-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая вычисляет значение         *");
            Console.WriteLine("* выражения (x + y + z) * 5.                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение  переменной x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение  переменной y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение  переменной z: ");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕШЕНИЕ:                                                                *");
            Console.WriteLine("(x + y + z) * 5 = " + DataService.Calc(x, y, z));
            Console.ReadKey();
        }
    }
}
