using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
// Bai 1 Viet PTB2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testt
{
    internal class PTB2;
    {
    static void giaiPTBac2(float a, float b, float c)
    {
        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else
            {
                Console.WriteLine("Phuong trinh co mot nghiem: x={0}", (-c / b));
            }
            return;
        }
        // Tinh delta
        float delta = b * b - 4 * a * c;
        float x1;
        float x2;
        if (delta > 0)
        {
            x1 = (float)((-b + Math.Sqrt(delta)) / (2 * a));
            x2 = (float)((-b - Math.Sqrt(delta)) / (2 * a));
            Console.Write("Phuong trinh co 2 nghiem la: x1 = {0} va x2 = {1}", x1, x2);
        }
        else if (delta == 0)
        {
            x1 = (-b / (2 * a));
            Console.Write("Phong trinh co nghiem kep: x1 = x2 = {0}", x1);
        }
        else
        {
            Console.Write("Phuong trinh vo nghiem!");
        }
    }
}
/**
 * Ham main
*/
static void Main(string[] args)
{
    float a, b, c;
    Console.Write("Nhap he so bac 2, a = ");
    String valA = Console.ReadLine();
    a = Convert.ToInt32(valA);
    Console.Write("Nhap he so bac 1, b = ");
    String valB = Console.ReadLine();
    b = Convert.ToInt32(valB);
    Console.Write("Nhap he so bac 0, c = ");
    String valC = Console.ReadLine();
    c = Convert.ToInt32(valC);
    giaiPTBac2(a, b, c);

}
   
  

// Bai 2 Tinh tien dien cua gia dinh
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_Test1;
{
    internal class Program;
    {
    static void Main(string[] args)
    {
        Console.Write("Nhap vao muc tieu thu ");
        float n = float.Parse(Console.ReadLine());
        float tiendien;

        if (n > 0 && n < 26)
        {
            tiendien = n * 1000;
            Console.WriteLine("Gia la 1000d");
        }
        else if (n > 25 && n < 76)
        {
            tiendien = 25 * 1000 + ((n - 25) * 1250);
            Console.WriteLine("Gia la 1250d");
        }
        else if (n > 75 && n < 151)
        {
            Console.WriteLine("Gia la 1800d");
        }
        else
        {
            Console.WriteLine("gia la 2500d");
        }
    }
}


// Bai3 
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, P, S;
            Console.WriteLine("Nhap vao chieu dai a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap vao chieu rong b: ");
            b = Convert.ToDouble(Console.ReadLine());
            P = (a + b) * 2;
            S = a * b;
            Console.WriteLine($"Chu vi hinh chu nhat la: {P}");
            Console.WriteLine($"Dien tich hinh chu nhat la:{S}");
        }
    }
}

// Bai 4:
interface INews;
{
    void News();
}
class News : INew s
{
    void display();
    int
}
