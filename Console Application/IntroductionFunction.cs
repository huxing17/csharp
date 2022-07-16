using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introductionfunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            int sum = c.Add(2, 3);
            string d = c.Today();
            Console.WriteLine(sum);
            Console.WriteLine(d);
            c.PrintString(2, 3);
        }
    }

    class Calculator
    {
        public int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }

        public string Today()
        {
            int day = DateTime.Now.Day;
            return day.ToString();
        }

        public void PrintString(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }
    }
}
