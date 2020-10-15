using System;
using System.Threading;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Факториал!---");
            Console.WriteLine("Введите число:");
            ulong num = GetNumber();
            string factorial = CalculateFactorial(num).ToString();
            int length = factorial.ToString().Length;
            length += 2;
            //╔ ═ ╗ ╣ ╠ ╝ ╩ ╚ ╬ ║
            while (true)
            {
                Console.Clear();
                Console.ResetColor();
                Console.Clear();
                WriteBoxLine(length, '╔', '═', '╗');
                WriteBoxLine(length, '║', ' ', '║', $"!{num}");
                WriteBoxLine(length, '╠', '═', '╣');
                WriteBoxLine(length, '║', ' ', '║', factorial);
                WriteBoxLine(length, '╚', '═', '╝');
                Thread.Sleep(1000);

                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;
                WriteBoxLine(length, '╔', '═', '╗');
                WriteBoxLine(length, '║', ' ', '║', $"!{num}");
                WriteBoxLine(length, '╠', '═', '╣');
                WriteBoxLine(length, '║', ' ', '║', factorial);
                WriteBoxLine(length, '╚', '═', '╝');
                Thread.Sleep(1000);
            }
        }
        //метод ввода
        static ulong GetNumber()
        {
            ulong num;
            string str;
            do
            {
                str=Console.ReadLine();
            } while (!UInt64.TryParse(str, out num) && num>=0);
            return num;
        }
        //метод вычисления факториала
        static ulong CalculateFactorial(ulong num)
        {
            if (num > 1) return num * CalculateFactorial(num - 1);
            else return 1;
        }
        public static void WriteBoxLine(int num, char beginSym, char indentSym, char endSym)
        {
            Console.Write(beginSym);
            for (int i = 0; i < num; i++)
                Console.Write(indentSym);
            Console.WriteLine(endSym);
        }
        public static void WriteBoxLine(int num, char beginSym, char indentSym, char endSym, string str)
        {
            Console.Write(beginSym);
            Console.Write(indentSym);
            Console.Write(str);
            int spaceNum = num - str.Length - 1;
            for (int i = 0; i < spaceNum; i++)
                Console.Write(indentSym);
            Console.WriteLine(endSym);
        }


    }
}
