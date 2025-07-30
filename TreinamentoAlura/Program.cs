using System.Collections;

string boasVindas = "Bem-Vindo ao Screen Sound";
List<string> listaBandas = new List<string>();

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
        case 3: Console.WriteLine("\nVocê escolheu a opção " + opcaoEscolhidaNum);
            break;
        case 4: Console.WriteLine("\nVocê escolheu a opção " + opcaoEscolhidaNum);
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
    listaBandas.Add(nomeBanda);
    Thread.Sleep(2000);
    Console.WriteLine($"\nA banda {nomeBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    OpcoesMenu();
}

void ListarBandas()
{
    Console.Clear();
    Console.WriteLine("\nAs bandas registradas são:");
    for (int i = 0; i < listaBandas.Count; i++)
    {
        Console.WriteLine($"Banda: {listaBandas[i]}");
    }
    Console.WriteLine("\nDigite algo pra voltar para a página inicial");
    Console.ReadKey();
    Thread.Sleep(2000);
    Console.Clear();
    OpcoesMenu();
}

ExibirMensagemDeBoasVindas();
OpcoesMenu();