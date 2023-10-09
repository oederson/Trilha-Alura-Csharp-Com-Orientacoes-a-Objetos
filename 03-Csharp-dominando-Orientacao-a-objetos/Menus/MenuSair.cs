using _03_Csharp_dominando_Orientacao_a_objetos.Modelos;

namespace _03_Csharp_dominando_Orientacao_a_objetos.Menus;

internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.WriteLine("Tchau tchau :)");
    }
}
