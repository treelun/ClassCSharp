using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Homework_Bob
{
    class SideDish : KoreaFood
    {
        public int calorie = 0;
        public int Happy = 0;
        public SideDish()
            {

            }
        public virtual int dontEat(int Happy)
        {

            return Happy;
        }

        public virtual int Eat(int calorie)
        {

            return calorie;
        }
    }
}
