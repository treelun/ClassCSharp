using System;
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
            Hp = 250;


            Attack_Power = 25;

            Name = "뱀파이어";

            MonsterLevel = "A";
            Coin = 300;
            PrintMonster();
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

            Console.WriteLine(@"

                                (                      )
                                |\    _,--------._    / |
                                | `.,'            `. /  |
                  희희          `  '              ,-'   '
                                \/_         _   (     /
                                (,-.`.    ,',-.`. `__,'
                                |/#\ ),-','#\`= ,'.` |
                                `._/)  -'.\_,'   ) ))|
                                /  (_.)\     .   -'//
                                (  /\____/\    ) )`'\
                                \ |V----V||  ' ,    \
                                |`- -- -'   ,'   \  \      _____
                            ___    |         .'    \ \  `._,-'     `-
                            `.__,`---^---'       \ ` -'
                                -.______  \ . /  ______,-
                                        `.     ,'            fk


");
        }
    }
}
