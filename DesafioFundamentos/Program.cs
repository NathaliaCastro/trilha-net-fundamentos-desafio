using DesafioFundamentos.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("\nSeja bem vindo ao estacionamento StopCar!\n" +
                  "Digite o valor fixo da tarifa para estacionar:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("\nDigite o preço cobrado por hora estacionada:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Escolha uma das opções:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Listar veículos");
    Console.WriteLine("3 - Remover veículo");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.ListarVeiculos();
            break;
        
        case "3":
            es.RemoverVeiculo();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("\nO programa foi finalizado.\n" +
                "Obrigada por nos escolher, volte sempre!");
