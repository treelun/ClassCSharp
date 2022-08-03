using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Homework_BaseballGame
{
    /*    숙제입니다! 수요일까지입니다! 8/3일까지 ~

     숫자야구입니다!

    게임이 시작되면 컴퓨터는 독립된 숫자 무작위로 3개를 고를껍니다.
    겹치지않는 숫자 3개를 컴퓨터가 가지고 있고,
    여러분은 그것을 맞추면 되는 게임입니다!

    룰입니다
    1. 컴퓨터가 3가지 숫자를 가지고 있고, 이 숫자들은 겹치지않는다.
    2. 여러분이 숫자를 맞추려고 하고, 틀릴때 마다 라운드가 올라간다.
    3. 컴퓨터가 가지고 있는 숫자가 있으면 Ball 카운트를 올리고,
    그 숫자가 위치까지 맞다면 Strike 카운트를 올립니다.

    예)컴퓨터의 숫자가 304이고, 여러분이 제시한 숫자가 054라면
    0은 있지만 위치가 다르기때문에 B 이고,
    4는 숫자도 같고, 위치도 같기때문에 S 입니다.
    결과적으로 컴퓨터는 <B 는 1개, S 는 1개> 라고 알려줄 것입니다.

    단, 숫자가 모두 겹치지 않는다면 아웃이라고 이야기 해주셔야 합니다!
    맞추면 게임 종료! 
    총 몇라운드가 진행이 되었는지 알려주시면 됩니다!

    코딩을 하실때 주의하실 점이 있습니다!
    ㄱ.컴퓨터가 내는 숫자 3개는 모두 겹치지않는다
    ㄴ. 여러분이 숫자를 맞추기 위해 입력하실때
    띄어쓰기를 하지 않고, 3글자 모두 적으셔야 합니다*/
    class Program
    {


        static void Main(string[] args)
        {






            char[] arrayMake = MakeNum(); //sumRan을 배열로 정리 123 을 받았으면 [1],[2],[3] 이런 식으로 배열에 담아줌
            Console.WriteLine($"{arrayMake[0]},{arrayMake[1]},{arrayMake[2]}"); //값이 배열로 잘 들어갔는지 확인
            Console.WriteLine("숫자 야구 게임을 시작합니다!");
            int round = 1;



            while (true)
            {


                Console.WriteLine($"라운드 {round}");

                Console.Write("숫자를 입력하세요 : ");
                string inputNum = Console.ReadLine();
                char[] arrayinput = inputNum.ToCharArray();

                if (SBCount(arrayinput, arrayMake))
                {
                    break;
                }
                else 
                {
                    round++;
                    continue;
                }




                //int strike = 0, ball = 0; //스트라이크 카운트와 볼카운트를 초기화 해줌 while문 안에 있지않으면 계속 누적되는 현상 발생 반복문을 돌고 continue로 돌아 나왔을때 0으로 초기화해주어야함


                /*                Console.WriteLine($"라운드 {round}");
                                Console.Write("숫자를 입력하세요 : ");
                                string inputNum = Console.ReadLine();
                                char[] arrayinput = inputNum.ToCharArray();*//*
                //Console.WriteLine($"{arrayinput[0]},{arrayinput[1]},{arrayinput[2]}");//값이 배열로 잘 들어갔는지 확인


                //정답이 아닐시 스트라이크와 볼의 카운트를 계산하기 위해 들어가는 조건들, 전부다 아닐시 아웃으로 빼야하기에 다 입력하게됨...한자리라도 빠지면 아웃으로 빠지는 현상 발생
                *//*                else if (arrayMake[0] == arrayinput[0] || arrayMake[0] == arrayinput[1] || arrayMake[0] == arrayinput[2] || arrayMake[1] == arrayinput[0] || arrayMake[1] == arrayinput[1] || arrayMake[1] == arrayinput[2] || arrayMake[2] == arrayinput[0] || arrayMake[2] == arrayinput[1] || arrayMake[2] == arrayinput[2])
                                {
                                    for (int i = 0; i < arrayMake.Length; i++)
                                    {
                                        if (arrayMake[i] == arrayinput[i]) //자릿수가 같을때 스트라이크 카운트를 올려줌
                                        {
                                            strike++;
                                        }
                                        else if (arrayMake[i] == arrayinput[1] || arrayMake[i] == arrayinput[2] || arrayMake[i] == arrayinput[0]) // 다른자릿수가 같을땐 볼카운트를 올려줌
                                        {
                                            ball++;
                                        }

                                    }
                                    Console.WriteLine($"틀렸습니다. S:{strike}\t\tB:{ball}"); //출력
                                    round++;

                                    continue;
                                }*//*


            }*/



            }
        }
        //arrayMake[0] == arrayinput[1] || arrayMake[0] == arrayinput[2] || arrayMake[1] == arrayinput[2] || arrayMake[0] == arrayinput[0] || arrayMake[1] == arrayinput[1] || arrayMake[2] == arrayinput[2]





        static char[] MakeNum()//3자리 숫자를 만들어줌 중복되는 숫자가 없게 만들어야 하기에 숫자를 스트링으로 받아와서 합쳐줌 배열로 랜덤숫자를 random.Next(100,999)로 한번에 받아서 Tochararray를 사용하여 진행해도 무관할듯함
                               //진행해 보지는 않았음
        {

            Random random = new Random();
            while (true)
            {
                //string으로 진행하는이유는 int일 경우 +를 사용할시 계산이 되어버림 string은 문자열이 합쳐짐
                string ran = random.Next(100, 999).ToString();//랜덤한 첫번재 자리수 
                char[] arrayran = ran.ToArray();
                if (arrayran[0] == arrayran[1] || arrayran[0] == arrayran[2] || arrayran[1] == arrayran[2])
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            if (i != k)
                            {
                                if (arrayran[i] == arrayran[k])
                                {
                                    string newrandom = random.Next(0, 9).ToString();
                                    arrayran[i] = char.Parse(newrandom);
                                    break;
                                }

                            }

                        }
                    }

                }



                return arrayran;

            }
        }

    





        static bool SBCount(char[] inputarray, char[] MakeArray)//가져와서 어떻게 써야할지 모르겠음..
        {
            
            //MakeNum 메서드를 sumRan에 담아줌
            //sumRan을 배열로 정리 123 을 받았으면 [1],[2],[3] 이런 식으로 배열에 담아줌
            Console.Write("숫자를 입력하세요 : ");
            string inputNum = Console.ReadLine();
            char[] arrayinput = inputNum.ToCharArray();

            int strike = 0;
            int ball = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    if (MakeArray[i] == arrayinput[k])
                    {
                        if (i == k)
                        {
                            strike++;
                        }
                        else
                        {
                            ball++;
                        }
                    }

                }


            }
            Console.WriteLine($"모든 숫자가 맞지않습니다 아웃!!!");
            
            //출력


            return Game(strike,ball);
        }

        public static bool Game(int strike,int ball)
        {
            
            if (strike == 3)
            {
                Console.WriteLine($"정답입니다!! 박수짝짝!!! 게임을 종료합니다.");
                return true;
                
            }
            else if (strike == 0 && ball == 0)
            {
                Console.WriteLine($"모든 숫자가 맞지않습니다 아웃!!!");
                
                
            }
            else
            {
                Console.WriteLine($"틀렸습니다. S:{strike}\t\tB:{ball}");
                
                
            }

            return false;
        }
    }
}
