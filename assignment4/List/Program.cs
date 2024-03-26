using System;
namespace assignment4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GenericList<int> intlist = new GenericList<int>();
            for (int i = 0; i < 10; i++)
            {
                intlist.Add(i);
            }
            //遍历
            intlist.ForEach(i => Console.WriteLine(i));
            //最大值
            int max = int.MinValue;
            intlist.ForEach(i => { if (i > max) max = i; });
            Console.WriteLine(max);
            //最小值
            int min = int.MaxValue;
            intlist.ForEach(i => { if (i < min) min = i; });
            Console.WriteLine(min);
            //求和
            int sum = 0;
            intlist.ForEach(i => sum += i);
            Console.WriteLine(sum);
            GenericList<string> strlist = new GenericList<string>();
            for (int i = 0; i < 10; i++)
            {
                strlist.Add("str" + i);
            }
            strlist.ForEach(s => Console.WriteLine(s));
        }
    }
}