using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

            Console.Clear();  
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

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n Digite a opção escolhida: \n");
            Console.ResetColor();

            opcao = int.Parse(Console.ReadLine());

            switch (opcao) {

            case 1:
            CadastrarPokemon();
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
            static void CadastrarPokemon() {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"
     ░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░
     ██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗
     ██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║
     ██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║
     ╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝
░     ╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░");
                   
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n Digite o Nome do seu Pokemon: \n");
            string nomePokemon = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n Digite o Tipo do seu Pokemon: \n");
            string  tipoPokemon = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n Digite a Altura do seu Pokemon: \n");
            string  alturaPokemon = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n Digite o Peso do seu Pokemon: \n");
            string  pesoPokemon = Console.ReadLine();
                      
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n Quantas Fraquezas ele tem? :\n");
            int qtdFraqueza = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdFraqueza; i++) {
            Console.WriteLine($"Fraqueza {i} : ");
            string fraquezaPokemon = Console.ReadLine(); }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n Quantas Evoluções ele tem? : \n");
            int qtdEvolucao = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdEvolucao; i++) {
            Console.WriteLine($"Evolução {i} : \n"); }
            string evolucaoPokemon = Console.ReadLine();
                
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("\n Parabéns ... Pokemon Cadastrado ");
            Thread.Sleep(3000);
            Console.ResetColor();
                
           
        }
      }
    }
