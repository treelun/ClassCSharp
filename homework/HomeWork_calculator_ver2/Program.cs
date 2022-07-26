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

            public Calcurator(ref int _num1, ref int _num2, ref int _total,  ref char _op, ref char _Continue)
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

                    if (Continue == 'N' || Continue == 'n')
                    {

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
            */
            {
                //op가 int 값이 되어야함 배열을 사용하는게 맞는거같음
                //여기가 반복이 되어야함

                //Console.Write("input : ");
                //string strCalc = Console.ReadLine();// 문자열을 입력 
                //char[] arrCalc = strCalc.ToCharArray();  // 문자열을 문자 배열로 변경

                //-------------------------------------------------------------------------
                Console.Write("input : ");
                string strCalc = Console.ReadLine();// 문자열을 입력 
                char[] arrCalc = strCalc.ToCharArray();  // 문자열을 문자 배열로 변경

                 

                double[] arrNum = new double[100];  // 연산 숫자 배열   
                char[] arrOp = new char[100];  // 연산자 배열   
                int numCnt = 0;    
                int opCnt = 0;    
                bool contNum = false;  // 두자릿수 이상 연속된 숫자 인지 체크

                    for (int i = 0; i < arrCalc.Length; i++)
                    {
                        if ((arrCalc[i] >= '0') && (arrCalc[i] <= '9'))
                        {
                            if (contNum)
                                arrNum[numCnt] = (arrNum[numCnt] * 10) + double.Parse(arrCalc[i].ToString());

                            else arrNum[numCnt] = double.Parse(arrCalc[i].ToString());

                            contNum = true;
                        }
                        else
                        {
                            numCnt++;
                            arrOp[opCnt++] = arrCalc[i];
                            contNum = false;
                        }
                    }


                    // 'x', '/' 의 경우 뒤에서 부터 연산자를 하나씩 꺼내면서 결과 계산
                    // 계산 결과를 앞 숫자 배열에 넣고 뒷 숫자 배열은 0 으로 바꿔준다.
                    // 계산한 연산자 'x', '/' 는 '+'로 바꿔준다
                    double resultCalc = 0;
                    for (int i = opCnt; i >= 0; i--)
                    { switch (arrOp[i])
                        {
                            case 'x':
                                arrNum[i] = arrNum[i] * arrNum[i + 1];
                                arrNum[i + 1] = 0; arrOp[i] = '+';
                                break;
                            case '/': arrNum[i] = arrNum[i] / arrNum[i + 1];
                                arrNum[i + 1] = 0; arrOp[i] = '+';
                                break;
                            default:
                                break;
                        }
                        resultCalc = arrNum[i + 1]; }

                    // '+', '-' 연산은 앞에서 부터 계산한다.
                    for (int i = 0; i < opCnt; i++)
                    {
                        switch (arrOp[i])
                        {
                            case '+': arrNum[i + 1] = arrNum[i] + arrNum[i + 1];
                                break;
                            case '-': arrNum[i + 1] = arrNum[i] - arrNum[i + 1];
                                break;
                            default: break;
                        }
                        resultCalc = arrNum[i + 1];
                    }

                    Console.WriteLine(resultCalc);


            }


            // 연산자를 하나씩 꺼내면서 결과 계산
            }

 
    }

        


    
}

