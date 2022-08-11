using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rullet
{
    class Monster_DeathKnight : AbstractMonster
    {
        public override void InitData()
        {
            Hp = 1000;


            Attack_Power = 40;

            Name = "데스나이트";

            MonsterLevel = "S";
            coin = 1000;

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
