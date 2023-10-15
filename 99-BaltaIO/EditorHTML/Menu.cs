using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EditorHTML
{
    public static class Menu
    {
        public static void Mostrar()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.White;
            DesenharTela();
            EscreverOpcoes();
            var opcao = short.Parse(Console.ReadLine());
            ManipularMenuDeOpcoes(opcao);
        }

        public static void DesenharTela()

        {
            Console.Write("+");

            for (int i = 0; i <= 30; i++ )
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
            for (int linhas = 0; linhas <= 10; linhas++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++ )
            {
                Console.Write(" ");
            }
                Console.Write("|");
                Console.Write("\n");
            }
            Console.Write("+");

            for (int i = 0; i <= 30; i++ )
            {
                Console.Write("-");
            }
            Console.Write("+");
             Console.Write("\n");
        }

        public static void EscreverOpcoes()
        {
            Console.SetCursorPosition(3,2);
            Console.Write("Editor de HTML");
            Console.SetCursorPosition(3,3);
            Console.Write("=====================");
            Console.SetCursorPosition(3,4);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3,6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3,7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3,9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3,10);
            Console.Write("Opção : ");
        }
        public static void ManipularMenuDeOpcoes(short opcao)
        {
            switch(opcao)
            {
                case 1: Editor.Mostar(); break;
                case 2: System.Console.WriteLine("Vizualizar"); break;
                case 0: {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
                default: Mostrar(); break;
            }
        }
    }
}