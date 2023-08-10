namespace String_Problems
{
    internal class Program
    {
        static void Main1(string[] args)
        {
          
            
                Console.Write("Enter a string: ");
                string input = Console.ReadLine().ToLower();

                char[] chars = input.ToCharArray();
                Array.Sort(chars);
                string sortedString = new string(chars);

                Console.WriteLine($"The string in alphabetical order is: {sortedString}");
            
        }
    }
}