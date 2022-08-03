using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Homework_Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            /*숙제입니다!!

            로또

            랜덤한 숫자 5개를 컴퓨터가 선택합니다!
            5개를 모두 맞추면 1등!
            4개를 맞추면 2등!
            3개를 맞추면 3등!
            2개를 맞추면 4등!
            1개를 맞추면 5등!

            순서는 상관없습니다~숫자가 있기만 하면 됩니다!
            while문 필요없이 단 한번만 진행해주시면 됩니다~

            정리

            1. 5개 숫자 랜덤하게 받기(1~49)
            2.유저가 5개 숫자 입력(단, 중복된 숫자를 입력하지 않는다라고 가정.띄어쓰기도)
            3.등수 출력*/
 /*           {
                Random ran = new Random();

                int[] randomNum = new int[5];
                int[] inputNum = new int[5];
                int count = 1;
                int O = 0;

                for (int i = 0; i < randomNum.Length; i++)
                {
                    randomNum[i] = ran.Next(1, 49);//숫자 받기
                    for (int i2 = 0; i2 < i; i2++)
                    {

                        if (randomNum[i] == randomNum[i2])
                        {
                            i--;

                        }
                    }


                }
                Console.WriteLine($"{randomNum[0]} , {randomNum[1]} , {randomNum[2]} , {randomNum[3]} , {randomNum[4]}");
                for (int i = 0; i < inputNum.Length; i++)
                {
                    Console.WriteLine($"{count++}번째 숫자를 입력하세요 (1~49)");
                    inputNum[i] = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i < randomNum.Length; i++)
                {
                    for (int k = 0; k < randomNum.Length; k++)
                    {
                        if (randomNum[i] == inputNum[k])
                        {
                            O++;
                            continue;
                        }


                    }
                }
                switch (O)
                {
                    case 1:
                        Console.WriteLine("5등당첨!");
                        break;
                    case 2:
                        Console.WriteLine("4등당첨!");
                        break;
                    case 3:
                        Console.WriteLine("3등당첨!");
                        break;
                    case 4:
                        Console.WriteLine("2등당첨!");
                        break;
                    case 5:
                        Console.WriteLine("1등당첨!");
                        break;
                    default:
                        Console.WriteLine("꽝 다음기회에...");
                        break;
                }
            }*/
            {
                int[] randomNum = new int[5];
                int[] inputNum = new int[5];
                randomNum = MakeNum(randomNum);
                Console.WriteLine($"{randomNum[0]} , {randomNum[1]} , {randomNum[2]} , {randomNum[3]} , {randomNum[4]}"); //작동이 잘 되는지 확인하기위해 랜덤값 표현
                inputNum = InputNum(inputNum);
                Final(InputEqualMake(randomNum, inputNum));
            }
        }
        static int[] MakeNum(int[] randomNum) // 랜덤한 숫자 가져오기
        {
            Random ran = new Random();

            randomNum = new int[5];
            for (int i = 0; i < randomNum.Length; i++)
            {
                randomNum[i] = ran.Next(1, 49);//숫자 받기
                for (int i2 = 0; i2 < i; i2++)
                {

                    if (randomNum[i] == randomNum[i2])
                    {
                        i--;

                    }
                }


            }
            return randomNum;
        }
        static int[] InputNum(int[] inputNum) // 내가 숫자 선택하기
        {
            inputNum = new int[5];
            int count = 1;
            for (int i = 0; i < inputNum.Length; i++)
            {
                Console.WriteLine($"{count++}번째 숫자를 입력하세요 (1~49)");
                inputNum[i] = int.Parse(Console.ReadLine());
            }
            return inputNum;
        }

        static int InputEqualMake(int[] inputNum, int[] randomNum) // 랜덤숫자와 입력숫자 비교 맞으면 Answer값을 올려줌
        {
            int Answer = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int k = 0; k < 5; k++)
                {
                    if (randomNum[i] == inputNum[k])
                    {
                        Answer++;
                        continue;
                    }

                   
                }
                
            }
            return Answer;
        }

        static void Final(int Answer) // Answer값을 받아옴 Answer가 5면 1등
        {

            switch (Answer)
            {
                case 1:
                    Console.WriteLine("5등당첨!");
                    break;
                case 2:
                    Console.WriteLine("4등당첨!");
                    break;
                case 3:
                    Console.WriteLine("3등당첨!");
                    break;
                case 4:
                    Console.WriteLine("2등당첨!");
                    break;
                case 5:
                    Console.WriteLine("1등당첨!");
                    break;
                default:
                    Console.WriteLine("꽝 다음기회에...");
                    break;
            }
        }
    }
}
