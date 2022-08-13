using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Rullet
{
    class Player : AbstractCharacter
    {
        public Player(ref int coin) : base(ref coin)
        {
        }

        public override void InitData(ref int coin)
        {

            
            Hp = 300;


            Attack_Power = 0;

            Name = "주인공";

            PlayerLevel = 1;
            Coin = coin;
            Exp = 0;
            //PrintPlayerStat();
        }

        public override void Attack(AbstractCharacter player)
        {
            base.SetAttack(player);
            string damageName = player.GetName();
            int gainExp = player.GetExp();
            

            Console.WriteLine($"{Name}이(가) {damageName}을 공격했다!");
            Console.WriteLine($"{Name}이(가) 경험치{gainExp}을 획득!");
        }

        public override void Levelup()
        {
            if (Exp == 100)
            {
                PlayerLevel += 1;
            }
        }


    }
}
