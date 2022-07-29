using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Homework_Bob
{
    class Meat : SideDish
    {
        public override int dontEat(int Happy)
        {
            base.dontEat(Happy);
            Console.WriteLine("고기를 안먹었다.(행복하지않다.)");

            return Happy;
        }

        public override int Eat(int calorie)
        {
            base.Eat(calorie);
            Console.WriteLine("고기를 야무지게 먹었다.(칼로리 절반 증가)");


            return calorie / 2;

        }
    }
}
