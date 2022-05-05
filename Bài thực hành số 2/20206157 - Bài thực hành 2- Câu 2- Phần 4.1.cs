// Nguyễn Quang Minh 20206157
// Đề bài : Tìm ước số chung lớn nhất của 2 số
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_thực_hành_số_2
{
    class Câu_2
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int a, b, UCLN;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (a == 0|| b == 0)
            {
                Console.WriteLine("USCLN là {0}", a + b);
            }
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            UCLN = a;
            Console.WriteLine("USCLN là : {0} " ,UCLN);
        }
    }
}
