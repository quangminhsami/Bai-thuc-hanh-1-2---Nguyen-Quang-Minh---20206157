/* Họ và tên : Nguyễn Quang Minh
   MSSV : 20206157
*/

// Đề bài : Giải phương trình bậc 2 với số phức​

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Bài_thực_hành_số_1
{
    class Câu_2___Phần_c_2
    {
        static void Main(string[] args)
        {
            float a, b, c;
            Console.WriteLine("Nhap a: ");
            a = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhap b: ");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhap c: ");
            c = float.Parse(Console.ReadLine());

            if (a == 0) // giai pt bac nhat
            {
                if (b == 0 && c == 0)
                {
                    Console.WriteLine("Phuong trinh vo so nghiem");
                }
                else if (b == 0 && c != 0)
                {
                    Console.WriteLine("Phuong trinh khong co nghiem");
                }
                else
                {
                    float x = (float)(-c / b);
                    Console.WriteLine("Phuong trinh co nghiem x = " + x);
                }
            }
            else
            {
                float delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    float real = (float)(-b / (2 * a));
                    float img = (float)(Math.Sqrt(-delta) / (2 * a));
                    Console.WriteLine("root 1 = {0} + {1}i, root 2 = {2} - {3}i", real, img, real, img);
                }
                else if (delta == 0)
                {
                    Console.WriteLine("Phuong trinh co nghiem kep x = " + (float)(-b / (2 * a)));
                }
                else
                {
                    float x1 = (float)(-b - Math.Sqrt(delta)) / (2 * a);
                    float x2 = (float)(-b + Math.Sqrt(delta)) / (2 * a);

                    Console.WriteLine("Nghiem phuong trinh la:");
                    Console.WriteLine("x1 = " + x1);
                    Console.WriteLine("x2 = " + x2);
                }
            }
        }
    }
}
