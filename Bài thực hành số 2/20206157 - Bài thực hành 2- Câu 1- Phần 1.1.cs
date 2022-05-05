using System;
using System.Text;
using System.IO;

namespace Bài_thực_hành_số_2
{
    class Đọc_file_có_sẵn
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nội dung trong file: ");
            string a = File.ReadAllText("B:/KTLT thầy Nam/Bài thực hành số 2/io1.txt");
            Console.WriteLine(a);

            Console.ReadKey();
        }
    }
}
