using System;

namespace the_task_33_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 2, 4, 5, 6, 7, 12, 34, 36, 102 };

            int minValue = myArray[0];

            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] < minValue)
                {
                    minValue = myArray[i];
                }

                Console.WriteLine(minValue);
                Console.ReadLine();
            }
        }
    }
}
