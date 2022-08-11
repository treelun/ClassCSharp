using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rullet
{
    class Character
    {
        public int Hp;
        protected string Name;
        public int Attack_Power;
        protected bool IsAlive;
        protected string MonsterLevel;
        protected uint PlayerLevel;
        public int Coin;
        public int Exp;
        protected int GiveExp;

        public Character()
        {
            IsAlive = true;
        }

        public void PrintStat()
        {
            Console.WriteLine($"이름 : {Name}  몬스터 등급 : {MonsterLevel}");
            Console.WriteLine($"체력 : {Hp}    공격력 : {Attack_Power}");
            Console.WriteLine($"보유 코인{Coin}     경험치 : {GiveExp}");

        }
        public void PrintPlayerStat()
        {
            Console.WriteLine($"이름 : {Name}  레벨 : {PlayerLevel}");
            Console.WriteLine($"체력 : {Hp}  공격력 : {Attack_Power} ");
            Console.WriteLine($"보유 코인{Coin}     경험치 : {Exp}");
        }

        public int Damage(int damage)
        {
            Hp -= damage;
            if (Hp <= 0)
            {
                IsAlive = false;
            }

            return Attack_Power; //대상에게 코인을 줌
        }

        public string GetMonsterLevel()
        {
            return MonsterLevel;
        }
        public int GetCoin()
        {
            return Coin;
        }

        public string GetName()
        {
            return Name;
        }
        public int GetAttack_Power()
        {
            
            return Attack_Power;
        }
        public int GetExp()
        {
            return GiveExp;
        }
        public int GetHP()
        {
            return Hp;
        }

    }
}
