using System;

namespace SmallAndLargestArr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 6, 4, 36, -9, 55, 164, 3257, 2344 };
            swepRef(ref arr);
            foreach (int nums in arr)
            {
                Console.WriteLine((nums + ""));
            }

        }

        static void swepRef(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = arr[i] * -1;
                }
            }
        }
    }
}
