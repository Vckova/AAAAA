using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAAA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] Tablero = new string[][]
            {
                new string[] {"1.1", "1.2"},
                //new string[] {"2.1", "2.2", "2.3", "2.4"},
                //new string[] {"3.1", "3.2", "3.3"}
            };
            Tablero = new string[][]
            {
                //new string[] {"1.1", "1.2"},
                new string[] {"2.1", "2.2", "2.3", "2.4"},
                //new string[] {"3.1", "3.2", "3.3"}
            };

            for (int i = 0; i < Tablero.Length; i++)
            {
                for (int j = 0; j < Tablero.Length; j++)
                {
                    Console.Write(Tablero[i][j]+" |");
                }
                Console.WriteLine();
            }
        }
    }
}
