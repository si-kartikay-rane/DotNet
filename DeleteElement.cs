using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    internal class DeleteElement
    {
        static void Main4(String[] Args)
        {
            Console.WriteLine("Enter the length of the array:");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[num];
            int i;
            for (i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter the number in array:");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter the position in which the element must be deleted:");
            int pos = Convert.ToInt32(Console.ReadLine());

            if (pos < 0 && pos > array.Length)
            {
                Console.WriteLine("The position given is not present in the array");
            }
            else
            {
                for (i = pos - 1; i < array.Length - 1; i++)
                {
                    array[i] = array[i + 1];
                }
            }
            Console.WriteLine("After the deletion of element ");
            
            for(i = 0; i < array.Length - 1; i++)
            {
                Console.Write(" "+array[i]);
            }
            
        }
    }
}
