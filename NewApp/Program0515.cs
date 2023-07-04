public class Program0515
{
    public static void Main(string[] args)
    {
        int a = 10;
        if ( a < 0)
        {
            System.Console.WriteLine("{0} la so nguyen am", a);
        }else
        {
            if( a % 2 ==0) {
                System.Console.WriteLine("{0} la so nguyen duwong chan", a);
            }else
            {
                System.Console.WriteLine("{0} la so nguyen duong le", a);
            }
        }
    }
}