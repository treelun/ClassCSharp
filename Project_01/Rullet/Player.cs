using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rullet
{
    class Player : AbstractCharacter
    {
        public override void InitData()
        {
            
            
            Hp = 300;


            Attack_Power = 0;

            Name = "주인공";

            PlayerLevel = 0;

            PrintPlayerStat();
        }


    }
}
