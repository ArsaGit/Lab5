using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Факториал!---");
            Console.WriteLine("Введите число:");
            ulong num = GetNumber();
            Console.WriteLine($"Факториал от {num} равен {CalculateFactorial(num)}");
            Console.WriteLine("╔═╗");

        }
        //метод ввода
        static ulong GetNumber()
        {
            ulong num;
            bool isNumberCorrect=false;
            do
            {
                string str=Console.ReadLine();
                isNumberCorrect = UInt64.TryParse(str, out num);
            } while (!isNumberCorrect&&num>=0);
            return num;
        }
        //метод вычисления факториала
        static ulong CalculateFactorial(ulong num)
        {
            if (num > 1) return num * CalculateFactorial(num - 1);
            else return 1;
        }


    }
}
