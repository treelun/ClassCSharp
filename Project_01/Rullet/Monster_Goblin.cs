using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rullet
{
    class Monster_Goblin : AbstractMonster
    {

        public override void InitData()
        {
            Hp = 75;


            Attack_Power = 5;

            Name = "고블린";

            MonsterLevel = "D";
            Coin = 150;
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
                                          /|                                           |\
            니반지는                      /||             ^               ^             ||\
            대장님한테 줬다              / \\__     희~  //               \\   희~    __// \
                                       /  |_  \         | \   /     \   / |         /  _|  \
                                      /  /  \  \         \  \/ \---/ \/  /         /  /     \
                                     /  /    |  \         \  \/\   /\/  /         /  |       \
                                    /  /     \   \__       \ ( 0\ /0 ) /       __/   /        \
                                   /  /       \     \___    \ \_/|\_/ /    ___/     /\         \
                                  /  /         \_)      \___ \/-\|/-\/ ___/      (_/\ \      `  \
                                 /  /           /\__)       \/  oVo  \/       (__/   ` \      `  \
                                /  /           /,   \__)    (_/\ _ /\_)    (__/         `      \  \
                               /  '           //       \__)  (__V_V__)  (__/                    \  \
                              /  '  '        /'           \   |{___}|   /         .              \  \
                             /  '  /        /              \/ |{___}| \/\          `              \  \
                            /     /        '       .        \/{_____}\/  \          \    `         \  \
                                 /                ,         /{_______}\   \          \    \         \
                                                 /         /{___/_\___}\   `          \    `");

        }
    }
}
