﻿using System;
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
        public Character()
        {
            IsAlive = true;
        }

        public void PrintStat()
        {
            Console.WriteLine($"Name : {Name}  MonsterLevel : {MonsterLevel}");
            Console.WriteLine($"Hp : {Hp}");

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

            return IsAlive; //공격하는 대상에게 리턴하는 경험치
        }
        public string GetMonsterLevel()
        {
            return MonsterLevel;
        }
        
    }
}
