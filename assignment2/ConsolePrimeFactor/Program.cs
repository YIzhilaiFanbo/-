using System;
using System.Collections.Generic;

namespace PrimeFactor
{
    public class PrimeFactor
    {
        int number;
        public PrimeFactor() { }
        public PrimeFactor(int number)
        {
            this.number = number;
        }
        public List<int> decompose()
        {
            List<int> primefactor = new List<int>();
            int num = number;
            if (num == 1)
            {
                primefactor.Add(num);
                return primefactor;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                int count = 0;
                while (num % i == 0 && num > 1)
                {
                    num /= i;
                    count++;
                }
                if (count != 0)
                {
                    primefactor.Add(i);
                }
            }
            if (num > 1)
            {
                primefactor.Add(num);
            }
            return primefactor;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("请输入数据：");
            string input = Console.ReadLine();
            int num = int.Parse(input);
            PrimeFactor number = new PrimeFactor(num);
            List<int> primefactor = number.decompose();
            Console.WriteLine("以下是它的素数因子：");
            foreach (int i in primefactor)
            {
                Console.Write(i + " ");
            }
        }
    }

}