using System;

namespace Reto__3_EL_GENERAODR_DE_CONSTRASEÑAS
{
    internal class Program
    {
        /*
        * Escribe un programa que sea capaz de generar contraseñas de forma aleatoria.
        * Podrás configurar generar contraseñas con los siguientes parámetros:
        * - Longitud: Entre 8 y 16.
        * - Con o sin letras mayúsculas.
        * - Con o sin números.
        * - Con o sin símbolos.
        * (Pudiendo combinar todos estos parámetros entre ellos)
        */
        protected static string _carateresMin = "abcdefghijklmnñopqrstuvwxyz";
        protected static string _carateresMax = _carateresMin.ToUpper();
        protected static string _numbers = "0123456789";
        protected static string _specialkeys = "$%&[]_-/()@";

        static void Main(string[] args)
        {
            Console.WriteLine($"Paswoord: {PaswoordGeneration(true, true, true, true, 16)}");
            Console.ReadKey();
        }

        private static string PaswoordGeneration(bool letterMin, bool letterMax, bool Numbers, bool SpecialKeys, int _long)
        {
            string paswoord = "", AllCaracteres = "";
            char caracter;
            Random rdm = new Random();
            if (_long < 8 || 16 < _long)
            {
                return "Longitud invalida";
            }
            if (letterMin)
            {
                AllCaracteres += _carateresMin;
            }
            if (letterMax)
            {
                AllCaracteres += _carateresMax;
            }
            if (Numbers)
            {
                AllCaracteres += _numbers;
            }
            if (SpecialKeys)
            {
                AllCaracteres += _specialkeys;
            }
            for (int i = paswoord.Length; i < _long; i++)
            {
                caracter = AllCaracteres[rdm.Next(AllCaracteres.Length)];
                paswoord += caracter.ToString();
            }
            return paswoord;
        }
    }
}
