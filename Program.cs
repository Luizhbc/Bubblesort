using System;

namespace Bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //int[] array = new int[9];
            int[] array = { 3, 1, 7, 9, 11, 15, 2, 4, 8 };
            int temporario;

            //Console.Write("Adicione {0} elementos no array :\n", array.Length);
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write("elemento - {0} : ", i);
            //    array[i] = Convert.ToInt32(Console.ReadLine());
            //}

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
