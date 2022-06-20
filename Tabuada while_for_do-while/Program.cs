using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada_while_for_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numini = 0, cont = 0, numter = 0, resultado = 0;
            {
                //ESTRUTURA FOR
                Console.WriteLine("Digite a tabuada desejada (método usando for):");
                numini = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o número de inicio desejado: ");
                cont = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o número final desejado: ");
                numter = int.Parse(Console.ReadLine());

                if (numini <= 0 || cont <= 0 || numter <= 0 || numini > 100 || cont > 100 || numter > 100)
                {
                    Console.WriteLine("O número informado excede  o limite");
                    Console.ReadKey();
                }

                else
                {
                    for (cont = cont; cont <= numter; cont++)
                    {
                        resultado = numini * cont;
                        Console.WriteLine($"{numini} X {cont} = {resultado}");
                    }
                }
                Console.ReadKey();

                //ESTRUTURA DO-WHILE
                Console.WriteLine("Digite a tabuada desejada (método usando do-while):");
                numini = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o número de inicio desejado: ");
                cont = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o número final desejado: ");
                numter = int.Parse(Console.ReadLine());

                if (numini <= 0 || cont <= 0 || numter <= 0 || numini > 100 || cont > 100 || numter > 100)
                {
                    Console.WriteLine("O número informado excede  o limite");
                    Console.ReadKey();
                }

                else
                {
                    do
                    {
                        resultado = numini * cont;
                        Console.WriteLine($"{numini} X {cont} = {resultado}");
                        cont++;
                    }
                    while (cont <= numter);
                }
                Console.ReadKey();



                //ESTRUTURA WHILE
                Console.WriteLine("Digite a tabuada desejada (método usando while):");
                numini = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o número de inicio desejado: ");
                cont = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o número final desejado: ");
                numter = int.Parse(Console.ReadLine());

                if (numini <= 0 || cont <= 0 || numter <= 0 || numini > 100 || cont > 100 || numter > 100)
                {
                    Console.WriteLine("O número informado excede  o limite");
                    Console.ReadKey();
                }

                else 
                {
                    while (numini <= 10)
                    {
                        while (cont <= numter)
                        {
                            resultado = numini * cont;
                            Console.WriteLine($"{numini} X {cont} = {resultado}");
                            cont++;
                        }
                    }
                    Console.ReadKey();
                }

            }
        }
    }
}
