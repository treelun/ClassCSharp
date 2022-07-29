using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_calculator_ver2
{
    class Program
    { 
        static void Main(string[] args)
        {
            {
                float[] arrayint = new float[100];
                char[] arraychar = new char[100];
                int opcnt = 0;
                char Continue = ' ';
                float resultCalc = 0;
                float[] arrayresult = new float[100];


                Console.Write("input : ");
                arrayint[0] = float.Parse(Console.ReadLine());

                for (int i = 1; i < arrayint.Length; i++)
                {

                    Console.Write($"insert type : ");
                    arraychar[opcnt++] = Console.ReadKey().KeyChar;
                    Console.ReadLine();

                    Console.Write("input : ");
                    arrayint[i] = float.Parse(Console.ReadLine());

                    Console.Write("\nContinue? (Y/N) : ");
                    Continue = Console.ReadKey().KeyChar;
                    Console.ReadLine();

                    if (Continue == 'N' || Continue == 'n')
                        {
                        for (int p = 1; p < opcnt; p++)
                        {
                            switch (arraychar[p])
                            {
                                case '*':
                                    Console.Write($"{arrayint[p]} * {arrayint[p + 1]} ");
                                    arrayresult[0] = arrayint[p] * arrayint[p + 1];
                                    Console.Write($"= {arrayint[p]} \n");
                                    
                                    
                                    resultCalc = arrayint[p];
                                    break;
                                case '/':
                                    Console.Write($"{arrayint[p]} / {arrayint[p + 1]} ");
                                    arrayint[p] = arrayint[p] / arrayint[p + 1];
                                    Console.Write($"= {arrayint[p]} \n");
                                    
                                    resultCalc = arrayint[p];
                                    continue;

                                default:
                                    break;
                            }

                        }

                        for (int k = 0; k <= opcnt; k++)
                        {
                            switch (arraychar[k])
                            {
                              /*  case '*':
                                    Console.Write($"{arrayint[k]} * {arrayint[k + 1]} ");
                                    arrayint[k] = arrayint[k] * arrayint[k + 1];
                                    Console.Write($"= {arrayint[k]} \n");
                                    arrayint[k + 1] = 0;
                                    arraychar[k] = '+';
                                    resultCalc = arrayint[k];
                                    continue;
                                case '/':
                                    Console.Write($"{arrayint[k]} / {arrayint[k + 1]} ");
                                    arrayint[k] = arrayint[k] / arrayint[k + 1];
                                    Console.Write($"= {arrayint[k]} \n");
                                    arrayint[k + 1] = 0;
                                    arraychar[k] = '+';
                                    resultCalc = arrayint[k];
                                    continue;
*/
                                case '+':
                                    Console.Write($"{arrayint[k]} + {arrayint[k + 1]} ");
                                    arrayint[k + 1] = arrayint[k] + arrayint[k + 1];
                                    Console.Write($"= {arrayint[k + 1]} \n");
                                    resultCalc = arrayint[k + 1];
                                    continue;
                                case '-':
                                    Console.Write($"{arrayint[k]} - {arrayint[k + 1]} ");
                                    arrayint[k + 1] = arrayint[k] - arrayint[k + 1];
                                    Console.Write($"= {arrayint[k + 1]} \n");

                                    resultCalc = arrayint[k + 1];
                                    continue;
                                default:
                                    break;

                            }
                            
                            
                        }
                        Console.WriteLine("resultCalc : " + resultCalc);
                        break;

                    }
                    else if (Continue == 'Y' || Continue == 'y')
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Finish");
                        break;
                    }

                }
                return;




                        /*
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
                                             arrNum[i + 1] = 0;
                                             arrOp[i] = '+';
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
                        */

                        // 연산자를 하나씩 꺼내면서 결과 계산
            }


        }





         
    }
}


