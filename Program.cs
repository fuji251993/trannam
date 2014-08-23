using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class Program
    {
        static void Main(string[] args)
        {
        float a, b,s;
            Console.Write("Nhap chieu dai:");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong:");
            b = int.Parse(Console.ReadLine());
            s = a * b;
            Console.WriteLine("Dien tich la = {0}",s);
            Console.ReadLine();
        }
    }
}
