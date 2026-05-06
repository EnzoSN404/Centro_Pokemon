using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {

           int opcao = 0;
            while (opcao != 4)
            {

                Console.Clear();  //
                Console.ForegroundColor = ConsoleColor.Green;




                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(@"
     ██████╗░░█████╗░██╗░░██╗███████╗███╗░░░███╗░█████╗░███╗░░██╗
     ██╔══██╗██╔══██╗██║░██╔╝██╔════╝████╗░████║██╔══██╗████╗░██║
     ██████╔╝██║░░██║█████═╝░█████╗░░██╔████╔██║██║░░██║██╔██╗██║
     ██╔═══╝░██║░░██║██╔═██╗░██╔══╝░░██║╚██╔╝██║██║░░██║██║╚████║
     ██║░░░░░╚█████╔╝██║░╚██╗███████╗██║░╚═╝░██║╚█████╔╝██║░╚███║
     ╚═╝░░░░░░╚════╝░╚═╝░░╚═╝╚══════╝╚═╝░░░░░╚═╝░╚════╝░╚═╝░░╚══╝");

                Console.ResetColor();
                Console.WriteLine("\n Seja muito bem-vindo ao Centro Pokemon!\n");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n 1 - Cadastrar Pokemon");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n 2 - Consultar Pokemon");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n 3 - Apagar Pokemon");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n 4 - Sair\n");
                Console.ResetColor();

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {

                    case 1:


                        break;
                    case 2:


                        break;
                    case 3:


                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("\nTchau Tchau, volte sempre!!!");
                        Console.ResetColor();
                        System.Threading.Thread.Sleep(2000);

                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nOpção Inválida!!!");
                        Console.ResetColor();
                        System.Threading.Thread.Sleep(2000);
                        break;


                }





            }
        }
    }
}
