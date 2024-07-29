namespace Day2
{
    internal class switchstatement
    {
      public  static void Main(String[] args)
        {
            for (int k = 5; k >= 0; k--)
            {
                for (int l = 0; l <= k; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 0;i<=5;i++)
            {
                for (int j = 0;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
           
        }
    }

}
