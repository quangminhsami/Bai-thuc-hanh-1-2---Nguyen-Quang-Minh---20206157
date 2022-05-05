/* Họ và tên : Nguyễn Quang Minh
   MSSV : 20206157
*/

// Đề bài: Chạy chương trình "Chào bạn, mình đến với thế giới lập trình" có nhập tên mình​

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_thực_hành_số_1
{
    class Câu_2___Phần_b
    {
        static void Main(string[] args)
        {
            string name;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Nhập tên:");
            Console.InputEncoding = Encoding.Unicode;
            name = Console.ReadLine();
            Console.WriteLine("Chào " + name + " đến với thế giới lập trình");

            Console.ReadKey();
        }
    }
}
