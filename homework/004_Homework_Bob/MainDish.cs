using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Homework_Bob
{
    class MainDish : KoreaFood
    {
        public int carboh = 0;
        public int empty = 0;

        public MainDish()
        {
            
            
        }
        public virtual int dontEat(int empty)
        {
            
            
            return empty;
        }

        public virtual int Eat(int carboh)
        {
            
            
            return carboh; 
        }
    }
}
