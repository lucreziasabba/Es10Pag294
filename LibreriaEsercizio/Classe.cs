using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEsercizio
{
    public class Classe
    {
        public static int[] Vett(int[]array)
        {
            int[] minori = new int[array.Length];
            int[] array_ordinato = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                int c = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        c++;
                    }
                }
                minori[i] = c;
            }
            for (int i = 0; i < array.Length; i++)
            {
                array_ordinato[minori[i]] = array[i];
            }
            return array_ordinato;
        }
    }
}
