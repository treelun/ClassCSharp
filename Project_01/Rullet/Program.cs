using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using System.Threading;

namespace Rullet
{

    class Program
    {
        //1.가챠 만들기
        //리니지라이크 게임처럼 뽑기를 진행 보유 코인이있고 코인을 사용할때까지 뽑기하여 원하는 item을 획득하면 다음 게임으로 진행
        //아이템 종류 여러가지제작, 뽑기확률, 뽑았을시 다음단계로 진행.
        //2.아이템 강화하기
        //뽑은 아이템을 1부터 강화 max 단계를 정해놓고 강화시작
        //강화 성공시 Damage 증가 , 증가폭은 일단 보류
        //일정 강화단계에서 실패시 강화단계 확률로 하락
        //3. 강화한 아이템으로 몬스터 잡기
        //몬스터 만들기 , a,b,c,d,s등 랭크를 정하여 차례대로 처치
        //등급별 몬스터 능력치 차등적용
        //아이템 강화하기에서 강화가 어느정도 이상되면 s랭크는 손쉽게 잡을수 있도록 레벨링
        //s랭크 몬스터 처치시 게임 종료
        //4.주인공 캐릭터 생성, 무기착용, 체력 stat 있어야함
        //몬스터를 한번에 못죽일시 데미지 들어옴
        //주인공 공격먼저 -> 몬스터 공격
        /*        0. 편하게 최상단에
        using static System.Console; 을 적고 시작하세요
        System.Console 을 스킵할 수 있습니다.

        1. 방향키 입력 방식
                        ConsoleKeyInfo key = Console.ReadKey(true);
                        switch (key.Key)
                        {
                            case ConsoleKey.UpArrow:
                                break;
                            case ConsoleKey.DownArrow:
                                break;
                            case ConsoleKey.Enter:
                                break;
                        }

        2.원하는 위치에 커서 두기
           SetCursorPosition( x 좌표 , y 좌표 );

        3.화면 전체 지우기
           Clear();

        4.글자 꾸미기
        한번 바꾸면 이후로 모두 적용이 됩니다.
        때문에, 원하지 않는다면 원래대로 돌려놔야 합니다.
           4-1. 글자 바탕색(원래 검은색이기 때문에 다시 검은색으로 돌려놓아야함)
                       BackgroundColor = ConsoleColor.Yellow;
        Write("★☆");
        BackgroundColor = ConsoleColor.Black;

        4 - 2.글자 색 바꾸기
              Console.ForegroundColor = ConsoleColor.Blue;
        Write("★☆");
        Console.ForegroundColor = ConsoleColor.White;

        5.잠시 대기하기
        1000 이 1초
           Thread.Sleep(1000); //1초 대기. 1초후에 뒤에 내용이 실행됨
        */



        static void Main(string[] args)
        {
            Console.SetWindowSize(110, 30); // 콘솔창 크기 조절
            MainMenu main = new MainMenu(); // 메인화면 출력을 위한 클래스 호출
            abstractItem[] item = new abstractItem[1000]; // 가챠를 진행하기위해 배열 생성
            Random random = new Random(); // 랜덤 인수 필요로 랜덤 선언
            AbstractCharacter[] player = new AbstractCharacter[1];
            AbstractMonster[] monsters = new AbstractMonster[1];
            Gotha got = new Gotha(); // 아이템뽑기 클래스
            Monster_Setting setting = new Monster_Setting();
            Title title = new Title();
            int posY = 0;
            string first = "뽑기상점으로 가기";
            string Second = "아이템 강화 시작";
            string Third = "사냥을....나가볼까?";
            string Fourth = "끝내기";
            int coin = 5000;
            bool _isFinish = false;
            bool _isStart = false;
            int playerHp = 300;
            int playerExp = 0;
            player[0] = new Player(ref coin);
            title.story();
            title.PrintTitle();
            got.Setting(item);
            bool start = false;
            int randomValue = 0;

            while (!_isFinish)
            {
                if (_isStart) //시작(enter)키를 누른 경우
                {
                    

                    if (posY == 0 && coin > 0)//아이템뽑기
                    {

                        randomValue = random.Next(0, 1000);
                        got.Gotcha(item, ref randomValue, ref coin, posY);//가챠진행

                        player[0].Coin = coin;
                        _isStart = false;
                        continue;
                        

                    }
                    else if(posY == 0 && coin <= 0)
                    {
                        _isStart = false;
                        continue;
                    }
                    else if(posY == 1)//아이템 강화
                    {
                        item[randomValue].Smith(ref coin);
                        player[0].Attack_Power = item[randomValue].WeaponDamage;
                        _isStart = false;
                        continue;
                    }
                    else if (posY == 2)
                    {





                        player[0].Attack(monsters, ref coin,ref playerHp, ref playerExp);
                        



                        _isStart = false;
                        continue;
                    }
                    else if (posY == 3)
                    {

                        _isFinish = true;
                        break;
                    }
                    /*                        



                                            case 3: //종료
                                                _isFinish = true;
                                                break;*/

                }
                else //대기화면인 경우
                {
                    BackgroundColor = ConsoleColor.Black;
                    ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(1000);
                    
                    main.mainMenu(ref posY,ref first, ref Second, ref Third, ref Fourth);
                    _isStart = true;
                    Clear();


                }

            } 
           
        }


    }
}
