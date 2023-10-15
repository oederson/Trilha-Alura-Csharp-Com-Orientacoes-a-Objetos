using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorHTML
{
    public class Editor
    {
        public static void Mostar()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("------------");
            Iniciar();
        }
        public static void Iniciar()
        {
            var arquivo = new StringBuilder();

            do
            {
                arquivo.Append(Console.ReadLine());
                arquivo.Append(Environment.NewLine);
            }while(Console.ReadKey().Key != ConsoleKey.Escape);
            Console.WriteLine("-------------------");
            Console.WriteLine(" Deseja salvar o arquivo ?");
            Visualizador.Mostar(arquivo.ToString());
        }
    }
}