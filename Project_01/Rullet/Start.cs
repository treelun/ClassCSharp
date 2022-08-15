using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using System.Threading;


namespace Rullet
{
    class Start
    {
        public void start()
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

            player[0] = new Player(ref coin);
            title.story();
            title.PrintTitle();
            got.Setting(item);
            int randomValue = 0;

            while (!_isFinish)
            {
                if (_isStart) //시작(enter)키를 누른 경우
                {


                    if (posY == 0 && coin > 0)//아이템뽑기
                    {

                        if (posY == 0 && coin > 0)
                        {
                            randomValue = random.Next(0, 1000);
                            got.Gotcha(item, ref randomValue, ref coin, posY);//가챠진행
                            player[0].Attack_Power = item[randomValue].WeaponDamage;
                            player[0].Coin = coin;
                            _isStart = false;
                            continue;
                        }

                        continue;

                    }
                    else if (posY == 0 && coin <= 0)
                    {
                        _isStart = false;
                        continue;
                    }
                    else if (posY == 1)//아이템 강화
                    {
                        item[randomValue].Smith(ref coin);
                        player[0].Attack_Power = item[randomValue].WeaponDamage;
                        _isStart = false;
                        continue;
                    }
                    else if (posY == 2)
                    {





                        player[0].Attack(monsters, ref coin);




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

                    main.mainMenu(ref posY, ref first, ref Second, ref Third, ref Fourth);
                    _isStart = true;
                    Clear();


                }

            }

        }
    }

        
}
