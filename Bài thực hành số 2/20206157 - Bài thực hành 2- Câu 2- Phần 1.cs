/* Họ và tên : Nguyễn Quang Minh
   MSSV : 20206157
*/

// Đề bài : Sử dụng vòng for để in hết ký tự A->Z

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_thực_hành_số_2
{
    class Câu_2
    {
        static void Main(String[] args)
        {
            for(char c = 'A'; c <= 'Z'; c++)
            {
                Console.WriteLine(c);
            }
        }
    }
}
