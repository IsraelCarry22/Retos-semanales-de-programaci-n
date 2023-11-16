using System;

namespace Reto__4_PRIMO_FIBONACCI_Y_PAR
{
    internal class Program
    {
        /*
        * Escribe un programa que, dado un número, compruebe y muestre si es primo,
        * fibonacci y par.
        * Ejemplos:
        * - Con el número 2, nos dirá: "2 es primo, fibonacci y es par"
        * - Con el número 7, nos dirá: "7 es primo, no es fibonacci y es impar"
        */
        static void Main(string[] args)
        {
            int Number = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write($"{Number} " + (IsPrimo(Number) == true ? "es primo, " : "no es primo, ") + (IsFibonacci(Number) == true ? "fibonacci " : "no es fibonacci ") + (IsPar(Number) == true ? "y es par" : "y es impar"));
            Console.ReadKey();
        }

        public static bool IsFibonacci(int N)
        {
            if (N == 1) return true;
            int Temp, ToCheck, PrevN = 1;
            for (int i = 1; i < N; Temp = PrevN, PrevN = i, i = Temp + PrevN)
            {
                ToCheck = i + PrevN;
                if (ToCheck > N) return false;
                else if (ToCheck == N) return true;
            }
            return false;
        }

        public static bool IsPrimo(int N)
        {
            int Divisible = 0;
            for (int i = 1; i <= N; i++)
            {
                if (N % i == 0) Divisible++;
            }
            if (Divisible <= 2) return true;
            return false;
        }

        public static bool IsPar(int N)
        {
            if (N % 2 == 0) return true;
            return false;
        }
    }
}
