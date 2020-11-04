using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {
            TTriangle tringle1 = new TTriangle(7, 5, 4);

            tringle1.SideC = 1;
            tringle1.SideB = 2;
            Console.WriteLine(tringle1.SideA + " " + tringle1.SideB + " " + tringle1.SideC);
            Console.ReadKey();
        }
    }
}