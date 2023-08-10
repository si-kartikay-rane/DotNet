namespace ControlStructures
{
    internal class CheckCredit
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Enter the price for an phone");
            int pur_price = Convert.ToInt32(Console.ReadLine());

            int credit_limit = 10000;

            if (pur_price > credit_limit)
            {
                Console.WriteLine("Value entered is more than the credit limit");
            }
            else
            {
                Console.WriteLine("Approved");
            }
        }
    }
}