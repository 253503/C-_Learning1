namespace ConsoleApp8
{
    internal class Program
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("enter a string :");
           string a = Console.ReadLine();
           string b=string.Empty;


            for (int i= a.Length-1; i>=0; i--)
            {
                b = b + a[i];
            }

            if(a==b)
            {
                Console.WriteLine(a + " is a palindrome");

            }
            else
            {
                Console.WriteLine(a+" is not a palindrome");
            }


        }
    }
}