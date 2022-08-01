using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace timewach_Game
{
    class Program
    {
        public void Continue()
        {


        }
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            //while, if , switch, break
            //ㄱ.숫자 하나 입력
            int inputNum = 0;
            //ㄴ.컴퓨터 > 랜덤한 숫자 (0~100)을 띄운다.(int randomNumber)
            Random random = new Random();

            //ㄷ.랜덤한 숫자가 입력한 숫자의 "배수" 인경우 Y를 입력
            // randomNumber == randomNumber % 2;(2의 배수인지 확인)
            //ㄹ.만약 "배수가" 가 아닌 경우 n을 누른다.
            //1. 정답인지 체크
            //2. 정답인 경우 컴퓨터가 랜덤한 숫자를 띄운후 얼마의 시간이 지났는지 띄우기(float total Time)
            //3. 정답이 아닌경우 틀렸다고 알려주기
            //4. 계속 할 것인지 물어보기 (Y를 입력하면 ㄴ부터 시작)
            //5. n을 입력하면 종료!
            //정답을 입력했을때 배수인지 확인하여 정답은 정답으로 > 오답은 오답으로

            while (true)
            {
                Console.WriteLine("숫자를 입력하세요");
                inputNum = int.Parse(Console.ReadLine());
                int randomNumber = random.Next(0, 100);
                stopwatch.Start();
                Console.WriteLine($"{randomNumber} 숫자가 {inputNum}의 배수인가?(Y,N)");
                string YorN = Console.ReadLine();


                if (YorN == "Y" || YorN == "N")
                {

                    if (randomNumber %  inputNum == 0 && YorN == "Y" || YorN == "N")
                    {
                        stopwatch.Stop();
                        Console.WriteLine("정답입니다. 총걸린시간은 : " + stopwatch.ElapsedMilliseconds / 1000);
                        
                    }
                    else if (randomNumber % inputNum != 0 && YorN == "Y" || YorN == "N")
                    {
                        Console.WriteLine("틀렸습니다.");
                    }

                    else
                    {
                        Console.WriteLine("종료");
                        break;
                    }
                    Console.WriteLine("계속하시겠습니까 ? (Y, N)");
                    YorN = Console.ReadLine();
                    if (YorN == "Y" || YorN == "N")
                    {
                        if (YorN == "Y" || YorN == "y")
                        {
                            continue;
                        }
                        else if (YorN == "N" || YorN == "n")
                        {
                            break;
                        }
                    }
                    break;
                }

            }
            
            Console.ReadKey();



        }
    }
}
