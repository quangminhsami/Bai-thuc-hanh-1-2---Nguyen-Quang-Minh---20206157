using System;
using System.Text;
using System.IO;

namespace Bài_thực_hành_số_2
{
    class Ghi_nội_dung_vào_1_file
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string noidung = "Nguyễn Quang Minh - 20206157";
            File.WriteAllText("B:/KTLT thầy Nam/Bài thực hành số 2/io2.txt", noidung);
            // Đọc file vừa ghi
            string a = File.ReadAllText("B:/KTLT thầy Nam/Bài thực hành số 2/io2.txt");
            Console.WriteLine(a);

            Console.ReadKey();
        }
    }
}
