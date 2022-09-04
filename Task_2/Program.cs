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
        Console.WriteLine ("Enter the third number:");
        string z = Console.ReadLine ();
        int c = Convert.ToInt32 (z);
         if (a>b && a>c)
        {
            Console.WriteLine (a+", "+b+", "+c+" -> "+a);
        }
        if (b>a && b>c)
        {
            Console.WriteLine (a+", "+b+", "+c+" -> "+b);
        }
        if (c>a && c>b)
        {
            Console.WriteLine (a+", "+b+", "+c+" -> "+c);
        }
    }
}
