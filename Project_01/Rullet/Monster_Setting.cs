using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rullet
{
    class Monster_Setting : Character
    {
        public void Setting(AbstractMonster[] monsters, string MonsterLevel)
        {



        }
        public void CalledMonster(AbstractMonster[] monsters, string MonsterLevel)
        {
            for (int i = 0; i < monsters.Length; i++)
            {
                if (MonsterLevel == "F")
                {
                    monsters[i] = new Monster_Rabit();
                }
                else if (MonsterLevel == "D")
                {
                    monsters[i] = new Monster_Goblin();
                }
                else if (MonsterLevel == "C")
                {
                    monsters[i] = new Monster_Orc();
                }
                else if (MonsterLevel == "B")
                {
                    monsters[i] = new Monster_Oger();
                }
                else if (MonsterLevel == "A")
                {
                    monsters[i] = new Monster_Vampire();
                }
                else if (MonsterLevel == "S")
                {
                    monsters[i] = new Monster_DeathKnight();
                }
                else if (MonsterLevel == "BOSS")
                {
                    monsters[i] = new Monster_Boss();
                }

            }
        }
    }
}
