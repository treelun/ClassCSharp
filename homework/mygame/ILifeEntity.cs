﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mygame
{
    interface ILifeEntity
    {
        void Attack(LifeEntity lifeEntity);
        void hit(int hitpoint);
    }
}
