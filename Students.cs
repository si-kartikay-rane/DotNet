using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    internal class Students
    {
        static void Main(String[] Args)
        {
            int[] students_marks = new int[10];
            int total = 0;
            int Avg = 0;
            
            
            for (int i = 0; i < students_marks.Length; i++)
            {
            
                    Console.WriteLine($"Enter the marks for {i+1} student");
                    students_marks[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            for (int i = 0; i < students_marks.Length; i++)
            {
                total += students_marks[i];
            }

            Avg = total / students_marks.Length;
            Console.WriteLine("Average marks of students are:" + Avg);

            Array.Sort(students_marks);
            Console.WriteLine("Highest marks:" + students_marks[students_marks.Length -1]);

        }
    }
}
