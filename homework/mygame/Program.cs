using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mygame
{
    class Program
    {
        /*간단한 게임

            ILifeEntity <- 인터페이스
            LifeEntity(ILifeEntity를 상속받음) <- 클래스
            MainCharacter, Monster<- 클래스(LifeEntity를 상속받음)
            Zombie (Monster 상속받음)
            Ghost(Monster 상속받음)

            ILifeEntity 내용엔 공격(함수), 데미지받음(함수)가 있음
            LifeEntity는 체력(int), 공격력(int)과 공격, 데미지받음을 재정의함.
            MainCharacter와 Monster는 LifeEntity를 상속받음.
            데미지를 줄때는 해당 클래스의 데미지받음을 호출함.
        */
        static void Main(string[] args)
        {
            MainCharacter character = new MainCharacter();
            character.Init();
            Zombie zombie = new Zombie();
            zombie.Init();
            Ghost ghost = new Ghost();
            ghost.Init();

            character.Attack(zombie);
            Console.WriteLine();

            character.Attack(ghost);
            Console.WriteLine();

            zombie.Attack(character);
            Console.WriteLine();


            character.defence(ghost);
            Console.WriteLine();



            Console.ReadKey();
            
            
   



        }
    

    }

}
