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
            Hp = 200;


            Attack_Power = 20;

            Name = "오우거";

            MonsterLevel = "B";
            Coin = 200;

            GiveExp = 15;
            //PrintStat();
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
            Console.WriteLine(@"       ");




        }
    }
}
