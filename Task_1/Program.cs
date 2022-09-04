public class primer
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Enter the number:");
        string x = Console.ReadLine ();
        int a = Convert.ToInt32 (x);
        Console.WriteLine ("Enter the second number:");
        string y = Console.ReadLine ();
        int b = Convert.ToInt32 (y);
        if (a>b)
        {
            Console.WriteLine ("a = "+a+"; b = "+b+"; max = "+a);
        }
        else
            {
            Console.WriteLine ("a = "+a+"; b = "+b+"; max = "+b);
            }
        }
}