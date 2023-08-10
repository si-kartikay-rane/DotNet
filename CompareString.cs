using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Problems
{
    internal class CompareString
    {
        public static void Main(String[] Args)
        {
            Console.Write("Enter the 1st string:");
            string str1 = Console.ReadLine();

            Console.Write("Enter the 2nd string:");
            string str2 = Console.ReadLine();

            Console.WriteLine("Comparing the strings while ignoring the case:"+ string.Equals(str1,str2, StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("Comparing the strings without ignoring the case:"+ string.Equals(str1, str2));
        }
    }
}
