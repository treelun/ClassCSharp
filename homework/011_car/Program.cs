using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_car
{
    class Program
    {

        static int Calculator(ref int num1, ref int num2, ref int total, ref char op)
        {
            int result = 0;

            switch (op)
            {
                case '+':
                    total = num1 + num2;
                    break;
                case '-':
                    total = num1 - num2;
                    break;
                case '*':
                    total = num1 * num2;
                    break;
                case '/':
                    total = num1 / num2;
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
            Console.WriteLine($"{num1}{op}{num2} = {total} \n\n");
            return result;
        }
        static void Main(string[] args)
        {

        }
    }
}
