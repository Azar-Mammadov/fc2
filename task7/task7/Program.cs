using System;

namespace task7
{
    class Program
    {
        static int argu(int a)
        {
            int bol = 0,result=0;
            while(a!=0)
            {
                bol = a % 10;
                a /= 10;
                result++; 
            }
            return result;
        }
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int result = argu(a);
            Console.WriteLine(result);
        }
    }
}
