
using System;
using System.Collections.Generic;

namespace Baitap2Lab2
{
    struct HangHoa
    {
        public int MaHH;
        public string TenHH;
        public int SoLuong;
        public double DonGia;

        // Ham tao
        public HangHoa(int ma, string ten, int sl, double gia)
        {
            MaHH = ma;
            TenHH = ten;
            SoLuong = sl;
            DonGia = gia;
        }

        // Ham tinh thanh tien
        public double ThanhTien()
        {
            return SoLuong * DonGia;
        }

        public override string ToString()
        {
            return string.Format(
                "{0} - {1} - {2} cai x {3} d = {4} d",
                MaHH, TenHH, SoLuong, DonGia, ThanhTien()
            );
        }
    }

    internal class Program
    {
        static void ThemHangHoa(List<HangHoa> ds)
        {
            Console.Write("Nhap ma hang hoa: ");
            int ma = int.Parse(Console.ReadLine());

            if (TimHangHoa(ds, ma))
            {
                Console.WriteLine("Ma hang hoa da ton tai!");
                return;
            }

            Console.Write("Nhap ten hang hoa: ");
            string ten = Console.ReadLine();

            Console.Write("Nhap so luong: ");
            int sl = int.Parse(Console.ReadLine());

            Console.Write("Nhap don gia: ");
            double gia = double.Parse(Console.ReadLine());

            HangHoa hh = new HangHoa(ma, ten, sl, gia);
            ds.Add(hh);

            Console.WriteLine("Them thanh cong!");
        }
        static bool TimHangHoa(List<HangHoa> ds, int ma)
        {
            foreach (HangHoa hh in ds)
            {
                if (hh.MaHH == ma)
                    return true;
            }

            return false;
        }
        static void XuatDanhSach(List<HangHoa> ds)
        {
            Console.WriteLine("\nDANH SACH HANG HOA:");

            if (ds.Count == 0)
            {
                Console.WriteLine("Danh sach rong!");
                return;
            }

            foreach (HangHoa hh in ds)
            {
                Console.WriteLine(hh);
            }
        }
        static bool XoaHangHoa(List<HangHoa> ds, int ma)
        {
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i].MaHH == ma)
                {
                    ds.RemoveAt(i);
                    return true;
                }
            }

            return false;
        }

        static void Main(string[] args)
        {
            List<HangHoa> dssp = new List<HangHoa>();

            string tiepTuc;
            do
            {
                ThemHangHoa(dssp);

                Console.Write("Tiep tuc nhap? (y/n): ");
                tiepTuc = Console.ReadLine();

            } while (tiepTuc.ToLower() == "y");
            XuatDanhSach(dssp);
            Console.Write("\nNhap ma hang hoa can tim: ");
            int ma = int.Parse(Console.ReadLine());

            if (TimHangHoa(dssp, ma))
            {
                Console.WriteLine("Tim thay hang hoa!");
  
            }
            else
            {
                Console.WriteLine("Khong tim thay hang hoa!");
            }
            Console.Write("\nNhap ma hang hoa can xoa: ");
            ma = int.Parse(Console.ReadLine());
            if (XoaHangHoa(dssp, ma))
            {
               Console.WriteLine("Xoa thanh cong!");
               XuatDanhSach(dssp);
            }
            else
            { 
               Console.WriteLine("Xoa khong thanh cong!");
            }

            Console.ReadKey();
        }
    }
}
