namespace _1.Largest_Common_End___Exercises
{
    using System;
    using System.Linq;

    public class LargestCommonEnd
    {
        public static void Main()
        {
            var arr1 = Console.ReadLine().Split(' ').ToArray();
            var arr2 = Console.ReadLine().Split(' ').ToArray();
            Console.WriteLine(largestCommonEnd(arr1, arr2));

        }

        static int largestCommonEnd(string[] arr1, string[] arr2)
        {
            int rightCounter = 0;
            int leftCounter = 0;

            while (rightCounter < arr1.Length && rightCounter < arr2.Length)
            {
                if (arr1[arr1.Length - rightCounter - 1] == arr2[arr2.Length - rightCounter - 1])
                {
                    rightCounter++;
                }
                else break;
            }

            while (leftCounter < arr1.Length && leftCounter < arr2.Length)
            {
                if (arr1[leftCounter] == arr2[leftCounter])
                {
                    leftCounter++;
                }
                else break;
            }

            return Math.Max(leftCounter, rightCounter);
        }
    }
}
