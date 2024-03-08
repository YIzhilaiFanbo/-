using System;

namespace Array
{
    public class Array
    {
        int[] array;
        public Array(int[] array)
        {
            this.array = array;
        }
        public Array() { }

        public int Max()
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        public int Min()
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
        public int Sum()
        {
            int sum = 0;
            foreach (int i in array)
            {
                sum += i;
            }
            return sum;
        }

        public double Average()
        {
            double average = 0;
            average = (double)this.Sum() / array.Length;
            return average;
        }

        public static void Main(String[] args)
        {
            Console.WriteLine("请输入数据（用空格分开）：");
            string input = Console.ReadLine();
            string[] numbersStrings = input.Split(' ');
            int[] numbers = new int[numbersStrings.Length];
            for (int i = 0; i < numbersStrings.Length; i++)
            {
                if (int.TryParse(numbersStrings[i], out int number))
                {
                    numbers[i] = number;
                }
                else
                {
                    Console.WriteLine("无法将 '{numbersStrings[i]}' 转换为整数。");
                    numbers[i] = 0;
                }
            }
            Array a = new Array(numbers);
            Console.WriteLine("该数组最大值为：" + a.Max());
            Console.WriteLine("该数组最小值为：" + a.Min());
            Console.WriteLine("该数组所有元素和为：" + a.Sum());
            Console.WriteLine("该数组平均值为：" + a.Average());
        }
    }


}