using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rullet
{
    abstract class AbstractCharacter : Character
    {
        public AbstractCharacter() : base()
        {
            
            int RandomValue = 0;
            abstractItem[] item = new abstractItem[RandomValue];
            InitData(item,ref RandomValue);

        }
        public abstract void InitData(abstractItem[] item, ref int RandomValue);

        protected void SetAttack(AbstractMonster damageArmy, ref int coin)
        {
            damageArmy.Damage(this.Attack_Power, ref coin);
            this.Attack(damageArmy.GetCoin(ref coin));
        }
        

        public abstract void Attack(AbstractMonster damageArmy, ref int coin);
    }
}
