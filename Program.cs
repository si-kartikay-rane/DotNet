namespace ArrayProblems
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Enter the length of the array:");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] NumArr = new int[num];
            for (int i = 0; i < NumArr.Length; i++) {
                Console.WriteLine("Enter the number in array:");
                NumArr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = NumArr.Length - 1; i>= 0; i--) {
                Console.WriteLine("The array is reverse order is:"+NumArr[i]);            
            }
        }
    }
}