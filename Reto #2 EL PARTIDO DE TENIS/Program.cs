using System;
using System.Collections.Generic;

namespace Reto__2_EL_PARTIDO_DE_TENIS
{
    internal class Program
    {
        /*
        * Escribe un programa que muestre cómo transcurre un juego de tenis y quién lo ha ganado.
        * El programa recibirá una secuencia formada por "P1" (Player 1) o "P2" (Player 2), según quien
        * gane cada punto del juego.
        * 
        * - Las puntuaciones de un juego son "Love" (cero), 15, 30, 40, "Deuce" (empate), ventaja.
        * - Ante la secuencia [P1, P1, P2, P2, P1, P2, P1, P1], el programa mostraría lo siguiente:
        *   15 - Love
        *   30 - Love
        *   30 - 15
        *   30 - 30
        *   40 - 30
        *   Deuce
        *   Ventaja P1
        *   Ha ganado el P1
        * - Si quieres, puedes controlar errores en la entrada de datos.   
        * - Consulta las reglas del juego si tienes dudas sobre el sistema de puntos.   
        */
        static void Main(string[] args)
        {
            string[] PayersNames = { "P1", "P1", "P2", "P2", "P1", "P2", "P1", "P1" };
            Console.WriteLine(TenisGame(PayersNames));
            Console.ReadKey();
        }

        public static string TenisGame(string[] Player)
        {
            var GamePoints = new Dictionary<int, string>()
            {
                {0, "Love" },
                {1, "15" },
                {2, "30" },
                {3, "40" }
            };
            int P1Points = 0, P2Points = 0;
            foreach (var Point in Player)
            {
                var x = (Point == "P1") ? P1Points++ : P2Points++;
                if ((P1Points + P2Points) < 6)
                {
                    Console.WriteLine($"{GamePoints[P1Points]} - {GamePoints[P2Points]}");
                }
                else if (P1Points == P2Points)
                {
                    Console.WriteLine("Deuce");
                }
                else if ((Math.Max(P1Points, P2Points) - Math.Min(P1Points, P2Points) == 2))
                {
                    Console.WriteLine($"Ha ganado {Point}");
                }
                else
                {
                    Console.WriteLine($"Ventaja {Point}");
                }
            }
            return "";
        }
    }
}
