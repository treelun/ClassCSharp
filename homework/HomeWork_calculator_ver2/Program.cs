using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_calculator_ver2
{
    class Program
    { 
        static void Main(string[] args)
        {
            {
                float[] arrayint = new float[10];
                char[] arraychar = new char[10];
                
                float[] result = new float[10];
                
               
                

                while (true)
                {
                    for (int i = 0; i < arrayint.Length; i++)
                    {
                        Console.Write("input : ");
                        arrayint[i] = float.Parse(Console.ReadLine());
                        Console.Write("input type : ");
                        arraychar[i] = Console.ReadKey().KeyChar;

                        
                    
                    Console.WriteLine("Continue? : ");
                    string con = Console.ReadLine();
                    if (con == "Y" | con == "y")
                        {
                            continue;
                            
                        }
                        if (con == "N" | con == "n")
                        {
                            while (true)
                            {
                                for (int k = 0; k < arrayint.Length; k++)
                                {
                                    switch (arraychar[k])
                                    {
                                        case '*':
                                            result[k] = arrayint[k] * arrayint[k + 1];

                                            break;

                                        case '/':
                                            result[k] = arrayint[k] / arrayint[k + 1];
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                for (int u = 0; u < arrayint.Length; u++)
                                {
                                    switch (arraychar[u])
                                    {
                                        case '+':
                                            result[u] = arrayint[u] + arrayint[u + 1];
                                            break;

                                        case '-':
                                            result[u] = arrayint[u] - arrayint[u + 1];
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                for (int p = 0; p < result.Length; p++)
                                {
                                    for (int k = 1; k < result.Length; k++)
                                    {
                                        switch (arraychar[p])
                                        {
                                            case '*':
                                                result[p] = result[p] * result[k];
                                                break;
                                            case '/':
                                                result[p] = result[p] / result[k];
                                                break;
                                            case '+':
                                                result[p] = result[p] + result[k];
                                                break;

                                            case '-':
                                                result[p] = result[p] - result[k];
                                                break;
                                            default:
                                                break;
                                        }
                                    }

                                }
                                Console.WriteLine($"{result[0]}");
                                return;
                            }
                        }



                    }
                    Console.WriteLine($"{result[0]}");
                    return;
                }
                

            }


        }
        static float[] InputNum()
        {
            float[] arraynum = new float[100];

            while (true)
            {
               
            }
            

        }
        static char[] InputType()
        {

            char[] arraytype = new char[100];
            
            while (true)
            {

                for (int k = 0; k < arraytype.Length; k++)
                {
                    
                    break;
                }
                
                


            }


        }
        
        static void Carculator()
        {
            float[] result = new float[100];
            while (true)
            {
                for (int i = 0; i < InputNum().Length; i++)
                {
                    switch (InputType()[i])
                    {
                        case '*':
                            result[i] = InputNum()[i] * InputNum()[i + 1];
                            
                            break;

                        case '/':
                            result[i] = InputNum()[i] / InputNum()[i + 1];
                            break;
                        default:
                            break;
                    }
                }
                for (int i = 0; i < InputNum().Length; i++)
                {
                    switch (InputType()[i])
                    {
                        case '+':
                            result[i] = InputNum()[i] + InputNum()[i + 1];
                            break;

                        case '-':
                            result[i] = InputNum()[i] - InputNum()[i + 1];
                            break;
                        default:
                            break;
                    }
                }
                for (int i = 0; i < result.Length; i++)
                {
                    for (int k = 1; k < result.Length; k++)
                    {
                        switch (InputType()[i])
                        {
                            case '*':
                                result[i] = result[i] * result[k];
                                break;
                            case '/':
                                result[i] = result[i] / result[k];
                                break;
                            case '+':
                                result[i] = result[i] + result[k];
                                break;

                            case '-':
                                result[i] = result[i] - result[k];
                                break;
                            default:
                                break;
                        }
                    }
                    
                }

            }
        }




    }
}


