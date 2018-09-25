using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAMA_7
{
    class PROGRAMA7
    {
        static void Main(string[] args)
        {
            int[] Vector;
            Random Random1 = new Random();
            Vector = new int[10];
            for (int x = 0; x < Vector.Length; x++)
            {
                Vector[x] = Random1.Next(0, 101);
                Console.WriteLine("Numero: " + Vector[x]);
            }
            for (int f = 0; f < 9; f++)
            {
                for (int x = 0; x < 9 - f; x++)
                {
                    if (Vector[x] > Vector[x + 1])
                    {
                        int Contador;
                        Contador = Vector[x];
                        Vector[x] = Vector[x + 1];
                        Vector[x + 1] = Contador;
                    }
                }
            }
            Console.WriteLine("-------------------");
            for (int x = 0; x < Vector.Length; x++)
            {
                Console.WriteLine("Numero Ordenado: " + Vector[x]);
            }




            Console.ReadKey();
        }
    }
}
