using System.Collections;

string boasVindas = "Bem-Vindo ao Screen Sound";
Dictionary<string, List<int>> listaBandas = new Dictionary<string, List<int>>();

void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine(boasVindas + "\n");
}

void OpcoesMenu()
{
    Console.WriteLine("Digite 1 para registrar uma banda: ");
    Console.WriteLine("Digite 2 para listar as bandas: ");
    Console.WriteLine("Digite 3 para avaliar uma banda: ");
    Console.WriteLine("Digite 4 para ver a nota de uma banda: ");
    Console.WriteLine("Digite 0 para sair: ");

    Console.Write("\nDigite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNum = int.Parse(opcaoEscolhida);

    switch(opcaoEscolhidaNum)
    {
        case 1: RegistrarBandas();
            break;
        case 2: ListarBandas();
            break;
        case 3: AvaliarBandas();
            break;
        case 4: MediaBanda();
            break;
        case 0: Console.WriteLine("\nVocê escolheu a opção " + opcaoEscolhidaNum);
            break;
        default: Console.WriteLine("\n" + opcaoEscolhidaNum + " Não é uma opção válida");
            break;
    }
}

void RegistrarBandas()
{
    Console.Clear();
    Console.WriteLine("\nRegistro de Bandas\n");
    Console.Write("Banda que deseja registrar: ");
    string nomeBanda = Console.ReadLine()!;
    listaBandas.Add(nomeBanda, new List<int>());
    Thread.Sleep(500);
    Console.WriteLine($"\nA banda {nomeBanda} foi registrada com sucesso!");
    Thread.Sleep(1000);
    Console.Clear();
    OpcoesMenu();
}

void ListarBandas()
{
    Console.Clear();
    Console.WriteLine("\nAs bandas registradas são:");
    foreach(string banda in listaBandas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite algo pra voltar para a página inicial");
    Console.ReadKey();
    Thread.Sleep(500);
    Console.Clear();
    OpcoesMenu();
}

void AvaliarBandas()
{
    Console.Clear();
    Console.WriteLine("\nAvaliar Bandas\n");
    foreach (string banda in listaBandas.Keys)
    {
        Console.WriteLine($"Banda:{banda}");
    }
    Console.Write("\nQual banda deseja avaliar: ");
    string nomeBanda = Console.ReadLine()!;
    if (listaBandas.ContainsKey(nomeBanda))
    {
        Console.Write("Digite a nota para essa banda: ");
        int nota = int.Parse(Console.ReadLine()!);
        listaBandas[nomeBanda].Add(nota);
        Console.Write("Banda avaliada com sucesso");
        Thread.Sleep(1500);
        Console.Clear();
        OpcoesMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada");
        Thread.Sleep(1500);
        Console.Clear();
        OpcoesMenu();
    }
}

void MediaBanda()
{
    foreach (string banda in listaBandas.Keys)
    {
        Console.WriteLine($"A nota da banda {banda} é: {listaBandas[nomeBanda]}");
    }
}

ExibirMensagemDeBoasVindas();
OpcoesMenu();