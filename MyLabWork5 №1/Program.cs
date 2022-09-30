using System;

namespace MyLabWork5__1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:"); //просим пользователя ввести число
            double a = Double.Parse(Console.ReadLine()); //задание числа вещественного типа
            a = Math.Round(a, 2); // округление заданного числа с точностью до сотых, присваивание значения переменной
            Console.WriteLine($"Число  с точностью до сотых {a}"); //вывод на экран значения переменной
        }
    }
}
