public class primer
{
    public static void Main()
        {
            Console.WriteLine ("Enter the number:");
        string x = Console.ReadLine ();
        int a = Convert.ToInt32 (x);
            
            if (a % 2 == 0)
                {
                  Console.WriteLine(a+" -> yes");
                }
            else 
                 { 
                  Console.WriteLine(a+" -> no");
                 }
        }
}
