using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace drawing
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            
            while (true)
            {
                
                for (int i = 0; i < 30; i++)
                {
                    int value = ran.Next(998, 1001);
                    Console.WriteLine(value);
                    
                }
                break;
            }

        }
    }
}
