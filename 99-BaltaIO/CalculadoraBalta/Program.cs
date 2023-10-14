Menu();

static void Menu()
{   
    Console.Clear();
    Console.WriteLine(@"Digite sua opção :
1 - Soma
2 - Subtração
3 - Divisão
4 - Multiplicação
5 - Sair ");

short escolha = short.Parse(Console.ReadLine());

switch(escolha)
    {
    case 1 : Soma(); 
             break;
    case 2 : Subtracao();
             break;
    case 3 : Divisao();
             break;
    case 4 : Multiplicacao();
             break;
    case 5 : System.Environment.Exit(0);
            break;
    default : Menu();
              break;
    };
    
    

}

static void Soma()
{
    Console.Clear();
    Console.WriteLine("Primeiro valor : ");
    float v1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Segundo valor : ");
    float v2 = float.Parse(Console.ReadLine());

    Console.Write("O resultado da soma é ");
    Console.WriteLine(v1 + v2);
    Console.ReadKey();
    Menu();
}

static void Subtracao()
{
    Console.Clear();
    Console.WriteLine("Primeiro valor : ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor : ");
    float v2 = float.Parse(Console.ReadLine());
    
    Console.WriteLine("");
    Console.WriteLine($"O resultado da subtração é : {v1 - v2}");
    Console.ReadKey();
    Menu();
}

static void Divisao()
{
    Console.Clear();
    Console.WriteLine("Primeiro valor : ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor : ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");
    Console.WriteLine($"O resultado da divisão é {v1 / v2}");
    Console.ReadKey();
    Menu();
}

static void Multiplicacao()
{
    Console.Clear();
    Console.WriteLine("Primeiro valor : ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor : ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");
    Console.WriteLine($"O resultado da multiplicação é {v1 * v2}");
    Console.ReadKey();
    Menu();
}