using System;

namespace task4
{
    class Program
    {
        static int Argu(int a,int b)
        {
            int result = 0 , c= 0,i=0 ;
            while(a!=0)
            {
                c = a % 10;
                a /= 10;
                i++;
                if (b==i)
                {
                    result = c;
                     
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int result = Argu(a,b);
            Console.WriteLine(result);
        }
    }
}
