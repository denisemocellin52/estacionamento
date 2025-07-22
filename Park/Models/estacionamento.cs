namespace PARK.Models
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
            Console.WriteLine("Digite a placa do veículo:");
            string? placa = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(placa))
            {
                Console.WriteLine("Placa inválida. Tente novamente.");
                return;
            }

            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo a ser removido:");
            string? placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = Convert.ToInt32(Console.ReadLine());

                decimal valorTotal = precoInicial + (precoPorHora * horas);
                veiculos.Remove(veiculos.First(x => x.ToUpper() == placa.ToUpper()));

                Console.WriteLine($"O veículo da placa {placa} foi removido e o valor total a pagar é: R$ {valorTotal:F2}");
            }
            else
            {
                Console.WriteLine($"Veículo {placa} não encontrado no lista de veículos.");
            }
        }


        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos cadastrados são:");
        foreach (var veiculo in veiculos)
        {
            Console.WriteLine($"- {veiculo}");
        }
    }
    else
    {
        Console.WriteLine("Não há veículos estacionados.");
    }
        }
    }
}