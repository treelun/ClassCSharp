using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_2week
{
    public class Carclulator
    {
        public int num1 = 0, num2 = 0, total = 0;
        public char op = ' ', Continue = ' ';
        public void conti(ref char Continue)
        {
            Console.Write("Continue? (Y/N) : ");
            Continue = Console.ReadKey().KeyChar;
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        public void input(ref int num1, ref int num2, ref char op)
        {
            Console.Write("input1 : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write($"insert type : ");
            op = Console.ReadKey().KeyChar;
            Console.ReadLine();
            Console.Write("input2 : ");
            num2 = int.Parse(Console.ReadLine());
        }

        public void input(ref int num2, ref char op)
        {

            Console.Write($"insert type : ");
            op = Console.ReadKey().KeyChar;
            Console.ReadLine();
            Console.Write("input2 : ");
            num2 = int.Parse(Console.ReadLine());
        }
        public int cal(ref int num1, ref int num2, ref int total, ref char op)
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
        public int roop(ref char Continue, ref int num2, ref char op)
        {
            int result = 0;

            if (Continue == 'Y' || Continue == 'y')
            {

                input(ref num2, ref op);

                
            }
            else if (Continue == 'N' || Continue == 'n')
            {

                Console.WriteLine("Finish");
                
            }
            else
            {
                Console.WriteLine("error");
               
            }
            return result;
        }
        public void Calcu()
        {
            input(ref num1, ref num2, ref op);

            while (true)
            {


                cal(ref num1, ref num2, ref total, ref op);

                conti(ref Continue);

                num1 = total;

                if (Continue == 'Y' || Continue == 'y')
                {

                    input(ref num2, ref op);

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
            Console.ReadKey();
        }
    }

    class Program
    {
        /*숙제입니다! 기간은 7월 27일(수요일) 밤 9시 까지입니다!

            계산기를 만들어 주시면됩니다!

            1.1번 값을 받고
            2. 타입을 받고(덧,뺄,곱,나누)
            3. 2번값을 받으면
            4. 결과를 보여줍니다!
            5. 계속할 것인지 알려주고
            6. 계속한다면 2번으로 돌아갑니다!
            6-1 이때, 1번값은 4번에서 나왔던 결과값입니다!
            (예시, 1+2=3 계속? 네! *2 = 6  같은 방식)

            즉, (1번) 타입 (2번) = (결과)
            (결과) 타입 (2번) = (결과2)
            (결과2) 타입 (2번) = (결과3) ...

            같은 방식입니다!

            저는 while문과 switch문, if 와 else if, continue 와 break, return을 모두 사용했습니다!
            화이팅입니다!3
        */
        static void conti(ref char Continue)
        {
            Console.Write("Continue? (Y/N) : ");
            Continue = Console.ReadKey().KeyChar;
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        static void input(ref int num1,ref int num2,ref char op)
        {
            Console.Write("input1 : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write($"insert type : ");
            op = Console.ReadKey().KeyChar;
            Console.ReadLine();
            Console.Write("input2 : ");
            num2 = int.Parse(Console.ReadLine());
        }

        static void input(ref int num2, ref char op)
        {
           
            Console.Write($"insert type : ");
            op = Console.ReadKey().KeyChar;
            Console.ReadLine();
            Console.Write("input2 : ");
            num2 = int.Parse(Console.ReadLine());
        }
        static int cal(ref int num1,ref int num2,ref int total,ref char op)
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
            /*
            {
                int num1 = 0, num2 = 0, total = 0 ;
                char op = ' ', Continue = ' ';


                input(ref num1,ref num2,ref op);

                while (true)
                {


                    cal(ref num1, ref num2, ref total, ref op);

                    conti(ref Continue);

                    num1 = total;

                    if (Continue == 'Y' || Continue == 'y')
                    {

                        input(ref num2, ref op);

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
                return ;
             Console.ReadKey();
            */
            {

                Carclulator car = new Carclulator();
                car.Calcu();
                

            }


        }



    }
}

