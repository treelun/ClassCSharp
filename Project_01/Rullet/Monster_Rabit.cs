using System;
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
            Hp = 100;


            Attack_Power = 2;

            Name = "토 끼";

            MonsterLevel = "F";
            coin = 100;

            GiveExp = 10;
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
