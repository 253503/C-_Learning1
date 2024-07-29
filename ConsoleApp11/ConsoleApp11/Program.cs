
public class program
{
    static void Main1(string[] args)
    {
        string str;
        str = "The quick brown fox jumps over the lazy dog.";
     
        if (str.Length >= 1)
        {
            var x = str.Substring(0, 1); 
            Console.WriteLine(x + str + x);
        }
    }
}