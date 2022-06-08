using System;

namespace ITC_Github_Study
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;

            n = numInput();
            m = numInput();

            n += m;
            Console.WriteLine(n);
        }

        static int numInput()
        {
            int num;
            Console.Write("数字を入力してください ");
            num = int.Parse(Console.ReadLine());
            return num;
        }
    }
}
