using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            long nConvertito;
            int contatore = 0;
            bool[] nBinario = new bool[7] {true, false, true, true, false, true, false};
            int[] DecimalePunt = new int[7] { 10, 10, 10, 10, 10, 10, 10 };

            Console.WriteLine("Il numero in binario è:");
            for (int j = nBinario.Length - 1; j > - 1; j--)
            {
                Console.Write(Convert.ToInt16(nBinario[j]));
                contatore++;
                if (contatore == 4)
                {
                    Console.Write(' ');
                    contatore = 0;
                }
            }

            nConvertito = Convert_Binario_To_Int(nBinario);

            Console.WriteLine("\nIl numero convertito da binario a intero è:");
            Console.WriteLine(nConvertito);
            Console.WriteLine("Il numero in Decimale puntato è:");

            for(int i = 0; i < DecimalePunt.Length; i++)
            {
                Console.Write(Convert.ToString(DecimalePunt[i]) + ".");
            }

            Console.WriteLine("\nIl numero convertito da decimale puntato a intero è:");

            nConvertito = Convert_Decimale_Puntato_To_Int(DecimalePunt);

            Console.WriteLine(nConvertito);
            Console.ReadLine();
        }
        static long Convert_Binario_To_Int(bool[] nBinario)
        {
            long conversione = 0;

            for (int i = 0; i < nBinario.Length; i++)
            {
                if (Convert.ToInt32(nBinario[i]) == 1)
                {
                    conversione = conversione + Convert.ToInt32(nBinario[i]) * Convert.ToInt64(Math.Pow(2, i));
                }
            }

            return conversione;
        }
        static long Convert_Decimale_Puntato_To_Int(int[] nDecimalePunt)
        {
            long conversione = 0;

            for (int i = nDecimalePunt.Length - 1; i >= 0; i--)
            {
                conversione = conversione + nDecimalePunt[i] * Convert.ToInt64(Math.Pow(256, i));
            }

            return conversione;
        }
    }
}
