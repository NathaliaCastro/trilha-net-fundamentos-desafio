using Microsoft.Win32.SafeHandles;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("\nInforme a placa do seu veículo:");
            
            string placa = Console.ReadLine();
            veiculos.Add(placa);
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

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
        {
            Console.WriteLine("\nInforme a placa do veículo para sair:");

            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("\nInforme quantas horas o veículo ficou estacionado:");

                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = precoInicial + (precoPorHora * horas);

                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi liberado e o preço pago foi de: R$ {valorTotal},00");
            }
            else
            {
                Console.WriteLine("Desculpe, veículo não localizado. Tente novamente!");
            }
        }
    }
}
