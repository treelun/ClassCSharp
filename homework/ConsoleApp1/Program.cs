using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstInput = "";
            string secondInput = "";
            string calcu = "";

            Console.Write("input1 : ");
            Console.ReadLine();

            Console.Write("input2 : ");
            Console.ReadLine();

            Console.Write("calcu : ");
            Console.ReadLine();

            int result = calculator(int.Parse(firstInput), int.Parse(secondInput), calcu);


            Console.WriteLine("the Result : " + result);

        }

        static int calculator(int num1, int num2, string type)
        {

            int result = 0;


            switch (type)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;


                default:

                    break;
            }

            return result;


        }

        static int cal(int num1, int num2, int total, char op)
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
            Console.WriteLine($"{total}\n\n");
            return result;
        }
        static void Main(string[] args)
        {
            {
                int num1 = 0, num2 = 0, total = 0, contotal = 0;
                char op = ' ', Continue = ' ';





                Console.Write("input1 : ");
                num1 = int.Parse(Console.ReadLine());
                Console.Write($"insert type : ");
                op = Console.ReadKey().KeyChar;
                Console.ReadLine();
                Console.Write("input2 : ");
                num2 = int.Parse(Console.ReadLine());

                while (true)
                {


                    cal(num1, num2, total, op);

                    Console.Write("Continue? (Y/N) : ");
                    Continue = Console.ReadKey().KeyChar;
                    Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine();


                    if (Continue == 'Y' || Continue == 'y')
                    {

                        Console.Write($"insert type : ");
                        op = Console.ReadKey().KeyChar;
                        Console.ReadLine();
                        Console.Write("input2 : ");
                        num2 = int.Parse(Console.ReadLine());




                        continue;

                    }
                    else if (Continue == 'N' || Continue == 'n')
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
            Console.ReadKey();
        }
}
