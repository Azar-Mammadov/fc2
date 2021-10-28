using System;

namespace fc2
{
    class Program
    {
        //Task 6. Write a C# program tonput any number from user andfind cube of the given numberusing method.
        static int cub(int a)
        {
            int result = 0;
            result = a * a * a;
            return result;
        }
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int result = cub(a);
            Console.WriteLine(result);
        }
    }
}
