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
    }
}
