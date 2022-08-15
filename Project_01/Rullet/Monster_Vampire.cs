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

        public void PrintMonster()
        {

            Console.WriteLine(@"

                                (                      )
                                |\    _,--------._    / |
                                | `.,'            `. /  |        하아 신선한 인간 피냄새
                  희희          `  '              ,-'   '        덤비십시오 인간
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
