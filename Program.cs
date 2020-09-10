using System;
using System.Text;

namespace _20songuyentodautien
{
    class Program
    {
        static int rs(int i, int index, int count)
        {
            index = 0;
            for (i = 2; i < 200; i++)
            {
                bool check = true;
                for (count = 2; count <= Math.Sqrt(i); count++)
                {
                    if (i % count == 0)
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                {
                    index = index + 1;
                    if (index <= 20)
                    {
                        Console.WriteLine(i + "\t");
                    }
                }
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("20 số nguyên tố đầu tiên là:");
            int i = Program.rs(0, 0, 0);
        }
    }
}
