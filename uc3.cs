using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uc3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int parttime = 4;
            int wage = 20;
            int fulltime = 8;

            Console.WriteLine("Part time employee : " + (parttime * wage));
            Console.WriteLine("By adding both full time and part time  : " + (parttime * wage + fulltime * wage));
            Console.ReadLine();
        }
    }
}
