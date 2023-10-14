Menu();
static void Menu()
{
    Console.Clear();
    System.Console.WriteLine("O que voce deseja fazer ?");
    System.Console.WriteLine("1 - Abrir arquivo");
    System.Console.WriteLine("2 - Criar arquivo");
    System.Console.WriteLine("0 - Sair");
    short opcao = short.Parse(System.Console.ReadLine());
    switch (opcao)
    {
        case 0: Environment.Exit(0); break;
        case 1: Abrir();break;
        case 2: Editar();break;
        default: Menu(); break;
    }
}

static void Abrir()
{
    Console.Clear();
    System.Console.WriteLine("Digite o caminho do arquivo :");
    string caminho = Console.ReadLine();

    using(var file = new StreamReader(caminho))
    {
        string texto = file.ReadToEnd();
        Console.WriteLine(texto);
    }
    System.Console.WriteLine("");
    Console.ReadLine();
    Menu();
}

static void Editar()
{
    Console.Clear();
    Console.WriteLine("Digite seu texto abaixo (ESC) para sair");
    Console.WriteLine("________________________");
    string texto = "";
    do
    {
        texto +=  Console.ReadLine();
        texto += Environment.NewLine;
    }
    while(Console.ReadKey().Key != ConsoleKey.Escape);
    {
        Salvar(texto);
    }
}

static void Salvar(string texto)
{
    Console.Clear();
    Console.WriteLine("Qual caminho para salvar o arquivo ?");
    var caminho = Console.ReadLine();
    using(var arquivo = new StreamWriter(caminho)) // Cria o objeto, usa e fecha, para nao correr o risco de ficar com arquivo aberto
    {
        arquivo.Write(texto);
    }
    System.Console.WriteLine($"Arquivo {caminho} salvo com sucesso!");
    Menu();
}
