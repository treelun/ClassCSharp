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
            
            InitData();
        }
        public abstract void InitData();
    }
}
