using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miniprojekti
{
    internal class Program
    {
        public class ArrayMin
        {
            public static void Main()
            {
                Console.WriteLine("Vendosni madhesine e array:");
                int size = int.Parse(Console.ReadLine());

                int[] array = new int[size];

                Console.WriteLine("Vendosni elementet e array:");
                for (int i = 0; i < size; i++)
                {
                    array[i] = int.Parse(Console.ReadLine());
                }

                int minValue = Min(array);
                Console.WriteLine("Vlera minimale e array eshte: {0}", minValue);
            }

            public static int Min(int[] array)
            {
                int minValue = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < minValue)
                    {
                        minValue = array[i];
                    }
                }
                return minValue;
            }
        }
    }
}