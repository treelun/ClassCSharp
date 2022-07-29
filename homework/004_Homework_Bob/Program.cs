using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Homework_Bob
{
    class Program
    {
        static void Main(string[] args)
        {
            Potato potato = new Potato();
            SweetPotato sweet = new SweetPotato();

            Meat meat = new Meat();
            Kimchi kimchi = new Kimchi();

            int happy;
            int calorie;
            int carboh;
            int empty;
            string userName = "유승호";
            
            


            carboh = potato.Eat(10) + sweet.Eat(10);
            Console.WriteLine();
            Console.WriteLine();
            empty = potato.dontEat(10) + sweet.dontEat(10);
            Console.WriteLine();
            Console.WriteLine();
            calorie = meat.Eat(10) + kimchi.Eat(10);
            Console.WriteLine();
            Console.WriteLine();
            happy = meat.dontEat(10)+ kimchi.dontEat(10);

            Console.WriteLine();
            Console.WriteLine();

            
            Console.WriteLine($"{userName}\n행복도 : {happy} 칼로리 : {calorie} 탄수화물 : {carboh} 공복 : {empty}");
            Console.ReadLine();

        }
    }
}
