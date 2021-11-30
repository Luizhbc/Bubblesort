using System;

namespace Bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 1, 7, 9, 11, 15, 2, 4, 8 };
            int temporario;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        temporario = array[i];
                        array[i] = array[j];
                        array[j] = temporario;
                    }
                }
            }
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }

    }
}
