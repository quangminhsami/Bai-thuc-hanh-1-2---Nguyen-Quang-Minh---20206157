// Nguyễn Quang Minh 20206157
// Đề bài : Tìm bội số chung nhỏ nhất của 2 số
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_thực_hành_số_2
{
    class Câu_2_4_2
    {
        static int gcd(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                return a + b;
            }
            while (a != b)
            {
                if (a > b)
                {
                    a-= b;
                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int a, b, lcm;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            lcm = (a * b) / gcd(a, b);
            Console.WriteLine("Bội số chung nhỏ nhất của {0} và {1} là {2}", a, b, lcm);

        }
    }
}
