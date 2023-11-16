using System;
using System.Text;

namespace Reto__6_PIEDRA_PAPEL_TIJERA_LAGARTO_SPOCK
{
    internal class Program
    {
        /*
        * Crea un programa que calcule quien gana más partidas al piedra,
        * papel, tijera, lagarto, spock.
        * - El resultado puede ser: "Player 1", "Player 2", "Tie" (empate)
        * - La función recibe un listado que contiene pares, representando cada jugada.
        * - El par puede contener combinaciones de "🗿" (piedra), "📄" (papel),
        *   "✂️" (tijera), "🦎" (lagarto) o "🖖" (spock).
        * - Ejemplo. Entrada: [("🗿","✂️"), ("✂️","🗿"), ("📄","✂️")]. Resultado: "Player 2".
        * - Debes buscar información sobre cómo se juega con estas 5 posibilidades.
        */

        public enum CharcatersGames { Piedra, Papel, Tijera, Lagarto, Spock };
        public static int _Player1Count;
        public static int _Player2Count;

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            StarGame(CharcatersGames.Lagarto, CharcatersGames.Piedra);
            StarGame(CharcatersGames.Papel, CharcatersGames.Piedra);
            StarGame(CharcatersGames.Papel, CharcatersGames.Piedra);
            if (_Player1Count != _Player2Count)
                Console.WriteLine((_Player1Count > _Player2Count) == true ? "Player 1" : "Player 2");
            else
                Console.WriteLine("Tie");
            Console.ReadKey();
        }

        public static void StarGame(CharcatersGames Player1, CharcatersGames Player2)
        {
            switch (Player1)
            {
                case CharcatersGames.Piedra:
                    if (Player2 == CharcatersGames.Piedra)
                        return;
                    else if (Player2 == CharcatersGames.Papel)
                        _Player2Count++;
                    else if (Player2 == CharcatersGames.Tijera)
                        _Player1Count++;
                    else if (Player2 == CharcatersGames.Lagarto)
                        _Player1Count++;
                    else if (Player2 == CharcatersGames.Spock)
                        _Player2Count++;
                    break;
                case CharcatersGames.Papel:
                    if (Player2 == CharcatersGames.Piedra)
                        _Player1Count++;
                    else if (Player2 == CharcatersGames.Papel)
                        return;
                    else if (Player2 == CharcatersGames.Tijera)
                        _Player2Count++;
                    else if (Player2 == CharcatersGames.Lagarto)
                        _Player2Count++;
                    else if (Player2 == CharcatersGames.Spock)
                        _Player1Count++;
                    break;
                case CharcatersGames.Tijera:
                    if (Player2 == CharcatersGames.Piedra)
                        _Player2Count++;
                    else if (Player2 == CharcatersGames.Papel)
                        _Player1Count++;
                    else if (Player2 == CharcatersGames.Tijera)
                        return;
                    else if (Player2 == CharcatersGames.Lagarto)
                        _Player1Count++;
                    else if (Player2 == CharcatersGames.Spock)
                        _Player2Count++;
                    break;
                case CharcatersGames.Lagarto:
                    if (Player2 == CharcatersGames.Piedra)
                        _Player2Count++;
                    else if (Player2 == CharcatersGames.Papel)
                        _Player1Count++;
                    else if (Player2 == CharcatersGames.Tijera)
                        _Player2Count++;
                    else if (Player2 == CharcatersGames.Lagarto)
                        return;
                    else if (Player2 == CharcatersGames.Spock)
                        _Player1Count++;
                    break;
                case CharcatersGames.Spock:
                    if (Player2 == CharcatersGames.Piedra)
                        _Player2Count++;
                    else if (Player2 == CharcatersGames.Papel)
                        _Player1Count++;
                    else if (Player2 == CharcatersGames.Tijera)
                        _Player1Count++;
                    else if (Player2 == CharcatersGames.Lagarto)
                        _Player2Count++;
                    else if (Player2 == CharcatersGames.Spock)
                        return;
                    break;
            }
        }
    }
}
