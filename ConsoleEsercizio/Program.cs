using LibreriaEsercizio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEsercizio
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TANTI = 10;
            int[] array = new int[TANTI];
            Random r = new Random();
            List<int> numeri = new List<int>();
            for (int i = 0; i < TANTI; i++)
            {
                int k;
                do
                {
                    k = r.Next(0, 100);
                } while (numeri.Contains(k));
                numeri.Add(k);
                array[i] = k;
            }
            int[] sortedArray = Classe.Vett(array);
            for (int i = 0; i < TANTI; i++)
            {
                Console.Write(sortedArray[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
