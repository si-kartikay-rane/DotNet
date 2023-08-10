using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    internal class CopyElements
    {
        static void Main3(String[] Args) 
        {
            Console.WriteLine("Enter the length of the array:");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[num];
            int i;
            for (i= 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter the number in array:");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] copyArray = new int[array.Length];
            for (i = 0; i < array.Length; i++) {
                copyArray[i] = array[i];
            }

            Console.Write("The Original array: "+ string.Join(", ", array));
            Console.WriteLine("\t The Copied array: "+string.Join(", ", copyArray));
        }
    }
}
