using NEWAPP.Models;
public class Program92
    {
        private static void Main(string[] args)
        {
            Person ps1 = new Person();
            Person ps2 = new Person();
            ps1.FullName = "Nguyen Van A";
            ps1.Address = "Ha Noi";
            ps1.Age = 18;
            ps1.Display();
            ps2.Display();
        }
    }