using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите X");
            double x = Convert.ToInt32(Console.ReadLine());
            double y = 5 * Math.Sin(x) - 7 * Math.Cos(x);
        }
    }
}
