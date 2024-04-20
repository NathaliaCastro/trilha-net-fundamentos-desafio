using Microsoft.Win32.SafeHandles;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    //Criando a classe chamada Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        //Declarando as variaveis precoInicial e precoPorHora com tipo decimal
        private List<string> veiculos = new List<string>();
        //Declarando a lista veiculos com tipo string

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        //Construtor vai receber os valores de precoInicial e precoPorHora
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        //Criando método para cadastrar um veiculo
        {
            Console.WriteLine("\nInforme a placa do seu veículo:");
                // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos" - IMPLEMENTAR AQUI
            
            string placa = Console.ReadLine();
            veiculos.Add(placa);
            //Declarando variavel placa com tipo string para armazenar a placa digitada pelo usuario e incluindo veiculo
        }

        public void ListarVeiculos()
        //Criando método para exibir os veiculos estacionados
        {
            if (veiculos.Any())
            //Se houver veiculos estacionados, listar as placas
            {
                Console.WriteLine("Os veículos estacionados são:");
                    // TODO: Realizar um laço de repetição, exibindo os veículos estacionados - IMPLEMENTAR AQUI

                foreach(string veiculo in veiculos){
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Estacionamento vazio.");
            }
        }

        public void RemoverVeiculo()
        //Criando método para retirar um veiculo
        {
            Console.WriteLine("\nInforme a placa do veículo para sair:");
                // TODO: Pedir para o usuário digitar a placa e armazenar na variável placa - IMPLEMENTAR AQUI

            string placa = Console.ReadLine();
            //Declarando variavel placa com tipo string para armazenar a placa digitada pelo usuario

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("\nInforme quantas horas o veículo ficou estacionado:");
                    // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado e
                    // realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal - IMPLEMENTAR AQUI

                int horas = int.Parse(Console.ReadLine());
                //Declarando variavel horas, convertando para o tipo string e armazenando a informacao
                decimal valorTotal = precoInicial + (precoPorHora * horas);
                //Calculando quanto o usuario tera que pagar pelo servico

                    // TODO: Remover a placa digitada da lista de veículos - IMPLEMENTAR AQUI
                veiculos.Remove(placa);
                //Apaga um veiculo
                Console.WriteLine($"O veículo {placa} foi liberado e o preço pago foi de: R$ {valorTotal},00");
            }
            else
            {
                Console.WriteLine("Desculpe, veículo não localizado. Tente novamente!");
            }
        }
    }
}
