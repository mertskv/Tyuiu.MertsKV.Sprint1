using Tyuiu.MertsKV.Sprint1.Task4.V16.Lib;

namespace Tyuiu.MertsKV.Sprint1.Task4.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataServise ds = new DataServise();

            Console.Title = "Спринт #1| Выполнил: Мерц К.В. | ИСТНб-25-1";
            Console.WriteLine("****************************************************");
            Console.WriteLine("* Спринт #1                                        *");
            Console.WriteLine("* Тема: Class math                                 *");
            Console.WriteLine("* Задание #4                                       *");
            Console.WriteLine("* Вариант #16                                      *");
            Console.WriteLine("* Выполнил: Мерц Кристина Викторовна | ИСТНб-25-1  *");
            Console.WriteLine("****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                         *");
            Console.WriteLine("* Написать программу, которая запрашивает у        *");
            Console.WriteLine("* пользователя исходные данные, вычисляет          *");
            Console.WriteLine("* результат по формуле и печатает его на экране.   *");
            Console.WriteLine("*                                                  *");
            Console.WriteLine("****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                 *");
            Console.WriteLine("****************************************************");

            int x;
            Console.WriteLine("Введите значение X:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                       *");
            Console.WriteLine("****************************************************");

            Console.WriteLine("1/(x+4) = " + ds.Calculate(x));
            Console.ReadKey();
        }
    }
}
