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
            AbstractCharacter[] player = new AbstractCharacter[1]; // 주인공의 데이터, 코인,공격력을 적용해 주기위해 선언
            AbstractMonster[] monsters = new AbstractMonster[1]; // 몬스터의 데이터를 받기위해 선언
            Gotha got = new Gotha(); // 아이템뽑기 클래스
            Title title = new Title(); // 게임 스토리와 제목을 위한 클래스

            int posY = 0;
            string first = "뽑기상점으로 가기";
            string Second = "아이템 강화 시작";
            string Third = "사냥을....나가볼까?";
            string Fourth = "끝내기";
            int coin = 5000;
            bool _isFinish = false;
            bool _isStart = false;

            player[0] = new Player(ref coin);//주인공캐릭터 생성
            Clear();

            
            title.PrintTitle();

            got.Setting(item);

            int randomValue = 0;

            while (!_isFinish) //isFinish를 트루로
            {
                if (_isStart) //시작(enter)키를 누른 경우
                {
                    if (posY == 0 && coin > 0) // 아이템뽑기
                    {
                        randomValue = random.Next(0, 1001);
                        got.Gotcha(item, ref randomValue, ref coin, posY);//가챠진행
                        player[0].Attack_Power = item[randomValue].WeaponDamage;
                        player[0].Coin = coin;
                        _isStart = false;
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
