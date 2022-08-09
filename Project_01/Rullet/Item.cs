using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;


namespace Rullet
{
    class Item
    {
        public string WeaponName;
        public uint WeaponDamage;
        public uint WeaponLevel;
        public int coin;

        public Item()
        {

            coin = 30000;
            WeaponDamage = 0;
            WeaponLevel = 0;
        }
        public string GetName()
        {
            return WeaponName;
        }

        public uint GetWeaponDamage()
        {
            return WeaponDamage;
        }
        public uint GetWeaponLevel()
        {
            return WeaponLevel;
        }
        public void PrintStat()
        {
            SetCursorPosition(40, 15);
            Console.WriteLine($"무기이름 : {WeaponName}");
            SetCursorPosition(40, 16);
            Console.WriteLine($"무기 공격력 : {WeaponDamage}, 강화레벨: {WeaponLevel}");
        }
        public int SetCoin(ref int _coin)
        {
            
            coin -= _coin;
            return coin;
        }
        
    }
}
