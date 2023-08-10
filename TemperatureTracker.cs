using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ControlStructures
{
    internal class TemperatureTracker
    {
        public static void Main(String[] Args)
        {
            int sentinel_val = 131;

            double n;
            double total = 0;

            List<double> temp_list = new List<double>();
            
            do
            {
                Console.WriteLine("Enter the temperatures between 20 and 130 (131 to exit): ");
                n = Convert.ToDouble(Console.ReadLine());
                temp_list.Add(n);
                total += n;
            }while (n != sentinel_val);

            int denominator = temp_list.Count;

            Console.WriteLine("The temperature loop has ended");
            Console.WriteLine("The temperatures entered by the user:");
            foreach (var m in temp_list)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine("\n The average temperature: "+(total/denominator));
            

        }

    }
}
