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
        public void PrintTitle()
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
        public void story()
        {
            SetCursorPosition(10, 5);
            Console.WriteLine("엄마의 심부름을 떠나던 주인공 숲속에서 고블린을 만나게 된다.");
            Thread.Sleep(2000);
            SetCursorPosition(10, 6);
            Console.WriteLine("반짝이는걸 좋아하는 고블린의 습성을 이용하여 손가락에 낀 반지를 던져 겨우 목숨만을 부지하고");
            Thread.Sleep(2000);
            SetCursorPosition(10, 7);
            Console.WriteLine("마을로 향하게 되는데...");
            Thread.Sleep(2000);
            Clear();
        }

    }
}
