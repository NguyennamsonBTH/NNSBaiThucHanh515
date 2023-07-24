using System.Xml;
using System.Security.AccessControl;
namespace NEWAPP.Models
{
    public class Employee
    {
        public int MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public int Age { get; set; }
        public String Luong { get; set; }
        public void EnterData()
        {
            System.Console.Write("MaNhanVien = ");
            MaNhanVien = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("TenNhanVien = ");
            TenNhanVien = Console.ReadLine();
            System.Console.Write("Age = ");
            Age = Convert.ToInt16(Console.ReadLine());
            System.Console.Write("Luong = ");
            Luong = Console.ReadLine();

        }
        public void Display()
        {
            System.Console.WriteLine("{0} MaNhanVien- {1} Ten- {2} Tuoi- {3} Luong", MaNhanVien, TenNhanVien, Age, Luong);
        }
    }

}
    