using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            MainCharacter mainCharacter = new MainCharacter();
            mainCharacter.Init();

            Zombie zombie = new Zombie();
            zombie.Init();

            Ghost ghost = new Ghost();
            ghost.Init();

            mainCharacter.Attack(ghost);
            Console.WriteLine();

            ghost.Attack(mainCharacter);
            Console.WriteLine();

            mainCharacter.Ammor(ghost);
            Console.WriteLine();

            zombie.Attack(mainCharacter);
            Console.WriteLine();

            mainCharacter.Weapon(ghost);
            Console.WriteLine();

            mainCharacter.Attack(ghost);
            Console.WriteLine();
        }
    }
}
