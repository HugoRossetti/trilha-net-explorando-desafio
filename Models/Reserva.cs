namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
    public Suite Suite { get; set; }
    public int DiasReservados { get; set; }

    public Reserva() 
    { 
        Hospedes = new List<Pessoa>(); // Inicializa a lista de hóspedes
    }

    public Reserva(int diasReservados) : this() // Chama o construtor padrão para inicializar a lista
    {
        DiasReservados = diasReservados;
    }

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
        // Verifica se a capacidade da suíte é maior ou igual ao número de hóspedes sendo recebido
        if (hospedes.Count <= Suite.Capacidade)
        {
            Hospedes = hospedes;
        }
        else
        {
            // Lança uma exception caso a capacidade seja menor que o número de hóspedes recebido
            throw new Exception("O número de hóspedes excede a capacidade da suíte.");
        }
    }

    public void CadastrarSuite(Suite suite)
    {
        Suite = suite;
    }

    public int ObterQuantidadeHospedes()
    {
        // Retorna a quantidade de hóspedes (propriedade Hospedes)
        return Hospedes.Count;
    }

    public decimal CalcularValorDiaria()
    {
        // Calcula o valor da diária: DiasReservados X Suite.ValorDiaria
        decimal valorTotal = DiasReservados * Suite.ValorDiaria;

        // Se os dias reservados forem maior ou igual a 10, aplica um desconto de 10%
        if (DiasReservados >= 10)
        {
            valorTotal *= 0.90m; // Aplica 10% de desconto
        }

        return valorTotal;
        }
    }
}