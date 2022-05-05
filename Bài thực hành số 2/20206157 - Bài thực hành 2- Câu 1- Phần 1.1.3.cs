using System;
using System.Text;
using System.IO;

namespace Bài_thực_hành_số_2
{
    class Cập_nhật_dữ_liệu_từ_file
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string noidung = "\nTrường đại học Bách Khoa Hà Nội";
            File.AppendAllText("B:/KTLT thầy Nam/Bài thực hành số 2/io2.txt", noidung);

            // Đọc file vừa ghi
            string a = File.ReadAllText("B:/KTLT thầy Nam/Bài thực hành số 2/io2.txt");
            Console.WriteLine(a);

            Console.ReadKey();
        }
    }
}
