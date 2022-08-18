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
        
    }
}
