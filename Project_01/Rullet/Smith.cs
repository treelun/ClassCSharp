using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rullet
{
    class Smith 
    {

        /*public void smith()
        {
            Random ran = new Random();
            int WeaponLevelMax = 15;
            while (WeaponLevel != WeaponLevelMax)
            {
                Console.WriteLine("강화를 진행 하시겠습니까? (Y/N)");
                string Answer = Console.ReadLine();

                if (Answer == "Y")
                {
                    for (uint i = WeaponLevel; i < WeaponLevelMax; i++)
                    {
                        int num = ran.Next(0, 9);
                        if (i > 0 && i < 6)
                        {
                            Console.WriteLine($"\t{i}강 진행중입니다.5강까지는 100프로 성공입니다. \n\t아무키나 눌러주세요");
                            Console.ReadKey();
                            WeaponDamage++;
                            WeaponLevel++;
                            coin -= 100;
                            Console.WriteLine($"강화에 성공했습니다! 강화레벨{WeaponLevel}로 상승 데미지{WeaponDamage}으로 증가");
                        }

                        else if (i >= 5 && i <= 10 && num <= 7)
                        {
                            Console.WriteLine($"\t{i}강 진행중입니다.성공 확률은 70프로 입니다. \n\t아무키나 눌러주세요");

                            Console.ReadKey();
                            WeaponDamage++;
                            WeaponLevel++;
                            Console.WriteLine($"강화에 성공했습니다! 강화레벨{WeaponLevel}로 상승 데미지{WeaponDamage}만큼 증가");
                            Console.WriteLine("계속 진행하시겠습니까? (Y/N)");
                            coin -= 500;
                            Answer = Console.ReadLine();
                            if (Answer == "Y")
                            {
                                continue;
                            }
                            else if (Answer == "N")
                            {
                                Console.WriteLine("강화를 종료합니다.");
                                break;
                            }

                        }
                        else if (i > 10 && num <= 3)
                        {
                            Console.WriteLine($"\t{i}강 진행중입니다.성공 확률은 30프로 입니다.\n\t아무키나 눌러주세요");
                            Console.ReadKey();
                            WeaponDamage++;
                            WeaponLevel++;
                            Console.WriteLine($"강화에 성공했습니다! 강화레벨{WeaponLevel}로 상승 데미지{WeaponDamage}으로 증가");
                            Console.WriteLine("계속 진행하시겠습니까? (Y/N)");
                            coin -= 1000;
                            Answer = Console.ReadLine();
                            if (Answer == "Y")
                            {
                                continue;
                            }
                            else if (Answer == "N")
                            {
                                Console.WriteLine("강화를 종료합니다.");
                                break;
                            }

                        }
                        else if (i > 5 && i <= 10 && num > 7)
                        {
                            Console.WriteLine($"\t{i}강 진행중입니다.성공 확률은 70프로 입니다. \n\t아무키나 눌러주세요");
                            Console.ReadKey();
                            WeaponDamage--;
                            WeaponLevel--;
                            Console.WriteLine($"강화에 실패했습니다! 강화레벨{WeaponLevel}로 감소 데미지{WeaponDamage}으로 감소");
                            Console.WriteLine("계속 진행하시겠습니까? (Y/N)");
                            coin -= 500;
                            Answer = Console.ReadLine();
                            i--;
                            i--;
                            if (Answer == "Y")
                            {
                                continue;
                            }
                            else if (Answer == "N")
                            {
                                Console.WriteLine("강화를 종료합니다.");
                                break;
                            }


                        }
                        else if (i > 10 && num > 3)
                        {
                            Console.WriteLine($"\t{i}강 진행중입니다.성공 확률은 30프로 입니다.\n\t아무키나 눌러주세요");
                            Console.ReadKey();
                            WeaponDamage--;
                            WeaponLevel--;
                            Console.WriteLine($"강화에 실패했습니다! 강화레벨{WeaponLevel}로 감소 데미지{WeaponDamage}으로 감소");
                            Console.WriteLine("계속 진행하시겠습니까? (Y/N)");
                            coin -= 1000;
                            Answer = Console.ReadLine();
                            i--;
                            i--;
                            if (Answer == "Y")
                            {
                                continue;
                            }
                            else if (Answer == "N")
                            {
                                Console.WriteLine("강화를 종료합니다.");
                                break;
                            }


                        }
                    }
                }
                else if (Answer == "N")
                {
                    Console.WriteLine($"강화를 종료합니다.\n아이템 최종 강화레벨{WeaponLevel}최종 데미지{WeaponDamage}");
                    break;
                }


                continue;
            }
        }*/


    }
}
