using System;

namespace task5
{
    class Program
    {
        static string argu(int a)
        {
            int b=0,i = 0;
            string s = "";
            string bin = "",result = "";
            while(a>=1)
            {
                b = a / 2;
                s += (a % 2).ToString();
                a = b; ;
            }
            for ( i =s.Length-1; i >= 0; i--)
            {
                bin += s[i];
                result = bin;
            }
            return result;
        }
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            string result = argu(a);
            Console.WriteLine(result);
        }
    }
}
