using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nhap vao chieu dài, chieu rong
            Console.Write(" Nhap vao chieu dai: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap vao chieu rong: ");
            double b = Convert.ToDouble(Console.ReadLine());
            // Tính chu vi và diện tích
            double fl = (a + b) * 2;
            double S = a * b;
            // Hiển thị kết quả
            Console.WriteLine("Chu vi la: " + fl);
            Console.WriteLine("Dien tich la: " + S);
        }
    }
}
