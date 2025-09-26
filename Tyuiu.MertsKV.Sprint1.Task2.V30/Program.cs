using Tyuiu.MertsKV.Sprint1.Task2.V30.Lib;
using System;

namespace Tyuiu.MertsKV.Sprint1.Task2.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService converter = new DataService();

            Console.WriteLine("***************************************");
            Console.WriteLine("* Конвертер километров в метры       *");
            Console.WriteLine("***************************************");
            Console.WriteLine("* 1 километр = 1000 метров           *");
            Console.WriteLine("* Результат округляется до 3 знаков  *");
            Console.WriteLine("* после запятой                      *");
            Console.WriteLine("***************************************");

            try
            {
                Console.Write("Введите расстояние в километрах: ");
                double kilometers = GetDoubleInput();

                double result = converter.ConvertKmToMetre(kilometers);

                Console.WriteLine("***************************************");
                Console.WriteLine("* Результат                           *");
                Console.WriteLine("***************************************");
                Console.WriteLine($"{kilometers} км = {result} м");

                Console.WriteLine($"\nТочное значение: {kilometers * 1000} м");
                Console.WriteLine($"После округления: {result} м");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.WriteLine("\nНажмите любую клавишу для завершения...");
            Console.ReadKey();
        }

        static double GetDoubleInput()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}
