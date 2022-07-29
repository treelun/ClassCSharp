using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Homework_Bob
{
    class Potato : MainDish
    {

        public override int dontEat(int empty)
        {
            Console.WriteLine("감자밥을 안먹었다.(공복증가)");
            base.dontEat(++empty);

            return empty;
        }

        public override int Eat(int carboh)
        {
            Console.WriteLine("감자밥을 야무지게 먹었다.(탄수화물이 절반증가).");
            base.Eat(carboh);

            return carboh/2;

        }
    }
}
