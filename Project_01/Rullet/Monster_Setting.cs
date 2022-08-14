using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Rullet
{
    class Monster_Setting : Character
    {
        public void CalledMonster(AbstractMonster[] monsters)
        {
            int Y = 0;
            string f = "F 등급 몬스터";
            string d = "D 등급 몬스터";
            string c = "C 등급 몬스터";
            string b = "B 등급 몬스터";
            string a = "A 등급 몬스터";
            string s = "S 등급 몬스터";
            string boss = "BOSS 등급 몬스터";
            MainMenu menu = new MainMenu();
            menu.MonsterSelectMenu(ref Y, ref f, ref d, ref c,ref b, ref a, ref s, ref boss);

            
            if (Y == 0)
            {
                monsters[0] = new Monster_Rabit();
                
            }
            else if (Y == 1)
            {
                monsters[0] = new Monster_Goblin();
                
            }
            else if (Y == 2)
            {
                monsters[0] = new Monster_Orc();
            }
            else if (Y == 3)
            {
                monsters[0] = new Monster_Oger();
            }
            else if (Y == 4)
            {
                monsters[0] = new Monster_Vampire();
            }
            else if (Y == 5)
            {
                monsters[0] = new Monster_DeathKnight();
            }
            else if (Y == 6)
            {
                monsters[0] = new Monster_Boss();
            }

            

        }
    }
}
