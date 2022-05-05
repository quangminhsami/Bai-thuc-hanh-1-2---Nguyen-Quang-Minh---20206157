/* Họ và tên : Nguyễn Quang Minh
   MSSV : 20206157
*/

// Đề bài : In được cây thông nô en theo chiều cao nhập vào​

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_thực_hành_số_1
{
    class Câu_2__Phần_d
    {
        static void noelTree(int h)
        {
			// draw body tree
			for (int i = 1; i <= h; i++)
			{
				//draw space
				for (int j = 1; j <= h - i; j++)
				{
					Console.Write(" ");
				}
				//draw *
				for (int k = 1; k <= i; k++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
			// draw root tree
			for (int i = 1; i <= 3; i++)
			{
				for (int j = 1; j < h - 2; j++)
				{
					Console.Write(" ");
				}
				for (int k = 1; k <= 3; k++)
				{
					Console.Write("**");
				}
				Console.WriteLine();
			}
		}
        static void Main(string[] args)
        {
			int h = Convert.ToInt32(Console.ReadLine());
			noelTree(h);

			Console.ReadKey();
        }
    }
}
