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
            Console.Read();
            Console.WriteLine("合計は{0}です");
        }

        static int numInput()
        {
            int num;
            Console.Write("数字を入力してください ");
            int.TryParse(Console.ReadLine(),out num);
            return num;
        }
    }
}
