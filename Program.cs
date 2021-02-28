using System;

namespace HomeWork_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            Console.ReadLine();
            int N = int.Parse(Console.ReadLine());
            

            for (int i = 0; i <= N; i++)
                if (Simple(i))
                {
                    Console.WriteLine(i.ToString() + "\n");
                }
        }

        private static bool Simple(int N)
        {
            for (int i = 2; i <= N / 2; i++)
                if (N % i == 0)
                {
                    return false;
                    
                }
                else return true;
            
        }

    }
}
