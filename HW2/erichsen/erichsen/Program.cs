using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erichsen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The prime number within 2-100 :");
            int[] array = new int[105];
            for(int i=2;i<array.Length;i++)
            {
                array[i] = 1;
            }
            for (int i = 2 ; i <=100; i++)
            {
                if(array[i]==1)
                {
                    int j = i + 1;
                    while(j<=100)
                    {
                        if(array[j]==1&&j%i==0)
                        {
                            array[j] = 0;
                        }
                        j++;
                    }
                }
            }
            for(int i=2;i<101;i++)
            {
                if (array[i] == 1)
                    Console.WriteLine(i);
            }
        }
    }
}
