using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();

            Console.WriteLine(int.Parse(str[0]) + int.Parse(str[1]));
        }
            

    }
}