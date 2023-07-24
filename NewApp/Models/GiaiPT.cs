namespace NEWAPP.Models
{
    public class GiaiPT
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public double x1 { get; set; }
        public double x2 { get; set; }
        public void NhapDuLieu()
        {
            System.Console.Write("a = ");
            a = double.Parse(Console.ReadLine());
            System.Console.Write("b = ");
            b = double.Parse(Console.ReadLine());
            System.Console.Write("c = ");
            c = double.Parse(Console.ReadLine());
        }
        public void XuatDuLieu()
        {
            x1=-b/a;
            System.Console.WriteLine("{0}x + {1} = 0 là {2}", a, b, x1);
        }
        public void Bac2()
        {
            double Dt = b*b - 4*a*c;
            if(Dt<0)
                System.Console.WriteLine("Phuong Trinh Vo Nghiem");
            else if (Dt == 0)
            {
                System.Console.WriteLine("Phuong Trinh Co Nghiem = {0}",-b/2*a);
            }
            else
            {
                x1=(-b + Math.Sqrt(Dt)/2*a);
                x2=(-b - Math.Sqrt(Dt)/2*a);
                System.Console.WriteLine("Phuong Trinh co 2 nghiem la: x1 = {0}, x2 = {1}", x1, x2);
            }    
        }
    }
}