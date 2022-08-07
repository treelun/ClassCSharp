using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rullet
{
    class Item
    {
        protected string WeaponName;
        protected uint WeaponDamage;

        public string GetName()
        {
            return WeaponName;
        }
        public uint GetWeaponDamage()
        {
            return WeaponDamage;
        }
    }

}
