using Tyuiu.ShmelevAV.Sprint1.Task3.V15.Lib;

namespace Tyuiu.ShmelevAV.Sprint1.Task3.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Шмелев А. В. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Шмелев Алексей Витальевич | ИИПб-24-2                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите скорость первого автомобиля:");
            double v1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите скорость второго автомобиля:");
            double v2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите расстояние между автомобилями:");
            double S = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите количество часов:");
            double T = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Через " + T + " часов автомобили будут на расстоянии " + ds.DistanceOverTime(v1, v2, S, T) + " км друг от друга.");

            Console.ReadKey();
        }
    }
}
