using System;

namespace MinSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(minSplit(160).ToString());
            Console.ReadKey();
        }

        public static int minSplit(int amount)
        {
            int[] monets = new[] { 1, 5, 10, 20, 50 };
            int[] array = new int[5];
            for (int i = 0; i < monets.Length; i++)
            {
                var a = amount / monets[i];
                if (a != 0 && a!= 1)
                {
                    array[i] = a;
                }
            }

            int min = array[0];
            int index = 1;

            while (index < array.Length)
            {
                if (array[index] < min)
                {
                    if (array[index] != 0)
                    {
                        min = array[index];
                    }
                }
                index++;
            }
            return min;
        }
    }
}