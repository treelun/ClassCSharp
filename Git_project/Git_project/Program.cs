using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_project
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 3;
            string s1 = "hi";
            Console.WriteLine("Hello World");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"{i}{s1}");
            Console.WriteLine(""+ i + s1);
            
            Console.WriteLine("{0}{1}", i, s1);




        }
    }
}
