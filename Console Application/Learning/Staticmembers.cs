//即使类没有实例，也存在静态成员，并且可以访问
//实例成员必须在创建一个实例后才存在

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staticmembers
{
    class D
    {
        public int mem1;
        static public int mem2;
    }
    class Program
    {
        static void Main(string[] args)
        {
            D d=new D();
            d.mem1 = 10;
            D.mem2 = 5;
            Console.WriteLine("mem1 = {0},mem2 = {1}", d.mem1, D.mem2);
        }
    }
}
