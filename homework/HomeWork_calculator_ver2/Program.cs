using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_calculator_ver2
{
    class Program
    {
        static void conti(ref char Continue)
        {
            Console.Write("Continue? (Y/N) : ");
            Continue = Console.ReadKey().KeyChar;
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
        }
        static void input(ref int num1, ref int num2, ref char op)
        {
            Console.Write("input1 : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write($"insert type : ");
            op = Console.ReadKey().KeyChar;
            Console.ReadLine();
            Console.Write("input2 : ");
            num2 = int.Parse(Console.ReadLine());
        }
        static int cal(ref int num1, ref int num2, ref int total, ref char op)
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
        static int cal2(ref int total, ref char op)
        {

            int result = 0;

            switch (op)
            {
                case '+':
                    total = total + total;
                    break;
                case '-':
                    total = total - total;
                    break;
                case '*':
                    total = total * total;
                    break;
                case '/':
                    total = total / total;
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
            Console.Write("");
            return result;
        }
        public struct Calcurator
        {
            int num1;
            int num2;
            int total;



            char op;
            char Continue;

            public Calcurator(ref int _num1, int _num2, int _total,  char _op, char _Continue)
            {
                num1 = _num1;
                num2 = _num2;
                total = _total;

                op = _op;
                Continue = _Continue;
            }
            public int Getnum1()
            {

                return num1;
            }
            public int Getnum2()
            {
                return num2;
            }
            public int Gettransnum1()
            {

                return num1;
            }
            public char GetOp(char _op)
            {
                return op;
            }
            public char GetContinue(char _Continue)
            {
                return Continue;
            }
            public void Setnum1(int _num1)
            {
                Console.Write("input1 : ");
                _num1 = int.Parse(Console.ReadLine());
                num1 = _num1;
            }
            public void Setnum2(int _num2)
            {
                Console.Write("input2 : ");
                _num2 = int.Parse(Console.ReadLine());
                num2 = _num2;
            }
            public void SetnOP(char _op)
            {
                Console.Write($"insert type : ");
                _op = Console.ReadKey().KeyChar;
                Console.ReadLine();
                op = _op;
            }
            public void transnum1(int total)
            {
                num1 = total;
            }
            public void SetConti(char _Continue)
            {
                Console.Write("Continue? (Y/N) : ");
                _Continue = Console.ReadKey().KeyChar;
                Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();
                Continue = _Continue;
            }

            public int Cal()
            {
                

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

                return total;
            }


        }

        static void Main(string[] args)
        {
            /*
            Console.Write("input2 : ");
            { 
                int num1 = 0, num2 = 0, total = 0;
                char op = ' ', Continue = ' ';


                input(ref num1, ref num2, ref op);

                while (true)
                {


                    cal(ref num1, ref num2, ref total, ref op);

                    conti(ref Continue);

                    num1 = total;

                    


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
            */
            {
                int num1 = 0, num2 = 0, total = 0;
                char op = ' ', Continue = ' ';

                Calcurator curator = new Calcurator();

                curator.Setnum1(num1);
                curator.Setnum2(num2);
                curator.SetnOP(op);
                curator.Cal();
                Console.Write($"{curator.Getnum1()} {curator.GetOp(op)} {curator.Getnum2()} = {curator.Cal()}");
                Console.WriteLine();
                while (true)
                {
                    curator.Setnum2(num2);
                    curator.SetnOP(op);
                    curator.Cal();
                    curator.SetConti(Continue);
                    curator.GetContinue(Continue);
                    Console.Write($"{curator.GetContinue(Continue)}");
                    Console.WriteLine();
                    if (Continue == 'N' || Continue == 'n')
                    {
                        curator.transnum1(total);
                        curator.Cal();
                        Console.Write($"{curator.Getnum1()} {curator.GetOp(op)} {curator.Getnum2()} = {curator.Cal()}");
                    }
                    else if (Continue == 'Y' || Continue == 'y')
                    {
                        continue;
                    }

                    else
                    {
                        Console.Write("Finish");
                    }
                }
                return;
            }
            
            //{
            //    //op가 int 값이 되어야함 배열을 사용하는게 맞는거같음

            //    char[] arrayinput = new char[11] {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };

            //    char index = ' ';

            //    for (int i = 0; i < arrayinput.Length; i++)
            //    {
            //        Console.Write($"input: ");
            //        index = char.Parse(Console.ReadLine());
            //        Console.WriteLine();
            //        arrayinput[i] = index;
            //        Console.Write($"[{i}]: {arrayinput[i]}");
            //        Console.WriteLine();
            //    }

            //}

               
        }
    }
}
