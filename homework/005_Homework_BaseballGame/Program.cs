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
    //숙제입니다!!
    /*
    아 개발자님 수정사항이 들어왔어요~

    월요일날 만들어주신 숫자야구게임을 수정해주시면됩니다!
    기본 룰은 똑같습니다
    단, 게임이 맨 처음 시작할때!
    총 몇개의 숫자를 가지고 게임할 지를 정해주시면 됩니다!!

    플로우는 
    0. 총 몇개의 숫자를 가지고 게임을 할지(2~8까지만) 입력받기
    (예, 숫자는 몇개? : 4 ,,,,, 여기서 4는 ReadLine() 으로 읽은겁니다)
    1. 컴퓨터가 숫자 n개 랜덤하게 뽑기
    ....

    내용은 변하지않아요
    숫자를 "몇개"가지고 게임할 지 정해주시면됩니다



    룰입니다
    1. 컴퓨터가 n가지 숫자를 가지고 있고, 이 숫자들은 겹치지않는다.
    2. 여러분이 숫자를 맞추려고 하고, 틀릴때 마다 라운드가 올라간다.
    3. 컴퓨터가 가지고 있는 숫자가 있으면 Ball 카운트를 올리고,
    그 숫자가 위치까지 맞다면 Strike 카운트를 올립니다.

    예)컴퓨터의 숫자가 304이고, 여러분이 제시한 숫자가 054라면
    0은 있지만 위치가 다르기때문에 B 이고,
    4는 숫자도 같고, 위치도 같기때문에 S 입니다.
    결과적으로 컴퓨터는<B 는 1개, S 는 1개> 라고 알려줄 것입니다.

    단, 숫자가 모두 겹치지 않는다면 아웃이라고 이야기 해주셔야 합니다!
    맞추면 게임 종료! 
    총 몇라운드가 진행이 되었는지 알려주시면 됩니다!

    코딩을 하실때 주의하실 점이 있습니다!
    ㄱ.컴퓨터가 내는 숫자 3개는 모두 겹치지않는다
    ㄴ. 여러분이 숫자를 맞추기 위해 입력하실때
    띄어쓰기를 하지 않고, 3글자 모두 적으셔야 합니다
    */
    class Program
    {


        static void Main(string[] args)
        {






            string[] arrayMake = MakeNum(); //sumRan을 배열로 정리 123 을 받았으면 [1],[2],[3] 이런 식으로 배열에 담아줌
            //Console.WriteLine($"{arrayMake[0]},{arrayMake[1]}{arrayMake[2]}"); //값이 배열로 잘 들어갔는지 확인
            Console.WriteLine("숫자 야구 게임을 시작합니다!");
            int round = 1;
            


            while (true)
            {
                int strike = 0;
                int ball = 0;
                Console.WriteLine($"라운드 {round}");

                string[] arrayInput = InputNum();

                for (int i = 0; i < arrayMake.Length; i++)
                {
                    for (int k = 0; k < arrayMake.Length; k++)
                    {
                        if (arrayMake[i] == arrayInput[k])
                        {
                            if (i == k)
                            {
                                strike++;
                                continue;
                            }
                            else
                            {
                                ball++;
                                continue;
                            }
                        }

                    }

                }

                switch (arrayMake.Length)
                {
                    case 8:
                        if (strike == 8)
                        {
                            Console.WriteLine($"정답입니다!! 박수짝짝!!! 총{round}를 진행했습니다. 게임을 종료합니다.");
                            break;

                        }
                        else if (strike == 0 && ball == 0)
                        {
                            Console.WriteLine($"모든 숫자가 맞지않습니다 아웃!!!");
                            round++;

                        }
                        else
                        {
                            Console.WriteLine($"틀렸습니다. S:{strike}\t\tB:{ball}");
                            round++;

                        }
                        continue;
                    case 7:
                        if (strike == 7)
                        {
                            Console.WriteLine($"정답입니다!! 박수짝짝!!! 총{round}를 진행했습니다. 게임을 종료합니다.");
                            break;

                        }
                        else if (strike == 0 && ball == 0)
                        {
                            Console.WriteLine($"모든 숫자가 맞지않습니다 아웃!!!");
                            round++;

                        }
                        else
                        {
                            Console.WriteLine($"틀렸습니다. S:{strike}\t\tB:{ball}");
                            round++;

                        }
                        continue;
                    case 6:
                        if (strike == 6)
                        {
                            Console.WriteLine($"정답입니다!! 박수짝짝!!! 총{round}를 진행했습니다. 게임을 종료합니다.");
                            break;

                        }
                        else if (strike == 0 && ball == 0)
                        {
                            Console.WriteLine($"모든 숫자가 맞지않습니다 아웃!!!");
                            round++;

                        }
                        else
                        {
                            Console.WriteLine($"틀렸습니다. S:{strike}\t\tB:{ball}");
                            round++;

                        }
                        continue;
                    case 5:
                        if (strike == 5)
                        {
                            Console.WriteLine($"정답입니다!! 박수짝짝!!! 총{round}를 진행했습니다. 게임을 종료합니다.");
                            break;

                        }
                        else if (strike == 0 && ball == 0)
                        {
                            Console.WriteLine($"모든 숫자가 맞지않습니다 아웃!!!");
                            round++;

                        }
                        else
                        {
                            Console.WriteLine($"틀렸습니다. S:{strike}\t\tB:{ball}");
                            round++;

                        }
                        continue;
                    case 4:
                        if (strike == 4)
                        {
                            Console.WriteLine($"정답입니다!! 박수짝짝!!! 총{round}를 진행했습니다. 게임을 종료합니다.");
                            break;

                        }
                        else if (strike == 0 && ball == 0)
                        {
                            Console.WriteLine($"모든 숫자가 맞지않습니다 아웃!!!");
                            round++;

                        }
                        else
                        {
                            Console.WriteLine($"틀렸습니다. S:{strike}\t\tB:{ball}");
                            round++;

                        }
                        continue;
                    case 3:
                        if (strike == 3)
                        {
                            Console.WriteLine($"정답입니다!! 박수짝짝!!! 총{round}를 진행했습니다. 게임을 종료합니다.");
                            break;

                        }
                        else if (strike == 0 && ball == 0)
                        {
                            Console.WriteLine($"모든 숫자가 맞지않습니다 아웃!!!");
                            round++;

                        }
                        else
                        {
                            Console.WriteLine($"틀렸습니다. S:{strike}\t\tB:{ball}");
                            round++;

                        }
                        continue;
                    case 2:
                        if (strike == 2)
                        {
                            Console.WriteLine($"정답입니다!! 박수짝짝!!! 총{round}를 진행했습니다. 게임을 종료합니다.");
                            break;

                        }
                        else if (strike == 0 && ball == 0)
                        {
                            Console.WriteLine($"모든 숫자가 맞지않습니다 아웃!!!");
                            round++;

                        }
                        else
                        {
                            Console.WriteLine($"틀렸습니다. S:{strike}\t\tB:{ball}");
                            round++;

                        }
                        continue;

                    default:
                        break;
                }


                break;
            }
        }















        static string[] MakeNum()
        {
            Random random = new Random();
            Console.Write("몇개의 숫자로 게임을 진행하겠습니까? (2~8)");
            int countNum = int.Parse(Console.ReadLine());
            string[] NumLenth = new string[countNum];
            for (int i = 0; i < NumLenth.Length; i++)
            {
                NumLenth[i] = random.Next(0, 9).ToString();
                for (int k = 0; k < i; k++)
                {

                    if (NumLenth[i] == NumLenth[k])
                    {
                        i--;

                    }

                }
            }
            return NumLenth;
        }
        static string[] InputNum()
        {
            Console.Write("숫자를 입력하세요 : ");
            string inputNum = Console.ReadLine();
            char[] arrayinput = inputNum.ToCharArray();
            string[] stringinput = new string[8];
            for (int i = 0; i < arrayinput.Length; i++)
            {
                if (true)
                {
                    stringinput[i] = arrayinput[i].ToString();
                }
            }
            return stringinput;
        }








        static int SBCount(char[] MakeArray)//가져와서 어떻게 써야할지 모르겠음..
        {

            Console.Write("숫자를 입력하세요 : ");
            string inputNum = Console.ReadLine();
            char[] arrayinput = inputNum.ToCharArray();

            int strike = 0;
            int ball = 0;

            for (int i = 0; i < MakeArray.Length; i++)
            {
                for (int k = 0; k < i; k++)
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
            return strike;
        }


        public static int Game(int strike, int ball)
        {
            string[] arrayMake = MakeNum();
            InputNum();


            int round = 1;
            switch (arrayMake.Length)
            {
                case 8:
                    if (strike == 8)
                    {
                        Console.WriteLine($"정답입니다!! 박수짝짝!!! 총{round}를 진행했습니다. 게임을 종료합니다.");
                        break;

                    }
                    else if (strike == 0 && ball == 0)
                    {
                        Console.WriteLine($"모든 숫자가 맞지않습니다 아웃!!!");
                        round++;

                    }
                    else
                    {
                        Console.WriteLine($"틀렸습니다. S:{strike}\t\tB:{ball}");
                        round++;

                    }
                    break;
                case 7:
                    if (strike == 7)
                    {
                        Console.WriteLine($"정답입니다!! 박수짝짝!!! 총{round}를 진행했습니다. 게임을 종료합니다.");
                        break;

                    }
                    else if (strike == 0 && ball == 0)
                    {
                        Console.WriteLine($"모든 숫자가 맞지않습니다 아웃!!!");
                        round++;

                    }
                    else
                    {
                        Console.WriteLine($"틀렸습니다. S:{strike}\t\tB:{ball}");
                        round++;

                    }
                    break;
                case 6:
                    if (strike == 6)
                    {
                        Console.WriteLine($"정답입니다!! 박수짝짝!!! 총{round}를 진행했습니다. 게임을 종료합니다.");
                        break;

                    }
                    else if (strike == 0 && ball == 0)
                    {
                        Console.WriteLine($"모든 숫자가 맞지않습니다 아웃!!!");
                        round++;

                    }
                    else
                    {
                        Console.WriteLine($"틀렸습니다. S:{strike}\t\tB:{ball}");
                        round++;

                    }
                    break;
                case 5:
                    if (strike == 5)
                    {
                        Console.WriteLine($"정답입니다!! 박수짝짝!!! 총{round}를 진행했습니다. 게임을 종료합니다.");
                        break;

                    }
                    else if (strike == 0 && ball == 0)
                    {
                        Console.WriteLine($"모든 숫자가 맞지않습니다 아웃!!!");
                        round++;

                    }
                    else
                    {
                        Console.WriteLine($"틀렸습니다. S:{strike}\t\tB:{ball}");
                        round++;

                    }
                    break;
                case 4:
                    if (strike == 4)
                    {
                        Console.WriteLine($"정답입니다!! 박수짝짝!!! 총{round}를 진행했습니다. 게임을 종료합니다.");
                        break;

                    }
                    else if (strike == 0 && ball == 0)
                    {
                        Console.WriteLine($"모든 숫자가 맞지않습니다 아웃!!!");
                        round++;

                    }
                    else
                    {
                        Console.WriteLine($"틀렸습니다. S:{strike}\t\tB:{ball}");
                        round++;

                    }
                    break;
                case 3:
                    if (strike == 3)
                    {
                        Console.WriteLine($"정답입니다!! 박수짝짝!!! 총{round}를 진행했습니다. 게임을 종료합니다.");
                        break;

                    }
                    else if (strike == 0 && ball == 0)
                    {
                        Console.WriteLine($"모든 숫자가 맞지않습니다 아웃!!!");
                        round++;

                    }
                    else
                    {
                        Console.WriteLine($"틀렸습니다. S:{strike}\t\tB:{ball}");
                        round++;

                    }
                    break;
                case 2:
                    if (strike == 2)
                    {
                        Console.WriteLine($"정답입니다!! 박수짝짝!!! 총{round}를 진행했습니다. 게임을 종료합니다.");
                        break;

                    }
                    else if (strike == 0 && ball == 0)
                    {
                        Console.WriteLine($"모든 숫자가 맞지않습니다 아웃!!!");
                        round++;

                    }
                    else
                    {
                        Console.WriteLine($"틀렸습니다. S:{strike}\t\tB:{ball}");
                        round++;

                    }
                    break;

                default:
                    break;
            }
            return round;
        }
       
    }
}
