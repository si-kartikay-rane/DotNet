using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    internal class Sum
    {
        static void Main2(String[] Args) {
            Console.WriteLine("Enter the length of the array:");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[num];

            for(int i = 0; i < array.Length; i++) {
                Console.WriteLine("Enter the number in array:");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            foreach (int item in array)
            {
                sum += item;
            }

            Console.WriteLine("The sum of digits in array:"+sum);
        }
    }
}
