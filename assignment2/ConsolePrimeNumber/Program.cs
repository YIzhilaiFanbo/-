using System;

namespace PrimeNumber
{
    public class PrimeNumber
    {
        int number;
        public PrimeNumber() { }

        public PrimeNumber(int number)
        {
            this.number = number;
        }

        public int[] primeNumber()
        {
            int[] primeNumber = new int[number - 1];
            for (int i = 0; i < number - 1; i++)
            {
                primeNumber[i] = i + 2;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                for (int j = 0; j < number - 1; j++)
                {
                    if (primeNumber[j] != 0 && primeNumber[j] != i && primeNumber[j] % i == 0)
                    {
                        primeNumber[j] = 0;
                    }
                }

            }
            return primeNumber;
        }

        public static void Main(string[] args)
        {
            int num = 100;
            PrimeNumber p = new PrimeNumber(num);
            int[] primeNumber = p.primeNumber();
            Console.WriteLine("2至" + num + "以内的素数有");
            for (int i = 0; i < num - 1; i++)
            {
                if (primeNumber[i] != 0)
                {
                    Console.Write(primeNumber[i] + " ");
                }
            }
        }
    }
}