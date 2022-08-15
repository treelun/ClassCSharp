﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rullet
{
    class Monster_Rabit : AbstractMonster
    {

        public override void InitData()
        {
            Hp = 50;


            Attack_Power = 2;

            Name = "토 끼";

            MonsterLevel = "F";
            Coin = 100;

            GiveExp = 10;
            PrintStat();
            PrintMonster();
        }

        public override void Attack(AbstractMonster player)
        {
            base.SetAttack(player);
            string damageName = player.GetName();
            int gainExp = player.GetExp();


            Console.WriteLine($"{Name}이(가) {damageName}을 공격했다!");
            Console.WriteLine($"{Name}이(가) 경험치{gainExp}을 획득!");
        }
        public void PrintMonster()
        {
            Console.WriteLine(@"

                          ***
                         ** **
                        **   **
                        **   **         ****
                        **   **       **   ****   토끼 두둥 등장!!
                        **  **       *   **   **
                         **  *      *  **  ***  **
                          **  *    *  **     **  *
                           ** **  ** **        **
                           **   **  **
                          *           *
                         *             *
                        *    0     0    *
                        *   /   @   \   *
                        *   \__/ \__/   *
                          *     W     *
                            **     **
                              *****

                            


");
        }
    }


}
