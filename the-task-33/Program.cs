using System;

namespace the_task_33_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 4, 56, 64 };

            Console.WriteLine("\nВывод массива:");

            for (int i = myArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(myArray[i]);
            }

            Console.ReadLine();
        }
    }
}
