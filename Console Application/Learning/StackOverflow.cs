using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            BadGuy bg = new BadGuy();
            bg.BadMethod();
        }
    }

    class BadGuy
    {
        public void BadMethod()
        {
            int x = 100;
            this.BadMethod();
        }
    }
}
