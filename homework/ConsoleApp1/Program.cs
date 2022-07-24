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
    }
}
