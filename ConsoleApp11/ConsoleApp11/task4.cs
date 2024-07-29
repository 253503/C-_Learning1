// See https://aka.ms/new-console-template for more information
namespace Day1Task
{
    internal class task4
    {
        public static void Main(string[] args)
        {
            
            double basic,Gross;
            double HRA,DA;

            Console.WriteLine("Input salary:");

            basic = Convert.ToInt32(Console.ReadLine());
            if (basic <= 10000)
            {
                HRA = basic * 0.2;
                DA = basic * 0.8;


            }
            else if (basic <= 20000)          
            {
                HRA = basic * 0.25;
                DA = basic * 0.90;
            }
            else  
            {
                HRA = basic * 0.30;
                DA = basic * 0.95;
            }

            Gross = basic + HRA + DA;
            Console.WriteLine("Total amount :" + Gross.ToString());

        }

    }

}
