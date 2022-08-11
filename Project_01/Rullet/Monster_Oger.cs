using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rullet
{
    class Monster_Oger : AbstractMonster
    {
        public override void InitData()
        {
            Hp = 300;


            Attack_Power = 20;

            Name = "오우거";

            MonsterLevel = "B";
            coin = 200;

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
