using System;
using System.Collections.Generic;
using System.Linq;

namespace BTONTAP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Products> Pr = new List<Products>();
            
            for (int i = 1; i <= 6; i++)
            {
                Products p = new Products();
                p.Product = "Pr" + i;
                p.Id = i;
                p.Name = "SP" + i;
                p.Price = 100 * i;
                p.Category = "Loai" + i;
                Pr.Add(p);
            }

            Console.WriteLine("San pham gia > 500: ");
            var SP = Pr.Where(x => x.Price > 500);
            foreach (Products p in SP) 
                Console.WriteLine(p);
            Console.WriteLine("Sap xep tang dan: ");
            var SX = Pr.OrderBy(x => x.Price).ToList();
            foreach (Products p in SX)
                Console.WriteLine(p);
            Console.WriteLine("Ba san pham re nhat: ");
            var SPRe = Pr.OrderBy(x => x.Price).Take(3);
            foreach (Products p in SPRe)
                Console.WriteLine(p);
            Console.Write("Nhap ten SP: ");
            string NhapSP = Console.ReadLine();
            if (Pr.Any(x => x.Name == NhapSP))
            {
                var HThi = Pr.Where(x => x.Name == NhapSP);
                Console.WriteLine("Tim thay: ");
                foreach (Products p in HThi)
                    Console.WriteLine(p);
            }
            else
                Console.WriteLine("Khong tim thay");

            var Tong = Pr.Sum(x => x.Price);
            Console.Write("Tong gia tri san pham: {0}", Tong);
            var Tb = Pr.Average(x => x.Price);
            Console.WriteLine("\nGia trung binh: {0}", Tb);
            Console.ReadKey();
        }
    }
}