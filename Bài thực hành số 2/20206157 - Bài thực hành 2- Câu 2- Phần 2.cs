/* Họ và tên : Nguyễn Quang Minh
   MSSV : 20206157
*/

// Đề bài: Viết chương trình kiểm tra một số có phải số nguyên tố hay không​

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
            int i, n, dem = 0;
            Console.WriteLine("Nhập số nguyên dương n: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n < 2)
            {
                Console.WriteLine("{0} không là số nguyên tố", n);
            }
            for(i = 2; i <= Math.Sqrt(n); i++)
            {
                if(n % i == 0)
                    {
                        dem = dem + 1;
                    }
            }
            if (dem == 0)
            {
            Console.WriteLine("{0} là số nguyên tố", n);
            }
            else
            {
                Console.WriteLine("{0} không là số nguyên tố", n);
            }
        }
    }
}
