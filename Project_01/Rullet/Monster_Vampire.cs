﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rullet
{
    class Monster_Vampire : AbstractMonster
    {
        public override void InitData()
        {
            Hp = 500;


            Attack_Power = 25;

            Name = "뱀파이어";

            MonsterLevel = "A";
            coin = 300;

            GiveExp = 15;
            //PrintStat();
        }

        public override void Attack(AbstractMonster damageArmy, ref int coin)
        {
            base.SetAttack(damageArmy, ref coin);
            string damageName = damageArmy.GetName();

            Console.WriteLine($"{Name}이(가) {damageName}을 공격했다!");

        }
    }
}
