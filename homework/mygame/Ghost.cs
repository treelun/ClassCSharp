﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mygame
{
    class Ghost : Monster
    {
        

        public override void Init()
        {
            base.Init();
            name = "Ghost";
            attackDamage = 4;
        }
    }
}
