using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rullet
{
    abstract class AbstractMonster : Character
    {
        public AbstractMonster() : base()
        {

            InitData();
        }
        protected void SetAttack(AbstractMonster damageArmy, ref int coin)
        {
            damageArmy.Damage(this.Attack_Power, ref coin);
            this.Attack(damageArmy.GetCoin(ref coin));
        }
        public abstract void InitData();

        public abstract void Attack(AbstractMonster damageArmy, ref int coin);
    }
}
