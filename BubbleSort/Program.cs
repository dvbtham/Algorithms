using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 1, 5, 4, 7, 9, 2, 8 };
            Console.Write("\nMang chua sap xep: ");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            Console.Write("\nMang da sap xep: ");
            IntArrayBubbleSort(arr);
            Console.ReadKey();
        }
        public static void exchange(int[] data, int m, int n)
        {
            int temporary;

            temporary = data[m];
            data[m] = data[n];
            data[n] = temporary;
        }
        public static void IntArrayBubbleSort(int[] data)
        {
            int i, j;
            int N = data.Length;

            for (j = N - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (data[i] > data[i + 1])
                        exchange(data, i, i + 1);
                }
            }
            for (int n = 0; n < data.Length; n++)
                Console.Write(data[n] + " ");
        }
    }
}
