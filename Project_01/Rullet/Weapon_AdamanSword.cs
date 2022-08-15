using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;


namespace Rullet
{
    class Weapon_AdamanSword : abstractItem
    {
        public override void InitData()
        {
            WeaponName = "아다만티움소드";
            WeaponDamage = 70;
            WeaponLevel = 0;
            PrintWeapon();
            //PrintStat();
        }
        public void PrintWeapon()
        {
            BackgroundColor = ConsoleColor.Black;
            ForegroundColor = ConsoleColor.DarkBlue;
            SetCursorPosition(51, 5);
            WriteLine("***");
            SetCursorPosition(50, 6);
            WriteLine("*****");
            SetCursorPosition(50, 7);
            WriteLine("*****");
            SetCursorPosition(50, 8);
            WriteLine("** **");
            SetCursorPosition(50, 9);
            WriteLine("** **");
            SetCursorPosition(50, 10);
            WriteLine("** **");
            SetCursorPosition(50, 11);
            WriteLine("** **");
            SetCursorPosition(50, 12);
            WriteLine("** **");
            SetCursorPosition(50, 13);
            WriteLine("** **");
            SetCursorPosition(48, 14);
            WriteLine("*********");
            SetCursorPosition(51, 15);
            WriteLine("***");
            SetCursorPosition(51, 16);
            WriteLine("***");
            SetCursorPosition(51, 17);
            WriteLine("***");
            SetCursorPosition(50, 18);
            WriteLine("*****");

        }
    }
}
