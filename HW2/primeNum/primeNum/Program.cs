using System;

namespace practise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a num：");
            int num = Convert.ToInt32(Console.ReadLine());
            primeNum(num);
        }

        public static void primeNum(int num)
        {
            int i = 2;
            if(num>1)
            {
                Console.WriteLine("Its prime factor:");
                while (num > 1)
                {
                    for (i = 2; i < num; i++)
                    {
                        if (num % i == 0)
                        {
                            Console.WriteLine(i);
                            break;
                        }
                    }
                    num = num / i;
                }
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine("0没有素数因子");
            }
        }
    }
}
