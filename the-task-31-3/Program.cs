using System;

namespace the_task_31_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 2, 4, 5, 6, 7, 12, 34, 36, 102 };

            int result = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    result += myArray[i];
                }
            }

            Console.WriteLine(result);

            Console.ReadLine();
        }

       
    }

}
