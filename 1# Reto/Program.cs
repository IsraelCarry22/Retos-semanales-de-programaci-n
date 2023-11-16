using System;

namespace Reto__0_EL_FAMOSO_FIZZ_BUZZ
{
	internal class Program
	{
		/*
		* Escribe un programa que muestre por consola (con un print) los
		* números de 1 a 100 (ambos incluidos y con un salto de línea entre
		* cada impresión), sustituyendo los siguientes:
		* - Múltiplos de 3 por la palabra "fizz".
		* - Múltiplos de 5 por la palabra "buzz".
		* - Múltiplos de 3 y de 5 a la vez por la palabra "fizzbuzz".
		*/
		static void Main(string[] args)
		{
			FIZZ_BUZZ();
		}

		private static void FIZZ_BUZZ()
		{
			for (int numbers = 1; numbers < 100; numbers++)
			{
				if (numbers % 3 == 0 && numbers % 5 == 0)
				{
					Console.WriteLine("FizzBuzz");
				}
				else if (numbers % 3 == 0)
				{
					Console.WriteLine("Fizz");
				}
				else if (numbers % 5 == 0)
				{
					Console.WriteLine("Buzz");
				}
				else
				{
					Console.WriteLine(numbers);
				}
			}
			Console.ReadKey();
		}
	}
}
