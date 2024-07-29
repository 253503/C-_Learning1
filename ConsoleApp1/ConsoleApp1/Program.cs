// See https://aka.ms/new-console-template for more information
namespace consoleApp1
{
    internal class program
    {
        public static void Main (string[] args)
        {
            int Unit;
            double amount,TotalAmount,surcharge;
            Console.WriteLine("Input unit:");
            Unit = Convert.ToInt32(Console.ReadLine());
            if(Unit <= 50)
            {
                amount = Unit * 0.50;

            }
            else if(Unit <= 100)
            {
                amount = Unit * 0.75;
            }
            else if (Unit <= 200)
            {
                amount = Unit * 1.20;
            }
            else 
            {
                amount = Unit * 1.50;
            }
            surcharge = amount * 0.20;
            TotalAmount = amount + surcharge;
            Console.WriteLine("Total amount :"+TotalAmount.ToString());

        }

    }

}
