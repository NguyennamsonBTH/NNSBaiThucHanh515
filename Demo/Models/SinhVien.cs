namespace Demo.Models{
    public class SinhVien {
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public int Tuoi { get; set; }
        public int SDT { get; set; }
        public void NhapThongTin(){
            System.Console.WriteLine("Nhap vao ten sinh vien: ");
            HoTen = Console.ReadLine();
            System.Console.WriteLine("Nhap vao dia chi: ");
            DiaChi = Console.ReadLine();
            System.Console.WriteLine("Nhap vao tuoi: ");
            Tuoi = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Nhap vao SDT: ");
            SDT = Convert.ToInt32(Console.ReadLine());
        }

        public void HienThi(){
            System.Console.WriteLine("Ho va ten: {0} \nDia chi: {1} \nTuoi: {2} \nSDT: {3}",HoTen,DiaChi,Tuoi,SDT);
        }
    }
}