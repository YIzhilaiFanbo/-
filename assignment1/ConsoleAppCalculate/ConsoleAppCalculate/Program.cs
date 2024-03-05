using System;

namespace Calculate
{
    public class Calculate
    {

        public double calculate(double x, double y, char ch)
        {
            double result = 0;
            switch (ch)
            {
                case '+':
                    result = x + y;
                    break;
                case '-':
                    result = x - y;
                    break;
                case '*':
                    result = x * y;
                    break;
                case '/':
                    result = x / y;
                    break;
            }
            return result;
        }
        public static void Main(string[] args)
        {
            Calculate cal = new Calculate();
            Console.WriteLine("请输入第一个运算数：");
            string num = Console.ReadLine();
            double num1 = Double.Parse(num);
            Console.WriteLine("请输入第二个运算数：");
            num = Console.ReadLine();
            double num2 = Double.Parse(num);
            Console.WriteLine("请输入运算符：");
            char opand = (char)System.Console.Read();
            Console.WriteLine("计算结果为：" + cal.calculate(num1, num2, opand));
        }
    }

}