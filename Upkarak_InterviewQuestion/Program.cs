using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upkarak_InterviewQuestion
{
    public class Program
    {
        public static Double FindX(Double a,Double b)
        {
            double numerator = 3 * a + 1;
            double result = Math.Sqrt(numerator) / b;
            return result;
        }

        private static int LargestNumber(int[] arr)
        {
            int max = arr[0]; 

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        static void Main()
        {

            double a = 5; 
            double b = 2;
            double output = Program.FindX(a, b);
            // Display the result
            Console.WriteLine($"The square root of (3*a+1)/b is: {output}");

            int[] arr = { 10, 5, 15, 7, 20, 3 };
            int arrOutput = Program.LargestNumber(arr);
            // Display the result
            Console.WriteLine($"The largest number in array is: {arrOutput}");

        }

    }
}
