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
