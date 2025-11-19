using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyHocSinh_LINQ
{
    class HocSinh
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<HocSinh> danhSachHocSinh = new List<HocSinh>()
            {
                new HocSinh { Id = 1, Name = "An", Age = 16 },
                new HocSinh { Id = 2, Name = "Anh", Age = 17 },
                new HocSinh { Id = 3, Name = "Truc", Age = 15 },
                new HocSinh { Id = 4, Name = "An Nhien", Age = 19 },
                new HocSinh { Id = 5, Name = "Mai", Age = 18 }
            };

            int choice;

            do
            {
                Console.WriteLine("\n===== MENU QUAN LY HOC SINH =====");
                Console.WriteLine("1. In danh sach hoc sinh");
                Console.WriteLine("2. Tim hoc sinh co tuoi tu 15 den 18");
                Console.WriteLine("3. Tim hoc sinh co ten bat dau bang chu 'A'");
                Console.WriteLine("4. Tinh tong tuoi cua hoc sinh");
                Console.WriteLine("5. Tim hoc sinh lon tuoi nhat");
                Console.WriteLine("6. Sap xep theo tuoi tang dan");
                Console.WriteLine("0. Thoat chuong trinh");
                Console.Write("Nhap lua chon: ");

                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Danh sach hoc sinh:");
                        danhSachHocSinh.ForEach(hs =>
                            Console.WriteLine($"{hs.Id} - {hs.Name} - {hs.Age}"));
                        break;

                    case 2:
                        Console.WriteLine("Hoc sinh tu 15 den 18 tuoi:");
                        var hs15_18 = danhSachHocSinh.Where(hs => hs.Age >= 15 && hs.Age <= 18);
                        foreach (var hs in hs15_18)
                            Console.WriteLine($"{hs.Name} - {hs.Age}");
                        break;

                    case 3:
                        Console.WriteLine("Hoc sinh co ten bat dau bang A:");
                        var tenA = danhSachHocSinh.Where(hs => hs.Name.StartsWith("A"));
                        foreach (var hs in tenA)
                            Console.WriteLine(hs.Name);
                        break;

                    case 4:
                        int tongTuoi = danhSachHocSinh.Sum(hs => hs.Age);
                        Console.WriteLine($"Tong tuoi cac hoc sinh: {tongTuoi}");
                        break;

                    case 5:
                        int maxAge = danhSachHocSinh.Max(hs => hs.Age);
                        var lonNhat = danhSachHocSinh.Where(hs => hs.Age == maxAge);
                        Console.WriteLine("Hoc sinh lon tuoi nhat:");
                        foreach (var hs in lonNhat)
                            Console.WriteLine($"{hs.Name} - {hs.Age}");
                        break;

                    case 6:
                        Console.WriteLine("Sap xep theo tuoi tang dan:");
                        var sortAsc = danhSachHocSinh.OrderBy(hs => hs.Age);
                        foreach (var hs in sortAsc)
                            Console.WriteLine($"{hs.Name} - {hs.Age}");
                        break;

                    case 0:
                        Console.WriteLine("Da thoat chuong trinh!");
                        break;

                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }

            } while (choice != 0);
        }
    }
}
