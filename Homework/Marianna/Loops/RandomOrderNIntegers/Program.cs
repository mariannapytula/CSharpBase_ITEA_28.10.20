using System;

namespace RandomOrderNIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Random rnd = new Random();
                int temp, randomNumber;
                Console.Write("Enter number: ");
                int n = Int32.Parse(Console.ReadLine());
                int[] arr = new int[n+1];

                for (int i = 1; i <= arr.Length; i++)
                {
                    arr[i] = i;
                }

                foreach (int i in arr)
                {
                    randomNumber = rnd.Next(1,n);
                    temp = arr[i];
                    arr[i] = arr[randomNumber];
                    arr[randomNumber] = temp;
                }

                foreach (int i in arr) Console.WriteLine(arr[i]);
            }
        }
    }
}
    

