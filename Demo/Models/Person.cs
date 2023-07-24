using System.Collections;

namespace Demo.Models{
    public class Person {
        public void NhapThongTin(ArrayList arrList){
            System.Console.WriteLine("Nhap vao so sinh vien: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < n ; i++ ){
                SinhVien Sv = new SinhVien();
                Sv.NhapThongTin();
                arrList.Add(Sv);
            }
        }
        public void InThongTin(ArrayList arrList){

            foreach(SinhVien Sv in arrList){
                Sv.HienThi();
            }
        }
        public void SuaThongTin(ArrayList arrList){
            System.Console.WriteLine("Nhap thong tin muon sua: ");
              String Ten = Console.ReadLine();
              

        }
    }
}