using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Threading;


namespace Rullet
{
   
    class Title
    {
        public void PrintTitle()// 게임 제목
        {

            SetCursorPosition(20, 5);
            Console.WriteLine("■                  ■■          ■■■                                       ");
            SetCursorPosition(20, 6);
            Console.WriteLine("■                ■              ■    ■                                   ");
            SetCursorPosition(20, 7);
            Console.WriteLine("■         ■■   ■       ■     ■    ■    ■                                 ");
            SetCursorPosition(20, 8);
            Console.WriteLine("■        ■  ■    ■   ■■■   ■■■                     ■                     ");
            SetCursorPosition(20, 9);
            Console.WriteLine("■        ■  ■      ■   ■     ■  ■      ■   ■■■  ■  ■                     ");
            SetCursorPosition(20, 10);
            Console.WriteLine("■        ■  ■      ■   ■     ■    ■    ■   ■  ■  ■  ■                    ");
            SetCursorPosition(20, 11);
            Console.WriteLine("■■■■   ■■   ■■     ■     ■     ■   ■   ■  ■    ■■                        ");
            SetCursorPosition(20, 12);
            Console.WriteLine("                                                           ■  ■          ");
            SetCursorPosition(20, 13);
            Console.WriteLine("                                                             ■           ");

            Thread.Sleep(500);


        }
        public void story() // 있으나 없으나 한 스토리
        {
            SetCursorPosition(10, 5);
            Console.WriteLine("엄마의 심부름을 떠나던 주인공 숲속에서 고블린을 만나게 된다.");
            Thread.Sleep(2000);
            SetCursorPosition(10, 6);
            Console.WriteLine("반짝이는걸 좋아하는 고블린의 습성을 이용하여 손가락에 낀 반지를 던져 겨우 목숨만을 부지하고");
            Thread.Sleep(2000);
            SetCursorPosition(10, 7);
            Console.WriteLine("심부름값 5000코인을 들고 마을로 향하게 되는데...");
            Thread.Sleep(3000);
            Clear();
        }
        public void notice()
        {
            SetCursorPosition(5, 5);
            Console.WriteLine("게임진행시 화면이 나온후 엔터를 눌러주세요.");
            Thread.Sleep(3000);
            SetCursorPosition(5, 6);
            Console.WriteLine("아이템을 뽑아 강화하고 몬스터의 등급을 선택하여 사냥하면됩니다.");
            Thread.Sleep(3000);
            SetCursorPosition(5, 7);
            Console.WriteLine("몬스터와의 전투는 가위바위보 형식으로 진행됩니다. 운만좋다면 제일안좋은무기로 보스도 잡을수있습니다.");
            Thread.Sleep(5000);
            Clear();
        }
    }
}
