using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            int result = c.SumFrom1ToX(100);
            Console.WriteLine(result);
        }
    }

    class Calculator
    {
        //循环
        //public int SumFrom1ToX(int x)
        //{
        //    int result = 0;
        //    for (int i = 0; i < x+1; i++)
        //    {
        //        result = result + i;
        //    }
        //    return result;
        //}

        //递归
        //public int SumFrom1ToX(int x)
        //{
        //    if(x==1)
        //    {
        //        return 1;
        //    }
        //    else
        //    {
        //        int result = x + SumFrom1ToX(x - 1);
        //        return result;
        //    }
        //}

        //公式
        public int SumFrom1ToX(int x)
        {
            return (1 + x) * x / 2;
        }
    }
}
