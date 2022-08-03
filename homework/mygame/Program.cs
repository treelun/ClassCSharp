using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mygame
{
    class Program
    {
        /*간단한 게임

            ILifeEntity <- 인터페이스
            LifeEntity(ILifeEntity를 상속받음) <- 클래스
            MainCharacter, Monster<- 클래스(LifeEntity를 상속받음)
            Zombie (Monster 상속받음)
            Ghost(Monster 상속받음)

            ILifeEntity 내용엔 공격(함수), 데미지받음(함수)가 있음
            LifeEntity는 체력(int), 공격력(int)과 공격, 데미지받음을 재정의함.
            MainCharacter와 Monster는 LifeEntity를 상속받음.
            데미지를 줄때는 해당 클래스의 데미지받음을 호출함.
        */
        static void Main(string[] args)
        {
            MainCharacter character = new MainCharacter();
            character.Init();
            Zombie zombie = new Zombie();
            zombie.Init();
            Ghost ghost = new Ghost();
            ghost.Init();

            character.Attack(zombie);
            Console.WriteLine();

            character.Attack(ghost);
            Console.WriteLine();

            zombie.Attack(character);
            Console.WriteLine();


            character.defence(ghost);
            Console.WriteLine();



            Console.ReadKey();


            string sumRan = MakeNum(); //MakeNum 메서드를 sumRan에 담아줌
            char[] arrayMake = sumRan.ToCharArray(); //sumRan을 배열로 정리 123 을 받았으면 [1],[2],[3] 이런 식으로 배열에 담아줌
            //Console.WriteLine($"{arrayMake[0]},{arrayMake[1]},{arrayMake[2]}"); //값이 배열로 잘 들어갔는지 확인
            Console.WriteLine("숫자 야구 게임을 시작합니다!");
            int round = 1;



            while (true)
            {
                int strike = 0, ball = 0; //스트라이크 카운트와 볼카운트를 초기화 해줌 while문 안에 있지않으면 계속 누적되는 현상 발생 반복문을 돌고 continue로 돌아 나왔을때 0으로 초기화해주어야함


                Console.WriteLine($"라운드 {round}");
                Console.Write("숫자를 입력하세요 : ");
                string inputNum = Console.ReadLine();
                char[] arrayinput = inputNum.ToCharArray();
                //Console.WriteLine($"{arrayinput[0]},{arrayinput[1]},{arrayinput[2]}");//값이 배열로 잘 들어갔는지 확인
                if (inputNum == sumRan)
                {
                    Console.WriteLine($"정답입니다!! 박수짝짝!!! 총{round}를 진행 했습니다. 게임을 종료합니다.");
                    break;
                }
                //정답이 아닐시 스트라이크와 볼의 카운트를 계산하기 위해 들어가는 조건들, 전부다 아닐시 아웃으로 빼야하기에 다 입력하게됨...한자리라도 빠지면 아웃으로 빠지는 현상 발생
                else if (arrayMake[0] == arrayinput[0] || arrayMake[0] == arrayinput[1] || arrayMake[0] == arrayinput[2] || arrayMake[1] == arrayinput[0] || arrayMake[1] == arrayinput[1] || arrayMake[1] == arrayinput[2] || arrayMake[2] == arrayinput[0] || arrayMake[2] == arrayinput[1] || arrayMake[2] == arrayinput[2])
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
                }
                else
                {
                    Console.WriteLine($"모든 숫자가 맞지않습니다 아웃!!!");
                    round++;
                }
                continue;
            }



        }

        //arrayMake[0] == arrayinput[1] || arrayMake[0] == arrayinput[2] || arrayMake[1] == arrayinput[2] || arrayMake[0] == arrayinput[0] || arrayMake[1] == arrayinput[1] || arrayMake[2] == arrayinput[2]





        static string MakeNum()//3자리 숫자를 만들어줌 중복되는 숫자가 없게 만들어야 하기에 숫자를 스트링으로 받아와서 합쳐줌 배열로 랜덤숫자를 random.Next(100,999)로 한번에 받아서 Tochararray를 사용하여 진행해도 무관할듯함
                               //진행해 보지는 않았음
        {

            Random random = new Random();
            while (true)
            {
                //string으로 진행하는이유는 int일 경우 +를 사용할시 계산이 되어버림 string은 문자열이 합쳐짐
                string ran = random.Next(0, 10).ToString();//랜덤한 첫번재 자리수 
                string ran1 = random.Next(0, 10).ToString();//랜덤한 두번재 자리수
                string ran2 = random.Next(0, 10).ToString();//랜덤한 세번재 자리수

                if (ran == ran2 || ran == ran1 || ran1 == ran2)//랜덤한 첫번재,두번째,세번째 자리수가 같은값인지 확인하고 같으면 다시 위로 올려보내서 다시조합
                {
                    continue;
                }
                string sumRan = ran + ran1 + ran2;
                return sumRan;

            }

        }




    }
    

 

}
