using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_car
{
    class Program
    {

        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0, total = 0;
            char op = ' ', con = ' ';
            

            Console.Write("input1 : ");
            num1 = int.Parse(Console.ReadLine());
            while (true)
            {
                Console.Write($"insert type : ");
                op = Console.ReadKey().KeyChar;
                Console.ReadLine();
                Console.Write("input2 : ");
                num2 = int.Parse(Console.ReadLine());
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
                    
                Console.WriteLine($"{total} \n\n");
                Console.Write("Continue? (Y/N) : ");
                con = Console.ReadKey().KeyChar;
                Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();
                if (con == 'Y' || con == 'y')
                {
                    num1 = total;
                    continue;
                }
                else if (con == 'N' || con == 'n')
                {
                    Console.WriteLine("Finish");
                    break;
                }
                else
                {
                    Console.WriteLine("error");
                    break;
                }
                
            }
            return;
        }
    }
}
