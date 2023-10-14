Menu();


static void Menu()
{
    Console.Clear();
    Console.WriteLine("S = Contar em segundos => 10s = 10segundos");
    Console.WriteLine("M = Contar em minutos => 1m = 1 minuto");
    Console.WriteLine("0 = Sair");
    Console.WriteLine("Quanto tempo deseja contar ? ");

    string entradaDoUsuario = Console.ReadLine().ToLower();
    if (entradaDoUsuario == "0" )
    {
        Environment.Exit(0);
    }else{
        char tipo = char.Parse(entradaDoUsuario.Substring(entradaDoUsuario.Length -1,1));
        int tempo = int.Parse(entradaDoUsuario.Substring(0,entradaDoUsuario.Length -1));
        Iniciar(tempo, tipo);
    }

}

static void Iniciar(int tempo, char tipo)
{
    if(tipo == 's')
    {
        int tempoAtual = 0;
        while(tempoAtual != tempo)
        {
            Console.Clear();
            tempoAtual++;
            Console.WriteLine(tempoAtual);
            Thread.Sleep(1000);
        }
    }else{
        int tempoAtual = 0;
        while(tempoAtual != tempo *60)
        {
            Console.Clear();
            tempoAtual++;
            Console.WriteLine(tempoAtual);
            Thread.Sleep(1000);
        }
    }
    Console.Clear();
    Console.WriteLine("Cronometro finalizado ");
    Thread.Sleep(2500);
}
