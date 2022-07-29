using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Homework_Bob
{
    class SweetPotato : MainDish

    {
        public override int dontEat(int empty)
        {
            Console.WriteLine("고구마 밥을 안먹었다.(공복1/2증가)");
            base.dontEat(++empty);

            return empty/2;
        }

        public override int Eat(int carboh)
        {
            Console.WriteLine("고구마 밥을 야무지게 먹었다.(탄수화물이 2배로 증가).");
            base.Eat(carboh);

            return carboh * 2;

        }
    }
}
