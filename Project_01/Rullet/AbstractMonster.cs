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
        public abstract void InitData();
    }
}
