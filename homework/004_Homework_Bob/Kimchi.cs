using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Homework_Bob
{
    class Kimchi : SideDish

    {
        public override int dontEat(int Happy)
        {
            
            base.dontEat(++Happy);
            Console.WriteLine("김치를 안먹었다.(행복증가??)");

            return Happy;
        }

        public override int Eat(int calorie)
        {
            base.Eat(calorie);
            Console.WriteLine("김치를 야무지게 먹었다.하지만 칼로리 증가하지 않는다.");


            return calorie;

        }
    }
}
