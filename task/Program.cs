using System;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 6, 5, 3, 64, 1 };
            //int x = arr[0];
            int temp;
            for (int i=0; i<arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
                
            }
            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
