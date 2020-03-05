using System;
using System.Linq;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 4, 6, 9, -1, 0, 3 ,1};
            Console.WriteLine("Min:{0}", Min(array));
            Console.WriteLine("Max:{0}", Max(array));
            Console.WriteLine("Average:{0}", Average(array));
            Console.WriteLine("Sum:{0}", Sum(array));
        }

        public static int Min(int[] array)
        {
            if (array == null) throw new Exception("The array is empty!");
            int min = 0;
            bool hasMin = false;
            foreach(int i in array)
            {
                if(hasMin)
                {
                    if (i < min) min = i;
                }
                else
                {
                    min = i;
                    hasMin = true;
                }
            }
            if (hasMin) return min;
            throw new Exception("Can't find!");
        }

        public static int Max(int[] array)
        {
            if (array == null) throw new Exception("The array is empty!");
            int max = 0;
            bool hasMax = false;
            foreach (int i in array)
            {
                if (hasMax)
                {
                    if (i > max) max = i;
                }
                else
                {
                    max = i;
                    hasMax = true;
                }
            }
            if (hasMax) return max;
            throw new Exception("Can't find!");
        }

        public static int Sum(int[] array)
        {
            if (array == null) throw new Exception("The array is empty!");
            int sum = 0;
            foreach (int i in array)
            {
                sum = i + sum;
            }
            return sum;
        }

        public static double Average(int[] array)
        {
            if (array == null) throw new Exception("The array is empty!");
            double sum = 0;
            double count = array.LongLength;
            foreach (int i in array)
            {
                sum = i + sum;
            }
            double avg = sum / count;
            return avg;
        }
    }
}

       

