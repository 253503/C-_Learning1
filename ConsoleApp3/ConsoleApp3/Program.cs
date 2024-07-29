namespace consoleApp3
{
    internal class Program
    {
        public static void swap(ref int  a , ref int  b)
        {
            var t = a;
            a = b; b = t;

        }
         static void Main(string[] args)
        {
            int a = 1, b = 5;
            Console.WriteLine("a:" + a + " " + "b:" + b);
            

            swap( ref a, ref b);
            Console.WriteLine("a:" + a + " " + "b:" + b);

        }

    }
}
