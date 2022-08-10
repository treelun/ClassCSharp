using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rullet
{
    class Character
    {
        protected uint Hp;
        protected string Name;
        protected uint Attack_Power;
        protected bool IsAlive;
        protected string MonsterLevel;
        protected uint PlayerLevel;
        public Character()
        {
            IsAlive = true;
        }

        public void PrintStat()
        {
            Console.WriteLine($"Name : {Name}  MonsterLevel : {MonsterLevel}");
            Console.WriteLine($"Hp : {Hp}");

        }
        public void PrintPlayerStat(abstractItem[] item, ref int RandomValue)
        {
            Console.WriteLine($"Name : {Name}  PlayerLevel : {PlayerLevel}");
            Console.WriteLine($"Hp : {Hp}  Attack_Power : {item[RandomValue].WeaponDamage} ");

        }
        public string GetName()
        {
            return Name;
        }
        public uint GetAttack_Power()
        {
            return Attack_Power;
        }
        public bool Damage(uint damage)
        {
            Hp -= damage;
            if (Hp <= 0)
            {
                IsAlive = false;
            }

            return IsAlive; //대상이 죽었는지 살았는지 처리
        }
        public string GetMonsterLevel()
        {
            return MonsterLevel;
        }
        
    }
}
