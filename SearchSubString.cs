using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Problems
{
    internal class SearchSubString
    {
        public static void Main4(String[] Args) {
            Console.Write("Enter the main string: ");
            string mainString = Console.ReadLine();

            Console.Write("Enter the Sub-string:");
            string SubString = Console.ReadLine();
            
            int index= mainString.IndexOf(SubString);
            
            Console.WriteLine($"Index of the substring in the main string is:"+index);


        }
    }
}
