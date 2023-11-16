using System;
using System.Collections.Generic;

namespace Reto__1_EL_LENGUAJE_HACKER
{
    internal class Program
    {
        /*
		* Escribe un programa que reciba un texto y transforme lenguaje natural a
		* "lenguaje hacker" (conocido realmente como "leet" o "1337"). Este lenguaje
		*  se caracteriza por sustituir caracteres alfanuméricos.
		* - Utiliza esta tabla (https://www.gamehouse.com/blog/leet-speak-cheat-sheet/) 
		*   con el alfabeto y los números en "leet".
		*   (Usa la primera opción de cada transformación. Por ejemplo "4" para la "a")
		*/
        static void Main(string[] args)
        {
            Console.Write("Ingresa texto: ");
            string txt = Console.ReadLine();
            Console.WriteLine(LenguajeHacker(txt));
            Console.ReadKey();
        }

        public static string LenguajeHacker(string text)
        {
            string NewTex = "";
            var Map = new Dictionary<string, string>
            { ["A"] = "@",["B"] = "13",["C"] = "[",["D"] = "|)",["E"] = "[-",["F"] = "|=",["G"] = "[,",["H"] = "|-|",["I"] = "|",["J"] = ",_|",["K"] = "|<",["L"] = "|_",["M"] = "|v|",["N"] = "/v",["Ñ"] = "/~v",["O"] = "[]",["P"] = "|°",["Q"] = "0_",["R"] = "|~",["S"] = "$",["T"] = "7",["U"] = "|_|",["V"] = "|/",["W"] = "Ш",["X"] = "><",["Y"] = "´/",["Z"] = "7_",["1"] = "L",["2"] = "R",["3"] = "S",["4"] = "A",["5"] = "E",["6"] = "b",["7"] = "T",["8"] = "B",["9"] = "g",["0"] = "o",
            };
            foreach (var item in text)
            {
                var caracter = item.ToString().ToUpper();
                if (Map.ContainsKey(caracter))
                {
                    NewTex += Map[caracter];
                }
                else
                {
                    NewTex += caracter;
                }
            }
            return NewTex;
        }
    }
}
